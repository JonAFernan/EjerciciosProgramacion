namespace _12Palindromo;

/*
 * Escribe una función que reciba un texto y retorne verdadero o
 * falso (Boolean) según sean o no palíndromos.
 * Un Palíndromo es una palabra o expresión que es igual si se lee
 * de izquierda a derecha que de derecha a izquierda.
 * NO se tienen en cuenta los espacios, signos de puntuación y tildes.
 * Ejemplo: Ana lleva al oso la avellana.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Palindromo("Ana lleva al oso la avellana"));
    }

    static bool Palindromo(string text)
    {
        string textWithoutSpaces ="";
        string reverseText ="";

        text = text.ToLower();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == ' ') continue;
            textWithoutSpaces += text[i];
        }
        
        for (int i = textWithoutSpaces.Length-1; i >= 0; i--)
        {
            reverseText += textWithoutSpaces[i];
        }

        return reverseText == textWithoutSpaces ? true : false;

    }
}
