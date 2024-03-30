using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BankOperations
    {
        public string Message { get; }
        public float Sum { get; }

        public BankOperations(string message, float sum)
        {
            Message = message;
            Sum = sum;
        }
    }
}