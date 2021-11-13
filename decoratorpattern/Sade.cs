using System;
namespace decoratorpattern
{
    public class Sade:Dekorator
    {
         public Sade(Ikahve kahve) : base(kahve)
        {

        }
        public override void KahveYap()
        {
            base.KahveYap();
            Console.WriteLine("Sade yapıldı ");
        }
    }
}