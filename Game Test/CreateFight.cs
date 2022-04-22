using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Assignment;

namespace Game_Test
{
    public class CreateFight
    {
        public static void Fight(Creature c1, Creature c2)
            {
                while (c1.IsDead() != true && c2.IsDead() != true)
                {
                    c1.Attack(c2);
                    Console.WriteLine($"{c1.Name} hit {c2.Name}");
                    Console.WriteLine("-------------------------------------------");
                    if (c2.IsDead() != true)
                    {
                        c2.Attack(c1);
                        Console.WriteLine($"{c2.Name} hit {c1.Name}");
                        Console.WriteLine("----------------------------------------");
                    }
                    else
                    {
                        break;
                    }
                }
            }
    }
}
