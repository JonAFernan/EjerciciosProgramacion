public class Program
{
    public static void Main(string[] args)
    {
        string FirstWord = "veranillo";
        string SecondWord = "lloverian";

        Console.WriteLine(Anagrama(FirstWord, SecondWord));

        static bool Anagrama(string word1, string word2)
        {
            bool result = false;
            List<char> listChar = new List<char>();
            if (word1 == word2) result = false;
            else if (word1.Length != word2.Length) result = false;
            else
            {
                List<char> listWord1 = new List<char>(word1);
                List<char> listWord2 = new List<char>(word2);
                foreach (var letter in listWord1)
                {
                    if (listWord2.Contains(letter))
                    {
                        listChar.Add(letter);
                        listWord2.Remove(letter);
                    }

                }
            }
            string word3 = string.Join("", listChar);
            if (word3 == word1) result = true;
            return result;
        }
    }
}