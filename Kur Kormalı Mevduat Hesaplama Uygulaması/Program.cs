namespace Kur_Kormalı_Mevduat_Hesaplama_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal Anapara, Vade, HesapTipi, AcılısKuru, KapanışKuru;

            Console.WriteLine("Anpara tutarını giriniz.");
            Anapara =Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Acılış kuru tutarını giriniz.");
            AcılısKuru = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Kapanış kuru tutarını giriniz");
            KapanışKuru = Convert.ToDecimal(Console.ReadLine());

            decimal AnaParaVeAcılısKuru = Anapara / AcılısKuru;
            decimal AnaParaVeKapanışKuru = Anapara / KapanışKuru;
            decimal Fark = AnaParaVeAcılısKuru - AnaParaVeKapanışKuru;

            decimal sonuc = Fark * KapanışKuru;

            Console.WriteLine(sonuc);
           
            


        }
    }
}