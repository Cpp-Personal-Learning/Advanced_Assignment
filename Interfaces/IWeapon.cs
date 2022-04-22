using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment.Interfaces
{
    public interface IWeapon
    {
        string Description { get; }
        int Damage { get; }
    }
}
