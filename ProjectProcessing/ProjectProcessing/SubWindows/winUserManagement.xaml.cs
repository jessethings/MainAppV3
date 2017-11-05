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
using FortunaExcelProcessing.GUI;
using FortunaExcelProcessing.Objects;

namespace ProjectProcessing.SubWindows
{
    /// <summary>
    /// Interaction logic for winManagement.xaml
    /// </summary>
    public partial class winUserManagement : Window
    {
        Dictionary<string, Branch> branchDict = new Dictionary<string, Branch>();

        public winUserManagement()
        {
            InitializeComponent();

            Task.Factory.StartNew(() => { LoadUsers(); });
            Task.Factory.StartNew(() => { LoadBranches(); });

            cmboPermission.Items.Add(PermissionLevel.Admin);
            cmboPermission.Items.Add(PermissionLevel.User);
            cmboPermission.Items.Add(PermissionLevel.Guest);
        }

        void LoadUsers()
        {
            if (userList.Items.Count > 0)
                userList.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () //send a request to the original thread to do the following operation
                { userList.Items.Clear(); }));

            List<User> users = DownloadData.GetAllUsers();

            userList.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () //send a request to the original thread to do the following operation
            {
                Dictionary<string, User> userDict = new Dictionary<string, User>();

                for (int i = 0; i < users.Count; i++)
                {
                    userList.Items.Add(users[i].Email);
                    userDict.Add(users[i].Email, users[i]);
                }

                userList.Tag = userDict;
            }));
        }

        void LoadBranches()
        {
            if (cmboBranch.Items.Count > 0)
                cmboBranch.Items.Clear();

            List<Branch> branches = DownloadData.GetAllBranches();

            cmboBranch.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () //send a request to the original thread to do the following operation
            {
                Dictionary<string, Branch> branchDict = new Dictionary<string, Branch>();

                for (int i = 0; i < branches.Count; i++)
                {
                    cmboBranch.Items.Add(branches[i].Name);
                    branchDict.Add(branches[i].Name, branches[i]);
                }

                cmboBranch.Tag = branchDict;
                branchDict = null;
            }));
        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void butEdit_Click(object sender, RoutedEventArgs e)
        {
            butSaveEdit.IsEnabled = true;
            panEditUser.Visibility = Visibility.Visible;
        }

        private void butSaveEdit_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameEdit.Text.Length > 2)
            {
                if (txtEmailEdit.Text.Length > 5 && txtEmailEdit.Text.Contains("@"))
                {
                    string user = userList.SelectedItem.ToString();
                    bool updatePassword = txtPasswordEdit.Password != "";

                    if (updatePassword)
                    {
                        if (txtPasswordEdit.Password.Length > 5 && txtPasswordEdit.Password.Length < 31)
                        {
                            try
                            {
                                Dictionary<string, Branch> branchDict = (Dictionary<string, Branch>)cmboBranch.Tag;
                                UploadData.ModifyUser(user, new User(txtNameEdit.Text, txtEmailEdit.Text, updatePassword == true ? txtPasswordEdit.Password : ""), updatePassword);
                                UploadData.ModifyPermissions(user, cmboPermission.SelectedIndex);
                                UploadData.AssignBranch(txtEmailEdit.Text, branchDict[cmboBranch.SelectedValue.ToString()].Id);
                                Task.Factory.StartNew(() => { LoadUsers(); });
                            }
                            catch
                            {
                                MessageBox.Show("Uh Oh! Something went wrong" + Environment.NewLine + "Please try again later or contact your administrator");
                            }
                        }
                        else
                            MessageBox.Show("Your password must be shorter than 6 characters");
                    }
                    else
                    {
                        try
                        {
                            Dictionary<string, Branch> branchDict = (Dictionary<string, Branch>)cmboBranch.Tag;
                            UploadData.ModifyUser(user, new User(txtNameEdit.Text, txtEmailEdit.Text, updatePassword == true ? txtPasswordEdit.Password : ""), updatePassword);
                            UploadData.ModifyPermissions(user, cmboPermission.SelectedIndex);
                            UploadData.AssignBranch(txtEmailEdit.Text, branchDict[cmboBranch.SelectedValue.ToString()].Id);
                            Task.Factory.StartNew(() => { LoadUsers(); });
                        }
                        catch
                        {
                            MessageBox.Show("Uh Oh! Something went wrong" + Environment.NewLine + "Please try again later or contact your administrator");
                        }
                    }
                }
                else
                    MessageBox.Show("Please enter a valid email address");
            }
            else
                MessageBox.Show("Please enter a valid name");
        }

        private void butCancelEdit_Click(object sender, RoutedEventArgs e)
        {
            panEditUser.Visibility = Visibility.Hidden;
            butSaveEdit.IsEnabled = false;
        }

        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = null;
            try
            {
                Dictionary<string, User> users = (Dictionary<string, User>)userList.Tag;
                user = users[userList.SelectedItem.ToString()];
                users = null;
            }
            catch
            {

            }
            if (user != null)
            {
                txtNameEdit.Text = user.Name;
                txtEmailEdit.Text = user.Email;
                txtPasswordEdit.Password = "";
                cmboPermission.SelectedIndex = (int)DownloadData.GetUserRole(user.Email);
                Branch branch = DownloadData.GetUserBranch(user.Email);
                if (branch != null)
                    cmboBranch.SelectedValue = branch.Name;
                else
                    cmboBranch.SelectedItem = null;
            }
        }
    }
}
