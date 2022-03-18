using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanHang
{
    class CPTB2
    {
        public CPTB2(double a, double b, double c)
        {
            //CPTB2 la consstructor, khi di vs new goi no ra
            // contrustor trung name vs class, ko co return value
            // this dai dien cho CPTB2 => truy xuat den a , va dua ve dong 9
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double a { get; set; }
        // bam prop tab 
        public double b { get; set; }
        public double c { get; set; }

        public string GiaiPhuongTrinh()
        {
            double d = Math.Pow(this.b, 2) - 4 * this.a * this.c;
            // neu mac dinh co khai bao abc o tren, thi k can this


            if (d < 0)
            {
                return string.Format("PT Vô Nghiệm");
            }
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return string.Format("X1= {0:f2} ,\n X2={1:f2}", x1, x2);

        }
    }
}
