using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class SchoolStaffViewModel
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public string Experience { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Salary { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string Designation { get; set; }
    }
}
