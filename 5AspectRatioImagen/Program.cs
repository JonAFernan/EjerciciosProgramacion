using System.Drawing;

namespace _5AspectRatioImagen;
class Program
{
    static void Main(string[] args)

    {
        string direccion = "426x240.png"; 
        ImageAspectRatio(direccion);
    }

    static void ImageAspectRatio(string imageUrl)
    {
        Bitmap image = new Bitmap(imageUrl);
        System.Console.WriteLine(image.Height);
        System.Console.WriteLine(image.Width);

        //426:240 == 16:9 redondeado
        //array con todos los aspect ratios. 
        //Se divide la altura por la anchura de la imagen y se comparada con el array del aspec ratio para ver con cual coincide.
    }
}
