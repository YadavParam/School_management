//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSubscriptionPlanDetail
    {
        public int Id { get; set; }
        public Nullable<int> SchoolId { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> PlanId { get; set; }
        public string UserEmailId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> Amount { get; set; }
        public string TransactionID { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
    }
}