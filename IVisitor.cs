namespace HomeWork
{
    public interface IVisitor<T>
    {
        public void Visit(T visitor);
    }
}