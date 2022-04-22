using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment
{
    public abstract class WorldObject
    {
        /// <summary>
        /// General class for an object properties in this game
        /// </summary>
        public abstract string Name { get; set; }
        public virtual bool Lootable { get; set; }
        public virtual bool Removable { get; set; }

        public WorldObject()
        {

        }
    }
}
