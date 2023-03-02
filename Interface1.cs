using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPoint
{
    public interface IShape 
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double radius { get; set; }

        public double CheckArea();
        
       
    }

   
}
