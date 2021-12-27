using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tur_donusumu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 14;
            byte b = (byte)a;
            Console.WriteLine(b.GetType());
            Console.WriteLine(b);
            Console.ReadLine();
            */

            /*
            //1. yöntem parse
            string a = "2";
            string b = "5";
            int c = int.Parse(a);
            int d = int.Parse(b);
            Console.WriteLine(c+d);
            Console.ReadLine();
            */

            /*
            //2. yöntem convert.toint32
            string a = "10";
            string b = "4";
            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);
            Console.WriteLine(c+d);
            Console.ReadLine();
            */

            /*
            //3. tostring() yöntemi
            int a = 2;
            int b = 5;
            string c = a.ToString();
            string d = b.ToString();
            Console.WriteLine(c + d);
            Console.ReadLine();
            */

            //kullanıcının yasını girmesini isteyip ekrana yazdırıcaz

            Console.WriteLine("Lütfen yaşınızı giriniz:");
            string yas = Console.ReadLine();
            int kullanici_yasi = int.Parse(yas);
            Console.WriteLine(kullanici_yasi);
            Console.ReadLine();




        }
    }
}
