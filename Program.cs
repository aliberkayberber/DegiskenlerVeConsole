using System;

namespace DegiskenlerVeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen asagidaki bilgileri giriniz:");
            System.Console.Write("T.C. Kimlik Numarası: ");
            string tcString = Console.ReadLine();
            UInt64 tcInt = 0; // uint32 degeriri tasma yapıyordu uint64 kullandım bu durumdan dolayı
            UInt64.TryParse(tcString , out tcInt);
            System.Console.Write("Adi: ");
            string name = Console.ReadLine();
            System.Console.Write("Soyadi: ");
            string surname = Console.ReadLine();
            System.Console.Write("Telefon Numarasi: ");
            string phoneString = Console.ReadLine();
            UInt64 phoneInt = Convert.ToUInt64(phoneString);
            System.Console.Write("Yas: ");
            string ageString = Console.ReadLine();
            byte ageByte = Convert.ToByte(ageString);
            System.Console.Write("Ilk Aldıgı Urunun Fiyati: ");
            string firstPriceString = Console.ReadLine();
            decimal firstPriceDecimal = Convert.ToDecimal(firstPriceString); // fiyat gibi durumlarda genellikle decimal kullanıldığı için
            System.Console.Write("Ikinci Aldigi Urunun Fiyati: ");
            string secondPriceString = Console.ReadLine();
            decimal secondPriceDecimal = Convert.ToDecimal(secondPriceString);// fiyat gibi durumlarda genellikle decimal kullanıldığı için
            System.Console.WriteLine("----------------------------------------------------");
            System.Console.WriteLine(tcString + " Tc numarali " + name + " " + surname + " isimli kisi icin kayıt olusturulmustur.");
            System.Console.WriteLine($"{phoneString} telefon numarasina bildirim mesaji gönderilmistir.");
            System.Console.WriteLine($"{firstPriceDecimal + secondPriceDecimal} toplam harcama karsiligi kazanilan % 10 patika puan miktari -> {(firstPriceDecimal + secondPriceDecimal) / 10} TL'dir.");

            


            


        }
    }
}
