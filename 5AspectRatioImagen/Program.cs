using System.Drawing;

namespace _5AspectRatioImagen;
class Program
{
    static void Main(string[] args)

    {
        string direccion = "426x240.png"; 
        ImageAspectRatio(direccion);
    }

    static Dictionary<decimal,string> AspectRaioDic= new Dictionary<decimal, string>() 
    {
    {1.78m, "19:4"},
    {1.00m, "1:1"},
    {1.33m, "4:3"},
    {1.5m, "3:2"},
    };

    static void ImageAspectRatio(string imageUrl)
    {
        Bitmap image = new Bitmap(imageUrl);

        decimal imageDecimalRatio = decimal.Round((decimal)image.Width / (decimal)image.Height , 2);

        if (AspectRaioDic.ContainsKey(imageDecimalRatio)) System.Console.WriteLine($"El Aspect Ratio de la imagen es {AspectRaioDic[imageDecimalRatio]}");
        else System.Console.WriteLine("La imagen no tiene un Aspect Ratio estandar");

         
    }
}
