using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Lesson5
{
    public partial class BankAccount
    {
        public BankAccount()
        {
            Console.WriteLine("Default constructor");
        }

        public void Start()
        {
            ShowAccount();
            UpdateAccount();
        }

        partial void ShowAccount()
        {
            Console.WriteLine("Kapital Bank Hesab 1000AZN");
        }
        partial void UpdateAccount()
        {
            Console.WriteLine("Update Account");
        }

    }
}
