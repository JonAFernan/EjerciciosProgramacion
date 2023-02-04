namespace Fibonacci;
/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
class Program{
 static void Main(string[] args)
    {
        Fibonacci(50);
    }

static void Fibonacci(int numOfFibonums)
{   
    
    long firstNum = 0;
    long secondNum = 1;
    long sumFirstSecond;
    System.Console.WriteLine(firstNum);

    if(numOfFibonums > 1)
    {
        System.Console.WriteLine(secondNum);

        for (int x= 2 ; x < numOfFibonums ; x++)

        {  
            sumFirstSecond = firstNum + secondNum;
            Console.WriteLine(sumFirstSecond);
            firstNum = secondNum;
            secondNum = sumFirstSecond;
        }
    }
}   
}