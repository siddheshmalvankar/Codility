using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBed
{
      public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Print Method from class A");
        }
    }

    public class B:A
    {
        public new void Print()
        {
            Console.WriteLine("Print Mthod from class B");
        }
    }

    public class C : B
    {
        public new void Print() //Override Keyowrd not accepted
        {
                       Console.WriteLine("Print Method from class C");
        }
    }
}
