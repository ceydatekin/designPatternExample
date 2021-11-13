using System;

namespace intagram
{
    public class takipciler : IObserver
    {
        public string name { get; set; }
        public int etiket { get; set; }
        public void Update(ISubject subject)
        {
            if(this.etiket==0){
                System.Console.WriteLine("{0} isimli kullanıcının dikkatine {1} isimli kullanıcı yeni bir gönderi paylaştı. ",name,(subject as kullanici).kullanici_adi);
                
            }
            else if(this.etiket==1){
                 System.Console.WriteLine("{0} isimli kullanıcının dikkatine {1} isimli kullanıcı size özel bir gönderi paylaştı. ",name,(subject as kullanici).kullanici_adi);
            }
        }
    }
}