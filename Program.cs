using System;

namespace login_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı Giriş Ekranına Hoşgeldiniz.");
            string kAdi = "ozan";
            string kSifresi = "123456";

            int hak =0;
            while (hak<3)
            {
            Console.Write("Kullanıcı Adı : ");
            string gAdi = Console.ReadLine();
            Console.Write("Kullanıcı Şifresi : ");
            string gSifresi = Console.ReadLine();
            
                if (kAdi==gAdi && kSifresi==gSifresi)
                {
                    Console.WriteLine("Başarı ile giriş yapıldı..");
                    break;
                }
                else if(kAdi!=gAdi || kSifresi!=gSifresi)
                {
                    Console.WriteLine("Kullanıcı adı yada şifre hatalı!!!");
                    hak +=1;
                    if (hak==3)
                    {
                        Console.WriteLine("Giriş hakkınız dolmuştur!");
                    }
                }
            }
        }
    }
}
