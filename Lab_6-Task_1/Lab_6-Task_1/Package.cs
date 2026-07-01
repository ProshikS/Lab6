using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Package : Box
{
    private int _weight; //вес посылки
    private string _frigale; //хрупкое или не хрупкое

    //конструкторы
    public Package() : base()
    {
        _weight = 1;
        _frigale = "Нет";
    }

    public Package(int length, int width, int height,
        int weight, string frigale): base(length, width, height)
    {
        _weight = weight;
        _frigale = frigale;
    }

    public Package (Package pack ) : base(pack)
    {
        _weight = pack._weight;
        _frigale = pack._frigale;
    }

    //методы
    //упаковка посылки
    public string Packing()
    {
        string answer = "";
        if (_frigale == "Да")
        {
            answer = "Требуется противоударная упаковка.";
        }
        else
        {
            answer = "Специальных требований к упаковке нет.";
        }
        return answer;
    }

    //транспортировка посылки
    public string Transportation()
    {
        string answer = "";
        if ((Length > 5) && (Width > 5) && (Height > 5))
        {
            if ((_frigale == "Да" )||(_weight < 50))
            {
                answer += " отдельно\n";
            }
            else
            {
                answer += " вместе со всем\n";
            }
        }
        else
        {
            if (_weight < 50)
            {
                answer += " вместе со всем\n";
            }
            else
            {
                answer += " отдельно\n"; 
            }
        }
            return "Перевозить послыку " + answer;
    }


    public override string ToString()
    {
        return "Длина = " + Length
            + ", Ширина = " + Width
            + ", Высота = " + Height
            + ", Масса = " + _weight
            + ", Хрупкое: " + _frigale;
    }
}

