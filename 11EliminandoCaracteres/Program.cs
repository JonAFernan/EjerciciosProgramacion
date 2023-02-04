namespace ModificadorPalabras;

/*
 * Crea una función que reciba dos cadenas como parámetro (str1, str2)
 * e imprima otras dos cadenas como salida (out1, out2).
 * - out1 contendrá todos los caracteres presentes en la str1 pero NO
 *   estén presentes en str2.
 * - out2 contendrá todos los caracteres presentes en la str2 pero NO
 *   estén presentes en str1.
 */

class Program{

    static void Main(string [] args)
    {
       WordModification("Hola","Caracola");
    }

    static void WordModification(string word1, string word2)
    {
        List<char> word1List = new List<char>();
        word1List.AddRange(word1.ToLower());
        List<char> word2List = new List<char>();
        word2List.AddRange(word2.ToLower());
        List<char> charToDelete = new List<char>();

        for (int i = 0; i < word1List.Count; i++)
        {

            for (int j = 0; j < word2List.Count; j++)
            {
                if (word1List[i] == word2List[j])
                {
                    word2List.Remove(word1List[i]);
                    charToDelete.Add(word1List[i]);
                    j = 0;
                }
                 
            }
        }

        for (int i = 0; i < charToDelete.Count; i++)
        {

            for (int j = 0; j < word1List.Count; j++)
            {
                if (charToDelete[i] == word1List[j])
                {
                    word1List.Remove(charToDelete[i]);
                    j = 0;
                }
                 
            }
        }
        
        
        System.Console.Write("New word1 is ");
        foreach (var item in word1List)
        {
            System.Console.Write(item);
        }
        

        System.Console.WriteLine();
        System.Console.Write("New word2 is ");
       
        foreach (var item in word2List)
        {
            System.Console.Write(item);
        }

    }
    
    
}