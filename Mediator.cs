using System;

namespace HomeWork
{
    public class Mediator
    {
        public event EventHandler<string> EventHandler;

        public void Send(Subject sender, string message)
        {
            EventHandler?.Invoke(sender, message);
        }
    }
}