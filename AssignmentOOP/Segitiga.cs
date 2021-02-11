using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Segitiga : BangunDatar
    {
        //encapsulation
        private float getAlas;
        private float getTinggi;
        public float alas
        { get; set; }
        public float tinggi
        { get; set; }

        float rumusKeliling(float alas)
        {
            return 3 * getAlas;
        }
        float rumusLuas(float alas, float tinggi)
        {
            return getAlas * getTinggi / 2;
        }
        //Constructor
        //overloading
        public Segitiga (float alas, float tinggi)
        {
            this.getAlas = alas;
            this.getTinggi = tinggi;
        }
        public Segitiga(float alas)
        {
            this.getAlas = alas;

        }
        //overriding
        public override float luas()
        {
            return rumusLuas(alas, tinggi);
        }
        public override float keliling()
        {
            return rumusKeliling(alas);
        }


    }
}
