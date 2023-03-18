using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace image
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathfille = "";
        public MainWindow()
        {
            InitializeComponent();



        }

        private void btimage_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog namen = new OpenFileDialog();

           // if (namen.ShowDialog() == true)
           // {
                //pathfille = namen.FileName;

                // Image Url: https://cdn.pixabay.com/photo/2022/11/13/13/44/green-7589292_960_720.jpg

                BitmapImage anyname = new BitmapImage();
                Uri uri = new Uri("https://cdn.pixabay.com/photo/2022/11/13/13/44/green-7589292_960_720.jpg");
                anyname.BeginInit();
                anyname.UriSource = uri;
                anyname.EndInit();
                showimage.Source = anyname;

                FormatConvertedBitmap change= new FormatConvertedBitmap();
                change.BeginInit();
                change.Source=anyname;
                change.DestinationFormat = PixelFormats.Gray32Float;
                change.EndInit();
                showimage.Source=change;

           // }
        }
    }
}       