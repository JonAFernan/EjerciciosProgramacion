using System.Globalization;

namespace _15ContadorDias;


/*
 * Crea una función que calcule y retorne cuántos días hay entre dos cadenas
 * de texto que representen fechas.
 * - Una cadena de texto que representa una fecha tiene el formato "dd/MM/yyyy".
 * - La función recibirá dos String y retornará un Int.
 * - La diferencia en días será absoluta (no importa el orden de las fechas).
 * - Si una de las dos cadenas de texto no representa una fecha correcta se
 *   lanzará una excepción.
 */
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DayCounter("28/02/2023", "25/12/1985"));
    }

    enum Months
    {
        January = 1,
        February,
        March,
        April,  
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        Dicember,

    }

    static Dictionary<string, int> monthsDaysDic = new Dictionary<string, int>()
    {
        {"January", 31},
        {"February", 28},
        {"March", 31},
        {"April", 30},  
        {"May", 31},
        {"June", 30},
        {"July", 31},
        {"August", 31},
        {"September", 30},
        {"October", 31},
        {"November", 30},
        {"Dicember", 31},
    };

    static int DayCounter(string date1, string date2)
    {
        if(!DateFormatCheck(date1) || !DateFormatCheck(date2) ) return 0;
        
        string [] date1Array = date1.Split('/');
        string [] date2Arrray = date2.Split('/');
        
        int date1Days = DateToDays(date1Array);
        int date2Days = DateToDays(date2Arrray);

        if (date1Days >= date2Days) return date1Days - date2Days;
        else return date2Days - date1Days;
    }

    static int DateToDays (string [] date)
    {
        int monthsDaysCounter = 0;
        int yearDaysCounter = 0;
        int [] dateIntArray = new int[date.Length];
        
        for (int i = 0; i < date.Length; i++)
        {
            dateIntArray[i] = Convert.ToInt32(date[i]);
        }

        for (int i = 1; i <= dateIntArray[1]-1; i++)
        {
            string monthKey = ((Months)i).ToString();
            monthsDaysCounter += monthsDaysDic[monthKey];
        }

        for (int i = 1; i <= dateIntArray[2]-1; i++)
        {
                if (i%4 == 0)
                    {
                        yearDaysCounter += 366;
                    } 
                else yearDaysCounter += 365;
        }

        if(dateIntArray[2]%4 == 0 && dateIntArray[1]>= 3) yearDaysCounter += 1;

        return dateIntArray[0] + monthsDaysCounter + yearDaysCounter ;
    }

    static bool DateFormatCheck (string date)
    {
        string format ="dd/MM/yyyy";
        CultureInfo provider = CultureInfo.InvariantCulture;
    
        try
        {
            DateTime dt = DateTime.ParseExact(date, format, provider);
            return true;
        }
        catch (FormatException)
        {
            Console.WriteLine($"{date} is not in the correct format.");
            return false;
        }
    }
}
