using System;

namespace HomeWork
{
    public class Visitor<T> : IVisitor<T>
        where T : Student
    {
        public void Visit(T student)
        {
            if (student.IsHomeWorkDone)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} has work done");
            }
            else
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} failed");
            }
        }
    }
}