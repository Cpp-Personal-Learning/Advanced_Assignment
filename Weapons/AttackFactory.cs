using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Assignment.Interfaces;

namespace Advanced_Assignment.Weapons
{
    public class AttackFactory: IWeaponFactory
    {
        public IWeapon CreateWeapon(WeaponType type)
            {
                if (type == WeaponType.Magic) return new WaterCurse();
                if (type == WeaponType.Projectile) return new Javelin();

                throw new ArgumentException($"No Attack Weapon available yet for type {type}");
            }
        }
    }
