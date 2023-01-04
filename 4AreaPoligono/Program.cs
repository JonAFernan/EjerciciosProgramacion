/*
 * Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */



Square square = new Square(2);
Polygon rectangle = new Rectangle(2,4);
Polygon triangle = new Triangle(5,5);

Area(square);
//Area(triangle);
//Area(rectangle);

void Area(Polygon poligono){
    
    poligono.CalculateArea();
    poligono.PrintArea();
}

 class Polygon {
    public virtual void PrintArea(){
    Console.WriteLine("Area de un poligono");
    }
    public virtual double CalculateArea(){
    double area = 0;
    return area;
    }
}

class Square : Polygon {
double side;
double area = 0;

public Square(double side){
    this.side = side;
}

public override  void PrintArea(){

    
    Console.WriteLine($"El area de este cuadrado es {area}");
 }

public override double CalculateArea(){
    double area = this.side * this.side;
    return area;
}
}
class Rectangle : Polygon {
double height;
double width;

public Rectangle(double height, double width){
    this.height = height;
    this.width = width;
}

public override void PrintArea(){

    double area = this.width * this.height;
    Console.WriteLine($"El area de este rectángulo es {area}");
 }
}

class Triangle : Polygon {
double height;
double triangleBase;

public Triangle(double height, double triangleBase){
    this.height = height;
    this.triangleBase = triangleBase;
}

public override  void PrintArea(){

    double area = (this.triangleBase * this.height)/2;
    Console.WriteLine($"El area de este triangulo es {area}");
 }
}