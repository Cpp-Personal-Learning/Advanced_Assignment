using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Assignment.Interfaces;

namespace Advanced_Assignment
{
    public abstract class DefenceItem:WorldObject, IWeapon
    {
        /// <summary>
        /// Properties for a defense item.
        /// </summary>
        public abstract int Damage { get; }
        public abstract string Description { get; }

        public override string ToString()
        {
            return $"{Name}, protects against {Damage} damage points. {Description}";
        }
    }
}
