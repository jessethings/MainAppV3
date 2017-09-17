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
    public partial class winBranchManagement : Window
    {
        public winBranchManagement()
        {
            InitializeComponent();

            Task.Factory.StartNew(() => { LoadBranches(); });
        }

        void LoadBranches()
        {
            if (branchList.Items.Count > 0)
                branchList.Items.Clear();

            List<Branch> branches = DownloadData.GetAllBranches();

            branchList.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () //send a request to the original thread to do the following operation
            {
                Dictionary<string, Branch> branchDict = new Dictionary<string, Branch>();

                for (int i = 0; i < branches.Count; i++)
                {
                    branchList.Items.Add(branches[i].Name);
                    branchDict.Add(branches[i].Name, branches[i]);
                }

                branchList.Tag = branchDict;
            }));
        }

        private void butEdit_Click(object sender, RoutedEventArgs e)
        {
            butSaveEdit.IsEnabled = true;
            panEditBranch.Visibility = Visibility.Visible;
        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void branchList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Dictionary<string, Branch> branchDict = (Dictionary<string, Branch>)branchList.Tag;
            Branch branch = branchDict[branchList.SelectedItem.ToString()];
            branchDict = null;

            txtIdEdit.Text = branch.Id.ToString();
            txtNameEdit.Text = branch.Name;
            txtAreaEdit.Text = branch.Area.ToString();
        }

        private void butCancelEdit_Click(object sender, RoutedEventArgs e)
        {
            panEditBranch.Visibility = Visibility.Hidden;
            butSaveEdit.IsEnabled = false;
        }

        private void butCreateEdit_Click(object sender, RoutedEventArgs e)
        {
            txtIdEdit.Text = "0";
            txtNameEdit.Text = "";
            txtAreaEdit.Text = "";
        }

        private void butSaveEdit_Click(object sender, RoutedEventArgs e)
        {
            if (txtNameEdit.Text.Length > 2)
            {
                double area = int.Parse(txtAreaEdit.Text);
                if (area > 0)
                {
                    try
                    {
                        UploadData.ModifyBranch(new Branch(int.Parse(txtIdEdit.Text), txtNameEdit.Text, area));
                        Task.Factory.StartNew(() => { LoadBranches(); });
                    }
                    catch
                    {
                        MessageBox.Show("Uh Oh! Something went wrong" + Environment.NewLine + "Please try again later or contact your administrator");
                    }
                }
                else
                    MessageBox.Show("Area needs to be greater than 0");
            }
            else
                MessageBox.Show("Branch names must be at least 3 characters long");
        }
    }
}
