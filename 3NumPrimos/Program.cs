/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

 bool Primodetector(int number, List<int> listPrimos)
{   
    bool result = false;
    bool divisor = true;
    int counter = 0;

    while(divisor)
        {
            if (number%listPrimos[counter]!= 0) 
            {
                if (listPrimos[counter] > number/listPrimos[counter])
                {
                    result = true;
                    break;
                }
                else counter++;
            }
            else divisor = false;
        }
    return result;
}

  List<int> PrintHundredNumPrimos (List<int> listPrimos , List<int> listNoPrimos){
    int counter = 0;
    while (counter<listPrimos.Count)
    {
    foreach (int i in listPrimos)
    {
        if (i!=listPrimos[0 + counter] && i%listPrimos[0+counter] == 0)
        {
            listNoPrimos.Add(i);
        }
    }
    foreach (int i in listNoPrimos)
    {
        if(listPrimos.Contains(i)) listPrimos.Remove(i);
    }
    counter++;
    }
    
    return listPrimos;
}

//*Crear lista de los 100 números primos
List<int> numPrimos = new List<int>();
List<int> noNumPrimos = new List<int>();

for (int x = 2 ; x <= 500 ; x++ )
    {   
        numPrimos.Add(x);
    }

List<int> ListPrimos = PrintHundredNumPrimos(numPrimos, noNumPrimos);

//Comprobar si un número es primo
Console.WriteLine("Introduce un número:");
int unknownPrimo = Convert.ToInt32(Console.ReadLine()); //104729
Console.WriteLine((Primodetector(unknownPrimo,ListPrimos) == true) ? $"{unknownPrimo} es un número primo" : $"{unknownPrimo} no es un número primo");

// imprimir los primos del 1 al 100
Console.WriteLine("A continuación se muestran los números primos entre el 1 y el 100:");
for (int x = 0 ; x < ListPrimos.Count ; x++ )
    {   if (ListPrimos[x] <= 100)
        Console.WriteLine(ListPrimos[x]);
        else break;
    }