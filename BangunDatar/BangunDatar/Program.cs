using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            menu:
            Console.WriteLine("===== Choose Your Choise  =====");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Trapesium");
            Console.WriteLine("5. Diamond");
            Console.WriteLine("Enter the Number of Your Choice : ");

            int pilihan = Convert.ToInt16(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("input square side :");
                    var nilai = new Square(); //penyimpanan niali  dari class
                    nilai.setSide(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("this square are is :" + nilai.luas()); //pendeklarasian memanggil class

                    Console.WriteLine("keliling" + nilai.keliling()); //pendeklarasian memanggil class
                    //int sisi1;
                    //int sisi2;
                    //int l;
                    //int k;

                    //Console.WriteLine("Input Side 1 : ");
                    //sisi1 = Convert.ToInt16(Console.ReadLine());
                    //Console.WriteLine("Input Side 2 : ");
                    //sisi2 = Convert.ToInt16(Console.ReadLine());

                    //l =(sisi1 * sisi2);
                    //Console.WriteLine("Area of Square is : "+ l);

                    //k =(4 * sisi1);
                    //Console.WriteLine("the Circumference of the Rectangle is : "+ k);





                    break;

                case 2:
                    int panjang;
                    int lebar;
                    int tinggi;
                    int luas;
                    int keliling;

                    Console.WriteLine("Input long : ");
                    panjang = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input Wide : ");
                    lebar = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input high : ");
                    tinggi = Convert.ToInt16(Console.ReadLine());

                    luas =(panjang * lebar * tinggi);
                    Console.WriteLine("Area of ​​Rectangle is : "+ luas);

                    keliling =(2 * (panjang + lebar));
                    Console.WriteLine("the Circumference of the Rectangle is : "+ keliling);
                break;

                case 3:
                    int alas;
                    int tingg;
                    int sis1;
                    int luas1;
                    int keliling1;

                    Console.WriteLine("Input the Base : ");
                    alas = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input the High : ");
                    tingg = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input the Side : ");
                    sis1 = Convert.ToInt16(Console.ReadLine());

                    luas1 =((alas * tingg)/2);
                    Console.WriteLine("Area of Triangle is : "+ luas1);

                    keliling1 =(alas * tingg * sis1);
                    Console.WriteLine("the Circumference of the Triangle is : "+ keliling1);
                break;

                case 4:
                    int ab;
                    int bc;
                    int cd;
                    int da;
                    int luas2;
                    int keliling2;

                    Console.WriteLine("Input length AB : ");
                    ab = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input length BC : ");
                    bc = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input length CD : ");
                    cd = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input length DA : ");
                    da = Convert.ToInt16(Console.ReadLine());

                    luas2 =(ab + bc + cd + da);
                    Console.WriteLine("Area of Trapesium is : "+ luas2);

                    keliling2 =((cd * bc) / 2);
                    Console.WriteLine("the Circumference of the Trapesium is : "+ keliling2);
                break;

                case 5:
                    int sis;
                    int d1;
                    int d2;
                    int kel;
                    int lu;

                    Console.WriteLine("Input the Side : ");
                    sis = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input D1 : ");
                    d1 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Input D2 : ");
                    d2 = Convert.ToInt16(Console.ReadLine());

                    lu =(sis * 4);
                    Console.WriteLine("Area of Diamond is : "+ lu);

                    kel =((d1 * d2) / 2);
                    Console.WriteLine("the Circumference of the Trapesium is : "+ kel);
                    break;

                default:
                    Console.WriteLine("The menu you entered is incorrect");
                    goto menu;
                    break;
            }
        }
    }
}
