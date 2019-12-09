using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Point
    {

        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public void Reset()
        {
            x = 0;
            y = 0;
        }

        public void IncrX(int p1)
        {
            x += p1;
        }

        public void IncrY(int p2)
        {
            y += p2;
        }

        public double Dist(Point point)
        {
            double z = Math.Sqrt((x - point.x) ^ 2 + (y - point.y) ^ 2);
            return z;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }

        public static bool operator true (Point p)
        {
            return p.x != 0 && p.y != 0;
        }

        public static bool operator false(Point p)
        {
            return p.x == 0 || p.y == 0;
        }

        public static bool operator < (Point p1, Point p2)
        {
            if (p1.x < p1.y && p2.x < p2.y) return true;
            else return false;
        }

        public static bool operator >(Point p1, Point p2)
        {
            if (p1.x > p1.y && p2.x > p2.y) return true;
            else return false;
        }

        public static bool operator >=(Point p1, Point p2)
        {
            if (p1.x >= p1.y && p2.x >= p2.y) return true;
            else return false;
        }

        public static bool operator <=(Point p1, Point p2)
        {
            if (p1.x <= p1.y && p2.x <= p2.y) return true;
            else return false;
        }

        public static Point operator ++ (Point p)
        {
            return new Point(p.x + 1, p.y + 1);
        }

        public static Point operator --(Point p)
        {
            return new Point(p.x - 1, p.y - 1);
        }

        public static implicit operator Point (int x)
        {
            return new Point(x, 0);
        }

        public static explicit operator int (Point p)
        {
            return p.y - p.x;
        }
    }
}
