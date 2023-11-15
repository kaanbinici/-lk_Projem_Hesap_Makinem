namespace İlk_Projem_Hesap_Makinem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc;
            char operatör;

            Console.WriteLine("Hesap Makinesi");
            Console.Write("Birinci sayıyı girin: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlemi seçin (+, -, *, /): ");
            operatör = Convert.ToChar(Console.ReadLine());

            switch (operatör)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case '/':
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                    }
                    else
                    {
                        Console.WriteLine("Hata: Sıfıra bölme hatası!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz operatör girişi!");
                    break;
            }

            Console.ReadLine();
        }
    }
}