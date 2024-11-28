using IronXL;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement.Users
{
    public partial class StaffAttendanceForm : Form
    {
        Form form;
        DataTable getTable = null;
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        List<StaffAttendanceForm> staffAttendanceExcel = new List<StaffAttendanceForm>();
        public StaffAttendanceForm()
        {
            InitializeComponent();
        }

        private void ChooseFile_Click(object sender, EventArgs e)
        {
            var processTable = new ProcessTable();
            System.Windows.Forms.OpenFileDialog openfiledialog1 = new System.Windows.Forms.OpenFileDialog();
            openfiledialog1.ShowDialog();
            openfiledialog1.Filter = "Excel Files|*.xls;*.xlsx|CSV Files|*.csv|All Files|*.*";

            if (string.IsNullOrEmpty(openfiledialog1.FileName))
            {
                MessageBox.Show("No file was selected.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FileInfo fileInfo = new FileInfo(openfiledialog1.FileName);
            long postedFile = fileInfo.Length;

            if (!Helper.Helper.CheckIfFileSizeWithinLimit(postedFile, 25 * 1024 * 1024)) //25 Mb
            {
                MessageBox.Show("File Should not more than be greater than 10 Mb", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!new[] { ".csv", ".xls", ".xlsx" }.Contains(fileInfo.Extension.ToLower()))
            {
                MessageBox.Show("File Should be csv, xlsx and xls file!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtfilepath.Text = openfiledialog1.FileName;
            try
            {
                var Listleadcolumnandcsvcolumn = new List<LeadColumnAndCSVColumn>();
                getTable = Commonfunction.GetDataTabletFromCSVFile(fileInfo, openfiledialog1.FileName);
                var mappingSuggestions = Commonfunction.GetSuggestionForLeadExcel();

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("UserId", typeof(string)),
                    new DataColumn("SchoolId", typeof(string)),
                    new DataColumn("Attendance", typeof(string)),
                    new DataColumn("Attendance Date", typeof(string))
                });


                for (int i = 0; i < getTable?.Rows.Count; i++)
                {
                    //if (i == 2)
                    //    break;

                    DataRow dr = dt.NewRow();
                    var leadcolumnandcsvcolumn = new LeadColumnAndCSVColumn();
                    List<object> details = new List<object>();

                    for (int j = 0; j < getTable.Columns.Count; j++)
                    {
                        string columnName = getTable.Columns[j].ColumnName;
                        leadcolumnandcsvcolumn.FieldsInStudent = mappingSuggestions.FirstOrDefault(x => x.label == columnName)?.value ?? "Do Not Map This Field,Please Check Your Excel";
                        leadcolumnandcsvcolumn.FieldsInCsV = columnName;

                        leadcolumnandcsvcolumn.Record_1_InFile = getTable.Rows[i][columnName].ToString();
                        details.Add(getTable.Rows[i][columnName]);
                        dr[j] = getTable.Rows[i][columnName];
                    }

                    dt.Rows.Add(dr);
                    Listleadcolumnandcsvcolumn.Add(leadcolumnandcsvcolumn);
                }
                StaffGridExcel.DataSource = dt;
                processTable.CompareLeadColumnToCSV = Listleadcolumnandcsvcolumn;
                StaffGridExcel.Refresh();
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show("The file has duplicate columns. Please make them unique.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UploadFile_Click(object sender, EventArgs e)
        {
            try
            {
                var postedFile = txtfilepath.Text;
                if (string.IsNullOrWhiteSpace(postedFile))
                {
                    MessageBox.Show("Please select a file before uploading.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                WorkBook wb = WorkBook.Create(ExcelFileFormat.XLS);
                WorkSheet ws = wb.DefaultWorkSheet;
                if (getTable != null)
                {
                    int uniqueOrDuplicateLeads = 0;
                    var UserId = getTable.Columns.Contains("UserId");
                    var SchoolId = getTable.Columns.Contains("SchoolId");
                    var Attendance = getTable.Columns.Contains("Attendance");
                    var AttendanceDate = getTable.Columns.Contains("AttendanceDate");

                    if (UserId == false || SchoolId == false || Attendance == false || AttendanceDate == false)
                    {
                        MessageBox.Show("Parent column not map please check column of excel csv, xlsx and xsl", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var duplicatestudent = CheckStudentAttendance(getTable);
                    if (duplicatestudent != null)
                    {
                        var path = "File_" + Guid.NewGuid() + "Test.csv";
                        string folderPath = "D:\\SchoolStaffAttendance\\" + path;
                        string fullPath = Path.Combine(folderPath, path);

                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }

                        StringBuilder sb = new StringBuilder();

                        IEnumerable<string> columnNames = duplicatestudent.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                        sb.AppendLine(string.Join(",", columnNames));

                        foreach (DataRow row in duplicatestudent.Rows)
                        {
                            IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                            sb.AppendLine(string.Join(",", fields));

                            var staff = new SatffAttendance
                            {
                                UserId = Convert.ToInt32(row.FieldOrDefault<string>("UserId")),
                                SchoolId = Convert.ToInt32(row.FieldOrDefault<string>("SchoolId")),
                                Attendance = GetAttendanceValue(row.FieldOrDefault<string>("Attendance")),
                                AttendanceDate = ParseDate(row.FieldOrDefault<string>("AttendanceDate")),
                                IsActive = true,
                                IsDelete = false,
                                DateAdded = DateTime.Now,
                                DateModified = DateTime.Now
                            };

                            Db.SatffAttendances.Add(staff);
                            Db.SaveChanges();
                        }

                        if (!string.IsNullOrWhiteSpace(folderPath))
                        {
                            SaveCSVToFile(sb.ToString(), fullPath);
                            form = new StaffAttendanceForm();
                            form.TopLevel = false;
                            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                            form.BringToFront();
                            form.Show();
                            MessageBox.Show("Successfully file uploaded!,if any error please check the excel file with reason column,added to your pc!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                form = new StaffAttendanceForm();
                form.TopLevel = false;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();
                MessageBox.Show(ex.ToString());
            }
        }

        public DataTable CheckStudentAttendance(DataTable leadDataTable)
        {

            var result = true;
            try
            {
                staffAttendanceExcel.Clear();
                var getorignalTable = leadDataTable;

                List<string> phoneNoList = new List<string>();

                var schoolId = Convert.ToInt32(GlobalAccount.SchoolId);

                if (!getorignalTable.Columns.Contains("Reason Behind Failure"))
                {
                    getorignalTable.Columns.Add("Reason Behind Failure", typeof(string));
                }

                using (var modifiyOrignalTable = new DataTable())
                {
                    foreach (DataRow row in getorignalTable.Rows)
                    {

                        int p = 0;
                        int s = 0;
                        Random r = new Random();
                        var staff = new SatffAttendance();
                        var UserId = row.Table.Columns.Contains("UserId");
                        var SchoolId = row.Table.Columns.Contains("SchoolId");
                        var Attendance = row.Table.Columns.Contains("Attendance");
                        var AttendanceDate = row.Table.Columns.Contains("AttendanceDate");


                        if (UserId)
                        {
                            var userid = "";
                            userid = row.FieldOrDefault<string>("UserId");

                            if (!string.IsNullOrEmpty(userid))
                            {
                                staff.UserId = Convert.ToInt32(userid);
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "StaffId is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }

                        if (SchoolId)
                        {
                            var schoolsid = "";
                            schoolsid = row.FieldOrDefault<string>("SchoolId");
                            if (!string.IsNullOrEmpty(schoolsid))
                            {
                                staff.SchoolId = Convert.ToInt32(schoolsid);
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "School Id is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }

                        if (Attendance)
                        {
                            var Attendances = "";
                            Attendances = row.FieldOrDefault<string>("Attendance");
                            if (!string.IsNullOrEmpty(Attendances))
                            {
                                var attendance = 0;
                                if (Attendances == "Present")
                                {
                                    staff.Attendance = 1;
                                }
                                else if (Attendances == "Absent")
                                {
                                    staff.Attendance = 2;
                                }
                                else if (Attendances.Trim() == "HalfDay")
                                {
                                    staff.Attendance = 3;
                                }
                                else if (Attendances.Trim() == "ShortLeave")
                                {
                                    staff.Attendance = 4;
                                }
                            }
                            else
                            {
                                var reasons = "";
                                var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                if (reason)
                                {
                                    row["Reason Behind Failure"] = "Attendance is empty,please check it!";
                                    row.EndEdit();
                                    p = 1;
                                    continue;
                                }
                            }
                        }
                        if (AttendanceDate)
                        {
                            var AttendanceDates = "";
                            AttendanceDates = row.FieldOrDefault<string>("AttendanceDate");
                            if (!string.IsNullOrEmpty(AttendanceDates))
                            {
                                DateTime attendanceDate;
                                if (DateTime.TryParse(AttendanceDates, CultureInfo.InvariantCulture, DateTimeStyles.None, out attendanceDate))
                                {
                                    staff.AttendanceDate = attendanceDate;
                                }
                            }
                            else
                            {
                                var reasons = "";
                                var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                if (reason)
                                {
                                    row["Reason Behind Failure"] = "Attendance Date is empty,please check it!";
                                    row.EndEdit();
                                    p = 1;
                                    continue;
                                }
                            }
                        }
                    }
                }

                return getorignalTable;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void SaveCSVToFile(string csvContent, string filePath)
        {
            File.WriteAllText(filePath, csvContent);
        }

        private int GetAttendanceValue(string attendance)
        {
            if (string.IsNullOrWhiteSpace(attendance))
            {
                return 0;
            }

            switch (attendance.Trim().ToLower())
            {
                case "present":
                    return 1;
                case "absent":
                    return 2;
                case "halfday":
                    return 3;
                case "ShortLeave":
                    return 4;
                default:
                    return 0;
            }
        }

        private DateTime ParseDate(string dateString)
        {
            if (string.IsNullOrEmpty(dateString))
            {
                throw new FormatException("Date string is null or empty.");
            }

            DateTime dateValue;
            string[] formats = { "MM/dd/yyyy", "dd/MM/yyyy", "yyyy-MM-dd" };
            var cultureInfo = CultureInfo.InvariantCulture;
            if (DateTime.TryParseExact(dateString, formats, cultureInfo, DateTimeStyles.None, out dateValue))
            {
                return dateValue;
            }
            else
            {
                throw new FormatException($"String '{dateString}' was not recognized as a valid DateTime.");
            }
        }
    }
}
