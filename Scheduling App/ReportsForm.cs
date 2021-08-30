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
    public partial class ReportsForm : Form
    {
        private Form Main;
        private List<User> ListOfUsers;

        public ReportsForm(Form form)
        {
            InitializeComponent();
            Main = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("Number of Appointment Types by Month Report: (Last Month, Current Month, Next Month)");
                text.AppendLine();
                DateTime thisMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime lastMonth = thisMonth.AddMonths(-1);
                DateTime nextMonth = thisMonth.AddMonths(2).AddMilliseconds(-1);

                var groupedByMonthList = MainScreen.ListOfAppointments
                    // The following threee lines contain Lambda expessions that order appointments, determine if appointments meet certain conditions, and group appointments to create a new list of appointments.
                    // The Lambda Expession is easier to read and faster
                    .OrderBy(appt => appt.Start)
                    .Where(appt => appt.Start >= lastMonth && appt.Start <= nextMonth)
                    .GroupBy(appt => appt.Start.ToString("MMMM yyyy"));

                foreach (var group in groupedByMonthList)
                {
                    text.AppendLine($"{group.Key}:");
                    var groupedByTypeList = group.GroupBy(appt => appt.Type);

                    foreach (var list in groupedByTypeList)
                    {
                        text.AppendLine($"\t{list.Key}: {list.Count()}");
                    }
                    text.AppendLine();
                }

                reportTextBox.Text = text.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("Schedule by Consultant Report: (This Month)");
                text.AppendLine();

                DateTime beginningOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime endOfMonth = beginningOfMonth.AddMonths(1).AddMilliseconds(-1);

                var groupedByConsultantList = MainScreen.ListOfAppointments
                    .Where(appt => appt.Start >= beginningOfMonth && appt.Start <= endOfMonth)
                    .GroupBy(appt => appt.UserId);

                foreach (var consultantList in groupedByConsultantList)
                {
                    text.AppendLine($"{ListOfUsers.Where(user => user.UserID == consultantList.Key).Single().UserName}'s Schedule:");
                    foreach (var appt in consultantList.OrderBy(appt => appt.Start))
                    {
                        text.AppendLine($"{MainScreen.ListOfCustomers.Where(customer => customer.CustomerId == appt.CustomerId).Single().CustomerName} - \t{appt.Start.ToString("dddd M/d/yyyy h:mm tt")}.");
                    }
                    text.AppendLine();
                }

                reportTextBox.Text = text.ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("Customers with Appointments this week:");
                text.AppendLine("------------------------------------");

                var startOfTheWeek = findBeginningOfWeek(DateTime.Now);
                var endOfTheWeek = findEndOfWeek(DateTime.Now);

                var listOfAppointmentsThisWeekGroupedByCustomerId = MainScreen.ListOfAppointments.Where(appt => appt.Start >= startOfTheWeek && appt.Start <= endOfTheWeek)
                    .GroupBy(appt => appt.CustomerId);

                foreach (var appt in listOfAppointmentsThisWeekGroupedByCustomerId)
                {
                    text.AppendLine($"Name:\t{MainScreen.ListOfCustomers.Where(customer => customer.CustomerId == appt.Key).Single().CustomerName}");
                    text.AppendLine($"Phone:\t{MainScreen.AddressDictionary[appt.Key].Phone}");
                    text.AppendLine("------------------------------------");
                }

                reportTextBox.Text = text.ToString();
            }
        }

        private void reportTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Show();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            ListOfUsers = Database.getAllUsers();
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
    }
}
