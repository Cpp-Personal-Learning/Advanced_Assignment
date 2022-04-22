using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment.Interfaces
{
    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(WeaponType type);
    }
}
