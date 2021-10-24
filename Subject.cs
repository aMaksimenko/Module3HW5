using System;

namespace HomeWork
{
    public class Subject
    {
        private readonly string _name;
        private readonly Mediator _mediator;

        public Subject(string name, Mediator mediator)
        {
            _name = name;
            _mediator = mediator;
            _mediator.EventHandler += Notify;
        }

        public string Name => _name;

        public void Send(string message)
        {
            _mediator.Send(this, message);
        }

        public void Notify(object sender, string message)
        {
            var subject = sender as Subject;

            if (subject != null && _name != subject.Name)
            {
                Console.WriteLine($"{_name} got from {subject.Name}: {message}");
            }
        }
    }
}