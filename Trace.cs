using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assignment
{
    /// <summary>
    /// The class is used to log events to a text file
    /// </summary>
    public static class Trace
    {
        public static TraceSource traceSource= new TraceSource("Application");

        static Trace()
        {
            traceSource.Switch = new SourceSwitch("App Log","All");
            
            TraceListener fileLog = new TextWriterTraceListener(new StreamWriter("LogFile.txt"));
            
            traceSource.Listeners.Add(fileLog);
        }
        public static void LogMessage(TraceEventType traceEventType, string message)
        {
            traceSource.TraceEvent(traceEventType, 555, message);

            traceSource.Flush();
        }
    }
}
