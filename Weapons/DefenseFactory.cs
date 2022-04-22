using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Assignment.Interfaces;

namespace Advanced_Assignment.Weapons
{ 
    public class DefenseFactory : IWeaponFactory
    {
        public IWeapon CreateWeapon(WeaponType type)
        {
            if (type == WeaponType.Magic) return new PepperSpray(); 
            if (type == WeaponType.Projectile) return new Shield();

            throw new ArgumentException($"No Defense Weapon available yet for type {type}");
        }
    }
}
