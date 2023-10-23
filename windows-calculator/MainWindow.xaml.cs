using System;
using System.Windows;
using System.Windows.Controls;

namespace windows_calculator
{
    public partial class MainWindow : Window
    {
        private bool buttonClicked = false;
        private bool dot_clicked = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button? btn = sender as Button;

            if (!buttonClicked)
                num1.Content += btn!.Content.ToString();
            else if (buttonClicked)
            {
                num2.Content += btn!.Content.ToString();
            }
        }

        private void equal(object sender, RoutedEventArgs e)
        {
            if (num1.Content != null && num2.Content != null)
            {
                if (operation.Content == "+")
                {
                    result.Content = Convert.ToString(Convert.ToDouble(num1.Content) + Convert.ToDouble(num2.Content));
                    operation.Content = "";
                    num2.Content = "";
                    num1.Content = result.Content;
                }
                else if (operation.Content == "-")
                {
                    result.Content = Convert.ToString(Convert.ToDouble(num1.Content) - Convert.ToDouble(num2.Content));
                    operation.Content = "";
                    num2.Content = "";
                    num1.Content = result.Content;
                }
                else if (operation.Content == "x")
                {
                    result.Content = Convert.ToString(Convert.ToDouble(num1.Content) * (Convert.ToDouble(num2.Content)));
                    operation.Content = "";
                    num2.Content = "";
                    num1.Content = result.Content;
                }
                else if (operation.Content == "÷")
                {
                    result.Content = Convert.ToString(Convert.ToDouble(num1.Content) / Convert.ToDouble(num2.Content));
                    operation.Content = "";
                    num2.Content = "";
                    num1.Content = result.Content;
                }
            }
        }

        private void plus(object sender, RoutedEventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Content != "")
            {
                operation.Content = "+";
                num1.Content = result.Content;
                num2.Content = "";
                result.Content = "";
            }

            else if (result.Content == "")
            {
                if (operation.Content == "")
                {
                    operation.Content = "+";
                }
                else if (num2.Content == "")
                {
                    operation.Content = "+";
                }
                else if (operation.Content == "+")
                {
                    if (num1.Content != null && num2.Content != null)
                    {

                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) + Convert.ToDouble(num2.Content));
                        operation.Content = "+";
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "-")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "+";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) - Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "x")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "+";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) * Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "÷")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "+";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) / Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }
            }
        }

        private void cixma(object sender, RoutedEventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Content != "")
            {
                operation.Content = "-";
                num1.Content = result.Content;
                num2.Content = "";
                result.Content = "";
            }

            else if (result.Content == "")
            {
                if (operation.Content == "")
                {
                    operation.Content = "-";
                }
                else if (num2.Content == "")
                {
                    operation.Content = "-";
                }
                else if (operation.Content == "+")
                {
                    if (num1.Content != null && num2.Content != null)
                    {

                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) + Convert.ToDouble(num2.Content));
                        operation.Content = "-";
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "-")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "-";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) - Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "x")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "-";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) * Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "÷")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "-";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) / Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }
            }
        }

        private void vurma(object sender, RoutedEventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Content != "")
            {
                operation.Content = "x";
                num1.Content = result.Content;
                num2.Content = "";
                result.Content = "";
            }

            else if (result.Content == "")
            {
                if (operation.Content == "")
                {
                    operation.Content = "x";
                }
                else if (num2.Content == "")
                {
                    operation.Content = "x";
                }
                else if (operation.Content == "+")
                {
                    if (num1.Content != null && num2.Content != null)
                    {

                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) + Convert.ToDouble(num2.Content));
                        operation.Content = "x";
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "-")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "x";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) - Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "x")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "x";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) * Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "÷")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "x";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) / Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }
            }
        }

        private void bolme(object sender, RoutedEventArgs e)
        {
            dot_clicked = false;
            buttonClicked = true;
            if (result.Content != "")
            {
                operation.Content = "÷";
                num1.Content = result.Content;
                num2.Content = "";
                result.Content = "";
            }

            else if (result.Content == "")
            {
                if (operation.Content == "")
                {
                    operation.Content = "÷";
                }
                else if (num2.Content == "")
                {
                    operation.Content = "÷";
                }
                else if (operation.Content == "+")
                {
                    if (num1.Content != null && num2.Content != null)
                    {

                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) + Convert.ToDouble(num2.Content));
                        operation.Content = "÷";
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "-")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "÷";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) - Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "x")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "÷";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) * Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }

                else if (operation.Content == "÷")
                {
                    if (num1.Content != null && num2.Content != null)
                    {
                        operation.Content = "÷";
                        num1.Content = Convert.ToString(Convert.ToDouble(num1.Content) / Convert.ToDouble(num2.Content));
                        num2.Content = "";
                    }
                }
            }
        }

        private void dot_click(object sender, RoutedEventArgs e)
        {
            if (!buttonClicked && !dot_clicked)
                num1.Content += ".";
            else if (buttonClicked && !dot_clicked)
            {
                num2.Content += ".";
            }
            dot_clicked = true;
        }

        private void faiz_click(object sender, RoutedEventArgs e)
        {

        }

        private void ce_click(object sender, RoutedEventArgs e)
        {
            num1.Content = "";
            num2.Content = "";
            operation.Content = "";
            result.Content = "";
            dot_clicked = false;
            buttonClicked = false;
        }

        private void c_click(object sender, RoutedEventArgs e)
        {
            num1.Content = "";
            num2.Content = "";
            operation.Content = "";
            result.Content = "";
            dot_clicked = false;
            buttonClicked = false;
        }

        private void backspace(object sender, RoutedEventArgs e)
        {

        }

        private void click(object sender, RoutedEventArgs e)
        {

        }

        private void kvadrat_click(object sender, RoutedEventArgs e)
        {
            result.Content = Convert.ToString(Math.Pow(Convert.ToDouble(num1.Content),2));
        }

        private void kokalti(object sender, RoutedEventArgs e)
        {
            result.Content = Convert.ToString(Math.Sqrt(Convert.ToDouble(num1.Content)));
        }

        private void menfi_Click(object sender, RoutedEventArgs e)
        {

        }
    }


}
