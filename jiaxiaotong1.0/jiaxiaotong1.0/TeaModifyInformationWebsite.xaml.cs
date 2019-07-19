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
    /// ParModifyInformationWebsite.xaml 的交互逻辑
    /// </summary>
    public partial class ParModifyInformationWebsite : Window
    {
        public ParModifyInformationWebsite()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ModifySuccessfulBulletWindow w = new ModifySuccessfulBulletWindow();
            w.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            ModifySuccessfulBulletWindow w = new ModifySuccessfulBulletWindow();
            w.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ParentsMainWebsite w = new ParentsMainWebsite();
            w.Show();
            this.Close();
        }
    }
}
