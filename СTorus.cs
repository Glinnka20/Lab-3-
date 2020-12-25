using System;
using System.Collections.Generic;
using System.Text;

namespace ООП3
{
    public class CTorus : CPoint
    {
        public CTorus( int circleradius1, int radiusToСenter1) : base(circleradius1, radiusToСenter1)
        {
            throw new System.NotImplementedException();
        }

        ~CTorus()
        {
            throw new System.NotImplementedException();
        }

        public static void task()
        {
            CPoint.Method();
            CGraphicsObject figure = new CPoint( CPoint.r, CPoint.R);
            figure.Info();
        }
    }
}