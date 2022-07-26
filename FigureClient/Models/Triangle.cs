using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureClient.Models
{
    public class Triangle
    {
        [DllImport("DllFigures.dll")]
        private static extern IntPtr CreateTriangleBySides(double a, double b, double c);
        [DllImport("DllFigures.dll")]
        private static extern IntPtr CreateTriangleByPoints(IntPtr p1, IntPtr p2, IntPtr p3);
        [DllImport("DllFigures.dll")]
        private static extern IntPtr CreateTriangleEmpty();
        [DllImport("DllFigures.dll")]
        private static extern void DeleteTriangle(IntPtr triangleToDelete);
        [DllImport("DllFigures.dll")]
        private static extern double getATriangleSide(IntPtr trianglePointer);
        [DllImport("DllFigures.dll")]
        private static extern double getBTriangleSide(IntPtr trianglePointer);
        [DllImport("DllFigures.dll")]
        private static extern double getCTriangleSide(IntPtr trianglePointer);
        [DllImport("DllFigures.dll")]
        private static extern void setATriangleSide(IntPtr trianglePointer, double a);
        [DllImport("DllFigures.dll")]
        private static extern int setBTriangleSide(IntPtr trianglePointer, double b);
        [DllImport("DllFigures.dll")]
        private static extern int setCTriangleSide(IntPtr trianglePointer, double c);
        [DllImport("DllFigures.dll")]
        private static extern void setATriangleSideViaPoints(IntPtr trianglePointer, IntPtr p1, IntPtr p2);
        [DllImport("DllFigures.dll")]
        private static extern int setBTriangleSideViaPoints(IntPtr trianglePointer, IntPtr p1, IntPtr p2);
        [DllImport("DllFigures.dll")]
        private static extern int setCTriangleSideViaPoints(IntPtr trianglePointer, IntPtr p1, IntPtr p2);
        [DllImport("DllFigures.dll")]
        private static extern double getTriangleArea(IntPtr trianglePointer);

        private IntPtr _trianglePointer;

        public Triangle()
        {
            _trianglePointer = CreateTriangleEmpty();
        }

        public Triangle(double a, double b, double c)
        {
            _trianglePointer = CreateTriangleBySides(a, b, c);
        }

        public Triangle(Point p1, Point p2, Point p3)
        {
            _trianglePointer = CreateTriangleByPoints(p1.intPtr, p2.intPtr, p3.intPtr);
        }

        ~Triangle()
        {
            DeleteTriangle(_trianglePointer);
        }

        public double aSide
        {
            get
            {
                return getATriangleSide(_trianglePointer);
            }
            set
            {
                setATriangleSide(_trianglePointer, value);
            }
        }

        public double bSide
        {
            get
            {
                return getBTriangleSide(_trianglePointer);
            }
            set
            {
                setBTriangleSide(_trianglePointer, value);
            }
        }

        public double cSide
        {
            get
            {
                return getCTriangleSide(_trianglePointer);
            }
            set
            {
                setCTriangleSide(_trianglePointer, value);
            }
        }

        public double getArea()
        {
            return getTriangleArea(_trianglePointer);
        }
    }
}
