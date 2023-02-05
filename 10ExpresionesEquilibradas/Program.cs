namespace _10ExpresionesEquilibradas;

/*
 * Crea un programa que comprueba si los paréntesis, llaves y corchetes
 * de una expresión están equilibrados.
 * - Equilibrado significa que estos delimitadores se abren y cieran
 *   en orden y de forma correcta.
 * - Paréntesis, llaves y corchetes son igual de prioritarios.
 *   No hay uno más importante que otro.
 * - Expresión balanceada: { [ a * ( c + d ) ] - 5 }
 * - Expresión no balanceada: { a * ( c + d ) ] - 5 }
 */
class Program
{
    static void Main(string[] args)
    {
        BalacedExpression("{ }[ a * c + d)  ] - 5 }");
        //BalacedExpression("a * c + d - 5 ");

    }

    static void BalacedExpression(string expresion)
    {
        bool balanced = false;
        char [] delimiterArray = "{}()[]".ToCharArray();
        List<char> expresionList = new List<char>();
        expresionList.AddRange(expresion);
        
        if(expresion.IndexOfAny(delimiterArray) == -1) balanced = true;
        else
        {
            foreach (char item in expresion)
            {
                // crear otra lista para poder eliminar los delimitadores de apertura. Este foreach no sirve???
                if(delimitersDic.ContainsKey(item))
                {
                    for (int i = 0; i < expresionList.Count; i++)
                    {
                        if (expresionList[i] == delimitersDic[item])
                        {
                            // hay que eliminar los delimitadores de apertura.
                            expresionList.Remove(expresionList[i]);
                            expresionList.Remove(expresionList[item]);
                            break;
                        }
                    }
                }

            
            }

            // convertir lista a string
        string isBalanced = string.Join(' ',expresionList);

        if(isBalanced.IndexOfAny(delimiterArray) == -1) balanced = true;
        }
        
        System.Console.WriteLine(balanced);

    }

    static Dictionary<char,char> delimitersDic = new Dictionary<char, char>()
    {
        {'{', '}'},
        {'(', ')'},
        {'[',']'},
    };
}
