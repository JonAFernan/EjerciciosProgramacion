/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

// Creacion de objetos
Polygon square = new Square(6f);
Polygon rectangle = new Rectangle(5f,10f);
Polygon triangle = new Triangle(5.2f,6f);


Area(square);
Area(triangle);
Area(rectangle);

void Area(Polygon poligono)
{    
    poligono.CalculateArea();
    poligono.PrintArea();
}

 class Polygon {
    float area;
    public virtual void PrintArea()
    {
    Console.WriteLine("Area de un poligono");
    }
    public virtual float CalculateArea()
    {
    return area;
    }
}

class Square : Polygon {
float side;
public float area;

public Square(float side)
{
    this.side = side;
}

public override  void PrintArea()
    {    
        Console.WriteLine($"El area de este cuadrado es {this.area}");
    }

public override float CalculateArea()
    {  
        return this.area= this.side * this.side;;
    }
}
class Rectangle : Polygon {
float height;
float width;
public float area;
public Rectangle(float height, float width)
{
    this.height = height;
    this.width = width;
}

public override void PrintArea()
    {
        Console.WriteLine($"El area de este rectángulo es {this.area}");
    }
 public override float CalculateArea()
    {
        return this.area= this.width * this.height;;
    }
}

class Triangle : Polygon {
float height;
float triangleBase;
float area;
public Triangle(float height, float triangleBase){
    this.height = height;
    this.triangleBase = triangleBase;
}

public override  void PrintArea()
    {
        Console.WriteLine($"El area de este triangulo es {this.area}");
    }
 public override float CalculateArea()
    { 
        return this.area= this.triangleBase * this.height / 2 ;
    }
}
