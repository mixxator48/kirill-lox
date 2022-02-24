using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public static class OperationsHandler
    {
        public static double getResult(double first, double second, MainWindow.Operations op)
        {
            double result;
            switch (op)
            {
                case MainWindow.Operations.Summary:
                    result = first + second;
                    break;
                case MainWindow.Operations.Substraction:
                    result = first - second;
                    break;
                case MainWindow.Operations.Multiply:
                    result = first * second;
                    break;
                case MainWindow.Operations.Divide:
                    result = first / second;
                    break;
                default:
                    Console.WriteLine("Incorrect operation type!");
                    return -1;
                    break;
            }
            return result;
        }

    }
}
