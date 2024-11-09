using Dapper;
using DocumentFormat.OpenXml.VariantTypes;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Academic
{
    public partial class ViewPeriodsPopUp : Form
    {
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        public ViewPeriodsPopUp()
        {
            InitializeComponent();
        }

        private void ViewPeriodsPopUp_Load(object sender, EventArgs e)
        {
            var schoolId = EditStaffViewModel.SchoolId;
            var classId = EditStaffViewModel.ClassId;
            var sectionId = EditStaffViewModel.SectionId;

            getPeriodData(classId,schoolId, sectionId);
        }

        public void getPeriodData(int classId, int schoolId, string sectionId)
        {
            try
            {
                var getPeriodDetails = Db.ClassPeriodAcademics.AsNoTracking().FirstOrDefault(x => x.ClassId == classId && x.SchoolId == schoolId && x.SectionId == sectionId);
                if (getPeriodDetails != null)
                {
                    using (var connection = new SqlConnection(ConnectionString))
                    {
                        var sql = new StringBuilder($@"select clPeriod.Id,clPeriod.Period,sub.SubjectName,concat(schstf.FirstName, ' ', schstf.LastName) as TeacherName,clPeriod.TimingFrom,clPeriod.TimingTo,clPeriod.Duration
                            from ClassPeriodAcademic clPeriod left join Subject sub on sub.SubjectId = clPeriod.SubjectId left join SchoolStaff schstf on schstf.Id = clPeriod.TeacherId 
                            where clPeriod.IsActive=1 and clPeriod.SchoolId={schoolId} and clPeriod.ClassId={classId} and clPeriod.SectionId='{sectionId}'");
                        var properties = connection.Query<ClassPeriodViewModel>(sql.ToString()).ToList();

                        foreach (var item in properties)
                        {
                            ViewPeriodDataGridView.Rows.Add(item.Id, item.Period, item.SubjectName, item.TeacherName, item.TimingFrom, item.TimingTo, item.Duration);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Period record not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
