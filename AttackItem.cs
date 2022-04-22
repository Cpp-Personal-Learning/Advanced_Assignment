using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Assignment.Interfaces;

namespace Advanced_Assignment
{
    /// <summary>
    /// Properties for an attack item.
    /// </summary>
    public abstract class AttackItem: WorldObject, IWeapon
    {
        public abstract int Damage { get; } 
        public abstract string Description { get; }
        public abstract int Range { get; }

        public override string ToString()
        {
            return $"{Name}, dealt {Damage} damage points, with range {Range}. {Description}";
        }
    }
}
