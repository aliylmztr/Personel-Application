using System;

namespace PersonelApplication
{
    public class Yazilimci : Calisan
    {
        private string diller;
        public Yazilimci(int id, string isim, string soyisim, string diller) : base(id, isim, soyisim)
        {
            this.diller = diller;
        }

        public void formatAt(string isletimSistemi)
        {
            Console.WriteLine(getIsim() + " şu anda " + isletimSistemi + " işletim sistemine format atıyor.");
        }
    }
}
