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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControls
{
    /// <summary>
    /// Interaction logic for TempUC1.xaml
    /// </summary>
    public partial class TempUC1 : UserControl
    {
        public TempUC1()
        {
            InitializeComponent();
        }

        private void ShowDetails(object sender, RoutedEventArgs e)
        {


            MessageBox.Show("Hello in details");
        }

       /* private void UploadImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files |*.bmp;*.jpg;*.png";
            openDialog.FilterIndex = 1;
            if (openDialog.ShowDialog() == true)
            {
                Imagebox.Source = new BitmapImage(new Uri(openDialog.FileName));

            }
        }*/
    }
}
