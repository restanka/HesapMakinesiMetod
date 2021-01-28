using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesiMetod
{
    class Program
    {
        static void Main(string[] args)
        {           
            double s1, s2, sonuc = 0;
            string islem;
            Baslik();
            Console.WriteLine();
            Console.Write("1.sayiyi giriniz : ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();                     
            Console.Write("2.sayiyi giriniz : ");
            s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("İşlemi Giriniz : Toplama: + , Çıkarma: - , Çarpma: * , Bölme: /");
            Console.WriteLine();
            islem = Console.ReadLine();
            Console.WriteLine();
            
            if (islem == "+" || islem == "-" || islem == "*" || islem == "/")
            {
                if (islem == "+")
                    sonuc = toplama(s1, s2);
                else if (islem == "-")
                    sonuc = cıkarma(s1, s2);
                else if (islem == "*")
                    sonuc = carpma(s1, s2);
                else if (islem == "/")
                    sonuc = bolme(s1, s2);
            }           
            else
                Console.WriteLine("Geçerli bir işlem seçiniz...");
                
            Console.WriteLine();
            Console.WriteLine("İşleminizin Sonucu : " + sonuc.ToString());
            Console.ReadLine();




            Console.WriteLine();











            Console.ReadLine();

        }

        private static void Baslik()
        {
            Console.WriteLine("***Hesap Makinası***");
        }

        static double toplama(double s1 , double s2)
        {
            return  s1 + s2;
            
        }

        static double cıkarma(double s1, double s2)
        {
            return s1 - s2;
        }

        static double carpma(double s1, double s2)
        {
            return s1 * s2;
        }

        static double bolme(double s1, double s2)
        {
            return s1 / s2;
        }

    }
}
