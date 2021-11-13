using System;
using System.Collections.Generic;

namespace decoratorpattern
{
    public abstract class Dekorator : Ikahve
    {
        private Ikahve kahve;
        public Dekorator(Ikahve kahve)
        {  
            this.kahve = kahve;
        }
        public virtual void Hesapla()
        {
            kahve.Hesapla();
           
        }
        public virtual void KahveYap()
        {
            kahve.KahveYap();
        }
    }
}