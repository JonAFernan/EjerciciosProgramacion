/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */

int [] FibonacciList = Fibonacci(50);
foreach (var i in FibonacciList)
{
    Console.WriteLine(i);
}

 

static int [] Fibonacci(int number)
{   
    int [] FiboList = new int[number];
    FiboList[0] = 1;
    FiboList[2] = 1;
    //int r = FiboList[0] + FiboList[1];
    //FiboList.Add(r);

    for (int index = 0 ; index < number ; index++)
    {
        FiboList[index + 2] = FiboList[index] + FiboList[index + 1];
    }
        
    return FiboList;
}   