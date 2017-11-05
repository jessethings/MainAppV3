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
using System.Diagnostics;

namespace ProjectProcessing.SubWindows
{
    /// <summary>
    /// Interaction logic for winManagement.xaml
    /// </summary>
    public partial class winDownload : Window
    {
        public int userId;

        public winDownload()
        {
            InitializeComponent();
        }

        private void butCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadCurrentDates();
        }

        //get all the dates for each of the weekly data uploads on the server
        private void LoadCurrentDates()
        {
            cmboDates.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate () //send a request to the original thread to do the following operation
            {
                List<DateHolder> dates = DownloadData.GetUserWeeklyDataDates();

                for (int i = 0; i < dates.Count; i++)
                {
                    cmboDates.Items.Add(dates[i].date_sent);
                }

                cmboDates.SelectedIndex = cmboDates.Items.Count - 1;

                cmboDates.Tag = dates;
            }));
        }

        private void butGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            if (cmboDates.SelectedItem != null)
            {
                FortunaExcelProcessing.ConsilidatedReport.processConsolidated test = new FortunaExcelProcessing.ConsilidatedReport.processConsolidated();
                string date = ((DateTime)(cmboDates.SelectedValue)).ToString("yyyy-MM-dd");
                string path = ModifySettings.GetWorkingPath() + "\\" + date + ".xlsx";
                List<DataHolder> data = DownloadData.GetWeeklyData(date);
                test.createWorkBook(path, date, data);
            }
            else
                MessageBox.Show("Please select a date");
        }

        private void butOpenReport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(ModifySettings.GetWorkingPath() + "\\");
            }
            catch
            {
                MessageBox.Show("Please create a report first");
            }
        }
    }
}
