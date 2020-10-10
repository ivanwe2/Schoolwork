using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTask_2
{
    public class Screen
    {
        public double Size { get; private set; }
        public string Colors { get; private set; } //not sure

        public Screen()
        {
            this.Size = 0;
            this.Colors = null;
        }

        public Screen(double size, string colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

    }
}
