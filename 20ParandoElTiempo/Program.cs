namespace _20ParandoElTiempo;

/*
 * Crea una función que sume 2 números y retorne su resultado pasados
 * unos segundos.
 * - Recibirá por parámetros los 2 números a sumar y los segundos que
 *   debe tardar en finalizar su ejecución.
 * - Si el lenguaje lo soporta, deberá retornar el resultado de forma
 *   asíncrona, es decir, sin detener la ejecución del programa principal.
 *   Se podría ejecutar varias veces al mismo tiempo.
 */
class Program
{
    static void Main(string[] args)
    {
        
        Calladditions();
        Console.ReadKey();
    }

    static async void Calladditions()
    {
        Task<int> call1 = StopingTimeAdditionAsync(28,21,5);
        Task<int> call2 = StopingTimeAdditionAsync(15,52,2);
        int addition1 = await call1;
        int addition2 = await call2;
    }

    static async Task<int> StopingTimeAdditionAsync (int sum1, int sum2 , int seconds)
    {
        int suma = sum1 + sum2;
        System.Console.WriteLine($"Inicio suma de {sum1} + {sum2} ");
        await Task.Delay(seconds * 1000);
        System.Console.WriteLine($"El resultado de {sum1} + {sum2} = {suma}");
        return suma;
    }
}
