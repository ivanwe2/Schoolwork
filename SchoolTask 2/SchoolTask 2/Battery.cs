using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask_2
{
    public class Battery
    {
        public string Model { get; private set; }
        public int IdleTime { get; private set; }
        public int HoursOfTalk { get; private set; }
        public BatteryType Type { get; private set; }

        public Battery()
        {
            this.Model = null;
            this.IdleTime = 0;
            this.HoursOfTalk = 0;
            this.Type = BatteryType.Null;
        }
        public Battery(string model)
        {
            this.Model = model;
            this.IdleTime = 0;
            this.HoursOfTalk = 0;
            this.Type = BatteryType.Null;
        }

        public Battery(string model, int idletime) : this(model)
        {
            this.IdleTime = idletime;
        }

        public Battery(string model, int idletime, int hoursoftalk)
            : this(model, idletime)
        {
            this.HoursOfTalk = hoursoftalk;
        }

        public Battery(string model, int idletime, int hoursoftalk, string batteryType)
             : this(model, idletime,hoursoftalk)
        {
            try
            {
                Type = (BatteryType)Enum.Parse(typeof(BatteryType), batteryType); 
                //typeof = The typeof is an operator 
                //keyword which is used to get a type at the compile-time. Or in other words, this operator is used to g
                //    et the System.Type object for a type. This operator takes the Type itself as an argu
                //    ment and returns the marked type of the argument.
            }
            catch (Exception)
            {

                throw new ArgumentException("Invalid battery type! : {0}",batteryType);
            }
        }
    }
}
