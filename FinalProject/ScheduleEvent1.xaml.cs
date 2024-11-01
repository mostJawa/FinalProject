using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
    }
}
