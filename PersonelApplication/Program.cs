using System;

namespace PersonelApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Uygulamasına Hoşgeldiniz!");
            
            while (true)
            {
                Console.WriteLine("1- Yazılımcı İşlemleri\n2- Yönetici İşlemleri\nq- Çıkış Yap");
                Console.Write("Yapmak istediğiniz işlemi seçiniz: ");

                string secilenIslem = Console.ReadLine();

                if (secilenIslem == "q")
                {
                    Console.WriteLine("Programdan çıkılıyor...");
                    break;
                }
                else if (secilenIslem == "1")
                {
                    Yazilimci yazilimci = new Yazilimci(1, "Enes", "Bayram", "Java, C#, C++");       
                    

                    while (true)
                    {
                        Console.WriteLine("1- Format At\n2- Yazılımcının Bilgilerini Göster\nq- Çıkış Yap");
                        Console.Write("Yazılımcı işlemi seçiniz: ");
                        string yazilimciIslem = Console.ReadLine();

                        if (yazilimciIslem == "q")
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                        else if (yazilimciIslem == "1")
                        {
                            Console.Write("İşletim sistemi giriniz: ");
                            string isletimSistemi = Console.ReadLine();
                            yazilimci.formatAt(isletimSistemi);
                        }
                        else if (yazilimciIslem == "2")
                        {
                            yazilimci.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                    }                   
                }
                else if (secilenIslem == "2")
                {
                    Yonetici yonetici = new Yonetici(2, "Yakup", "Reçber", 12);
                    

                    while (true)
                    {
                        Console.WriteLine("1- Zam Yap\n2- Yöneticinin Bilgilerini Göster\nq- Çıkış Yap");
                        Console.Write("Yönetici işlemi seçiniz: ");
                        string yoneticiIslem = Console.ReadLine();

                        if (yoneticiIslem == "q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor...");
                            break;
                        }
                        else if (yoneticiIslem == "1")
                        {
                            Console.Write("Zam miktarını giriniz: ");
                            int zamMiktarı = Convert.ToInt32(Console.ReadLine());
                            yonetici.zamYap(zamMiktarı);
                        }
                        else if (yoneticiIslem == "2")
                        {
                            yonetici.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen çalışan uygulaması için geçerli bir işlem giriniz!");
                }
            }
            Console.ReadLine();
        }
    }
}
