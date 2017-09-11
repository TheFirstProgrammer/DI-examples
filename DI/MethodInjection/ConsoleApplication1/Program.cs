using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //If we need to pass different dependencies on every method call then we use method injection.
        static void Main(string[] args)
        {
            //We are going to we pass the object of the concrete class into the method the dependent class which is actually invoking the action

            //EventLogWriter writer = new EventLogWriter(); //writer is object of concrete class
            //EmailSender writer = new EmailSender(); //writer is object of concrete class
            SMSSender writer = new SMSSender(); //writer is object of concrete class

            AppPoolWatcher watcher = new AppPoolWatcher(); //dependent class
            watcher.Notify(writer,"sample message"); //Basically use the Notify method that belonds to the passed object
        }
    }
}
