using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask_2
{
    public class Call
    {
        
        public DateTime CallDateTime { get; private set; }
        public double  CallLength{ get; private set; }

        public Call()
        {
            CallDateTime = default;
            CallLength = 0;
        }
        public Call(DateTime date,double lenght)
        {
            CallDateTime = date;
            CallLength = lenght;
        }

        public string GetCallInfo()
        {
            StringBuilder s = new StringBuilder();
            s.AppendLine("Call date: " + this.CallDateTime.ToString());
            s.AppendLine("Call duration: " + this.CallLength.ToString());
            return s.ToString();
        }
    }
}
