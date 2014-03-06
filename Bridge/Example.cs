using System;

namespace Bridge
{
    public class Example
    {
    }

    public interface IBridgeComponents
    {
        void Send (string dataType);
    }

    public abstract class Client
    {
        public IBridgeComponents Components;
        public abstract void Send ();
    }

    public class EmailClientImpl : Client
    {
        public override void Send ()
        {
            Components.Send ("Email");
        }
    }

    public class SmsClientImpl : Client
    {
        public override void Send ()
        {
            Components.Send ("Sms");
        }
    }

    public class WebService : IBridgeComponents
    {
        public void Send (string dataType)
        {
            Console.WriteLine("Sending "+dataType+" using WebService");
        }
    }

    public class ThirdPatry : IBridgeComponents
    {
        public void Send (string dataType)
        {
            Console.WriteLine("Sending "+dataType+" using 3rd-party library");
        }
    }
}
