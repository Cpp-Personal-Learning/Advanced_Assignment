using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment.Weapons
{
    public class Javelin:AttackItem
    {
        public override string Name
        {
            get { return "Javelin"; }
            set {}
        }

        public override int Damage
        {
            get { return 40; }
        }

        public override string Description
        {
            get { return "Long Throw Javelin"; }
        }

        public override int Range
        {
            get { return 70; }
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
