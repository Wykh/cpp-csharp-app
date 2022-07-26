using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureClient.Models
{
    public class Rectangle
    {
        [DllImport("DllFigures.dll")]
        private static extern IntPtr CreateRectangleBySides(int a, int b);
        [DllImport("DllFigures.dll")]
        private static extern IntPtr CreateRectangleEmpty();
        [DllImport("DllFigures.dll")]
        private static extern void DeleteRectangle(IntPtr rectangleToDelete);
        [DllImport("DllFigures.dll")]
        private static extern int getARectangleSide(IntPtr rectanglePointer);
        [DllImport("DllFigures.dll")]
        private static extern int getBRectangleSide(IntPtr rectanglePointer);
        [DllImport("DllFigures.dll")]
        private static extern void setARectangleSide(IntPtr rectanglePointer, int a);
        [DllImport("DllFigures.dll")]
        private static extern int setBRectangleSide(IntPtr rectanglePointer, int b);
        [DllImport("DllFigures.dll")]
        private static extern int getRectangleArea(IntPtr rectanglePointer);

        private IntPtr _rectanglePointer;

        public Rectangle(int a, int b)
        {
            _rectanglePointer = CreateRectangleBySides(a, b);
        }

        public Rectangle()
        {
            _rectanglePointer = CreateRectangleEmpty();
        }

        public int aSide
        {
            get
            {
                return getARectangleSide(_rectanglePointer);
            }
            set
            {
                setARectangleSide(_rectanglePointer, value);
            }
        }

        public int bSide
        {
            get
            {
                return getBRectangleSide(_rectanglePointer);
            }
            set
            {
                setBRectangleSide(_rectanglePointer, value);
            }
        }

        public int getArea()
        {
            return getRectangleArea(_rectanglePointer);
        }

        ~Rectangle()
        {
            DeleteRectangle(_rectanglePointer);
        }
    }
}
