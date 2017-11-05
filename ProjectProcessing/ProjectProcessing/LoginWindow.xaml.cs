using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using MahApps.Metro;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using ProjectProcessing.Properties;
using FortunaExcelProcessing.GUI;
using FortunaExcelProcessing;

namespace ProjectProcessing
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (chkchk.IsChecked == true)
            {
                MainApp ma = new MainApp();
                ma.Owner = GetWindow(this);
                Hide();
                ma.ShowDialog();
                Close();
            }
            else
            {
                if (txtEmailLogin.Text.Length > 5 && txtEmailLogin.Text.Contains("@"))
                {
                    if (txtPasswordLogin.Password.Length > 5 && txtPasswordCreate.Password.Length < 30)
                    {
                        try
                        {
                            AttemptLogin(txtEmailLogin.Text, txtPasswordLogin.Password);
                        }
                        catch
                        {
                            MessageBox.Show("Uh Oh! Something went wrong" + Environment.NewLine + "Please try again later or contact your administrator");
                        }
                    }
                    else
                        MessageBox.Show("Your password must be at least 6 characters and less than 30");
                }
                else
                    MessageBox.Show("Please enter a valid email address");
            }
        }

        private void AttemptLogin(string email, string password)
        {
            if (DownloadData.IsLoginCorrect(email, password))
            {
                if (chkRemembner.IsChecked == true)
                    ModifySettings.UpdateRememberedUser(new User("", email, password));

                MainApp ma = new MainApp();
                ma.Owner = GetWindow(this);
                ma.SetUser(email);
                Hide();
                ma.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Incorrect login details");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent(ModifySettings.GetWinColour()), ThemeManager.GetAppTheme(ModifySettings.GetWinTheme()));
            }
            catch
            {
                MessageBox.Show("Invalid Theme Selection");
            }

            try
            {
                if (ModifySettings.GetIsLoginRemembered())
                {
                    User user = ModifySettings.GetRememberedUser();
                    AttemptLogin(user.Email, user.Password);
                }
            }
            catch
            {
                MessageBox.Show("Error, unable to remember login");
            }
        }

        private void butCancelCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountPan.Visibility = Visibility.Hidden;
        }

        private void butCreatePanel_Click(object sender, RoutedEventArgs e)
        {
            CreateAccountPan.Visibility = Visibility.Visible;
        }

        private void butCreateNew_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameCreate.Text.Length > 2)
            {
                if (txtEmailCreate.Text.Length > 5 && txtEmailCreate.Text.Contains("@"))
                {
                    if (txtPasswordCreate.Password.Length > 5 && txtPasswordCreate.Password.Length < 30)
                    {
                        try
                        {
                            UploadData.CreateUser(new User(txtNameCreate.Text, txtEmailCreate.Text, txtPasswordCreate.Password));
                        }
                        catch
                        {
                            MessageBox.Show("Uh Oh! Something went wrong" + Environment.NewLine + "Please try again later or contact your administrator");
                        }
                    }
                    else
                        MessageBox.Show("Your password must be at least 6 characters and less than 30");
                }
                else
                    MessageBox.Show("Please enter a valid email address");
            }
            else
                MessageBox.Show("Please enter a valid name");
        }
    }
}
