using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment.Weapons
{
    public class WaterCurse:AttackItem
    {
        public override string Name
        {
            get { return "Water Curse"; }
            set{}
        }

        public override int Damage
        {
            get { return 75; }
        }

        public override string Description
        {
            get { return "Magic Toxic Water"; }
        }

        public override int Range
        {
            get { return 30; }
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
