using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_IvanRusev_11e
{
    public static class MobileTest
    {
        public static void BeginTest()
        {
            //begining test
            Console.WriteLine("How many automobiles do you want to insert in the system? x=>1");
            int n = int.Parse(Console.ReadLine());
            if(n >= 1)
            {
                // creating a list for the cars
                List<Mobile> list = new List<Mobile>();
                for (int i = 0; i < n; i++)
                {
                    //initializing cars and owner
                    
                    Console.WriteLine("Mobile number {0}",i+1);      
                    Console.WriteLine("Write mobile model:");
                    string model = Console.ReadLine();

                    Console.WriteLine("Write mobile brand:");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Write mobile year:");
                    int year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Write mobile kilometers:");
                    double kms = double.Parse(Console.ReadLine());

                    Console.WriteLine("Write owner names and phone {firstname, lastname, phoneNumber");
                    List<string> ownerprop = Console.ReadLine().Split(',').ToList();
                    Owner o = new Owner(ownerprop[0], ownerprop[1], ownerprop[2]);

                    Mobile m = new Mobile(model, brand, year, kms, o);
                    list.Add(m);
                    Console.WriteLine("Mobile {0} added!", i + 1);
                }
                //printing info
                for (int i = 0; i < list.Count; i++)
                {
                    Mobile.PrintMobileInfo(list[i]);
                }
            }
            else Console.WriteLine("Have a nice day!");

        }
    }
}
