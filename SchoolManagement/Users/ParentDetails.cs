using DocumentFormat.OpenXml.Wordprocessing;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Users
{
    public partial class ParentDetails : Form
    {
        private List<ParentsViewModel> allData;
        private int pageSize = 25;
        private int currentPage = 0;
        private int totalRecords = 0;
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        public ParentDetails()
        {
            InitializeComponent();
        }

        private void ParentDetails_Load(object sender, EventArgs e)
        {
            DataOfParentDetails(1, pageSize);
        }

        private void DataOfParentDetails(int pageNumber, int pageSize)
        {
            var data = Db.Parents.Where(x => x.IsDelete != true).OrderBy(x => x.Id)
            .Skip((pageNumber - 1) * pageSize).Take(pageSize)
            .Select(x => new ParentsViewModel
            {
                Id = x.Id,
                SchoolId = x.SchoolId,
                ParentId = x.ParentId,
                FathersName = x.FathersName,
                MothersName = x.MothersName,
                FathersMailId = x.FathersMailId,
                MothersMailId = x.MothersMailId,
                FathersMobileNumber = x.FathersMobileNumber,
                MothersMobileNumber = x.MothersMobileNumber,
                FathersOccupation = x.FathersOccupation,
                MothersOccupation = x.MothersOccupation,
                FathersBloodGroup = x.FathersBloodGroup,
                MothersBloodGroup = x.MothersBloodGroup,
                Password = x.Password,
                Address = x.Address,
            }).ToList();

            allData = data;
            ParentRecord.AutoGenerateColumns = false;

            totalRecords = Db.Parents.Where(m => m.IsDelete != true).Count();

            TotalCount.Text = $"Total Count: {totalRecords}";

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            var currentPageData = allData?.Skip(currentPage * pageSize).Take(pageSize).ToList();
            ParentRecord.DataSource = currentPageData;

            previousBtn.Enabled = currentPage > 0;
            nextBtn.Enabled = currentPage < TotalPages - 1;

            btnBetweenPg.Text = $"Pages: {currentPage + 1} / {TotalPages}";
        }

        private int TotalPages => allData != null ? (int)Math.Ceiling((double)allData.Count / pageSize) : 0;

        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                UpdateDataGridView();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < TotalPages - 1)
            {
                currentPage++;
                UpdateDataGridView();
            }
        }
    }
}
