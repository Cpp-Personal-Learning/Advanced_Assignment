using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment.Weapons
{
    public class PepperSpray:DefenceItem
    {
        public override string Name
        {
            get { return "Pepper Spray"; }
            set { }
        }

        public override int Damage
        {
            get { return 75; }
        }

        public override string Description
        {
            get { return "Spray and make enemy loose sight"; }
        }

        public override bool Removable
        {
            get { return true; }
        }
        public override bool Lootable
        {
            get { return true; }
        }
    }
}
