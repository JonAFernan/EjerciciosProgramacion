namespace NumPrimos;
/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */
class Program{

    static void Main(string [] args)
    {
        System.Console.WriteLine(PrimoDetector(997) ? "Es un número primo":"No es un número primo");
        PrimoPrinter(1,100);
    
    }
    static bool PrimoDetector(int number)
    {   
        bool isPrimo = true;
        if (number < 2) isPrimo = false;
        for (int i = 2; i < number; i++)
        {
            if (number%i == 0) isPrimo= false;
        }

        return isPrimo;
    }
    static void PrimoPrinter(int primosFrom , int primosTo)
    {       
        
        for (int i = primosFrom; i <= primosTo; i++)
        {
            if (PrimoDetector(i)) System.Console.WriteLine(i);
        }
    }
}