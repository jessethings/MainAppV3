﻿using System;
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
using FortunaExcelProcessing.Objects;
using FortunaExcelProcessing.GUI;
using System.IO;

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
            SetUser(ModifySettings.GetRememberedUser().Email);
            CheckTempLoc();
        }

        private void CheckTempLoc()
        {
            if (!Directory.Exists(ModifySettings.GetWorkingPath()))
            {
                try
                {
                    Directory.CreateDirectory(ModifySettings.GetWorkingPath());
                }
                catch
                {
                    Directory.CreateDirectory(@"C:\Project\Temp");
                }
            }
        }

        public void SetUser(string user)
        {
            txtUser.Content = user;
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
                System.Diagnostics.Process.Start(ModifySettings.GetWebsiteUrl());
            }
            catch
            {
                MessageBox.Show("Invalid or Non-Existent Settings File");
            }
        }

        //open up the management window when the user clicks management
        private void butManagement_Click(object sender, RoutedEventArgs e)
        {
            try
            {//DownloadData.GetUserRole(txtUser.Content.ToString())
                if (chkchk.IsChecked == true || DownloadData.GetUserRole(txtUser.Content.ToString()) == PermissionLevel.Admin)
                {
                    winManagement win = new winManagement();
                    win.Owner = this;
                    Overlay.Visibility = Visibility.Visible;
                    win.ShowDialog();
                    win = null;
                    Overlay.Visibility = Visibility.Hidden;
                }
            }
            catch
            {
                MessageBox.Show("You do not have the permissions to view this menu");
            }
        }

        //open up the upload menu when the user clicks upload
        private void butUpload_Click(object sender, RoutedEventArgs e)
        {
            winUpload win = new winUpload();
            win.SetBranchId(DownloadData.GetUserBranch(txtUser.Content.ToString()).Id);
            win.Owner = this;
            Overlay.Visibility = Visibility.Visible;
            win.ShowDialog();
            win = null;
            Overlay.Visibility = Visibility.Hidden;
        }

        //open up the download menu when the user clicks download
        private void butDownload_Click(object sender, RoutedEventArgs e)
        {
            winDownload win = new winDownload();
            win.Owner = this;
            Overlay.Visibility = Visibility.Visible;
            win.ShowDialog();
            win = null;
            Overlay.Visibility = Visibility.Hidden;
        }
    }
}
