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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string current = "";
        string previous = "";
        double temp = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;

        }

        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;
            switch (name)
            {
                case "b0":
                    current += "0";
                    CurrentTextBlock.Text = current;
                    break;


                case "b1":
                    current += "1";
                    CurrentTextBlock.Text = current;
                    break;

                case "b2":
                    current += "2";
                    CurrentTextBlock.Text = current;
                    break;

                case "b3":
                    current += "3";
                    CurrentTextBlock.Text = current;
                    break;

                case "b4":
                    current += "4";
                    CurrentTextBlock.Text = current;
                    break;

                case "b5":
                    current += "5";
                    CurrentTextBlock.Text = current;
                    break;

                case "b6":
                    current += "6";
                    CurrentTextBlock.Text = current;
                    break;

                case "b7":
                    current += "7";
                    CurrentTextBlock.Text = current;
                    break;

                case "b8":
                    current += "8";
                    CurrentTextBlock.Text = current;
                    break;

                case "b9":
                    current += "9";
                    CurrentTextBlock.Text = current;
                    break;

                case "Decimal":
                    if (!current.Contains("."))
                    {
                        current += ".";
                        CurrentTextBlock.Text = current;
                    }

                    break;
            }

        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            if (current != "")
            {
                temp = double.Parse(current);
                previous = temp.ToString();
                PreviousTextBlock.Text = previous + "+";
                current = "";
                operation = "Sum";
            }
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (current != "")
            {
                temp = double.Parse(current);
                previous = temp.ToString();
                PreviousTextBlock.Text = previous + "-";
                current = "";
                operation = "Minus";
            }
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (current != "")
            {
                temp = double.Parse(current);
                previous = temp.ToString();
                PreviousTextBlock.Text = previous + "×";
                current = "";
                operation = "Multiplication";
            }
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            if (current != "")
            {
                temp = double.Parse(current);
                previous = temp.ToString();
                PreviousTextBlock.Text = previous + "÷";
                current = "";
                operation = "Division";
            }
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "Sum":
                    PreviousTextBlock.Text = previous + "+" + current;
                    double ResultPlus = temp + double.Parse(current);
                    current = ResultPlus.ToString();
                    CurrentTextBlock.Text = current;
                    break;
                case "Minus":
                    PreviousTextBlock.Text = previous + "-" + current;
                    double ResultMinus = temp - double.Parse(current);
                    current = ResultMinus.ToString();
                    CurrentTextBlock.Text = current;
                    break;

                case "Multiplication":
                    PreviousTextBlock.Text = previous + "×" + current;
                    double ResultMultiplication = temp * double.Parse(current);
                    current = ResultMultiplication.ToString();
                    CurrentTextBlock.Text = current;
                    break;
                case "Division":
                    PreviousTextBlock.Text = previous + "÷" + current;
                    double ResultDivision = temp / double.Parse(current);
                    current = ResultDivision.ToString();
                    CurrentTextBlock.Text = current;
                    break;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CurrentTextBlock.Text = null;
            PreviousTextBlock.Text = null;
            current = "";
            temp = 0;
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentTextBlock.Text.Length > 0)
            {
                CurrentTextBlock.Text = CurrentTextBlock.Text.Substring(0, CurrentTextBlock.Text.Length - 1);
                current = CurrentTextBlock.Text;
            }
        }

    }
       
}
