using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp = "isi";
            do
            {

                Console.WriteLine("------BangunDatar Datar------");
                Console.WriteLine("pilihan:");
                Console.WriteLine("1. menghitung keliling persegi");
                Console.WriteLine("2. menghiutng luas persegi");
                Console.WriteLine("3. menghiutng keliling persegi panjang");
                Console.WriteLine("4. menghiutng luas persegi panjang");
                Console.WriteLine("5. menghiutng keliling segitiga");
                Console.WriteLine("6. menghiutng luas segitiga");

                Console.WriteLine("------------------------------");
                Console.WriteLine("masukan pilihan 1 - 6");
                Console.WriteLine("------------------------------");

                try
                {
                    int choose = Convert.ToInt32(Console.ReadLine());


                    switch (choose)
                    {
                        case 1:
                            Console.Write("sisi bangun datar : ");
                            int sisi_k = Convert.ToInt32(Console.ReadLine());
                            Persegi kelilingPersegi = new Persegi(sisi_k);
                            Console.WriteLine("keliling persegi adalah " + kelilingPersegi.keliling());
                            Console.Write("apakah ingin melakukan perhitung lagi? jika iya tekan Y, jika tidak tekan T ");
                            Console.WriteLine();
                            temp = Console.ReadLine();
                            break;

                        case 2:
                            Console.Write("sisi bangun datar : ");
                            int sisi_l = Convert.ToInt32(Console.ReadLine());
                            Persegi LuasPersegi = new Persegi(sisi_l);
                            Console.WriteLine("Luas persegi adalah " + LuasPersegi.luas());
                            Console.Write("apakah ingin melakukan perhitung lagi? jika iya tekan Y, jika tidak tekan T ");
                            Console.WriteLine();
                            temp = Console.ReadLine();
                            break;

                        case 3:
                            Console.Write("panjang bangun datar : ");
                            int panjang_k = Convert.ToInt32(Console.ReadLine());
                            Console.Write("lebar bangun datar : ");
                            int lebar_k = Convert.ToInt32(Console.ReadLine());
                            PersegiPanjang K_persegiPanjang = new PersegiPanjang(panjang_k, lebar_k);
                            Console.WriteLine("keliling persegi panjang adalah " + K_persegiPanjang.keliling());
                            Console.Write("apakah ingin melakukan perhitung lagi? jika iya tekan Y, jika tidak tekan T ");
                            Console.WriteLine();
                            temp = Console.ReadLine();
                            break;

                        case 4:
                            Console.Write("panjang bangun datar : ");
                            int panjang_l = Convert.ToInt32(Console.ReadLine());
                            Console.Write("lebar bangun datar : ");
                            int lebar_l = Convert.ToInt32(Console.ReadLine());
                            PersegiPanjang L_persegiPanjang = new PersegiPanjang(panjang_l, lebar_l);
                            Console.WriteLine("Luas persegi panjang adalah " + L_persegiPanjang.luas());
                            Console.Write("apakah ingin melakukan perhitung lagi? jika iya tekan Y, jika tidak tekan T ");
                            Console.WriteLine();
                            temp = Console.ReadLine();
                            break;

                        case 5:
                            Console.Write("sisi bangun datar : ");
                            int alas_k = Convert.ToInt32(Console.ReadLine());
                            Segitiga K_segitiga = new Segitiga(alas_k);
                            Console.WriteLine("keliling persegi panjang adalah " + K_segitiga.keliling());
                            Console.Write("apakah ingin melakukan perhitung lagi? jika iya tekan Y, jika tidak tekan T ");
                            Console.WriteLine();
                            temp = Console.ReadLine();
                            break;

                        case 6:
                            Console.Write("alas bangun datar : ");
                            int alas_l = Convert.ToInt32(Console.ReadLine());
                            Console.Write("tinggi bangun datar : ");
                            int tinggi_l = Convert.ToInt32(Console.ReadLine());
                            Segitiga L_segitiga = new Segitiga(alas_l, tinggi_l);
                            Console.WriteLine("keliling persegi panjang adalah " + L_segitiga.luas());
                            Console.Write("apakah ingin melakukan perhitung lagi? jika iya tekan Y, jika tidak tekan T ");
                            Console.WriteLine();
                            temp = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("silahkan untuk memilih ulang");

                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("silahkan masukan angga pada menu tekan Y untuk mengulangi");
                    Console.WriteLine();
                    temp = Console.ReadLine();
                }

            }

            while ((temp == "y") || (temp == "Y"));
        }
    }
}
