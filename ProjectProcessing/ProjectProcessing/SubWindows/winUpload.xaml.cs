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
using Microsoft.Win32;
using System.IO;
using FortunaExcelProcessing.GUI;
using FortunaExcelProcessing;

namespace ProjectProcessing.SubWindows
{
    /// <summary>
    /// Interaction logic for winUpload.xaml
    /// </summary>
    public partial class winUpload : Window
    {
        UploadStage uStage = UploadStage.nil;
        Brush green = new SolidColorBrush(Colors.Green);
        Brush black = new SolidColorBrush(Colors.Black);
        string _file;
        ProcessData ProcDat;
        BranchIDManagement branchMan;

        public winUpload()
        {
            InitializeComponent();
        }

//BELOW ME IS HORRIBLE CODE THAT WILL BE REWRITTEN
//TRY NOT TO COMMIT SUICIDE IF YOU VIEW IT
#region IGNORE_ME
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            uStage = UploadStage.selectFile;
            butUpload.Content = "Select a Data File";
            butUpload.IsEnabled = true;
            labUploadStatus.Content = "X";
            labProcessStatus.Content = "X";
            labSelectStatus.Content = "X";
            labProcessStatus.Visibility = Visibility.Hidden;
            labUploadStatus.Visibility = Visibility.Hidden;
            _file = "";
            //CheckForExistingUpload();
        }

        //check what stage of the upload process the application is currently at
        void CheckForExistingUpload()
        {
            if (IsDbLocValid())
            {
                uStage = UploadStage.uploadFile;
                labSelectStatus.Content = "✓";
                labProcessStatus.Content = "✓";
                butUpload.Content = "Upload Processed Data";
                labUploadStatus.Visibility = Visibility.Visible;
                labProcessStatus.Visibility = Visibility.Visible;
                labProcess.Foreground = green;
                labProcessStatus.Foreground = green;
                labSelect.Foreground = green;
                labSelectStatus.Foreground = green;
            }
        }

        //user wants to close the upload window
        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        //user clicks upload button
        private void butUpload_Click(object sender, RoutedEventArgs e)
        {
            UpdateStatus();
        }

        //displays and changes progress of the upload process depending on the user's actions
        void UpdateStatus()
        {
            if (uStage == UploadStage.selectFile)
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Multiselect = false;
                dlg.CheckFileExists = true;
                dlg.CheckPathExists = true;
                dlg.ValidateNames = true;
                if (ModifySettings.GetWorkingPath() != null && Directory.Exists(ModifySettings.GetWorkingPath()))
                    dlg.InitialDirectory = ModifySettings.GetWorkingPath();
                if (dlg.ShowDialog() == true)
                {
                    _file = dlg.FileName;
                    StepOne();
                    
                    butUpload.Content = "Process File";
                    labSelectStatus.Content = "✓";
                    labSelect.Foreground = green;
                    labSelectStatus.Foreground = green;
                    labProcessStatus.Visibility = Visibility.Visible;
                    uStage++;
                }
            }
            else if (uStage == UploadStage.processFile)
            {
                labProcessStatus.Content = "-";
                butUpload.IsEnabled = false;
                if (IsDbLocValid())
                {
                    //process
                    StepTwo();

                    butUpload.Content = "Upload Processed Data";
                    butUpload.IsEnabled = true;
                    uStage++;
                    labProcessStatus.Content = "✓";
                    labProcess.Foreground = green;
                    labProcessStatus.Foreground = green;
                    labUploadStatus.Visibility = Visibility.Visible;
                }
                else
                {
                    labProcessStatus.Content = "X";
                    MessageBox.Show("File URL Error");
                    butUpload.IsEnabled = true;
                }
            }
            else if (uStage == UploadStage.uploadFile)
            {
                labUploadStatus.Content = "-";
                butUpload.IsEnabled = false;
                if (IsDbLocValid() || true)
                {
                    //upload
                    StepThree();

                    butUpload.Content = "Complete!";
                    uStage++;
                    labUploadStatus.Content = "✓";
                    labUpload.Foreground = green;
                    labUploadStatus.Foreground = green;
                }
                else
                {
                    labUploadStatus.Content = "X";
                    MessageBox.Show("File URL Error");
                    butUpload.IsEnabled = true;
                }
            }
        }


        bool IsDbLocValid()
        {
            if (Directory.Exists(ModifySettings.GetWorkingPath()))
                if (File.Exists(ModifySettings.GetDbFilePath()))
                    return true;
            return false;
        }

        private void butRestart_Click(object sender, RoutedEventArgs e)
        {
            if (IsDbLocValid())
                File.Delete(ModifySettings.GetDbFilePath());
            uStage = UploadStage.selectFile;
            butUpload.IsEnabled = true;
            butUpload.Content = "Select a Data File";
            labUploadStatus.Content = "X";
            labProcessStatus.Content = "X";
            labSelectStatus.Content = "X";
            labProcessStatus.Visibility = Visibility.Hidden;
            labUploadStatus.Visibility = Visibility.Hidden;
            labUpload.Foreground = black;
            labUploadStatus.Foreground = black;
            labProcess.Foreground = black;
            labProcessStatus.Foreground = black;
            labSelect.Foreground = black;
            labSelectStatus.Foreground = black;
        }
#endregion IGNORE_ME

        //THIS IS THE METHOD CALLED WHEN THE USER SELECTS A FILE IN THE FILE DIALOG
        void StepOne()
        {
            branchMan = new BranchIDManagement();
            ProcDat = new ProcessData(_file);
            ProcDat.createSQLiteDB();
            branchMan.CreateFarmTable();
            ProcDat.CreateWorkBook();
            //ProcDat.CloseWorkbook();
        }

        //THIS IS THE METHOD CALLED WHEN THE USER CLICKS THE PROCESS BUTTON
        void StepTwo()
        {
            ProcDat.processSheet("Weekly Data");
            ProcDat.processSheet("Weekly Observations");
            ProcDat.processSheet("Hives");
            ProcDat.CloseWorkbook();
        }

        //THIS IS THE METHOD CALLED WHEN THE USER CLICKS UPLOAD
        void StepThree()
        {

        }
    }
}
