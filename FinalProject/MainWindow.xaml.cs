using System.Windows;

namespace FinalProject
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        // Close the current window and open the CreateAccount window
        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new CreateAccount();
            newPage.Show();
            this.Close();
        }

        // Close the current window and open the SignIn window
        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new SignIn();
            newPage.Show();
            this.Close();
        }

        // Close the current window
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
