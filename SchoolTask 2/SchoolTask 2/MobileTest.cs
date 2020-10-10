using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask_2
{
    public static class MobileTest
    {
         public static void Begin()
        {
            Battery b = new Battery("victoria secret", 10, 7, "LiIon");
            Screen s = new Screen(6, "1000000");
            Mobile m = new Mobile("MI A2 Lite", "Xiaomi", 1000, "Ivan",b,s);

            DateTime d = DateTime.UtcNow;
            Call c = new Call(d,44);
            m.AddCall(m,c); 

            Console.WriteLine(Mobile.GetMobileInfo(m));
        }

    }
}
