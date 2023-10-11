using System;

namespace Heloworld
{
     class program
     {
         static void Main(string[] args)
         {
            const float phi = 3.14f; //KODE CONST: digunakan untuk menjadikan variabel dan nilainya menjadi immutable(tidak bisa diubah sama sekai)
            //TIPE DATA NUMBER
            int angka = 10 ; //INT merupakan tipe data bilangan bulat
            double angkadouble = 3.14 ; // DOUBLE dan FLOAT merupakan tipe data bilangan desimal
            float angkafloat = 10.2f ;
            //TIPE DATA BOOL
           bool benar = true; //digunakan untuk mereprentasikan dua nilai yang mungkin benar atau salah
           bool salah = false;
           if (benar == true)
           {
            Console.WriteLine("ini adalah pernyataan benar.");
           }
           else
           {
            Console.WriteLine("ini adalah pernyataan salah.");
           }
           //OPERATOR ARITMATIKA
           var hasil1 = 389*67; //operator aaritmatika berguna untuk menghitung 
           var hasil2 = 87+90;
           var hasil3 = 20 / 7;
           //KODE INCREMENT DAN DCREMENT
           int a = 3;


           Console.WriteLine(a);
           Console.WriteLine(++a);
           Console.WriteLine(a);

            Console.WriteLine(a);
           Console.WriteLine(a++);
           Console.WriteLine(a);

             Console.WriteLine(hasil1);
             Console.WriteLine(hasil2);
             Console.WriteLine(hasil3);
             Console.WriteLine(phi);
             Console.WriteLine("Azriel Sepuh"); //variabel adalah tempat untuk menyimpan data
             Console.WriteLine("Azriel Sepuh");
             Console.WriteLine("Azriel Sepuh");
       }
 }

}
