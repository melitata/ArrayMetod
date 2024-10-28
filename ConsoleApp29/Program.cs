using System;
namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[]args)

        {
            //Sort
            int[] sayilar = { 23, 12, 4, 86, 72, 3, 11, 17 };
            Console.WriteLine("*****Sırasız Dizi*****");
            foreach (var sayi in sayilar)
            
                Console.WriteLine(sayi);

            Console.WriteLine("*****Sıralı Dizi*****");
            Array.Sort(sayilar);    //diziyi küçükten büyüğe sıralar

            foreach (var sayi in sayilar)//diziyi yazdırır

                Console.WriteLine(sayi);

            //clear
            Console.WriteLine("*****Array Clear*****");//2. indexten itibaren 2 elemanı siler
                    
            Array.Clear(sayilar, 2, 2);//2. indexten itibaren 2 elemanı siler
            foreach (var sayi in sayilar)
                Console.WriteLine(sayi);
            //Reverse
            Array.Reverse(sayilar);//diziyi ters çevirir
            Console.WriteLine("*****Array Reverse*****");
            foreach (var sayi in sayilar)
                Console.WriteLine(sayi);
            //IndexOf
       
            Console.WriteLine("*****Array IndexOf*****");
            Console.WriteLine(Array.IndexOf(sayilar, 23));//23 elemanının indexini verir
            //Resize
            Console.WriteLine("*****Array Resize*****");
            Array.Resize<int>(ref sayilar, 9);//diziyi 9 elemanlı yapar
            sayilar[8] = 99;//8. indexe 99 elemanını ekler
            foreach (var sayi in sayilar)
                Console.WriteLine(sayi);
          

        }
    }
}
