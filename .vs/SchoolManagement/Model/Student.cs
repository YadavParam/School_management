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
    
    public partial class Student
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public int SchoolId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<int> StudentType { get; set; }
        public string ParentId { get; set; }
        public Nullable<int> ClassId { get; set; }
        public string SectionId { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public byte[] Image { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> Isdelete { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string Password { get; set; }
    }
}
