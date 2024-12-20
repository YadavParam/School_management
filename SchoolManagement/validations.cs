﻿using SchoolManagement.Academic;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using SchoolManagement.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement
{
    public class validations
    {
        System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        public MessageValidate ValidateRegister(SchoolDetail schooldetails)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (string.IsNullOrEmpty(schooldetails.Name))
            {
                message.Status = true;
                message.Message = "Contact Name Not filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schooldetails.Email))
            {
                message.Status = true;
                message.Message = "Contact Email Not filled, Please Check it!!";
                message.Text = "Email";
                return message;
            }
            else if (!string.IsNullOrEmpty(schooldetails.Email))
            {
                if (!expr.IsMatch(schooldetails.Email))
                {
                    message.Status = true;
                    message.Message = "Email is incorrect, Please Check it!!";
                    message.Text = "Email";
                    return message;
                }
            }
            else if (string.IsNullOrEmpty(schooldetails.Pan))
            {
                message.Status = true;
                message.Message = "Contact Pan No. Not filled, Please Check it!!";
                message.Text = "Pan";
                return message;
            }
            else if (!string.IsNullOrEmpty(schooldetails.Pan))
            {
                if (schooldetails.Pan.Length != 10)
                {
                    message.Status = true;
                    message.Message = "Contact Pan No. Is Incorrect, Please Check it!!";
                    message.Text = "Pan";
                    return message;
                }
            }
            else if (string.IsNullOrEmpty(schooldetails.SchoolName))
            {
                message.Status = true;
                message.Message = "School Name Not filled, Please Check it!!";
                message.Text = "SchoolName";
                return message;
            }
            else if (string.IsNullOrEmpty(schooldetails.SchoolWebsite))
            {
                message.Status = true;
                message.Message = "SchoolWebsite Not filled, Please Check it!!";
                message.Text = "SchoolWebsite";
                return message;
            }

            return message;
        }
        public MessageValidate ValidateParents(Parent Parentdetails,string studentadmission)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;

            if (string.IsNullOrEmpty(Parentdetails.FathersName))
            {
                message.Status = true;
                message.Message = "Father Name Not filled, Please Check it!!";
                message.Text = "Name";
                return message;
            }
            else if (string.IsNullOrEmpty(Parentdetails.MothersName))
            {
                message.Status = true;
                message.Message = "Mother Name Not filled, Please Check it!!";
                message.Text = "Name";
                return message;
            }
            else if (string.IsNullOrEmpty(Parentdetails.FathersMailId) || string.IsNullOrEmpty(Parentdetails.MothersMailId))
            {
                message.Status = true;
                message.Message = "Email Not filled, Please Check it!!";
                message.Text = "Email";
                return message;
            }

            else if (!expr.IsMatch(Parentdetails.FathersMailId))
            {
                    message.Status = true;
                    message.Message = "Father Email is incorrect, Please Check it!!";
                    message.Text = "Email";
                    return message;
            }
            else if (!expr.IsMatch(Parentdetails.MothersMailId))
            {
                    message.Status = true;
                    message.Message = "Mother Email is incorrect, Please Check it!!";
                    message.Text = "Email";
                    return message;
            }
            else if (Parentdetails.FathersMobileNumber.Length !=10)
            {
                message.Status = true;
                message.Message = "Father Mobile Number is incorrect, Please Check it!!";
                message.Text = "Mobile";
                return message;
            }
            else if (Parentdetails.MothersMobileNumber.Length !=10)
            {
                message.Status = true;
                message.Message = "Mother Mobile Number is incorrect, Please Check it!!";
                message.Text = "Mobile";
                return message;
            }
            else if (string.IsNullOrEmpty(Parentdetails.FathersOccupation) || string.IsNullOrEmpty(Parentdetails.MothersOccupation))
            {
                message.Status = true;
                message.Message = "Occupation Not filled, Please Check it!!";
                message.Text = "Occupation";
                return message;
            }
            else if (string.IsNullOrEmpty(Parentdetails.Address))
            {
                message.Status = true;
                message.Message = "Address Not filled, Please Check it!!";
                message.Text = "Address";
                return message;
            }
            else if(studentadmission=="0")
            {
                message.Status = true;
                message.Message = "Select student Admission Type!!";
                message.Text = "Admission Type";
                return message;
            }

            return message;
        }
        public MessageValidate ValidateStudents(Student studentdetails)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;

            if (string.IsNullOrEmpty(studentdetails.Name))
            {
                message.Status = true;
                message.Message = "Name Not filled, Please Check it!!";
                message.Text = "Name";
                return message;
            }
           
            else if (string.IsNullOrEmpty(studentdetails.Email))
            {
                message.Status = true;
                message.Message = "Email Not filled, Please Check it!!";
                message.Text = "Email";
                return message;
            }

            else if (!expr.IsMatch(studentdetails.Email))
            {
                message.Status = true;
                message.Message = "Email is incorrect, Please Check it!!";
                message.Text = "Email";
                return message;
            }
            else if (studentdetails.StudentType==0)
            {
                message.Status = true;
                message.Message = "!Please Select Student Type!";
                message.Text = "Mobile";
                return message;
            }
            else if (studentdetails.PhoneNumber.Length != 10)
            {
                message.Status = true;
                message.Message = "Mobile Number is incorrect, Please Check it!!";
                message.Text = "Mobile";
                return message;
            }
           
            else if (string.IsNullOrEmpty(studentdetails.Gender))
            {
                message.Status = true;
                message.Message = "Gender Not filled, Please Check it!!";
                message.Text = "Gender";
                return message;
            }
            else if (studentdetails.SectionId ==null)
            {
                message.Status = true;
                message.Message = "Section Not filled, Please Check it!!";
                message.Text = "Section";
                return message;
            }
            else if (string.IsNullOrEmpty(studentdetails.Address))
            {
                message.Status = true;
                message.Message = "Address Not filled, Please Check it!!";
                message.Text = "Address";
                return message;
            }
            else if (string.IsNullOrEmpty(studentdetails.BloodGroup))
            {
                message.Status = true;
                message.Message = "Blood group Not filled, Please Check it!!";
                message.Text = "Blood Group";
                return message;
            }
            return message;
        }
        public MessageValidate ValidateSubject(Subject subject)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (string.IsNullOrEmpty(subject.ClassName))
            {
                message.Status = true;
                message.Message = "Class Name Cannot be Empty, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(subject.SubjectName))
            {
                message.Status = true;
                message.Message = "Subject Name Cannot filled, Please Check it!!";
                return message;
            }

            return message;
        }

        public MessageValidate ValidateSchoolStaff(SchoolStaff schoolStaff, User schoolstaffvalidate)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (schoolStaff.Image == null || schoolStaff.Image.Length == 0)
            {
                message.Status = true;
                message.Message = "Image Cannot filled, Please Check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(schoolStaff.FirstName))
            {
                message.Status = true;
                message.Message = "Name Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolstaffvalidate.Email))
            {
                message.Status = true;
                message.Message = "Email Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolstaffvalidate.PhoneNumber))
            {
                message.Status = true;
                message.Message = "Phone Number Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.Gender))
            {
                message.Status = true;
                message.Message = "Gender Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.Salary))
            {
                message.Status = true;
                message.Message = "Salary Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.Experience))
            {
                message.Status = true;
                message.Message = "Experience Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.Address))
            {
                message.Status = true;
                message.Message = "Address Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.BankName))
            {
                message.Status = true;
                message.Message = "Bank Name Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.AccountNumber))
            {
                message.Status = true;
                message.Message = "Account Number Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.IFSCCode))
            {
                message.Status = true;
                message.Message = "IFSC Code Cannot filled, Please Check it!!";
                return message;
            }
            else if (string.IsNullOrEmpty(schoolStaff.BranchName))
            {
                message.Status = true;
                message.Message = "Branch Name Cannot filled, Please Check it!!";
                return message;
            }
            //if(schoolStaff.s){
            //else if (schoolStaff.ClassId == null)
            //{
            //    message.Status = true;
            //    message.Message = "Class Cannot filled, Please Check it!!";
            //    return message;
            //}
            //else if (schoolStaff.SubjectId == null)
            //{
            //    message.Status = true;
            //    message.Message = "Subject Cannot filled, Please Check it!!";
            //    return message;
            //}
            else if (string.IsNullOrEmpty(schoolStaff.Designation))
            {
                message.Status = true;
                message.Message = "Designation Cannot filled, Please Check it!!";
                return message;
            }
            //}
            return message;
        }

        public MessageValidate ValidateStudentAttandance(ClassPeriodAcademic classperiod)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if(string.IsNullOrEmpty(classperiod.Period))
            {
                message.Status = true;
                message.Message = "Period Cannot filled, Please Check it!!";
                return message;
            }
            if(classperiod.SubjectId == null || classperiod.SubjectId==0)
            {
                message.Status = true;
                message.Message = "Subject Cannot filled, Please Check it!!";
                return message;
            }
            if(classperiod.TeacherId == null || classperiod.TeacherId==0)
            {
                message.Status = true;
                message.Message = "Teacher Name Cannot filled, Please Check it!!";
                return message;
            }
            if(string.IsNullOrEmpty(classperiod.TimingFrom) && string.IsNullOrEmpty(classperiod.TimingTo))
            {
                message.Status = true;
                message.Message = "time Cannot filled, Please Check it!!";
                return message;
            }
            if(string.IsNullOrEmpty(classperiod.Duration))
            {
                message.Status = true;
                message.Message = "time Cannot filled, Please Check it!!";
                return message;
            }

            return message;
        }

        public MessageValidate ValidateClassRoutine(ClassRoutineAcademic classRoutine)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (classRoutine.ClassId == null || classRoutine.ClassId == 0)
            {
                message.Status = true;
                message.Message = "Class Cannot filled, Please Check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(classRoutine.SectionId))
            {
                message.Status = true;
                message.Message = "section Cannot filled, Please Check it!!";
                return message;
            }
            if (classRoutine.SubjectId == null || classRoutine.SubjectId == 0)
            {
                message.Status = true;
                message.Message = "Subject Cannot filled, Please Check it!!";
                return message;
            }
            if (classRoutine.TeacherId == null || classRoutine.TeacherId == 0)
            {
                message.Status = true;
                message.Message = "Teacher Cannot filled, Please Check it!!";
                return message;
            }

            return message;
        }

        public MessageValidate ValidateStudentFee(StudentFeeAccounting studentFee)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (studentFee.ClassId == null)
            {
                message.Status = true;
                message.Message = "Class not filled, Please Check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(studentFee.YearFee))
            {
                message.Status = true;
                message.Message = "Fees not filled, Please Check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(studentFee.Installment))
            {
                message.Status = true;
                message.Message = "Installment not filled, Please Check it!!";
                return message;
            }

            return message;
        }

        public MessageValidate ValidateStudentFeeInstallment(StudentFeeInstallment studentFeeInstallment)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (string.IsNullOrEmpty(studentFeeInstallment.FeeAmount))
            {
                message.Status = true;
                message.Message = "Fee amount not filled, Please Check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(studentFeeInstallment.FirstPayPayment))
            {
                message.Status = true;
                message.Message = "First pay payment not filled, Please Check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(studentFeeInstallment.NegotiableAmount))
            {
                message.Status = true;
                message.Message = "Negotiable amount not filled, Please Check it!!";
                return message;
            }
            if (studentFeeInstallment.RemainingAmount == null)
            {
                message.Status = true;
                message.Message = "Remaining amount not filled, Please Check it!!";
                return message;
            }

            return message;
        }

        public MessageValidate ValidateExpenseManager(Expens expens)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (expens.Date == null)
            {
                message.Status = true;
                message.Message = "Date not filled, Please check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(expens.ExpenseCategory)) 
            {
                message.Status = true;
                message.Message = "Expense Category not filled, Please check it!!";
                return message;
            }
            if(expens.Amount == 0.0f)
            {
                message.Status = true;
                message.Message = "Amount not filled, please check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(expens.ExpenseType))
            {
                message.Status = true;
                message.Message = "Expense Type not filled, Please check it!!";
                return message;
            }

            return message;
        }

        public MessageValidate ValidateEvent(Event events)
        {
            MessageValidate message = new MessageValidate();
            message.Status = false;
            if (string.IsNullOrEmpty(events.EventTitle))
            {
                message.Status = true;
                message.Message = "Event title not filled, Please check it!!";
                return message;
            }
            if (events.StartingDate == null)
            {
                message.Status = true;
                message.Message = "Starting date not filled, Please check it!!";
                return message;
            }
            if (events.EndingDate == null)
            {
                message.Status = true;
                message.Message = "Ending date not filled, Please check it!!";
                return message;
            }
            if (string.IsNullOrEmpty(events.DescriptionSummary))
            {
                message.Status = true;
                message.Message = "Description summary not filled, Please check it!!";
                return message;
            }

            return message;
        }
    }
}
