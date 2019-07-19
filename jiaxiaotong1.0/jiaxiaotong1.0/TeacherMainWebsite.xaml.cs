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
    /// TeacherMainWebsite.xaml 的交互逻辑
    /// </summary>
    public partial class TeacherMainWebsite : Window
    {
        public TeacherMainWebsite()
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TeacherInformationModificationWebsite w = new TeacherInformationModificationWebsite();
            w.Show();
            this.Close();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            AttendanceManagementWebsite w = new AttendanceManagementWebsite();
            w.Show();
            this.Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            TeacherInformationModificationWebsite w = new TeacherInformationModificationWebsite();
            w.Show();
            this.Close();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

           StudentInformationManagementWebsite w = new StudentInformationManagementWebsite();
           w.Show();
           this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            PublishHomework w = new PublishHomework();
            w.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            commentMeWb w = new commentMeWb();
            w.Show();
            this.Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            scoreMeWb w = new scoreMeWb();
            w.Show();
            this.Close();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            parMeWb w = new parMeWb();
            w.Show();
            this.Close();
        }
    }
}
