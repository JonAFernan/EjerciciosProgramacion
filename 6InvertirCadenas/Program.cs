/*
 * Crea un programa que invierta el orden de una cadena de texto
 * sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */

 
 
 ReverseString("hello world");
 
 void ReverseString(string word)
 {
    for (int i = word.Length - 1; i >= 0; i--)
    {
        System.Console.Write(word[i]);
    }

 }
