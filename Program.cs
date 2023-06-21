using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multilevel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single
         Child1 code1 = new Child1();
            code1.excute();

         //Multilevel 
        Loan Code = new Loan();
            Code.excute();
            Code.excute1();

            //heirarchical
        son1 s = new son1();
        son2 s1 = new son2();
            s.parent();
            s.child();

            s1.child2();
            s1.parent();
            

            //ParentClass parentClass = new ParentClass();
            //parentClass.Execute();

            Console.ReadLine();
        }
    }
}
