using System;
namespace decoratorpattern
{
    public class Sütlü : Dekorator
    {
        public Sütlü(Ikahve kahve) : base(kahve)
        {

        }
        public override void KahveYap()
        {
            base.KahveYap();
            Console.WriteLine("Süt Eklendi  ");
        }
        public override void Hesapla()
        {
            base.Hesapla();
            GenelKahve.toplam+=3;
        }
    }
}