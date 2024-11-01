using System.Windows;
using System.Windows.Media;

namespace FinalProject
{
    public partial class MakeSchedule : Window
    {
        public MakeSchedule()
        {
            InitializeComponent();
        }

        // Closes the window when clicked
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Selects all the times and sets userSchedule to true
        private void btnSelctAll_Click(object sender, RoutedEventArgs e)
        {
            User user = Application.Current.Properties["currentUser"] as User;
            M0.Background = default;
            M0.Foreground = Brushes.White;
            M1.Background = default;
            M1.Foreground = Brushes.White;
            M2.Background = default;
            M2.Foreground = Brushes.White;
            M3.Background = default;
            M3.Foreground = Brushes.White;
            M4.Background = default;
            M4.Foreground = Brushes.White;
            M5.Background = default;
            M5.Foreground = Brushes.White;
            M6.Background = default;
            M6.Foreground = Brushes.White;
            M7.Background = default;
            M7.Foreground = Brushes.White;
            M8.Background = default;
            M8.Foreground = Brushes.White;
            M9.Background = default;
            M9.Foreground = Brushes.White;
            Ma.Background = default;
            Ma.Foreground = Brushes.White;
            Mb.Background = default;
            Mb.Foreground = Brushes.White;
            Mc.Background = default;
            Mc.Foreground = Brushes.White;
            Md.Background = default;
            Md.Foreground = Brushes.White;
            Me.Background = default;
            Me.Foreground = Brushes.White;
            Mf.Background = default;
            Mf.Foreground = Brushes.White;
            T0.Background = default;
            T0.Foreground = Brushes.White;
            T1.Background = default;
            T1.Foreground = Brushes.White;
            T2.Background = default;
            T2.Foreground = Brushes.White;
            T3.Background = default;
            T3.Foreground = Brushes.White;
            T4.Background = default;
            T4.Foreground = Brushes.White;
            T5.Background = default;
            T5.Foreground = Brushes.White;
            T6.Background = default;
            T6.Foreground = Brushes.White;
            T7.Background = default;
            T7.Foreground = Brushes.White;
            T8.Background = default;
            T8.Foreground = Brushes.White;
            T9.Background = default;
            T9.Foreground = Brushes.White;
            Ta.Background = default;
            Ta.Foreground = Brushes.White;
            Tb.Background = default;
            Tb.Foreground = Brushes.White;
            Tc.Background = default;
            Tc.Foreground = Brushes.White;
            Td.Background = default;
            Td.Foreground = Brushes.White;
            Te.Background = default;
            Te.Foreground = Brushes.White;
            Tf.Background = default;
            Tf.Foreground = Brushes.White;
            W0.Background = default;
            W0.Foreground = Brushes.White;
            W1.Background = default;
            W1.Foreground = Brushes.White;
            W2.Background = default;
            W2.Foreground = Brushes.White;
            W3.Background = default;
            W3.Foreground = Brushes.White;
            W4.Background = default;
            W4.Foreground = Brushes.White;
            W5.Background = default;
            W5.Foreground = Brushes.White;
            W6.Background = default;
            W6.Foreground = Brushes.White;
            W7.Background = default;
            W7.Foreground = Brushes.White;
            W8.Background = default;
            W8.Foreground = Brushes.White;
            W9.Background = default;
            W9.Foreground = Brushes.White;
            Wa.Background = default;
            Wa.Foreground = Brushes.White;
            Wb.Background = default;
            Wb.Foreground = Brushes.White;
            Wc.Background = default;
            Wc.Foreground = Brushes.White;
            Wd.Background = default;
            Wd.Foreground = Brushes.White;
            We.Background = default;
            We.Foreground = Brushes.White;
            Wf.Background = default;
            Wf.Foreground = Brushes.White;
            H0.Background = default;
            H0.Foreground = Brushes.White;
            H1.Background = default;
            H1.Foreground = Brushes.White;
            H2.Background = default;
            H2.Foreground = Brushes.White;
            H3.Background = default;
            H3.Foreground = Brushes.White;
            H4.Background = default;
            H4.Foreground = Brushes.White;
            H5.Background = default;
            H5.Foreground = Brushes.White;
            H6.Background = default;
            H6.Foreground = Brushes.White;
            H7.Background = default;
            H7.Foreground = Brushes.White;
            H8.Background = default;
            H8.Foreground = Brushes.White;
            H9.Background = default;
            H9.Foreground = Brushes.White;
            Ha.Background = default;
            Ha.Foreground = Brushes.White;
            Hb.Background = default;
            Hb.Foreground = Brushes.White;
            Hc.Background = default;
            Hc.Foreground = Brushes.White;
            Hd.Background = default;
            Hd.Foreground = Brushes.White;
            He.Background = default;
            He.Foreground = Brushes.White;
            Hf.Background = default;
            Hf.Foreground = Brushes.White;
            F0.Background = default;
            F0.Foreground = Brushes.White;
            F1.Background = default;
            F1.Foreground = Brushes.White;
            F2.Background = default;
            F2.Foreground = Brushes.White;
            F3.Background = default;
            F3.Foreground = Brushes.White;
            F4.Background = default;
            F4.Foreground = Brushes.White;
            F5.Background = default;
            F5.Foreground = Brushes.White;
            F6.Background = default;
            F6.Foreground = Brushes.White;
            F7.Background = default;
            F7.Foreground = Brushes.White;
            F8.Background = default;
            F8.Foreground = Brushes.White;
            F9.Background = default;
            F9.Foreground = Brushes.White;
            Fa.Background = default;
            Fa.Foreground = Brushes.White;
            Fb.Background = default;
            Fb.Foreground = Brushes.White;
            Fc.Background = default;
            Fc.Foreground = Brushes.White;
            Fd.Background = default;
            Fd.Foreground = Brushes.White;
            Fe.Background = default;
            Fe.Foreground = Brushes.White;
            Ff.Background = default;
            Ff.Foreground = Brushes.White;

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; i < 16; i++)
                {
                    user._userSchedule[i, j] = true;
                }
            }
        }

        // Deselects all the times and sets userSchedule to false
        private void btnDeselctAll_Click(object sender, RoutedEventArgs e)
        {
            User user = Application.Current.Properties["currentUser"] as User;
            M0.Background = Brushes.White;
            M0.Background = Brushes.Black;
            M1.Background = Brushes.White;
            M1.Background = Brushes.Black;
            M2.Background = Brushes.White;
            M2.Background = Brushes.Black;
            M3.Background = Brushes.White;
            M3.Background = Brushes.Black;
            M4.Background = Brushes.White;
            M4.Background = Brushes.Black;
            M5.Background = Brushes.White;
            M5.Background = Brushes.Black;
            M6.Background = Brushes.White;
            M6.Background = Brushes.Black;
            M7.Background = Brushes.White;
            M7.Background = Brushes.Black;
            M8.Background = Brushes.White;
            M8.Background = Brushes.Black;
            M9.Background = Brushes.White;
            M9.Background = Brushes.Black;
            Ma.Background = Brushes.White;
            Ma.Background = Brushes.Black;
            Mb.Background = Brushes.White;
            Mb.Background = Brushes.Black;
            Mc.Background = Brushes.White;
            Mc.Background = Brushes.Black;
            Md.Background = Brushes.White;
            Md.Background = Brushes.Black;
            Me.Background = Brushes.White;
            Me.Background = Brushes.Black;
            Mf.Background = Brushes.White;
            Mf.Background = Brushes.Black;
            T0.Background = Brushes.White;
            T0.Background = Brushes.Black;
            T1.Background = Brushes.White;
            T1.Background = Brushes.Black;
            T2.Background = Brushes.White;
            T2.Background = Brushes.Black;
            T3.Background = Brushes.White;
            T3.Background = Brushes.Black;
            T4.Background = Brushes.White;
            T4.Background = Brushes.Black;
            T5.Background = Brushes.White;
            T5.Background = Brushes.Black;
            T6.Background = Brushes.White;
            T6.Background = Brushes.Black;
            T7.Background = Brushes.White;
            T7.Background = Brushes.Black;
            T8.Background = Brushes.White;
            T8.Background = Brushes.Black;
            T9.Background = Brushes.White;
            T9.Background = Brushes.Black;
            Ta.Background = Brushes.White;
            Ta.Background = Brushes.Black;
            Tb.Background = Brushes.White;
            Tb.Background = Brushes.Black;
            Tc.Background = Brushes.White;
            Tc.Background = Brushes.Black;
            Td.Background = Brushes.White;
            Td.Background = Brushes.Black;
            Te.Background = Brushes.White;
            Te.Background = Brushes.Black;
            Tf.Background = Brushes.White;
            Tf.Background = Brushes.Black;
            W0.Background = Brushes.White;
            W0.Background = Brushes.Black;
            W1.Background = Brushes.White;
            W1.Background = Brushes.Black;
            W2.Background = Brushes.White;
            W2.Background = Brushes.Black;
            W3.Background = Brushes.White;
            W3.Background = Brushes.Black;
            W4.Background = Brushes.White;
            W4.Background = Brushes.Black;
            W5.Background = Brushes.White;
            W5.Background = Brushes.Black;
            W6.Background = Brushes.White;
            W6.Background = Brushes.Black;
            W7.Background = Brushes.White;
            W7.Background = Brushes.Black;
            W8.Background = Brushes.White;
            W8.Background = Brushes.Black;
            W9.Background = Brushes.White;
            W9.Background = Brushes.Black;
            Wa.Background = Brushes.White;
            Wa.Background = Brushes.Black;
            Wb.Background = Brushes.White;
            Wb.Background = Brushes.Black;
            Wc.Background = Brushes.White;
            Wc.Background = Brushes.Black;
            Wd.Background = Brushes.White;
            Wd.Background = Brushes.Black;
            We.Background = Brushes.White;
            We.Background = Brushes.Black;
            Wf.Background = Brushes.White;
            Wf.Background = Brushes.Black;
            H0.Background = Brushes.White;
            H0.Background = Brushes.Black;
            H1.Background = Brushes.White;
            H1.Background = Brushes.Black;
            H2.Background = Brushes.White;
            H2.Background = Brushes.Black;
            H3.Background = Brushes.White;
            H3.Background = Brushes.Black;
            H4.Background = Brushes.White;
            H4.Background = Brushes.Black;
            H5.Background = Brushes.White;
            H5.Background = Brushes.Black;
            H6.Background = Brushes.White;
            H6.Background = Brushes.Black;
            H7.Background = Brushes.White;
            H7.Background = Brushes.Black;
            H8.Background = Brushes.White;
            H8.Background = Brushes.Black;
            H9.Background = Brushes.White;
            H9.Background = Brushes.Black;
            Ha.Background = Brushes.White;
            Ha.Background = Brushes.Black;
            Hb.Background = Brushes.White;
            Hb.Background = Brushes.Black;
            Hc.Background = Brushes.White;
            Hc.Background = Brushes.Black;
            Hd.Background = Brushes.White;
            Hd.Background = Brushes.Black;
            He.Background = Brushes.White;
            He.Background = Brushes.Black;
            Hf.Background = Brushes.White;
            Hf.Background = Brushes.Black;
            F0.Background = Brushes.White;
            F0.Background = Brushes.Black;
            F1.Background = Brushes.White;
            F1.Background = Brushes.Black;
            F2.Background = Brushes.White;
            F2.Background = Brushes.Black;
            F3.Background = Brushes.White;
            F3.Background = Brushes.Black;
            F4.Background = Brushes.White;
            F4.Background = Brushes.Black;
            F5.Background = Brushes.White;
            F5.Background = Brushes.Black;
            F6.Background = Brushes.White;
            F6.Background = Brushes.Black;
            F7.Background = Brushes.White;
            F7.Background = Brushes.Black;
            F8.Background = Brushes.White;
            F8.Background = Brushes.Black;
            F9.Background = Brushes.White;
            F9.Background = Brushes.Black;
            Fa.Background = Brushes.White;
            Fa.Background = Brushes.Black;
            Fb.Background = Brushes.White;
            Fb.Background = Brushes.Black;
            Fc.Background = Brushes.White;
            Fc.Background = Brushes.Black;
            Fd.Background = Brushes.White;
            Fd.Background = Brushes.Black;
            Fe.Background = Brushes.White;
            Fe.Background = Brushes.Black;
            Ff.Background = Brushes.White;
            Ff.Background = Brushes.Black;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 16; i++)
                {
                    user._userSchedule[i, j] = false;
                }
            }
        }

        // Takes the user to the group page
        private void btnCont_Click(object sender, RoutedEventArgs e)
        {
            var newPage = new GroupPage();
            newPage.Show();
            this.Close();
        }
    }
}
