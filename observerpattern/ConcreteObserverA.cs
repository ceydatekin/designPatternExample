using System;
namespace observerpattern
{
    public class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
             if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Değişim oldu.");
            }
        }
    }
}