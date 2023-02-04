namespace _7ContadorPalabras;
/*
 * Crea un programa que cuente cuantas veces se repite cada palabra
 * y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que
 *   lo resuelvan automáticamente.
 */
class Program
{
    static void Main(string[] args)
    {
        WordCounter("Hello World! Hello boy or girl. Tomorrow World(Hello)boy and girl.");
    }


    static void WordCounter (string word)
    {
        char [] punctuationMarks = ".,:!?¿()¡[]{} ".ToCharArray();
        List<string> wordList = new List<string>();
        List<string> wordListComparer;
        string [] wordArray = word.Split(punctuationMarks);
        foreach (var item in wordArray)
        {
            if(item != string.Empty)
            wordList.Add(item.ToLower());
        }

        wordListComparer = new List<string>(wordList);
        
        for (int i = 0; i < wordList.Count; i++)
        {
            int counter = 0;

            System.Console.Write($"La palabra {wordList[i]} aparece ");
            
            for (int x = 0; x < wordListComparer.Count; x++)
            {
                
                if(wordList[i]==wordListComparer[x])
                {
                    
                    counter++;
                    if(counter>1)
                    {
                        wordList.RemoveAt(x);
                        wordListComparer.RemoveAt(x);
                        x=i;
                    }
                    
                    
                }      
            }
             
            System.Console.WriteLine(counter == 1 ? "una vez" : $"{counter} veces.");
        }

    }
}
