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

namespace ProjectProcessing.SubWindows
{
    /// <summary>
    /// Interaction logic for winManagement.xaml
    /// </summary>
    public partial class winManagement : Window
    {
        public winManagement()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void butUsers_Click(object sender, RoutedEventArgs e)
        {
            winUserManagement win = new winUserManagement();
            win.Owner = this.Owner;
            win.ShowDialog();
            win = null;
        }

        private void butFarms_Click(object sender, RoutedEventArgs e)
        {
            winBranchManagement win = new winBranchManagement();
            win.Owner = this.Owner;
            win.ShowDialog();
            win = null;
        }
    }
}
