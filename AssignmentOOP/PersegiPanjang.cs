using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP
{
    class PersegiPanjang : BangunDatar
    {
        //encapsulation
        private float getpanjang;
        private float getLebar;
        public float panjang
        { get; set; }
        public float lebar
        { get; set; }

        float rumusKeliling(float panjang, float lebar)
        {
            return 2 * (getpanjang + getLebar);
        }
        float rumusLuas(float panjang, float lebar)
        {
            return getpanjang * getLebar;
        }
        //Constructor
        public PersegiPanjang(float panjang, float lebar)
        {
            this.getLebar = lebar;
            this.getpanjang = panjang;
        }
        //overriding
        public override float luas()
        {
            return rumusLuas(panjang, lebar);
        }
        public override float keliling()
        {
            return rumusKeliling(panjang, lebar);
        }



    }
}
