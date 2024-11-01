using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for ScheduleEvent.xaml
    /// </summary>
    public partial class ScheduleEvent : Window
    {
        public ScheduleEvent()
        {
            InitializeComponent();
        }

        //could not for the life of me figure out how to use this, so I found someone online who'd figured it out before: https://www.godo.dev/tutorials/wpf-load-external-image/
        //basically, allows the user to select and upload a photo, then displays it
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {

                uploadedPhoto.Source = new BitmapImage(new Uri(op.FileName));
                uploadedPhoto.Width = 150;
            }
            else
            {
                return;
            }

        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Generate_Event_Click(object sender, RoutedEventArgs e)
        {
            User user = Application.Current.Properties["currentUser"] as User;
            Image eventImage = uploadedPhoto;
            string eventName = EventNameTextBox.Text;
            string eventDescription = DescriptionTextBox.Text;
            string eventLength = LengthOfEventComboBox.Text;
            int eventStart = 0;
            int eventEnd = 0;



            int[,] schedule = new int[5, 16];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (user._userSchedule[i, j] == true)
                    {
                        schedule[i, j]++;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    if (schedule[i, j] == 0)
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 9;
                                    eventEnd = 10;
                                }
                                else if (eventLength == "2 s")
                                {
                                    eventStart = 9;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "8 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 1)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 10;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 2)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 11;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 3)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 12;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 4)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 1;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 5)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 2;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 6)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 3;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 3;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 7)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 4;
                                    eventEnd = 5;
                                }
                            }
                        }
                        else if (i == 1)
                        {
                            if (j == 0)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 9;
                                    eventEnd = 10;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "8 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 1)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 10;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 2)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 11;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 3)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 12;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 4)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 1;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 5)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 2;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 6)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 3;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 3;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 7)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 4;
                                    eventEnd = 5;
                                }
                            }
                        }
                        else if (i == 2)
                        {
                            if (j == 0)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 9;
                                    eventEnd = 10;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "8 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 1)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 10;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 2)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 11;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 3)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 12;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 4)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 1;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 5)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 2;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 6)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 3;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 3;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 7)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 4;
                                    eventEnd = 5;
                                }
                            }
                        }
                        else if (i == 3)
                        {
                            if (j == 0)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 9;
                                    eventEnd = 10;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "8 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 1)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 10;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 2)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 11;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 3)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 12;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 4)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 1;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 5)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 2;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 6)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 3;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 3;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 7)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 4;
                                    eventEnd = 5;
                                }
                            }
                        }
                        else if (i == 4)
                        {
                            if (j == 0)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 9;
                                    eventEnd = 10;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "8 hours")
                                {
                                    eventStart = 9;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 1)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 10;
                                    eventEnd = 11;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "7 hours")
                                {
                                    eventStart = 10;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 2)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 11;
                                    eventEnd = 12;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "6 hours")
                                {
                                    eventStart = 11;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 3)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 12;
                                    eventEnd = 1;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "5 hours")
                                {
                                    eventStart = 12;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 4)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 1;
                                    eventEnd = 2;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "4 hours")
                                {
                                    eventStart = 1;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 5)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 2;
                                    eventEnd = 3;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "3 hours")
                                {
                                    eventStart = 2;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 6)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 3;
                                    eventEnd = 4;
                                }
                                else if (eventLength == "2 hours")
                                {
                                    eventStart = 3;
                                    eventEnd = 5;
                                }
                            }
                            else if (j == 7)
                            {
                                if (eventLength == "1 hour")
                                {
                                    eventStart = 4;
                                    eventEnd = 5;
                                }
                            }
                        }
                    }
                }
            }

            int exists = 1;
            Application.Current.Properties["EventExists"] = exists;
            Application.Current.Properties["Event"] = new Event(eventDescription, eventName, eventLength, eventStart, eventEnd, eventImage);

            var newPage = new GroupView();
            newPage.Show();
            this.Close();
        }
    }
}