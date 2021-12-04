using System;
using System.IO;
using System.Reflection;
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
using Vlc.DotNet.Wpf;

namespace vlc1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public VlcControl myVlcControl;
        public MainWindow()
        {
            InitializeComponent();

            myVlcControl.MediaPlayer.VlcLibDirectory =
                //replace this path with an appropriate one
            new DirectoryInfo(@"c:\Program Files (x86)\VideoLAN\VLC\");
            myVlcControl.MediaPlayer.EndInit();
            myVlcControl.MediaPlayer.Play(new Uri("http://download.blender.org/peach/" +
                "bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"));
        }

        public void updateFiles()
        {
            string Name = "Basava";
            string Qualification = "BE";
            int YearOfPassOut = 2018;

            Console.WriteLine("Standard DateTime Format Specifiers");
        }
    }


}
