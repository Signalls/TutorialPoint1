using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TutorialPoint.Program;

namespace TutorialPoint
{
    public class RectangleShape : Shapes, IShape
    {
        public double CheckArea()
        {
            return Length * Width;
        }
    }
}
