using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Assignment;
using Advanced_Assignment.Interfaces;
using Advanced_Assignment.Weapons;
using Trace = Advanced_Assignment.Trace;

namespace Game_Test
{
    public static class CreateWeapon
    {
        static IWeaponFactory attackFactory=new AttackFactory();
        private static IWeaponFactory defenseFactory = new DefenseFactory();
        public static List<IWeapon> list=new List<IWeapon>();

        public static void Create()
        {
            IWeapon javelin = attackFactory.CreateWeapon(WeaponType.Projectile);
            Console.WriteLine("Javelin created");
            list.Add(javelin);

            IWeapon magicWater = attackFactory.CreateWeapon(WeaponType.Magic);
            Console.WriteLine("Cursed Water created");
            list.Add(magicWater);

            IWeapon shield = defenseFactory.CreateWeapon(WeaponType.Projectile);
            Console.WriteLine("Shield created");
            list.Add(shield);

            IWeapon pepperSpray = defenseFactory.CreateWeapon(WeaponType.Magic);
            Console.WriteLine("Pepper Spray created");
            list.Add(pepperSpray);

        }


    }
}
