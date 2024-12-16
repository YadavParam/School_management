using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class AccountsOfMonthWiseViewModel
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public string StudentId { get; set; }
        public string SectionId { get; set; }
        public int ClassId { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string FeeAmount { get; set; }
        public string TotalPaidPayment { get; set; }
        public string LatestStatus { get; set; }
    }
}
