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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControls
{
    /// <summary>
    /// Interaction logic for AllPhones.xaml
    /// </summary>
    public partial class AllPhones : UserControl
    {
        public AllPhones()
        {
            InitializeComponent();
        }

        private void ShowDetails_k40(object sender, RoutedEventArgs e)
        {

            //int choice = int.Parse(Console.ReadLine());
            using (var db = new All_Phone_UserControlEntities())
            {
                var specs = db.Get_All_Specs("RedmiK40").ToList();
            }

           /* foreach (var item in specs)
            {

            }*/
        }

        private void ShowDetails_iphone13(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("iphone13");

        }

        private void ShowDetails_iphone14(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("iphone14");

        }

        private void ShowDetails_mi11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mi11");

        }

        private void ShowDetails_mi11lite(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("mi11lite");

        }

        private void ShowDetails_oppoF21(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("oppoF21");

        }

        private void ShowDetails_miMix4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("miMix4");

        }

        private void ShowDetails_vivoX70(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("vivoX70");

        }
    }
}
