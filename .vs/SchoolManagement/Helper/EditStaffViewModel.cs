using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Helper
{
    public static  class EditStaffViewModel
    {
        public static int Id { get; set; }
        public static int ClassId { get; set; }
        public static int SchoolId { get; set; }
        public static string SectionId { get; set; }
        public static string StudentId { get; set; }
        public static string ParentId { get; set; }
        public static int UserId { get; set; }
    }
}
