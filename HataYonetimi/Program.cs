using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan telefon numarasını alıp eğer doğru ormatta girdiyse doğru yalış formatta girdiyse yanlış mesajını bazdıran pogram

            //Not: Try yazıp Tab+Tab 
            //try
            //{
            //    Console.WriteLine("Lütfen telefon numarasını 10 haneli olacak şekilde başında 0 olmadan giriniz");

            //    long gelentelefonno = long.Parse(Console.ReadLine());
            //    Console.WriteLine("Tebikler. Giriş başarılı");
            //}
            //catch (Exception)
            //{
            //    //Hata olduğunda bu scope da çalışır.
            //    Console.WriteLine("Yanlış giriş yaptınız");
            //}

            //try
            //{
            //    Console.WriteLine("Lütfen telefon numarasını 10 haneli olacak şekilde başında 0 olmadan giriniz");

            //    long gelentelefonno = Convert.ToInt64(Console.ReadLine());
            //    Console.WriteLine("Tebikler. Giriş başarılı");
            //}
            //catch (Exception hata)
            //{

            //    //Catch ifadesinin yanında bulunan exception isisna demektir. Uygulamamızın kararlı çalışmasını bozan durumla ilgii istisna detaylarını bize verir.

            //    Console.WriteLine(hata.Message);//Hata Mesajı
            //    Console.WriteLine(hata.Source); //Hatanın kaynağını bize verir
            //    Console.WriteLine(hata.HelpLink); //Yardım Linki
            //    Console.WriteLine(hata.StackTrace); //Hatanın konumu


            //    Console.WriteLine("Yanlış giriş yaptınız");

            //try
            //{
            //    Console.WriteLine("Lütfen telefon numarasını 10 haneli olacak şekilde başında 0 olmadan giriniz");

            //    long gelentelefonno = Convert.ToInt64(Console.ReadLine());
            //    Console.WriteLine("Tebikler. Giriş başarılı");
            //}
            //catch (Exception ex)
            //{
            //    //Catch ifadesinin yanında bulunan exception isisna demektir. Uygulamamızın kararlı çalışmasını bozan durumla ilgii istisna detaylarını bize verir.

            //    Console.WriteLine("Hata!" + ex.Message);//Hata Mesajı
            //}
            //finally
            //{
            //    //Hata olsa da olmasada çalışmasını istediğiniz kodlaın yazıldığı alandır.Try-Catch-Finally üçlüsünde en son çalışan kısımdır

            //    Console.WriteLine("Hata var mı yok mu bilemiyoum. Ama her iki durumda da çalışırım :) ");
            //}



            //Dışarıdan alınan iki sayının birbiine bölümünü yapan herhangi bir hata olması durumunda hata mesajını gösteren pogram
            //Hatalı Format
            //Veri ipinin boyutunu aşması Overflow
            //Sıfıra Bölünme Hatası DivideByZeroExcepion


            try
            {
                Console.Write("Birinci Sayıyı Giriniz: ");
                int sayi1 = int.Parse(Console.ReadLine());
                
                Console.Write("İkinci Sayıyı Giriniz: ");
                int sayi2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Bölme başarılı. Sonuç= "+Convert.ToDouble(sayi1)/Convert.ToDouble(sayi2));

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format hatası"+ex.Message);
            }
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine("Format hatası"+ex.Message);
            //}
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Sıfıra bölünme hatası" + ex.Message);
            }
            //catch (OverflowException)
            catch (OverflowException ex)
            {
                Console.WriteLine("Veri taşma hatası" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hatalı Giriş" + ex.Message);
            }


            Console.ReadLine();
        }
    }
}
