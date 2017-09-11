using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Property injection is used less frequently.
        static void Main(string[] args)
        {
            //What if the responsibility of selection of concrete class and invocation of method are in separate places? 
            //In such cases we need property injection!
            //We are going to we pass the object of the concrete class via a setter property that was exposed by the dependent class
            //Note: This approach is useful when the responsibility of selecting the concrete implementation and invoking the action are done in separate places/modules

            //EventLogWriter writer = new EventLogWriter(); //concrete class
            EmailSender writer = new EmailSender(); //concrete class
            //SMSSender writer = new SMSSender(); //concrete class

            AppPoolWatcher watcher = new AppPoolWatcher(); //dependent class
            watcher.Action = writer; //pass the object of the concrete class to the dependent class
            watcher.Notify("sample message");
        }
    }
}
