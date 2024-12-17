namespace Rastgele_Bir_Macera_Hikayesi_Oluşturucu_A_Randomly_Generated_Adventure_Story_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MaceraBaslat metodu çağırılıyor
            Program.MaceraBaslat();
        }
        // Macera başlatma metodu
        static void MaceraBaslat()
        {
            Console.WriteLine("=== Rastgele Macera Hikayesi ===");
            Console.Write("Karakterinizin adını girin: ");
            string isim = Console.ReadLine();

            Console.Write("Karakterinizin yaşını girin: ");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("Bir meslek seçin (örnek: Savaşçı, Büyücü, Avcı): ");
            string meslek = Console.ReadLine();

            Console.WriteLine("\nHikaye başlıyor...");

            RastgeleMaceraBaslat(isim, yas, meslek);
        }

        static void RastgeleMaceraBaslat(string isim, int yas, string meslek)
        {
            string[] mekanlar = { "karanlık bir ormanda", "terkedilmiş bir kalede", "esrarengiz bir mağarada", "büyülü bir şehirde" };
            string[] olaylar = {
                "dev bir ejderha ile karşılaştı",
                "bir grup haydut tarafından pusuya düşürüldü",
                "esrarengiz bir büyücüden gizemli bir teklif aldı",
                "yeraltından gelen garip bir ses duydu"
            };
            string[] sonuçlar = {
                "büyük bir hazine buldu",
                "tehlikeden kıl payı kurtuldu",
                "efsanevi bir yaratıkla dost oldu",
                "kendi yeteneklerinin sınırını keşfetti"
            };

            Random rastgele = new Random();

            string mekan = mekanlar[rastgele.Next(mekanlar.Length)];
            string olay = olaylar[rastgele.Next(olaylar.Length)];
            string sonuc = sonuçlar[rastgele.Next(sonuçlar.Length)];

            Console.WriteLine($"\nBir gün, {isim} adında {yas} yaşında bir {meslek}, {mekan} dolaşırken {olay}. Sonunda, {sonuc}!");
            Console.WriteLine("\nHikayen burada sona eriyor. Yeni bir macera oluşturmak ister misiniz? (Evet/Hayır)");

            string cevap = Console.ReadLine()?.ToLower();
            if (cevap == "evet")
            {
                Console.Clear();
                MaceraBaslat(); // Tekrar aynı metodun çağrılması
            }
            else
            {
                Console.WriteLine("Macera sona erdi. Hoşça kal!");
            }
        }
    }      } 
