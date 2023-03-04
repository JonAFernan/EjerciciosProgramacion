namespace _19ConversorDeTiempo;

/*
 * Crea una función que reciba días, horas, minutos y segundos (como enteros)
 * y retorne su resultado en milisegundos.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(TimeToMiliseconds(2147483647,2147483647,2147483647,2147483647));
    }

    static ulong TimeToMiliseconds( int days ,int hours, int minutes, int seconds)
    {
        return  ((ulong)days * 86400000 + (ulong)hours * (ulong)3600000 + (ulong)minutes * 60000 + (ulong)seconds * 1000);
    }
    
}
