using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExercise.Classes
{
    public class Rectangle
    {
        public Rectangle()
        {

        }

        private int height;
        /// <summary>
        /// Gets and sets the width
        /// </summary>
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        private int width;
        /// <summary>
        /// Gets and sets the width
        /// </summary>
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int CalculateArea()
        {
            return width * height;
        }

    }
}
