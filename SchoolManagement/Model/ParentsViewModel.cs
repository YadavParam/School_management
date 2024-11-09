using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class ParentsViewModel
    {
        public int Id { get; set; }
        public string ParentId { get; set; }
        public int SchoolId { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string FathersMailId { get; set; }
        public string MothersMailId { get; set; }
        public string NoOfChildren { get; set; }
        public string FathersMobileNumber { get; set; }
        public string MothersMobileNumber { get; set; }
        public string FathersOccupation { get; set; }
        public string MothersOccupation { get; set; }
        public string FathersBloodGroup { get; set; }
        public string MothersBloodGroup { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
