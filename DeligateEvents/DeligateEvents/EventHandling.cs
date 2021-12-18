using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateEvents
{
    //declare a delegate
    public delegate void EventHandler(string x);
    class EventHandling
    {
        public class Operation
        {
            //define a event based on delegate
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);

                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        private static void CatchEvent1(string s)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            Operation o = new Operation();
            o.Action("Event Calling");
            Console.WriteLine();
            o.xyz += new EventHandler(CatchEvent);
            o.xyz += new EventHandler(CatchEvent1);
            o.Action("Event Called");
        }
    }

}
