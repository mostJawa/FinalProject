using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FinalProject.View.UserControls
{
    /// <summary>
    /// Interaction logic for TimeStampBtn.xaml
    /// </summary>
    public partial class TimeStampBtn : UserControl
    {
        public TimeStampBtn()
        {
            InitializeComponent();
        }

        // Created this property to allow for the button to be set to a specific time increment
        private string strTimeStamp;
        public string StrTimeStamp
        {
            get { return strTimeStamp; }
            set
            {
                strTimeStamp = value;
                btnTimeStamp.Content = strTimeStamp;
            }
        }

        // This method is used to change the background and foreground colors of the button depending on selection and to update the user's schedule
        private void btnTimeStamp_Click(object sender, RoutedEventArgs e)
        {
            var origBack = btnTimeStamp.Background;
            var origFore = btnTimeStamp.Foreground;
            if (btnTimeStamp.Background == Brushes.White)
            {
                btnTimeStamp.Background = default;
                btnTimeStamp.Foreground = Brushes.White;
            }
            else
            {
                btnTimeStamp.Background = Brushes.White;
                btnTimeStamp.Foreground = Brushes.Black;
            }
            char weekdayInit = btnTimeStamp.Name[0];
            char timePos = btnTimeStamp.Name[1];
            User user = Application.Current.Properties["currentUser"] as User;

            if (btnTimeStamp.Background == default)
            {
                if (weekdayInit == 'M')
                {
                    if (timePos == '0')
                    {
                        user._userSchedule[0, 0] = true;
                    }
                    if (timePos == '1')
                    {
                        user._userSchedule[0, 1] = true;
                    }
                    if (timePos == '2')
                    {
                        user._userSchedule[0, 2] = true;
                    }
                    if (timePos == '3')
                    {
                        user._userSchedule[0, 3] = true;
                    }
                    if (timePos == '4')
                    {
                        user._userSchedule[0, 4] = true;
                    }
                    if (timePos == '5')
                    {
                        user._userSchedule[0, 5] = true;
                    }
                    if (timePos == '6')
                    {
                        user._userSchedule[0, 6] = true;
                    }
                    if (timePos == '7')
                    {
                        user._userSchedule[0, 7] = true;
                    }
                    if (timePos == '8')
                    {
                        user._userSchedule[0, 8] = true;
                    }
                    if (timePos == '9')
                    {
                        user._userSchedule[0, 9] = true;
                    }
                    if (timePos == 'a')
                    {
                        user._userSchedule[0, 10] = true;
                    }
                    if (timePos == 'b')
                    {
                        user._userSchedule[0, 11] = true;
                    }
                    if (timePos == 'c')
                    {
                        user._userSchedule[0, 12] = true;
                    }
                    if (timePos == 'd')
                    {
                        user._userSchedule[0, 13] = true;
                    }
                    if (timePos == 'e')
                    {
                        user._userSchedule[0, 14] = true;
                    }
                    if (timePos == 'e')
                    {
                        user._userSchedule[0, 15] = true;
                    }
                }
                if (weekdayInit == 'T')
                {
                    if (timePos == '0')
                    {
                        user._userSchedule[1, 0] = true;
                    }
                    if (timePos == '1')
                    {
                        user._userSchedule[1, 1] = true;
                    }
                    if (timePos == '2')
                    {
                        user._userSchedule[1, 2] = true;
                    }
                    if (timePos == '3')
                    {
                        user._userSchedule[1, 3] = true;
                    }
                    if (timePos == '4')
                    {
                        user._userSchedule[1, 4] = true;
                    }
                    if (timePos == '5')
                    {
                        user._userSchedule[1, 5] = true;
                    }
                    if (timePos == '6')
                    {
                        user._userSchedule[1, 6] = true;
                    }
                    if (timePos == '7')
                    {
                        user._userSchedule[1, 7] = true;
                    }
                    if (timePos == '8')
                    {
                        user._userSchedule[1, 8] = true;
                    }
                    if (timePos == '9')
                    {
                        user._userSchedule[1, 9] = true;
                    }
                    if (timePos == 'a')
                    {
                        user._userSchedule[1, 10] = true;
                    }
                    if (timePos == 'b')
                    {
                        user._userSchedule[1, 11] = true;
                    }
                    if (timePos == 'c')
                    {
                        user._userSchedule[1, 12] = true;
                    }
                    if (timePos == 'd')
                    {
                        user._userSchedule[1, 13] = true;
                    }
                    if (timePos == 'e')
                    {
                        user._userSchedule[1, 14] = true;
                    }
                    if (timePos == 'e')
                    {
                        user._userSchedule[1, 15] = true;
                    }
                    if (weekdayInit == 'W')
                    {
                        if (timePos == '0')
                        {
                            user._userSchedule[2, 0] = true;
                        }
                        if (timePos == '1')
                        {
                            user._userSchedule[2, 1] = true;
                        }
                        if (timePos == '2')
                        {
                            user._userSchedule[2, 2] = true;
                        }
                        if (timePos == '3')
                        {
                            user._userSchedule[2, 3] = true;
                        }
                        if (timePos == '4')
                        {
                            user._userSchedule[2, 4] = true;
                        }
                        if (timePos == '5')
                        {
                            user._userSchedule[2, 5] = true;
                        }
                        if (timePos == '6')
                        {
                            user._userSchedule[2, 6] = true;
                        }
                        if (timePos == '7')
                        {
                            user._userSchedule[2, 7] = true;
                        }
                        if (timePos == '8')
                        {
                            user._userSchedule[2, 8] = true;
                        }
                        if (timePos == '9')
                        {
                            user._userSchedule[2, 9] = true;
                        }
                        if (timePos == 'a')
                        {
                            user._userSchedule[2, 10] = true;
                        }
                        if (timePos == 'b')
                        {
                            user._userSchedule[2, 11] = true;
                        }
                        if (timePos == 'c')
                        {
                            user._userSchedule[2, 12] = true;
                        }
                        if (timePos == 'd')
                        {
                            user._userSchedule[2, 13] = true;
                        }
                        if (timePos == 'e')
                        {
                            user._userSchedule[2, 14] = true;
                        }
                        if (timePos == 'e')
                        {
                            user._userSchedule[2, 15] = true;
                        }
                    }
                    if (weekdayInit == 'H')
                    {
                        if (timePos == '0')
                        {
                            user._userSchedule[3, 0] = true;
                        }
                        if (timePos == '1')
                        {
                            user._userSchedule[3, 1] = true;
                        }
                        if (timePos == '2')
                        {
                            user._userSchedule[3, 2] = true;
                        }
                        if (timePos == '3')
                        {
                            user._userSchedule[3, 3] = true;
                        }
                        if (timePos == '4')
                        {
                            user._userSchedule[3, 4] = true;
                        }
                        if (timePos == '5')
                        {
                            user._userSchedule[3, 5] = true;
                        }
                        if (timePos == '6')
                        {
                            user._userSchedule[3, 6] = true;
                        }
                        if (timePos == '7')
                        {
                            user._userSchedule[3, 7] = true;
                        }
                        if (timePos == '8')
                        {
                            user._userSchedule[3, 8] = true;
                        }
                        if (timePos == '9')
                        {
                            user._userSchedule[3, 9] = true;
                        }
                        if (timePos == 'a')
                        {
                            user._userSchedule[3, 10] = true;
                        }
                        if (timePos == 'b')
                        {
                            user._userSchedule[3, 11] = true;
                        }
                        if (timePos == 'c')
                        {
                            user._userSchedule[3, 12] = true;
                        }
                        if (timePos == 'd')
                        {
                            user._userSchedule[3, 13] = true;
                        }
                        if (timePos == 'e')
                        {
                            user._userSchedule[3, 14] = true;
                        }
                        if (timePos == 'e')
                        {
                            user._userSchedule[3, 15] = true;
                        }
                    }
                    if (weekdayInit == 'F')
                    {
                        if (timePos == '0')
                        {
                            user._userSchedule[4, 0] = true;
                        }
                        if (timePos == '1')
                        {
                            user._userSchedule[4, 1] = true;
                        }
                        if (timePos == '2')
                        {
                            user._userSchedule[4, 2] = true;
                        }
                        if (timePos == '3')
                        {
                            user._userSchedule[4, 3] = true;
                        }
                        if (timePos == '4')
                        {
                            user._userSchedule[4, 4] = true;
                        }
                        if (timePos == '5')
                        {
                            user._userSchedule[4, 5] = true;
                        }
                        if (timePos == '6')
                        {
                            user._userSchedule[4, 6] = true;
                        }
                        if (timePos == '7')
                        {
                            user._userSchedule[4, 7] = true;
                        }
                        if (timePos == '8')
                        {
                            user._userSchedule[4, 8] = true;
                        }
                        if (timePos == '9')
                        {
                            user._userSchedule[4, 9] = true;
                        }
                        if (timePos == 'a')
                        {
                            user._userSchedule[4, 10] = true;
                        }
                        if (timePos == 'b')
                        {
                            user._userSchedule[4, 11] = true;
                        }
                        if (timePos == 'c')
                        {
                            user._userSchedule[4, 12] = true;
                        }
                        if (timePos == 'd')
                        {
                            user._userSchedule[4, 13] = true;
                        }
                        if (timePos == 'e')
                        {
                            user._userSchedule[4, 14] = true;
                        }
                        if (timePos == 'e')
                        {
                            user._userSchedule[4, 15] = true;
                        }
                    }
                }
            }
            // This is the code that updates the user's schedule globally
            Application.Current.Properties["currentUser"] = user;
        }
    }
}
