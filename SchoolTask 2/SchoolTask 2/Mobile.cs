using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask_2
{
    public class Mobile
    {

        //Properties
        public string Model { get; private set; }

        public string Manufacturer { get; private set; }

        public decimal Price { get; private set; }

        public string Owner { get; private set; }

        public Battery BatteryCharacteristics { get; private set; }

        public Screen ScreenCharacteristics { get; private set; }

        public static Mobile n = new Mobile("Nokia", 100);

        public List<Call> CallHistory { get; private set; }

        //Constructors
        public Mobile(string model, decimal price)
        {
            this.Model = model;
            this.Manufacturer = "Unknown";
            this.Price = price;
            this.Owner = "Unknown";
            this.BatteryCharacteristics = new Battery();
            this.ScreenCharacteristics = new Screen();
            this.CallHistory = new List<Call>();
        }

        public Mobile(string model,string manufacturer, decimal price) 
            : this(model, price)
        {
           
            this.Manufacturer = null;
        }

        public Mobile(string model, string manufacturer, decimal price, string owner) 
            : this(model,manufacturer,price)
        {

            this.Owner = owner;
        }

        public Mobile(string model, string manufacturer, decimal price, string owner, Battery b, Screen s)
            : this(model, manufacturer, price,owner)
        {

            this.BatteryCharacteristics = b;
            this.ScreenCharacteristics = s;
        }



        //Overall Functionality
        public static string GetMobileInfo(Mobile m)
        {
            Console.WriteLine("Selected Mobile Phone:");
            Console.WriteLine("{0} made by: {1}   owned by: {2}",m.Model,m.Manufacturer,m.Owner);

            Console.WriteLine("Do you want specifications? Y/N");
            string str = Console.ReadLine();

            if (str.ToLower() == "y")
            {
                StringBuilder s = new StringBuilder();
                s.AppendLine("Price :" + m.Price.ToString());

                s.AppendLine("Battery specs:");
                s.AppendLine("-Model: " + m.BatteryCharacteristics.Model);
                s.AppendLine("-Idle time: " + m.BatteryCharacteristics.IdleTime.ToString());
                s.AppendLine("-Hour of talking: " + m.BatteryCharacteristics.HoursOfTalk.ToString());
                s.AppendLine("-Battery type: " + m.BatteryCharacteristics.Type.ToString());

                s.AppendLine("Screen specs:");
                s.AppendLine("-Size: " + m.ScreenCharacteristics.Size.ToString());
                s.AppendLine("-Colors: " + m.ScreenCharacteristics.Colors);

                s.AppendLine("Call History: ");
                for (int i = 0; i < m.CallHistory.Count; i++)
                {
                    s.AppendLine(" *" + m.CallHistory[i].GetCallInfo());
                }
                return s.ToString();
            }
            else return "Have a nice day!";



        }

        //Call history management fuctionality

        public void AddCall(Mobile m,Call c)
        {
            m.CallHistory.Add(c);
        }

        public void DeleteCall(Mobile m, Call c)
        {
            m.CallHistory.Remove(m.CallHistory.FirstOrDefault(x => x.CallDateTime == c.CallDateTime));
        }

        public void EraseHistory(Mobile m)
        {
            m.CallHistory.RemoveAll(x => x.CallLength >= 0);
        }
    }
}
