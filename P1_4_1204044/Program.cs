using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1204044
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.Clear();

            Console.WriteLine("MENU PERSEGI PANJANG\n" +
               "1. Hitung Luas\n" +
               "2. Hitung Keliling\n" +
               "3. Hitung Panjang Diagonal\n");

            Console.Write("Menu pilihan: ");

            
            int Pilih = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            if (Pilih == 1)
            {
                int p, l, L;

                Console.WriteLine("LUAS PERSEGI PANJANG\n");
                Console.Write("Masukkan Panjang ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan Lebar ");
                l = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                L = p * l;
                Console.WriteLine("Luas Persegi Panjang = " + L);
            }

            else if (Pilih == 2)
            {
                int p, l, K;

                Console.WriteLine("KELILING PERSEGI PANJANG\n");
                Console.Write("Masukkan Panjang ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan Lebar ");
                l = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("");
                K = 2 * (p + l);
                Console.WriteLine("Keliling Persegi Panjang = " + K);
            }

            else if (Pilih == 3)
            {
                int  p, l, D;

                Console.WriteLine("PANJANG DIAGONAL PERSEGI PANJANG");
                Console.Write("Masukkan Panjang ");
                p = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan Lebar ");
                l = Convert.ToInt32(Console.ReadLine());
       
                Console.WriteLine("");
                D = (p * p) + (l * l);
                Console.WriteLine("Panjang Diagonal Persegi Panjang = " + D);
            }
        }
    }
}
