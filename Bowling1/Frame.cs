using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Bowling1
{
    public class Frame
    {
        public  Roll[] rolls = new Roll[2];

        public  Frame()
        {
            rolls[0] = new Roll(0);
            rolls[1] = new Roll(0);
        }


        internal int num = 0;

        public virtual void addThrow(int pins)
        {
            rolls[num] = new Roll(pins);
            num++;
        }

        internal int criticalMass = 2;
        public virtual bool isClosed => (num >= criticalMass || rolls[0].isStrike);

        public int score
        {
            get
            {
                if (rolls[0].isStrike) { return rolls[0].pins1; }
                else { return rolls[0].pins1 + rolls[1].pins1; }
            }
        }
        
        public bool isSpare => rolls[0].pins1 + rolls[1].pins1 == 10;

    }
    public class LastFrame : Frame
    {


        


        public override void addThrow(int pins)
        {
            //if (rolls[0].isStrike || isSpare) { criticalMass = 3; }
            
            
            rolls[num] = new Roll(pins);
            num++;
        }
        public override bool isClosed => (num >= criticalMass);


    }

}
