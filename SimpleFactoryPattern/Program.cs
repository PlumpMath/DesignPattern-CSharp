using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = OperationFactory.CreateOperation("-");
            operation.NumberA = 1;
            operation.NumberB = 2;

            var result = operation.Calculate();
            System.Console.WriteLine(result);
            System.Console.ReadKey();
        }
    }
}
