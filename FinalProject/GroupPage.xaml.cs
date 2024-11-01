using System.Windows;
using System.Windows.Input;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for GroupPage.xaml
    /// </summary>
    public partial class GroupPage : Window
    {
        public GroupPage()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (lbGroups.SelectedItem != null)
            {
                int index = this.lbGroups.SelectedIndex;
                var newPage = new GroupView();
                newPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a group to view");
            }


        }
    }
}
