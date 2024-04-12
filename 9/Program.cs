using System;

try
{
    Shapes[] shapes = new Shapes[3];  //Создание массива, состоящего из 3 фигур (круг, квадрат, ромб)
    shapes[0] = new Circle(12.8); //1-ый элемент - круг пренадлежит классу круг со значением радиуса = 12.8
    shapes[1] = new Square(13); //2-ый элемент - квадрат пренадлежит классу квадрат со значением стороны = 13
    shapes[2] = new Rhomb(5.5, 7.5); //3-ый элемент - ромб пренадлежит классу ромб со значением диагоналей = 5.5 и 7.5
    shapes[0].Area(); // нахождение площади круга
    shapes[1].Area(); // нахождение площади квадрата
    shapes[2].Area(); // нахождение площади ромба
}
catch (Exception ex)
{
    Console.WriteLine("You have got an error" + ex.Message);
}

interface Shapes //фигуры
{
    void Area();
}

abstract class AbstrQuadrilateral : Shapes //четырехугольники
{
    protected double area;
    public abstract void Area();
    
}
abstract class AbstrCircle : Shapes //круг (не является четырехугольником)
{
    protected double radius;
    public abstract void Area();
}
abstract class AbstrSquare : AbstrQuadrilateral //квадрат - четырехугольник
{
    protected double side;
}
abstract class AbstrRhomb : AbstrQuadrilateral //ромб - четырехугольник
{
    protected double diagonal1;
    protected double diagonal2;
}

class Circle : AbstrCircle
{
    public Circle(double radius) : base()
    {
        this.radius = radius;
    }
    public override void Area()
    {
        double area = radius * radius * 3.14;
        Console.WriteLine($"The area of the circle is equal to {area}");
    }

    ~Circle()
    {
        Console.WriteLine("Circle is deleted");
    }
}
class Square : AbstrSquare
{
    public Square(double side) : base()
    {
        this.side = side;
    }
    public override void Area()
    {
        double area = side * side;
        Console.WriteLine($"The area of the square is equal to {area}");
    }
    ~Square()
    {
        Console.WriteLine("Square is deleted");
    }
}
class Rhomb : AbstrRhomb
{
    public Rhomb(double diagonal1, double diagonal2) : base()
    {
        this.diagonal1 = diagonal1;
        this.diagonal2 = diagonal2;
    }
    public override void Area()
    {
        double area = 0.5*(diagonal1 * diagonal2);
        Console.WriteLine($"The area of the rhomb is equal to {area}");
    }
    ~Rhomb()
    {
        Console.WriteLine("Rhomb is deleted");
    }
}
