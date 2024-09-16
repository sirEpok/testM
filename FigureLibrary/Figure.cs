using System;
using static System.Math;

namespace FigureLibrary
{
    abstract class Figure
    {
        public abstract double GetArea();
    }

    class Circle : Figure
    {
        public double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override double GetArea() => Math.PI * radius * radius;
    }

    class Triangle : Figure
    {
        public double SideA, SideB, SideC;
        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }
        public override double GetArea()
        {
            if (SideA > SideB && SideA > SideC)
            {
                if (SideA * SideA == SideB * SideB + SideC * SideC)
                {
                    return SideB * SideC / 2;
                }
            }
            else if (SideB > SideC && SideB > SideA)
            {
                if (SideB * SideB == SideA * SideA + SideC * SideC)
                {
                    return SideA * SideC / 2;
                }
            }
            else
            {
                if (SideC * SideC == SideA * SideA + SideB * SideB)
                {
                    return SideA * SideB / 2;
                }
            }

            return Math.Sqrt(SideA + SideB + SideC) / 4;
        }
    }
}

//Связь "многие-ко-многим" возникает между двумя таблицами,
//когда в каждой из них может присутствовать несколько ключей другой таблицы.
//Чтобы данные со связью "многие-ко-многим" могли быть представлены в базе данных,
//этот тип связи преобразуется в две связи "один-ко-многим"

// Product -> PC <- Category

//SELECT * FROM PC
//INNER JOIN Product ON Product.id = PC.product_id
//INNER JOIN Category ON Category.id = PC.category_id;