using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel

{
    internal class Multilevel
    {

        protected String heading = "Multilevel";
        protected String name = Console.ReadLine();
        protected String account = Console.ReadLine();

    }
    internal class Account : Multilevel
    {
        
        public void excute()
        {

            Console.ReadLine();
            Console.WriteLine(heading);
            Console.WriteLine("your Account Details");
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("Your Account No: "+ account);
            Console.ReadLine();

        }
    }
    internal class Loan : Account
    {
        protected int amount = 94668;
        public void excute1()
        {
            Console.WriteLine("your Load Details");
            Console.WriteLine("Your Name is: " + name);
            Console.WriteLine("Loan Amount: " + amount);
            Console.ReadLine();
        }
    }
}
