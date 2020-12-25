using System;
using System.Collections.Generic;
using System.Text;

namespace ООП3
{
    public abstract class CGraphicsObject
    {
       
        public abstract string area();
        public abstract string volume();
        public void Info()
        {
          
            Console.WriteLine($"Площадь: {area()}\n");
            Console.WriteLine($"Обьем: {volume()}\n");
        }
    }
}