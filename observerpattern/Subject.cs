using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading;

namespace observerpattern
{
    public class Subject : ISubject
    {
        public int State { get; set; } = -0;
        public string name { get; set; }
        //Listede bize bağlı değişen durumdan bilgilendirilecek olan üyeler bulunur.
        private List<IObserver> _observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            //Üyelere yeni üye eklemek
            this._observers.Add(observer);
        }

        public void Notify()
        {
            // item=üyeler üyelere yeni geilşne durum güncellemsi yapıldı
            foreach (IObserver item in _observers)
            {
                item.Update(this);
            }
        }

        public void Remove(IObserver observer)
        {
             //Üyelerden üye çıkartmak
            this._observers.Remove(observer);
        }
         public void SomeBusinessLogic()
        {
            this.State = new Random().Next(0, 10);

            Thread.Sleep(1500);

            Console.WriteLine("Subject: Durumum yeni dğeişti: " + this.State);
            this.Notify();
        }
    }
}