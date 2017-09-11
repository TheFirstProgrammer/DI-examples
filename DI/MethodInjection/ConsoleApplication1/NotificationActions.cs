using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public interface INotificationAction
    {
        void ActOnNotification(string message);
    }

    internal class AppPoolWatcher
    {
        INotificationAction action = null;

        //Remove the constructor when using a method injection and instead pass the concrete class directly into method
        public void Notify(INotificationAction concreteAction, string message)
        {
            this.action = concreteAction;
            action.ActOnNotification(message);
        }
    }

    internal class EventLogWriter: INotificationAction
    {
        public void ActOnNotification(string message)
        {
            //Send a message to a fake event log
            System.Diagnostics.Debug.WriteLine("Event log " + message);
        }
    }

    internal class EmailSender : INotificationAction
    {
        public void ActOnNotification(string message)
        {
            //Send a fake email message 
            System.Diagnostics.Debug.WriteLine("Email " + message);
        }
    }

    internal class SMSSender: INotificationAction
    {
        public void ActOnNotification(string message)
        {
            //Send a fake SMS message
            System.Diagnostics.Debug.WriteLine("SMS " + message);
        }
    }
}
