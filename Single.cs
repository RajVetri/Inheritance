using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Single
    {
       
        protected String parent = Console.ReadLine();
        protected String child = Console.ReadLine();
      

    }
    internal class Child1 : Single
    {
        public void excute()
        {
            Console.WriteLine(" Single ");
            Console.WriteLine(" Your Parents Name");
            Console.WriteLine(parent);
            Console.WriteLine(" Your Child Name");
            Console.WriteLine(child);
        }
    } 

}
