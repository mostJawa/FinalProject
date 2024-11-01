using System.IO;
using System.Windows;

namespace FinalProject
{
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSignIn1_Click(object sender, RoutedEventArgs e)
        {
            // If the username and password match, run this code
            string usernameForFilePath = usernameTextBox.Text;
            string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), usernameForFilePath + ".txt");
            bool exists = File.Exists(filePath);
            //if file does not exist
            if (!exists)
            {
                MessageBox.Show("That account was not found in our super secure, definitely cloud-hosted, certainly not locally-stored database");
            }
            else//if it does exist
            {
                //open it and then read through it, storing the variables contained inside
                using (StreamReader sr = File.OpenText(filePath))
                {
                    string firstName = sr.ReadLine();
                    string lastName = sr.ReadLine();
                    string username = sr.ReadLine();
                    string password = sr.ReadLine();

                    if (password == passwordBox.Password)//if the password was correct, continue through the application and sign in as that user
                    {
                        MessageBox.Show("Welcome back, " + firstName);
                        CreateGlobalUser(firstName, lastName, username, password);
                        AccountVerifiedContinue();
                    }
                    else//otherwise, prompt them to sign-in again
                    {
                        MessageBox.Show("The password you entered was incorrect. Please try again");
                    }
                }
            }
        }

        // this method creates a global user that can be accessed from any page
        public void CreateGlobalUser(string fN, string lN, string un, string pw)
        {
            Application.Current.Properties["currentUser"] = new User(fN, lN, un, pw);

        }

        // this method opens the MakeSchedule page
        public void AccountVerifiedContinue()
        {

            var MakeSchedulePage = new MakeSchedule();
            MakeSchedulePage.Show();
            MessageBox.Show("Please enter the times you are not available", "Note", MessageBoxButton.OK, MessageBoxImage.Information);

            this.Close();
        }

        // this method opens the MainWindow page
        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new MainWindow();
            newPage.Show();
            this.Close();
        }
    }
}
