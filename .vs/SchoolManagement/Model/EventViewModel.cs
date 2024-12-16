using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class EventViewModel
    {
        public int EventId { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public string EventTitle { get; set; }
        public Nullable<DateTime> StartingDate { get; set; }
        public Nullable<DateTime> EndingDate { get; set; }
        public string DescriptionSummary { get; set; }
    }
}
