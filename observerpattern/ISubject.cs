namespace observerpattern
{
    public interface ISubject
    {
        void Notify();
        void Add(IObserver observer);
        void Remove(IObserver observer);
    }
}