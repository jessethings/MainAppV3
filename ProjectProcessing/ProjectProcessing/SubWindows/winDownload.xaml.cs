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
using FortunaExcelProcessing.Objects;

namespace ProjectProcessing.SubWindows
{
    /// <summary>
    /// Interaction logic for winManagement.xaml
    /// </summary>
    public partial class winDownload : Window
    {
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
                    cmboDates.Items.Add(dates[i].sdate);
                }

                cmboDates.Tag = dates;
            }));
        }

        private void butGenerateReport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
