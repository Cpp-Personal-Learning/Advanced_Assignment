// See https://aka.ms/new-console-template for more information

using Advanced_Assignment;
using Advanced_Assignment.Interfaces;
using Advanced_Assignment.Weapons;
using Game_Test;

World world = new World();

Position positionMain = new Position(5, 5);
Creature main = new Creature("Catalina", positionMain);
Game_Test.CreateWeapon.Create();
main.Loot(Game_Test.CreateWeapon.list[1] as WorldObject);


Position positionEnemy = new Position(5, 7);
Creature enemy = new Creature("Paula", positionEnemy);
main.Loot(Game_Test.CreateWeapon.list[2] as WorldObject);

enemy.defenceItems.Add(Game_Test.CreateWeapon.list[3]);

CreateFight.Fight(main, enemy);