using System.IO;
using System.Windows;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        //Closes the application
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CreateAccButton_Click(object sender, RoutedEventArgs e)
        {
            //retrieves the current directory and adds a file to it using the username that the user provides
            string filePath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), usernameTextBox.Text + ".txt");

            // If the username and password match, run this code
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(fNameTextBox.Text);
                sw.WriteLine(lNameTextBox.Text);

                sw.WriteLine(usernameTextBox.Text);
                sw.WriteLine(passwordTextBox.Password);
            }

            Application.Current.Properties["currentUser"] = new User(fNameTextBox.Text, lNameTextBox.Text, usernameTextBox.Text, passwordTextBox.Password);

            //This code just opens the new schedule page, allowing the user to add their schedule 
            var MakeSchedulePage = new MakeSchedule();
            MakeSchedulePage.Show();
            MessageBox.Show("Please enter the times you are not available", "Note", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();

            // Else, have a pop up telling the user they've entered their Username/Password incorrectly
        }
    }
}
