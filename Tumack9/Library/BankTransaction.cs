using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumac
{
    internal class BankTransaction
    {
        readonly DateTime data ;
        readonly decimal sum;
        public BankTransaction(decimal sum)
        {
            this.sum = sum;
            data = DateTime.Now;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" Date:{data} Sum:{sum}");
        }
    }
}
