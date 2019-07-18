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
    /// Login_Website.xaml 的交互逻辑
    /// </summary>
    public partial class Login_Website : Window
    {
        public Login_Website()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string t = comboBox.Text;
            if (t == "学生")
            {
                StudentMainWebsite w = new StudentMainWebsite();
                w.Show();
                this.Close();
            }
            if (t == "家长")
            {
                ParentsMainWebsite w = new ParentsMainWebsite();
                w.Show();
                this.Close();
            }

        }
    }
}
