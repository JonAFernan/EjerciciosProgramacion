namespace _8DecimalBinario;

/*
 * Crea un programa se encargue de transformar un número
 * decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
 */


class Program
{
    static void Main(string[] args)
    {
        ConvertToBinary(100);
    }

    static void ConvertToBinary(int number)
    {
        string binaryNumber="";
        bool x= true;

        if (number== 0) Console.WriteLine("0");
        else if(number == 1) Console.WriteLine("1");
        else 
        {
            do
            {
                binaryNumber += (number%2).ToString();
                number = number/2;

                if(number == 1) 
                {
                binaryNumber += number;    
                x= false;
                }
            } while (x);

            for (int i = binaryNumber.Length-1; 0 <= i; i--)
            {
                Console.Write(binaryNumber[i]);
            }
        
        }  
    
    }
}
