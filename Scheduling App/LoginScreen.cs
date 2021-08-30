using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_App
{
    public partial class LoginScreen : Form
    {
        private List<User> users;
        private string culture;
        public LoginScreen()
        {
             InitializeComponent();
        }

        
        private void changeLoginToGreek()
        {
            LoginScreenLabel.Text = "οθόνη σύνδεσης";
            UnameLabel.Text = "όνομα χρήστη";
            PwdLabel.Text = "Κωδικός πρόσβασης";
            LoginBtn.Text = "Σύνδεση";
            ExitBtn.Text = "έξοδος";
        }
         private void button1_Click(object sender, EventArgs e)
         {
            string userName = UnameTextBox.Text;
            string password = PwdTextBox.Text;

            try
            {
                if (userName == "" || password == "")
                {
                    if (culture == "el")
                    {
                        throw new LoginException("Πρέπει να έχετε όνομα χρήστη και κωδικό πρόσβασης για να συνδεθείτε");
                    }

                    throw new LoginException("You need to have both a User Name and Password to login");
                }
                //Below Lambda expession used to determine if user name entered match one of the user names returned from the database.
                // The Lambda Expession is easier to read and faster
                List<User> signedInUser = users.Where(user => user.UserName == userName).ToList();

                if (signedInUser.Count < 1)
                {
                    if (culture == "el")
                    {
                        throw new LoginException("Το όνομα χρήστη που εισαγάγατε δεν υπάρχει.");
                    }
                    throw new LoginException("The User Name you entered does not exist.");
                }

                if (signedInUser[0].Password != password)
                {
                    if (culture == "el")
                    {
                        throw new LoginException("Ο κωδικός πρόσβασης είναι λανθασμένος");
                    }
                    throw new LoginException("The password is incorrect");
                }
                Logging.logActivity(signedInUser[0]);

                var mainScreen = new MainScreen(signedInUser[0]);
                mainScreen.Show();
                Hide();
            }
            catch (LoginException error)
            {
                ErrorLabel.Text = error.Message;
            }

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PwdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            users = Database.getAllUsers();
            ErrorLabel.Text = "";
            if (culture == "el")
            {
                changeLoginToGreek();
            }
        }
         private void LoginScreenLabel_Click(object sender, EventArgs e)
         {

         }
    }
}
