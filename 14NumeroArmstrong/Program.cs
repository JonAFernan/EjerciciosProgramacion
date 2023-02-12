namespace _14NumeroArmstrong;

/*
 * Escribe una función que calcule si un número dado es un número de Armstrong
 * (o también llamado narcisista).
 * Si no conoces qué es un número de Armstrong, debes buscar información 
 * al respecto.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Armstrong(153));
    }

    static bool Armstrong(int number)
    {
        int numberDigitsRaisedAddition = 0;
        string numberString = number.ToString();
        double raisedPower = numberString.Length;
        foreach (var item in numberString)
        {
            int x = Convert.ToInt32(Math.Pow(Char.GetNumericValue(item),raisedPower));
            numberDigitsRaisedAddition += x;
        }
        
        return number == numberDigitsRaisedAddition ? true : false;
    }
}

