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
    /// TeacherInformationModificationWebsite.xaml 的交互逻辑
    /// </summary>
    public partial class TeacherInformationModificationWebsite : Window
    {
        public TeacherInformationModificationWebsite()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ModifySuccessfulBulletWindow w = new ModifySuccessfulBulletWindow();
            w.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TeacherMainWebsite w = new TeacherMainWebsite();
            w.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            TeacherMainWebsite w = new TeacherMainWebsite();
            w.Show();
            this.Close();
        }
    }
}
