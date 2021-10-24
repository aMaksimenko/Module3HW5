namespace HomeWork
{
    public class Starter
    {
        public void Run()
        {
            var bob = new Student()
            {
                FirstName = "Bob",
                LastName = "Lebovski",
                IsHomeWorkDone = false,
            };
            var nick = new Student()
            {
                FirstName = "Nick",
                LastName = "Valkovski",
                IsHomeWorkDone = true,
            };
            var betsi = new Student()
            {
                FirstName = "Betsi",
                LastName = "Smith",
                IsHomeWorkDone = true
            };

            bob.Accept(new Visitor<Student>());
            nick.Accept(new Visitor<Student>());
            betsi.Accept(new Visitor<Student>());
        }
    }
}