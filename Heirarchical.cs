using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class heirachical
    {
       public void parent()
        {
            Console.WriteLine("Heirarchical");
            Console.WriteLine("Parent");
        }
    }

    internal class son1 : heirachical
    {
        public void child()
        {
            Console.WriteLine("son1");
            parent();
        }

    }

    internal class son2 : heirachical
    {
        public void child2()
        {
            Console.WriteLine("Son2");
            parent();
        }
    }
}

