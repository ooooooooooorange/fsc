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
    }
}
