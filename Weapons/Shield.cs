using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment.Weapons
{
    public class Shield:DefenceItem
    {
        public override string Name
        {
            get { return "Shield"; }
            set { }
        }

        public override int Damage
        {
            get { return 75; }
        }

        public override string Description
        {
            get { return "Great Metal Shield"; }
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
