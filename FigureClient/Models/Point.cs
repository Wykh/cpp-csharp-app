using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureClient.Models
{
    public class Point
    {
        [DllImport("DllFigures.dll")]
        private static extern IntPtr CreatePointByChords(int a, int b);
        [DllImport("DllFigures.dll")]
        private static extern IntPtr CreatePointEmpty();
        [DllImport("DllFigures.dll")]
        private static extern void DeletePoint(IntPtr pointToDelete);
        [DllImport("DllFigures.dll")]
        private static extern int getX(IntPtr pointPointer);
        [DllImport("DllFigures.dll")]
        private static extern int getY(IntPtr pointPointer);
        [DllImport("DllFigures.dll")]
        private static extern void setX(IntPtr pointPointer, int a);
        [DllImport("DllFigures.dll")]
        private static extern int setY(IntPtr pointPointer, int b);
        [DllImport("DllFigures.dll")]
        private static extern double getDistance(IntPtr pointPointer, IntPtr target);

        private IntPtr _pointPointer;

        public Point()
        {
            _pointPointer = CreatePointEmpty();
        }

        public Point(int a, int b)
        {
            _pointPointer = CreatePointByChords(a, b);
        }

        ~Point()
        {
            DeletePoint(_pointPointer);
        }

        public int x
        {
            get
            {
                return getX(_pointPointer);
            }
            set
            {
                setX(_pointPointer, value);
            }
        }

        public int y
        {
            get
            {
                return getY(_pointPointer);
            }
            set
            {
                setY(_pointPointer, value);
            }
        }

        public IntPtr intPtr
        {
            get
            {
                return _pointPointer;
            }
        }

        public double getDistance(Point p)
        {
            return getDistance(_pointPointer, p.intPtr);
        } 
    }
}
