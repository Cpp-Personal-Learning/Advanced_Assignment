using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advanced_Assignment.Interfaces;

namespace Advanced_Assignment
{
    public class Creature:ICreature
    {
        public string Name { get; set; }
        //public CreatureStateEnum CurrentStateEnum { get; set; }
        //public List<CreatureStateEnum> CreatureStates { get; set; }
        //public WorldObjectsEnum CurrentWorldObject { get; set; }
        //public Dictionary<WorldObjectsEnum, IWorldObjects> creatureStateWithWorldObj { get; }
        public Position Position { get; set; }

        public int HitPoint { get; set; }
        public int MaxHitpoints;

        public List<IWeapon> attackItems = new List<IWeapon>();
        public List<IWeapon> defenceItems = new List<IWeapon>();

        public Creature(string name, Position position)
        {
            Name = name;
            Position = position;
            HitPoint = 100;
        }

        public void Attack(Creature enemy)
        {
            Trace.LogMessage(TraceEventType.Information,"Attacking");
            var attacks = attackItems.Sum(AttackItem => AttackItem.Damage);
            enemy.ReceiveHits(attacks);
        }


        public void Loot(WorldObject worldObject)
        {
            Trace.LogMessage(TraceEventType.Information, "Looting");
            if (worldObject.Removable)
            {
                if (worldObject is AttackItem)
                {
                    attackItems.Add((AttackItem)worldObject);
                }
                else if (worldObject is DefenceItem)
                {
                    defenceItems.Add(worldObject as DefenceItem);
                }
            }
        }

        public void ReceiveHits(int hit)
        {
            Trace.LogMessage(TraceEventType.Information, "Damage Received");
            var defence = defenceItems.Sum(DefenceItem => DefenceItem.Damage);
            if(defence>hit) HitPoint-=hit;
            else HitPoint -= (hit - defence);
        }

        public bool IsDead()
        {
            if (HitPoint is <= 0)
            { Trace.LogMessage(TraceEventType.Information, $"{Name} died."); }
            return HitPoint is <= 0;
        }

        public bool IsWinner()
        {
            if (HitPoint is > 0)
            { Trace.LogMessage(TraceEventType.Information, $"{Name} survived"); }
            return HitPoint > 0;
        }


        public void Heal(int hitpoints)
        {
            this.HitPoint += hitpoints;
            if (this.HitPoint > MaxHitpoints)
                HitPoint = MaxHitpoints;
        }


        //public void Hit(){}
        //public void Loot(){}
        //public void ReceiveHit(){}
    }
}
