/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

// Creacion de objetos
Polygon square = new Square(6);
Polygon rectangle = new Rectangle(5,10);
Polygon triangle = new Triangle(5,6);


Area(square);
Area(triangle);
Area(rectangle);

void Area(Polygon poligono)
{    
    poligono.CalculateArea();
    poligono.PrintArea();
}

 class Polygon {
    double area;
    public virtual void PrintArea()
    {
    Console.WriteLine("Area de un poligono");
    }
    public virtual double CalculateArea()
    {
    return area;
    }
}

class Square : Polygon {
double side;
public double area;

public Square(double side)
{
    this.side = side;
}

public override  void PrintArea()
    {    
        Console.WriteLine($"El area de este cuadrado es {this.area}");
    }

public override double CalculateArea()
    {  
        return this.area= this.side * this.side;;
    }
}
class Rectangle : Polygon {
double height;
double width;
public double area;
public Rectangle(double height, double width)
{
    this.height = height;
    this.width = width;
}

public override void PrintArea()
    {
        Console.WriteLine($"El area de este rectángulo es {this.area}");
    }
 public override double CalculateArea()
    {
        return this.area= this.width * this.height;;
    }
}

class Triangle : Polygon {
double height;
double triangleBase;
double area;
public Triangle(double height, double triangleBase){
    this.height = height;
    this.triangleBase = triangleBase;
}

public override  void PrintArea()
    {
        Console.WriteLine($"El area de este triangulo es {this.area}");
    }
 public override double CalculateArea()
    { 
        return this.area= this.triangleBase * this.height / 2 ;
    }
}
