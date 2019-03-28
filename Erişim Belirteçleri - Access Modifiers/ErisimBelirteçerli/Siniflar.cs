using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirteçerli
{
    class Siniflar
    {
        public class TemelSinif
        {
            protected string degisken_1 = "Temel sınıf içerisinde";
            public string degisken_2 = "Temel sınıf içerisinde";
            private string degisken_3 = "Temel sınıf içerisinde";

        }

        public class TuretilmisSinif : TemelSinif
        {
            public void Metot_1()
            {
                degisken_1 = "Türetilmiş sınıf içerisinde";
            }
            public void Metot_2()
            {
                degisken_2 = "Türetilmiş sınıf içerisinde";
            }
        }
        
    }
    /*
     * Erişim belirteci protected olan elemanların private elemanlardan tek farkı kalıtım yolu ile
     * aktarılabiliyor olmasıdır. Eğer kalıtım söz konusu değilse protected elemanların private
     * elemanlardan bir farkı kalmaz. Erişim belireci protected olan elemanları, sadece kalıtım yolu
     * ile aktarılabilen private elemanlar olarak düşünebiliriz.
     */
}
