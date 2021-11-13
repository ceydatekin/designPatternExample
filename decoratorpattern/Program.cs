using System;

namespace decoratorpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(@"lütfen şeker seçiminizi yapınız:
                                        1. Şeker istiyorum
                                        2. Şeker istemiyorum");
            bool seker=false;
            int seker_secimi;
            seker_secimi = int.Parse(Console.ReadLine()); 
            switch (seker_secimi)
            {
                case 1:
                seker=true;
                break;
                case 2:
                seker=false;
                break;
                
            }            
            System.Console.WriteLine(@"Lütfen kahvenize eklemek istediklerinizi seçin
                                        1.sade kahve
                                        2.sütlü kahve
                                        3.sade karamelli(+3tl) kahve
                                        4.sütlü karamelli(+8tl) kahve");
            int kahve_secimi;
            kahve_secimi = int.Parse(Console.ReadLine()); 
            switch (kahve_secimi)
            {
                case 1:
                Ikahve kahve1 = new GenelKahve(seker);
                Ikahve sadekahve1= new Sade(kahve1);
                sadekahve1.KahveYap();
                sadekahve1.Hesapla();
                break;
                case 2:
                Ikahve kahve2 = new GenelKahve(seker);
                Ikahve sütlükahve2= new Sütlü(kahve2);
                sütlükahve2.KahveYap();
                sütlükahve2.Hesapla();
                break;
                case 3:
                Ikahve kahve3 = new GenelKahve(seker);
                Ikahve sadekahve3= new Sade(kahve3);
                Ikahve sadeKaramelliKahve3 = new Karamelli(sadekahve3);
                sadeKaramelliKahve3.KahveYap();
                sadeKaramelliKahve3.Hesapla();
                break;
                case 4:
                Ikahve kahve4 = new GenelKahve(seker);
                Ikahve sütlükahve4= new Sütlü(kahve4);
                Ikahve sütlüKaramelliKahve4 = new Karamelli(sütlükahve4);
                sütlüKaramelliKahve4.KahveYap();
                sütlüKaramelliKahve4.Hesapla();
                break;
            }
             System.Console.WriteLine("toplam tutar : {0}",GenelKahve.toplam); 
        }
    }
}
