namespace KargoKayitBilgi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string takipNo;

        Giris:
            Console.Write("Kargo takip no giriniz: ");
            takipNo = Console.ReadLine();

            if (takipNo.Length > 20)
            {
                Console.WriteLine("Takip no uzunluğu en fazla 20 karakter olabilir.");
                goto Giris; // Eğer uzunluk fazla ise, tekrar giriş yapılması istenir
            }

            Console.Write("Alıcı isim soyisim giriniz: ");
            string alici = Console.ReadLine();

            Console.Write("Gönderici isim soyisim giriniz: ");
            string gonderici = Console.ReadLine();

            Console.Write("Açıklama giriniz: ");
            string aciklama = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Kargo Takip No: " + takipNo);
            Console.WriteLine("Gönderici: " + gonderici);
            Console.WriteLine("Alıcı: " + alici);
            Console.WriteLine("Açıklama: " + aciklama);

            if (aciklama.ToLower().Contains("kırılabilir")) //büyük küçük harf duyarlılığı kaldırıldı
            {
                Console.WriteLine("Kargonuz hassas gönderi olarak kayıt edilmiştir.");
            }
        }
    }
}
