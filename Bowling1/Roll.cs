using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling1
{
    public class Roll
    {
        private int pins;
        public Roll(int pins)
        {
            this.pins = pins;
        }

        public int pins1
        {
            get { return pins; }
        }
        public bool isStrike => pins == 10;   
    }
}
