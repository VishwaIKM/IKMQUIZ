using QUIZ.Core;
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

namespace QUIZ.View
{
    /// <summary>
    /// Interaction logic for StartUpWindow.xaml
    /// </summary>
    public partial class StartUpWindow : Window
    {
        public StartUpWindow()
        {
            General.S_StartUpWindow_Instance = this;
            InitializeComponent();
        }

        private void btn_AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //LoginWindow _login_window = new LoginWindow();
            General.S_LoginWindow_Instance.Show();
        }

        private void btn_CandidateLogin_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            General.CandidateTestStartvalue = 1;
            General.CandidateTestStart = DateTime.Now;
            General.S_CandidateDashboard_Instance.Show();


        }

        private void Exit_Btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
