using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //testing static field Nokia
            Console.WriteLine(Mobile.GetMobileInfo(Mobile.n));

            //testing whole class

            MobileTest.Begin();
        }
    }
}
