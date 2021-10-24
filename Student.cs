namespace HomeWork
{
    public class Student
    {
        public bool IsHomeWorkDone { get; set; }
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public void Accept(Visitor<Student> visitor)
        {
            visitor.Visit(this);
        }
    }
}