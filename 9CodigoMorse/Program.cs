namespace _9CodigoMorse;

/*
 * Crea un programa que sea capaz de transformar texto natural a código
 * morse y viceversa.
 * - Debe detectar automáticamente de qué tipo se trata y realizar
 *   la conversión.
 * - En morse se soporta raya "—", punto ".", un espacio " " entre letras
 *   o símbolos y dos espacios entre palabras "  ".
 * - El alfabeto morse soportado será el mostrado en
 *   https://es.wikipedia.org/wiki/Código_morse.
 */
class Program
{
    static void Main(string[] args)
    {
       System.Console.WriteLine(MorseTralator("... --- ...  ... --- ...")); 
       System.Console.WriteLine(MorseTralator("SOS SOS")); 

    }

    static Dictionary<char, string> morseDic = new Dictionary<char, string>()
    {
        {'A', ".-"},
        {'B', "-..."},
        {'C', "-.-."},
        {'D', "-.."},
        {'E', "."},
        {'F', "..-."},
        {'G', "--."},
        {'H', "...."},
        {'I', ".."},
        {'J', ".---"},
        {'K', "-.-"},
        {'L', ".-.."},
        {'M', "--"},
        {'N', "-."},
        {'O', "---"},
        {'P', ".--."},
        {'Q', "--.-"},
        {'R', ".-."},
        {'S', "..."},
        {'T', "-"},
        {'U', "..-"},
        {'V', "...-"},
        {'W', ".--"},
        {'X', "-..-"},
        {'Y', "-.--"},
        {'Z', "--.."},
        {'1', ".----"},
        {'2', "..---"},
        {'3', "...--"},
        {'4', "....-"},
        {'5', "....."},
        {'6', "-...."},
        {'7', "--..."},
        {'8', "---.."},
        {'9', "----."},
        {'0', "-----"},
    };
    static Dictionary<string, char> wordDic = morseDic.ToDictionary(x => x.Value, x => x.Key);

    

    static string MorseTralator(string msg)
    {   
        msg = msg.ToUpper();
        char [] wordChar = "ABCDEFGHIJKLMNOPQRSTU".ToArray<char>();
        if(msg.IndexOfAny(wordChar) == -1) return ToWord(msg);
        else return ToMorse(msg);

        
    }

    static string ToWord(string msg)
    {
        string ToWordtraslate= string.Empty;
        string [] msgArray = msg.Split(' ');
        foreach (string item in msgArray)
        {
            if(item == string.Empty) ToWordtraslate += " ";
            else ToWordtraslate += wordDic[item];
        }

        return ToWordtraslate;
    }
    static string ToMorse(string msg)
    {
        string ToMorseTraslate = string.Empty;
        foreach (char item in msg)
        {
            if(item == ' ') ToMorseTraslate += "  ";
            else ToMorseTraslate += morseDic[item];
        }
        
        return ToMorseTraslate;
    }
}

