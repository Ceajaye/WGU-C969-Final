using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class AppointmentsForm : Form
    {
        private Form Main;
        private DateTime SelectedDate;
       // private bool monthSelected = true;
       
        public AppointmentsForm(Form main)
        {
            InitializeComponent();
            MainLabel.Text = $"Appointments for { MainScreen.LoggedInUser.UserName }";
            Main = main;
            SelectedDate = DateTime.Now;
            DatesRadioButton.Checked = true;
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            displayThisMonth();
            populateComboBoxAppointmentType();
        }

        private void populateComboBoxAppointmentType()
        {
            comboBoxAppointmentType.DataSource = new[] { "Scrum", "Presentation", "Lunch", "Interview", "Consultation" };
            comboBoxAppointmentType.SelectedItem = null;
        }


        private void displayThisMonth()
        {
            dateTimePickerStartDate.Value = findBeginningOfMonth(DateTime.Now);
            dateTimePickerEndDate.Value = findEndOfMonth(DateTime.Now);
            appointmentDataGridView.DataSource = getAppointmentsInTimePeriod(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
        }

        public void UpdateSelection()
        {

        }

        private void AppointmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Show();
        }

        private void formatDataGridView()
        {
            var dataGridView = appointmentDataGridView;
            dataGridView.AutoResizeColumns();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.ClearSelection();
        }

        private void appointmentDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            formatDataGridView();
        }

        private void MainLabel_Click(object sender, EventArgs e)
        {

        }

        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (monthRadioButton.Checked == true)
        //    {
        //        monthSelected = true;
        //        updateViewWithMonthlySelected();
        //    }
        //}

        //private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (weekRadioButton.Checked == true)
        //    {
        //        monthSelected = false;
        //        updateViewWithWeeklySelected();
        //    }
        //}

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AppointmentAddEditForm(this);
            addForm.Show();
            appointmentDataGridView.ClearSelection();
            Hide();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (appointmentDataGridView.SelectedRows.Count < 1)
                {
                    throw new ApplicationException("You must select an appointment to edit.");
                }
                var selectedRow = appointmentDataGridView.SelectedRows[0];
                int selectedAppointmentId = Convert.ToInt32(selectedRow.Cells[0].Value);
                var editForm = new AppointmentAddEditForm(this, selectedAppointmentId);
                editForm.Show();
                appointmentDataGridView.ClearSelection();
                Hide();
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }
    

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (appointmentDataGridView.SelectedRows.Count < 1)
                {
                    throw new ApplicationException("You must select an appointment to delete.");
                }
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete the selected appointment?", "Application Instruction", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    var selectedRow = appointmentDataGridView.SelectedRows[0];
                    int selectedAppointmentId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    Appointment selectedAppointment = MainScreen.ListOfAppointments.Where(appt => appt.AppointmentId == selectedAppointmentId).Single();
                    Database.deleteAppointment(selectedAppointment);
                    
                }
                else
                {
                    appointmentDataGridView.ClearSelection();
                }
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Main.Show();
        }


        private DateTime findBeginningOfWeek(DateTime date)
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            var difference = date.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (difference < 0)
            {
                difference = difference + 7;
            }
            return date.AddDays(-difference).Date;
        }

        private DateTime findEndOfWeek(DateTime date)
        {
            return findBeginningOfWeek(date).AddDays(7).AddMilliseconds(-1);
        }

        private DateTime findBeginningOfMonth(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }

        private DateTime findEndOfMonth(DateTime date)
        {
            return findBeginningOfMonth(date).AddMonths(1).AddMilliseconds(-1);
        }

        private BindingList<Appointment> getAppointmentsInTimePeriod(DateTime beginTime, DateTime endTime)
        {
            //used the following lambda in linq statement to recreate list of Appointments that fall within the begin and end time bounds.
            return new BindingList<Appointment>(MainScreen.ListOfAppointments.Where(appt => appt.Start >= beginTime && appt.End <= endTime).ToList());
        }

        private BindingList<Appointment> getAppointmentsByCustomerId(int id)
        { //return a list of appointments for a datagrid view based on customerID
            return new BindingList<Appointment>(MainScreen.ListOfAppointments.Where(appt => appt.CustomerId == id).ToList());
        }


        private BindingList<Appointment> getAppointmentsByAppointmentType(string type)
        {
            return new BindingList<Appointment>(MainScreen.ListOfAppointments.Where(appt => appt.Type == type).ToList());
        }

        // private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        //  {
        //    SelectedDate = monthCalendar.SelectionStart;

        //   if (monthRadioButton.Checked == true)
        //  {
        //     updateViewWithMonthlySelected();
        //}
        //  else
        // {
        //      updateViewWithWeeklySelected();
        //  }
        //}

        private void updateViewWithMonthlySelected()
        {
            DateTime beginningOfMonth = findBeginningOfMonth(SelectedDate);
            DateTime endOfMonth = findEndOfMonth(SelectedDate);
            appointmentDataGridView.DataSource = getAppointmentsInTimePeriod(beginningOfMonth, endOfMonth);
        }

        private void updateViewWithWeeklySelected()
        {
            DateTime beginningOfWeek = findBeginningOfWeek(SelectedDate);
            DateTime endOfWeek = findEndOfWeek(SelectedDate);
            appointmentDataGridView.DataSource = getAppointmentsInTimePeriod(beginningOfWeek, endOfWeek);
        }

        private void updateViewWithSearchedId(int id)
        {
            appointmentDataGridView.DataSource = getAppointmentsByCustomerId(id);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            CustomerIDlabel.Visible = false;
            AppointmentTypeLabel.Visible = false;
            CustomerIDtextbox.Visible = false;
            comboBoxAppointmentType.Visible = false;
            StartDateLabel.Visible = true;
            EndDateLabel.Visible = true;
            dateTimePickerStartDate.Visible = true;
            dateTimePickerEndDate.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (CustomerIDradioButton.Checked == true)
            {
                updateViewOnCustomerID();
            }

            if (AppointmentTypeRadioButton.Checked == true)
            {
                updateViewOnAppointmentType();
            }
            if (DatesRadioButton.Checked == true)
            {
                updateViewOnDate();
            }
        }


        private void updateViewOnCustomerID()
        {
            int customerId = 0;
            int.TryParse(CustomerIDtextbox.Text, out customerId);
            if (customerId < 1)
            {
                MessageBox.Show("Please enter a number greater than 0");
                return;
            }
            BindingList<Appointment> appointments = getAppointmentsByCustomerId(customerId);
            if (appointments.Count == 0)
            {
                MessageBox.Show("No appointments found for customer ID");
                return;
            }
            appointmentDataGridView.DataSource = appointments;
        }


        private void updateViewOnAppointmentType()
        {
            BindingList<Appointment> appointments = getAppointmentsByAppointmentType(comboBoxAppointmentType.Text);
            if (appointments.Count == 0)
            {
                MessageBox.Show("You have no appointments for selected type.");
                return;
            }
            appointmentDataGridView.DataSource = appointments;
        }

        private void updateViewOnDate()
        {
            var StartDate = dateTimePickerStartDate.Value;
            var EndDate = dateTimePickerEndDate.Value.AddMilliseconds(1);

            if (StartDate > EndDate)
            {
                MessageBox.Show($"The start date: {StartDate} is later than  \n the end date: {EndDate}");
                return;
            }

            BindingList<Appointment> appointments = getAppointmentsInTimePeriod(StartDate, EndDate);
            if (appointments.Count == 0)
            {
                MessageBox.Show("No appointments found for date range provided.");
                return;
            }
            appointmentDataGridView.DataSource = appointments;
        }

        private void CustomerIDradioButton_CheckedChanged(object sender, EventArgs e)
        {

            CustomerIDlabel.Visible = true;
            AppointmentTypeLabel.Visible = false;
            CustomerIDtextbox.Visible = true;
            comboBoxAppointmentType.Visible = false;
            StartDateLabel.Visible = false;
            EndDateLabel.Visible = false;
            dateTimePickerStartDate.Visible = false;
            dateTimePickerEndDate.Visible = false;
        }

        private void AppointmentTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CustomerIDlabel.Visible = false;
            AppointmentTypeLabel.Visible = true;
            CustomerIDtextbox.Visible = false;
            comboBoxAppointmentType.Visible = true;
            StartDateLabel.Visible = false;
            EndDateLabel.Visible = false;
            dateTimePickerStartDate.Visible = false;
            dateTimePickerEndDate.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
