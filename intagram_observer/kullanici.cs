using System.Collections.Generic;
using System;
namespace intagram
{
    public class kullanici : ISubject
    {
        public string kullanici_adi { get; set; }
        public int secim { get; set; }
        public string  etiketlenecekisim { get; set; }
        public int etiket { get; set; } = 0;
         private List<IObserver> _observers = new List<IObserver>();
        
        //constructor'da kullanıcı adi verilen nesnelerimizi ad propertimizle eşleştirdik. 
        public kullanici(string name)
        { 
            System.Console.WriteLine("kullanıcı oluştu");
            this.kullanici_adi= name;

        }
        public void fotoat(){
           System.Console.WriteLine("hikaye mi fotoğrafmı paylaşmak istersiniz:");
           System.Console.WriteLine("hikaye için 1 fotoğarf için 2 ye basınız etiketli foto için 3 e basınız");
           secim = Int16.Parse(Console.ReadLine());
           switch (secim)
           {
               case 1 :  System.Console.WriteLine("hikayede bildirim gitmez");  break;
               case 2 :  System.Console.WriteLine("fotoğraf paylaşılıyor"); Notify(); break;
               case 3 : System.Console.WriteLine("etiketlenecek kişiyi şeçiniz");
                        etiketlenecekisim= Console.ReadLine();
                        for (int i = 0; i < _observers.Count; i++)
                        {
                            if(etiketlenecekisim==(_observers[i] as takipciler).name)
                            {
                                ((takipciler)_observers[i]).etiket = 1;
                                etiketle();
                            }
                        } break;
           }
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
        public void etiketle(){
             Notify();
        }
    }
}