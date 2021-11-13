using System;

namespace intagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var k1 = new kullanici("ceyda");
            var takipci1= new takipciler();
            k1.Attach(takipci1);
            takipci1.name="deniz";

            var takipci2= new takipciler();
            k1.Attach(takipci2);
            takipci2.name="den";

            var takipci3= new takipciler();
            k1.Attach(takipci3);
            takipci3.name="de";
            k1.fotoat();
        
        }
    }
}
