using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Box
{
    //поля (длина, ширина, высоат)
    private int _length;
    private int _width;
    private int _height;

    //конструкторы

    public Box()
    {
        _length = 1;
        _width = 1;
        _height = 1;
    }

    public Box (int length, int width, int height)
    {
        _length = length;
        _width = width;
        _height = height;
    }

    //копирования
    public Box (Box b)
    {
        _length = b._length;
        _width = b._width;
        _height = b._height;
    }

    public int Bigger()
    {
        int temp = 0;
        if (_length > _height)
        {
            temp = _length;
            if( temp <  _width )
            {
                temp = _width;
            }
        }
        else
        {
            if(_height >  _width)
            {
                temp = _height;
            }
            else
            {
                temp = _width;
            }
        }
        return temp;
    }

    public override string ToString()
    {
        return "Длина = " + _length 
            + ", Ширина = " + _width
            + ", Высота = " + _height;
    }

    public int Length
    {
        get 
        { 
            return _length; 
        }
        set 
        { 
            _length = value; 
        }
    }
    
    public int Width
    {
        get 
        { 
            return _width; 
        }
        set 
        { 
            _width = value; 
        }
    }

    public int Height
    {
        get 
        { 
            return _height; 
        }
        set
        { 
            _height = value; 
        }
    }
}

