﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class ExpenseManagerViewModel
    {
        public int Id { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<DateTime> Date { get; set; }
        public string ExpenseCategory { get; set; }
        public string ExpenseType { get; set; }
        public Nullable<double> Amount { get; set; }
    }
}
