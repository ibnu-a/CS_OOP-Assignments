using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class Persegi : BangunDatar
    {
        //encapsulation
        private float getSisi;
        public float Sisi
        { get; set; }

        float RumusKeliling (float Sisi)
        {
            return getSisi*getSisi;
        }
        float RumusLuas (float Sisi)
        {
            return 4 * getSisi;
        }
        //Constructor
        public Persegi(float Sisi)
        {
            this.getSisi = Sisi;
        }
        //overriding
        public override float keliling()
        {
            return RumusKeliling(Sisi);
        }
        public override float luas()
        {
            return RumusLuas(Sisi);
        }

      

    }
}
