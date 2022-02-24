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
using WpfApp1;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для kirill lox
    /// </summary>
    /// 
    

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double firstNumber;
        double secondNumber;


        public enum Operations
        {
            Summary,
            Substraction,
            Multiply,
            Divide
        }

        public double sum(double x, double y)
        {
            return (x + y);
        }        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = OperationsHandler.getResult(firstNumber, secondNumber, Operations.Summary);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = OperationsHandler.getResult(firstNumber, secondNumber, Operations.Substraction);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = OperationsHandler.getResult(firstNumber, secondNumber, Operations.Divide);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = OperationsHandler.getResult(firstNumber, secondNumber, Operations.Multiply);
        }

        private void secondNumberLabel_LostFocus(object sender, RoutedEventArgs e)
        {
            secondNumber = double.Parse(secondNumberLabel.Text);
        }

        private void firstNumberLabel_LostFocus(object sender, RoutedEventArgs e)
        {
            firstNumber = double.Parse(firstNumberLabel.Text);
        }

    }
}
