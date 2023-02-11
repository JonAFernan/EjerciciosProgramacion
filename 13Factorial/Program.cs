namespace _13Factorial;

/*
 * Escribe una función que calcule y retorne el factorial de un número dado
 * de forma recursiva.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Factorial(4));
    }

    static int Factorial(int number)
    {
        if(number == 1) return number;
        return number * Factorial(number-1);
    }
}
