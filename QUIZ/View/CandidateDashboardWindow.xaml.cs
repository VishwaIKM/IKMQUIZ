using QUIZ.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace QUIZ.View
{
    /// <summary>
    /// Interaction logic for CandidateDashboardWindow.xaml
    /// </summary>
    public partial class CandidateDashboardWindow : Window
    {
        double rem_time = 3600;
        public CandidateDashboardWindow()
        {
            InitializeComponent();
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            

            if (General.CandidateTestStartvalue == 1)
            {
                TimeSpan diff = DateTime.Now - General.CandidateTestStart;
                TimeSpan t = TimeSpan.FromSeconds(rem_time - diff.TotalSeconds);
                string answer = string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds,
                t.Milliseconds);
                Time_lbl.Text = answer;
            }
              
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        public void TimmerUpdate()
        {
            
        }
    }
}
