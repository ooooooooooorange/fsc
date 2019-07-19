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

namespace jiaxiaotong1._0
{
    /// <summary>
    /// StudentMainWebsite.xaml 的交互逻辑
    /// </summary>
    public partial class StudentMainWebsite : Window
    {
        public StudentMainWebsite()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Login_Website w = new Login_Website();
            w.Show();
            this.Close();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            ModifyPasswordWebsite w = new ModifyPasswordWebsite();
            w.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StuModifyInformationWebsite w = new StuModifyInformationWebsite();
                w.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ViewMessageWebsite w = new ViewMessageWebsite();
            w.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ExchangeWebsite w = new ExchangeWebsite();
            w.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            RewardAndPenaltyCommentsWebsite w = new RewardAndPenaltyCommentsWebsite();
            w.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AttendanceWebsite w = new AttendanceWebsite();
            w.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            LookatHomeworkWebsites w = new LookatHomeworkWebsites();
            w.Show();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            ScoreWebsite w = new ScoreWebsite();
            w.Show();
        }
    }
}
