using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            save_ScreenShot_as_File();
            MessageBox.Show("Screen Captured");
        }
        //Implement the logic to take screenshot.
        private void save_ScreenShot_as_File()
        {

            //------------< save_ScreenShot_as_File() >------------

            String filename = "ScreenCapture-" + DateTime.Now.ToString("ddMMyyyy-hhmmss") + ".png";

            //< size >

            int screenLeft = (int)SystemParameters.VirtualScreenLeft;

            int screenTop = (int)SystemParameters.VirtualScreenTop;

            int screenWidth = (int)SystemParameters.VirtualScreenWidth;

            int screenHeight = (int)SystemParameters.VirtualScreenHeight;

            //</ size >

            Bitmap bitmap_Screen = new Bitmap(screenWidth, screenHeight);

            Graphics g = Graphics.FromImage(bitmap_Screen);

            //get ScreenShot

            //into bitmap as graphics

            g.CopyFromScreen(screenLeft, screenTop, 0, 0, bitmap_Screen.Size);

            //get ScreenShot

            //save bitmap 

            bitmap_Screen.Save("D:\\FirstApp\\SaveScreenshots\\"+ filename);

            //save bitmap

            //------------</ save_ScreenShot_as_File() >------------

        }

        
    }
}
