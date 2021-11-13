namespace decoratorpattern
{
    public class GenelKahve : Ikahve
    {
        public static int toplam { get; set; }=0;
        private bool Seker ;
        public GenelKahve(bool seker)
        {
            this.Seker=seker;
        }
        public void Hesapla()
        {
            toplam=10;
           
        }
        public void KahveYap()
        {
            if (Seker)
            {
                System.Console.WriteLine("Kahvenize şeker ekledik...");
            }
            else
            {
                System.Console.WriteLine("Kahvenize şeker eklemedik...");
            }
        }
    }
}