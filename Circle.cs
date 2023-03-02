using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TutorialPoint.Program;

namespace TutorialPoint
{
    public class Circle : Shapes, IShape
    {
        public double CheckArea()
        {
            return 3.14159 * (radius * radius);
        }
    }
}
