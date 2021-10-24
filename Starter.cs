namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var mediator = new Mediator();
            var bob = new Subject("Bob", mediator);
            var john = new Subject("John", mediator);
            var carl = new Subject("Carl", mediator);
            var nancy = new Subject("Nancy", mediator);

            bob.Send("Hello, guys!");
        }
    }
}