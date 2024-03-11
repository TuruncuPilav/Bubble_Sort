using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20]; //Dizi nesnesini oluşturur.
            Random rnd = new Random(); //Random nesnesini oluşturur.

            for (int i = 0; i < numbers.Length; i++) //Dizi nesnesinin uzunluğu kadar döngüye girer.
                numbers[i] = rnd.Next(1, 100); //İndislere rastgele değerler atar.

            Console.Write("Düzensiz Dizi: ");
            foreach (var item in numbers)
                Console.Write(item + " ");
            Console.WriteLine("");

            int control = 1; //Yer değiştirme yapılıp yapılmadığını kontrol eden değişken.
            int temp; //İndislerdeki verileri değiştirirken kullanılan değişken.
            while (control != 0)
            {
                control = 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1]) //Kendisinden sonra gelen sayı ondan küçük olup olmadığını kontorl eden koşul.
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        ++control;
                    }
                }
            }

            Console.Write("Düzenli Dizi:  ");
            foreach (var item in numbers)
                Console.Write(item + " ");

            Console.Read();
        }
    }
}
