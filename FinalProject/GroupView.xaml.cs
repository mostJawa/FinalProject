using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for GroupView.xaml
    /// </summary>
    public partial class GroupView : Window
    {
        Button newEvent = new Button();
        public GroupView()
        {

            //int exists = (int)Application.Current.Properties["EventExists"];

            InitializeComponent();  // Move this to the beginning of the constructor

            if (Application.Current.Properties["Event"] is Event currEvent && currEvent.EventName != null)
            {

                newEvent.Content = "Event: " + currEvent.EventName + "\n"
                    + "Description: " + currEvent.Description + "\n"
                    + "Start Time: " + currEvent.StartTime + "\n"
                    + "End Time: " + currEvent.EndTime;
                newEvent.HorizontalContentAlignment = HorizontalAlignment.Left;
                newEvent.VerticalContentAlignment = VerticalAlignment.Top;
                newEvent.SetValue(Grid.RowProperty, 1);
                newEvent.SetValue(Grid.ColumnProperty, 1);
                newEvent.Height = 120;
                newEvent.Width = 340;
                newEvent.Background = (Brush)FindResource("btnGradient");
                newEvent.Foreground = Brushes.White;
                newEvent.Padding = new Thickness(17, 4, 0, 0);
                newEvent.FontSize = 14;


                // Add the newEvent button to the visual tree of the Grid
                MainGrid.Children.Add(newEvent);
            }
        }



        private void btnCreateEvent_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new ScheduleEvent();
            newPage.Show();
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRemoveEvent_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Remove(newEvent);
        }
    }
}
