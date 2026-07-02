using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

internal class Point
{
    private double _x;
    private double _y;

    public Point()
    {
        _x = 0;
        _y = 0;
    }

    public Point(double x, double y)
    {
        _x=x;
        _y=y;
    }

    public Point(Point p)
    {
        _x = p._x;
        _y = p._y;
    }

    public double length(Point A, Point B)
    {
        return Math.Sqrt((B._x-A._x)*(B._x - A._x)
            +(B._y-A._y)*(B._y - A._y));
    }

    //унарные операции
    //++
    public static Point operator ++ (Point p)
    {
        return new Point(++p._x, p._y);
    }

    //--
    public static Point operator -- (Point p)
    {
        return new Point(--p._x, p._y);
    }


    //операции приведения типа
    //int(явная) - целое число x
    public static explicit operator int(Point p)
    {
        return (int)p._x;
    }

    //double(неявная) - вещественный y
    public static implicit operator double(Point p)
    {
        return p._y;
    }

    //бинарные операции
    //+ Point p
    public static double operator +(Point A, Point B)
    {
        return Math.Sqrt((A._x - B._x)*(A._x - B._x) +
            (A._y - B._y)* (A._y - B._y));
    }

    // точка + целое число
    public static Point operator +(Point p, int value)
    {
        return new Point(p._x + value, p._y);
    }

    // целое число + точка 
    public static Point operator +(int value, Point p)
    {
        return new Point(p._x + value, p._y);
    }

    //перегруженный ToString()
    public override string ToString()
    {
        return "x = " + _x + ", y = " + _y;
    }

    //свойства
    public double X
    {
        get 
        {
            return _x; 
        }
        set 
        {
            _x = value; 
        }
    }

    public double Y
    {
        get 
        { 
            return _y; 
        }
        set
        {
            _y = value; 
        }
    }
}

