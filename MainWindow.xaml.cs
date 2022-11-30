using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += allSizesChange;
            //bt_equal.Click += bt_equal_Click;
        }
        void allSizesChange(object sender, EventArgs e)
        {
            var win = GetWindow(this);
            bt_CE.Width = win.Width / 4 - 15;
            bt_C.Width = win.Width / 4 - 15;
            bt_1.Width = win.Width / 4 - 15;
            bt_2.Width = win.Width / 4 - 15;
            bt_clear_one.Width = win.Width / 4 - 15;
            bt_divide.Width = win.Width / 4 - 15;
            bt_dot.Width = win.Width / 4 - 15;
            bt_equal.Width = win.Width / 2 - 25;
            bt_minus.Width = win.Width / 4 - 15;
            bt_multiply.Width = win.Width / 4 - 15;
            bt_plus.Width = win.Width / 4 - 15;
            bt_3.Width = win.Width / 4 - 15;
            bt_4.Width = win.Width / 4 - 15;
            bt_5.Width = win.Width / 4 - 15;
            bt_6.Width = win.Width / 4 - 15;
            bt_7.Width = win.Width / 4 - 15;
            bt_8.Width = win.Width / 4 - 15;
            bt_9.Width = win.Width / 4 - 15;
            bt_0.Width = win.Width / 4 - 15;
            dP.Width = win.Width - 20;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Button b = (Button)sender;
            //textBlock1.Text += b.Content.ToString();
        }

        private void bt_CE_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }

        private void bt_C_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void bt_clear_one_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void bt_7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_7.Content.ToString();
        }

        private void bt_8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_8.Content.ToString();
        }

        private void bt_9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_9.Content.ToString();
        }

        private void bt_4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_4.Content.ToString();
        }

        private void bt_5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_5.Content.ToString();
        }

        private void bt_6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_6.Content.ToString();
        }

        private void bt_1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_1.Content.ToString();
        }

        private void bt_2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_2.Content.ToString();
        }

        private void bt_3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_3.Content.ToString();
        }

        private void bt_dot_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !textBox1.Text.Contains('.'))
                textBox1.Text += ".";
        }

        private void bt_sign_Click(object sender, RoutedEventArgs e)
        {
            Button clickedbt = (Button)sender;
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Text += textBox1.Text + clickedbt.Content.ToString();
                textBox1.Text = "";
            }
        }

        private void bt_0_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += bt_7.Content.ToString();
        }

        private void bt_equal_Click(object sender, RoutedEventArgs e)
        {
            Button clickedbt = (Button)sender;
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text))
            {
                textBox2.Text += textBox1.Text + clickedbt.Content.ToString();
            }
            string str=textBox2.Text.Replace(',','.');
            str = str.Remove(str.Length-1);
            double result = Convert.ToDouble(new DataTable().Compute(str, null));
            textBox1.Text = result.ToString();

        }
    }
}
