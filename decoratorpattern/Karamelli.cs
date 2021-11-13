using System;
namespace decoratorpattern
{
    public class Karamelli:Dekorator
    {
        public Karamelli(Ikahve kahve) : base(kahve)
        {

        }
        public override void KahveYap()
        {
            base.KahveYap();
            Console.WriteLine("Karamel Eklendi  ");
            
        }
        public override void Hesapla()
        {
            base.Hesapla();
            GenelKahve.toplam+=8;
            
        }
    }
}