using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class StudentInstallmentViewModel
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int SchoolId { get; set; }
        public int ClassId { get; set; }
        public string SectionId { get; set; }
        public DateTime InstallmentDate { get; set; }
        public DateTime DateOfPay { get; set; }
        public string PaidPayment { get; set; }
        public string Status { get; set; }
        public string RemainingAmount { get; set; }
    }
}
