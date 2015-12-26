using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactoryPattern
{
    class OperationFactory
    {
        public static Operation CreateOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new AddOperation();
                    break;
                case "-":
                    operation = new SubOperation();
                    break;
                default: break;
            }

            return operation;
        }
    }
}
