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
using MahApps.Metro.Controls;
using ProjectProcessing.SubWindows;
using ProjectProcessing.Properties;

namespace ProjectProcessing
{
    /// <summary>
    /// Interaction logic for MainApp.xaml
    /// </summary>
    public partial class MainApp
    {
        public MainApp()
        {
            InitializeComponent();
        }

        //open up the settings window when the user clicks the settings button
        private void butSettings_Click(object sender, RoutedEventArgs e)
        {
            winSettings win = new winSettings();
            win.Owner = this;
            Overlay.Visibility = Visibility.Visible;
            win.ShowDialog();
            win = null;
            Overlay.Visibility = Visibility.Hidden;
        }

        //open up the project's website when a user clicks the website button
        private void butWebsite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(AppSettings.Default.WebsiteUrl);
            }
            catch
            {
                MessageBox.Show("Invalid or Non-Existent Settings File");
            }
        }

        //open up the management window when the user clicks management
        private void butManagement_Click(object sender, RoutedEventArgs e)
        {
            winManagement win = new winManagement();
            win.Owner = this;
            Overlay.Visibility = Visibility.Visible;
            win.ShowDialog();
            win = null;
            Overlay.Visibility = Visibility.Hidden;
        }

        //open up the upload menu when the user clicks upload
        private void butUpload_Click(object sender, RoutedEventArgs e)
        {
            winUpload win = new winUpload();
            win.Owner = this;
            Overlay.Visibility = Visibility.Visible;
            win.ShowDialog();
            win = null;
            Overlay.Visibility = Visibility.Hidden;
        }
    }
}
