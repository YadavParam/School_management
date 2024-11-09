using Dapper;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagement.Users
{
    public partial class StaffDetailsPopUp : Form
    {
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        public StaffDetailsPopUp()
        {
            InitializeComponent();
        }

        private void StaffDetailsPopUp_Load(object sender, EventArgs e)
        {
            var Id = EditStaffViewModel.Id;
            var SchoolId = EditStaffViewModel.SchoolId;

            getStaffData(SchoolId, Id);

        }

        public void getStaffData(int SchoolId, int Id)
        {
            try
            {
                var getStaffDetails = Db.SchoolStaffs.AsNoTracking().FirstOrDefault(x => x.SchoolId == SchoolId && x.Id == Id);
                if (getStaffDetails != null)
                {
                    using (var connection = new SqlConnection(ConnectionString))
                    {
                        var sql = new StringBuilder($@"select sholStf.Id,sholStf.SchoolId,concat(sholStf.FirstName, ' ', sholStf.LastName) as Name,clas.ClassName,sub.SubjectName,sholStf.Experience,sholStf.JoiningDate,sholStf.Salary,sholStf.Gender,
                            sholStf.Address,sholStf.BankName,sholStf.BranchName,sholStf.AccountNumber,sholStf.IFSCCode,sholStf.Designation
                            from SchoolStaff sholStf left join Subject sub on sub.SubjectId = sholStf.SubjectId left join Class clas on clas.ClassId = sholStf.ClassId
                            where sholStf.IsActive=1 and sholStf.SchoolId={SchoolId} and sholStf.Id={Id}");
                        var properties = connection.Query<SchoolStaffViewModel>(sql.ToString()).ToList();

                        foreach (var item in properties)
                        {
                            IdLabel.Text = item.Id.ToString();
                            SchoolIdLabel.Text = item.SchoolId.ToString();
                            Name.Text = item.Name;
                            ClassName.Text = item.ClassName;
                            SubjectName.Text = item.SubjectName;
                            Experience.Text = item.Experience.ToString();
                            JoiningDate.Text = item.JoiningDate.ToString("dd-MM-yyyy");
                            Salary.Text = item.Salary.ToString();
                            Gender.Text = item.Gender;
                            Address.Text = item.Address;
                            BankName.Text = item.BankName;
                            BranchName.Text = item.BranchName;
                            AccountNumber.Text = item.AccountNumber;
                            IFSCCode.Text = item.IFSCCode;
                            Designation.Text = item.Designation;

                            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
                            toolTip.SetToolTip(Name, $"{item.Name}");
                            toolTip.SetToolTip(ClassName, $"{item.ClassName}");
                            toolTip.SetToolTip(SubjectName, $"{item.SubjectName}");
                            toolTip.SetToolTip(Experience, $"{item.Experience}");
                            toolTip.SetToolTip(JoiningDate, $"{item.JoiningDate}");
                            toolTip.SetToolTip(Salary, $"{item.Salary}");
                            toolTip.SetToolTip(Gender, $"{item.Gender}");
                            toolTip.SetToolTip(Designation, $"{item.Designation}");
                            toolTip.SetToolTip(BankName, $"{item.BankName}");
                            toolTip.SetToolTip(BranchName, $"{item.BranchName}");
                            toolTip.SetToolTip(AccountNumber, $"{item.AccountNumber}");
                            toolTip.SetToolTip(IFSCCode, $"{item.IFSCCode}");
                            toolTip.SetToolTip(Address, $"{item.Address}");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Staff record not found.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
