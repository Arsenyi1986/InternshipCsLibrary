using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLibrary
{
    public class Triang : Figure
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Triang(string tName, double s1, double s2, double s3) : base (tName)
        {
            if (s1 < 0 || s2 < 0 || s3 < 0)
            {

                throw new TriEx("Такой треугольник не может существовать, так как одна или несколько сторон меньше 0");

            }else if (s1 > (s2 + s3) || s2 > (s1 + s3) || s3 > (s1 + s2))
            {

                throw new TriEx("Такой треугольник не может существовать, так как одна сторона больше суммы двух других");

            }else{

                Side1 = s1;
                Side2 = s2;
                Side3 = s3;

            }
        }

        public override double Square()
        {
            var p = (Side1 + Side2 + Side3) / 2;
            var square = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            return square;
        }

        public bool isRightTri()
        { 
        
            bool isRight = (Side1 == Math.Sqrt(Math.Pow(Side2, 2) + Math.Pow(Side3, 2)) || Side2 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side3, 2)) || Side3 == Math.Sqrt(Math.Pow(Side1, 2) + Math.Pow(Side2, 2)));

            return isRight;
        }

    }
}
