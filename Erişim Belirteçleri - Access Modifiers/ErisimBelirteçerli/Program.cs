using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirteçerli
{
    class Program
    {
        /*
         * Erişim Belirteçleri, metot ve değişkenlere olan erişimin sınırını belirtirler.
         * 
         * 1-Private: Sadece tanımlandığı sınıfın içinden erişilebilirler (Kalıtım ile Aktarılamaz!)
         * 2-Public: Her yerden erişilebilir (Kalıtım ile aktarılır).
         * 3-Internal: Sadece bulunduğu projeden erişilebilirler (Kalıtım ile aktarılır).
         * 4-Protected: Tanımlandığı sınıfta ve o sınıfı miras alan(Kalıtım) sınıflardan 
         * erişilebilir (Kalıtım ile aktarılır).
         * 5-Protected Internal: Tanımlandığı sınıfın içinden ve ondan türetilen sınıfların
         * içinden erişilebilir. Türetilen sınıfın aynı program içerisinde olmaması sorun teşkil
         * etmez.
         * ------------------------------------------------------------------------------------
         * [Dikkat]:Türetilmiş bir sınıfta, temel sınıftaki elemanlardan sadece "public" ve "protected" 
         * olarak tanımlananlar aktarılır. Erişim belirteci "private" olan elemanlar kalıtım ile
         * aktarılamazlar!
         */
        static void Main(string[] args)
        {

        }
    }
}
