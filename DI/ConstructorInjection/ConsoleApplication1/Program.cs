using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Constructor injection is the mostly used approach when it comes to implementing the dependency injection. 
        static void Main(string[] args)
        {
            //We are going to we pass the object of the concrete class into the constructor of the dependent class
            //EventLogWriter writer = new EventLogWriter(); //concrete class
            //EmailSender writer = new EmailSender(); //concrete class
            SMSSender writer = new SMSSender(); //concrete class

            AppPoolWatcher watcher = new AppPoolWatcher(writer); //dependent class
            watcher.Notify("sample message");
        }
    }
}
