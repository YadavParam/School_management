using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class FeeInvoiceCrystalReportViewModel
    {
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FathersName { get; set; }
        public int ClassId { get; set; }
        public string StudentId { get; set; }
        public string FeeAmount { get; set; }
        public string FirstPayPayment {  get; set; }
    }
}
