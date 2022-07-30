using System;
using System.Windows;

namespace calculator
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double x;
        public double y;
        public char c;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += "0";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                c = '+';
                TextBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                c = '-';
                TextBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                c = '*';
                TextBox1.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

            {
                try
                {
                    x = Convert.ToDouble(TextBox1.Text);
                    c = '/';
                    TextBox1.Text = "";
                }
                catch (Exception)
                
                    MessageBox.Show("Введите число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }




        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            try
            {
                y = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = "";
                switch (c)
                {
                    case '+':
                        TextBox1.Text = Convert.ToString(x + y);
                        break;
                    case '-':
                        TextBox1.Text = Convert.ToString(x - y);
                        break;
                    case '/':
                        if (y == 0)
                        {
                            MessageBox.Show("На ноль делить нельзя!", "Error", MessageBoxButton.OK);
                        }
                        else
                        {
                            TextBox1.Text = Convert.ToString(x / y);

                        }
                        break;

                    case '*':
                        TextBox1.Text = Convert.ToString(x * y);
                        break;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Введите выражение", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }




        }




        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "";
            x = 0;
            y = 0;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += ",";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = Convert.ToString(Math.Pow(x, 2));
            }
            catch (Exception)
            {

                MessageBox.Show("Введите значение для вычисления", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = Convert.ToString(Math.Sqrt(x));
            }
            catch (Exception)
            {

                MessageBox.Show("Введите значение для вычисления", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = Convert.ToString(Math.Sin((x * Math.PI) / 180));
            }
            catch (Exception)
            {

                MessageBox.Show("Введите значение для вычисления", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = Convert.ToString(Math.Cos((x * Math.PI) / 180));

            }
            catch (Exception)
            {

                MessageBox.Show("Введите значение для вычисления", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = Convert.ToString(Math.Tan((x * Math.PI) / 180));
            }
            catch (Exception)
            {

                MessageBox.Show("Введите значение для вычисления", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            try
            {
                x = Convert.ToDouble(TextBox1.Text);
                TextBox1.Text = Convert.ToString((Math.Cos((x * Math.PI) / 180)) / Math.Sin((x * Math.PI) / 180));
            }
            catch (Exception)
            {

                MessageBox.Show("Введите значение для вычисления", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = TextBox1.Text;
                s = s.Substring(0, s.Length - 1);
                TextBox1.Text = s;
            }
            catch (Exception)
            {

                return;
            }


        }


    }
}
