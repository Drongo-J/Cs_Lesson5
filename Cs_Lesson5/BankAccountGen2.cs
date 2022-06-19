using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Lesson5
{
    public partial class BankAccount
    {
        public BankAccount(string name)
        {
            Console.WriteLine($"Name : {name}");
            ShowAccount();
        }
    }
}
