using System;
namespace ООП3
{
    public class CPoint : CGraphicsObject
    {
        public static int r, R;
        public CPoint(int circleradius1,int radiusToСenter1)
        {
            circleradius = circleradius1;
            radiusToСenter = radiusToСenter1;
        }
       //Радиус круга
        public int circleradius
        {
            get { return r; }
            set { r = value < 0 ? -value : value; }
        }
        //Растояние от центра до оси
        public int radiusToСenter
        {
            get { return R; }
            set { R = value < 0 ? -value : value; }
        }
       
        //Площадь
        public override string area()
        {
            return (4*Math.Pow(Math.PI,2)*R*r).ToString();
        }
        //
        public override string volume()
        {
            return (2 * Math.Pow(Math.PI, 2) * R * Math.Pow(r, 2)).ToString();
        }
        public static void Method()
        {
            Console.WriteLine("Задайте длину радиуса окружности и растояния от центра окружности до оси тора: ");
            r = int.Parse(Console.ReadLine());
            R = int.Parse(Console.ReadLine());
            Console.ReadKey();
        }
    }
}