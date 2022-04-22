using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        public World()
        {
            Configuration.ReadConfig();

            MaxX = Configuration.MaxWorldSize;
            MaxY = Configuration.MinWorldSize;


            Trace.LogMessage(TraceEventType.Information, $"New World Created! X: {MaxX}, Y: {MaxY}");
        }
    }
}
