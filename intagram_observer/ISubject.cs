namespace intagram
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        
        void Detach(IObserver observer);

        void Notify();
    }
}