namespace _16PrimeraEnMayusculas;

/*
 * Crea una función que reciba un String de cualquier tipo y se encargue de
 * poner en mayúscula la primera letra de cada palabra.
 * - No se pueden utilizar operaciones del lenguaje que
 *   lo resuelvan directamente.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FirstToMayus("¡hello!"));
        Console.WriteLine(FirstToMayus("hello"));
        Console.WriteLine(FirstToMayus("Hello"));
    }

    static string FirstToMayus(string word)
    {
        string firstLetterMayus = "";
        int mayusCounter = 0;
        char [] letters = "abcdefghijklmnopqrstuvwxyz".ToArray();
        word = word.ToLower();
        for (int i = 0; i < word.Length; i++)
        {
            if(mayusCounter == 0 && (word[i].ToString()).IndexOfAny(letters) != -1)
            {
                firstLetterMayus += (word[i].ToString()).ToUpper();
                mayusCounter ++;
            }
            else firstLetterMayus += word[i];
        }


        return firstLetterMayus;
    }
}
