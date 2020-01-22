using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    public class Square
    {
        private double sisi; // pendeklarasian untuk variabel

        public void setSide(Double side){
            this.sisi = side; // metod untuk mengambil nilai sisi 
        }
         public Double luas () //fungsi luas 
        {
            return Math.Pow(this.sisi,2); // retrun untuk pengembalian niali 
        }
        public Double keliling ()
        {
            return this.sisi * sisi;
        }
    }
}
