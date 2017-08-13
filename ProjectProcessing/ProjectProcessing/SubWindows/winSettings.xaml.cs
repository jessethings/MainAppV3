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
using MahApps.Metro;
using System.IO;

namespace ProjectProcessing.SubWindows
{
    /// <summary>
    /// Interaction logic for winSettings.xaml
    /// </summary>
    public partial class winSettings : Window
    {
        public winSettings()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach(Accent acc in ThemeManager.Accents)
                {
                    cmboWinColour.Items.Add(acc.Name);
                }

                foreach(AppTheme ath in ThemeManager.AppThemes)
                {
                    cmboWinTheme.Items.Add(ath.Name);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Theme Selection");
            }

            try
            {
                SetTxtTempLoc(Properties.Settings.Default.TempLoc);
                cmboWinColour.SelectedItem = Properties.Settings.Default.WinColour;
                cmboWinTheme.SelectedItem = Properties.Settings.Default.WinTheme;
            }
            catch
            {
                MessageBox.Show("Invalid or Non-Existent Settings File");
            }
        }

        //user wants to close the window without saving any changes
        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //user wants to save any changes made and close the window
        private void butSave_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.TempLoc = txtTempLoc.Text;
            Properties.Settings.Default.WinColour = (string)cmboWinColour.SelectedItem;
            Properties.Settings.Default.WinTheme = (string)cmboWinTheme.SelectedItem;
            Properties.Settings.Default.Save();
            this.Close();
        }

        //user wants to select a new temporary folder location
        private void butSetTempLoc_Click(object sender, RoutedEventArgs e)
        {
            if (OpenFileSelectDialog() != "File Cancel Error")
            {
                txtTempLoc.Text = OpenFileSelectDialog();
                SetTxtTempLoc(txtTempLoc.Text);
            }
        }

        //a method for selecting a single folder and returning the full url
        public string OpenFileSelectDialog()
        {
            System.Windows.Forms.FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            dlg.ShowNewFolderButton = true;

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) //user selected a valid folder and clicked OK
            {
                return dlg.SelectedPath; //return full url
            }
            return "File Cancel Error";
        }

        //A method for updating the text of txtTempLoc to a new temporary folder URL
        public void SetTxtTempLoc(string TempLocUrl)
        {
            if (TempLocUrl != null && Directory.Exists(TempLocUrl))
                txtTempLoc.Text = TempLocUrl;
            else
                txtTempLoc.Text = "File URL Error";
        }

        //Used to reset the application settings
        private void butResetSettings_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Reset();
        }

        //when a user changes the colour selection for the application base colour or accent
        private void cmboTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmboWinColour.SelectedItem != null && cmboWinTheme.SelectedItem != null)
            {
                try
                {
                    ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent(cmboWinColour.SelectedValue.ToString()), ThemeManager.GetAppTheme(cmboWinTheme.SelectedValue.ToString()));
                    Properties.Settings.Default.WinColour = cmboWinColour.SelectedItem.ToString();
                    Properties.Settings.Default.WinTheme = cmboWinTheme.SelectedItem.ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid Theme Selection");
                }
            }
        }
    }
}
