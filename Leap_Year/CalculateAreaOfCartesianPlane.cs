using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leap_Year
{
    public sealed class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class CalculateAreaOfCartesianPlane :IOperationsCalculateArea
    {
        public int calculateArea(int[,] arr)
        {
            int sideAD = 0;
            int sideDB = 0;
            int area = 0;
            Point point = new Point();
            int[] xPoints = new int[3];
            int[] yPoints = new int[3];

            //A
            point.X = arr[1, 0];
            point.Y = arr[1, 1];
            xPoints[0] = point.X;
            yPoints[0] = point.Y;

            //D
            point.X = arr[4, 0];
            point.Y = arr[4, 1];
            xPoints[1] = point.X;
            yPoints[1] = point.Y;

            //B
            point.X = arr[2, 0];
            point.Y = arr[2, 1];
            xPoints[2] = point.X;
            yPoints[2] = point.Y;

            for (int x1 = 0; x1 < 2; x1++)
            {
                sideAD = sideAD + Math.Abs(xPoints[x1]);
            }

            for (int y1 = 1; y1 < 3; y1++)
            {
                sideDB = sideDB + Math.Abs(yPoints[y1]);
            }

            return area = sideAD * sideDB;
        } 
    }
}
