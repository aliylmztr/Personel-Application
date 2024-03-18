using System;

namespace PersonelApplication
{
    public class Yonetici : Calisan
    {
        private int sorumluKisiSayisi;
        public Yonetici(int id, string isim, string soyisim, int sorumluKisiSayisi) : base (id, isim, soyisim)
        {
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void zamYap(int zamMiktarı)
        {
            Console.WriteLine(getIsim() + ", çalışanlara " + zamMiktarı + " TL zam yapıyor.");
        }
    }
}
