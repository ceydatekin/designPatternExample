using System;

namespace observerpattern
{
    class Program
    {
        static void Main(string[] args)
        {
           var subject = new Subject();
           var observerA = new ConcreteObserverA();
            subject.Add(observerA);

            var observerB = new ConcreteObserverB();
            subject.Add(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Remove(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
