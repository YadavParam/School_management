using CsvHelper;
using SchoolManagement.Accounting;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace SchoolManagement.Academic
{
    public partial class EventCalender : Form
    {
        private int eventIdToUpdate;
        private int SchoolId;
        private SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        validations validate = new validations();
        Form frm;
        public EventCalender()
        {
            InitializeComponent();
        }

        private void EventCalender_Load(object sender, EventArgs e)
        {
            int EventId = EditStaffViewModel.Id;
            SchoolId = EditStaffViewModel.SchoolId;
            if (EventId != null && EventId != 0 && SchoolId != null && SchoolId != 0)
            {
                GetEventData(EventId, SchoolId);
            }
        }

        private void EventSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (EventSubmit.Text.Trim() == "Save Event")
                {
                    var events = new Event
                    {
                        SchoolId = 2008,
                        EventTitle = EventTitle.Text,
                        StartingDate = Convert.ToDateTime(EventStartingDate.Text),
                        EndingDate = Convert.ToDateTime(EventEndingDate.Text),
                        DescriptionSummary = Summary.Text,
                        IsActive = true,
                        IsDelete = false,
                        DateAdded = DateTime.Now,
                        DateModified = DateTime.Now,
                    };
                    var eventValidate = validate.ValidateEvent(events);
                    if (eventValidate.Status == true)
                    {
                        MessageBox.Show(eventValidate.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        DbContext.Events.Add(events);
                        DbContext.SaveChanges();

                        MessageBox.Show("New event inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EventTitle.Text = "";
                        EventStartingDate.Text = string.Empty;
                        EventEndingDate.Text = string.Empty;
                        Summary.Text = string.Empty;
                    }
                }
                else if (EventSubmit.Text == "Update Event")
                {
                    UpdateEvent();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void GetEventData(int EventId, int SchoolId)
        {
            try
            {
                var eventDetails = DbContext.Events.AsNoTracking().FirstOrDefault(x => x.EventId == EventId && x.SchoolId == SchoolId);
                if (eventDetails != null)
                {
                    eventIdToUpdate = eventDetails.EventId;
                    EventTitle.Text = eventDetails.EventTitle;
                    if (eventDetails.StartingDate.HasValue)
                    {
                        EventStartingDate.Value = eventDetails.StartingDate.Value;
                    }
                    if (eventDetails.EndingDate.HasValue)
                    {
                        EventEndingDate.Value = eventDetails.EndingDate.Value;
                    }
                    Summary.Text = eventDetails.DescriptionSummary;

                    EventSubmit.Text = "Update Event";
                }
                else
                {
                    MessageBox.Show("Expense details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UpdateEvent()
        {
            try
            {
                var eventDetails = DbContext.Events.AsNoTracking().FirstOrDefault(x => x.EventId == eventIdToUpdate && x.SchoolId == SchoolId);
                if (eventDetails != null)
                {
                    eventDetails.EventTitle = EventTitle.Text;
                    eventDetails.StartingDate = Convert.ToDateTime(EventStartingDate.Text);
                    eventDetails.EndingDate = Convert.ToDateTime(EventEndingDate.Text);
                    eventDetails.DescriptionSummary = Summary.Text;
                    var eventValidate = validate.ValidateEvent(eventDetails);
                    if (eventValidate.Status == true)
                    {
                        MessageBox.Show(eventValidate.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        eventDetails.DateModified = DateTime.Now;
                        DbContext.Entry(eventDetails).State = EntityState.Modified;
                        DbContext.SaveChanges();

                        MessageBox.Show("Event updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EventTitle.Text = string.Empty;
                        EventStartingDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                        EventEndingDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                        Summary.Text = string.Empty;
                        EventSubmit.Text = "Save Event";
                        this.Hide();
                        frm = new EventCalenderDetails();
                        frm.TopLevel = false;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
                        Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
                        frm.BringToFront();
                        frm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Events details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Something went wrong, it can be internet issue also please check your internet properly and filled Details, if problem occurs continue, please contact to Singhtek!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
