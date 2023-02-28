
double radian;
double angle;
bool vali = true;
Console.WriteLine("Ingrese el radian: ");
do
{
    if (Double.TryParse(Console.ReadLine(), out radian))
    {
        do
        {
            Console.WriteLine("Ingrese el valor de ángulo");
            if (double.TryParse(Console.ReadLine(), out angle))
            {
                convertCoordinates(radian, angle);
                vali = false;
            }
            else
            {
                Console.WriteLine("Ni ingreso un valor valido como angulo, intentelo una vez más");
            }
        } while (vali == true);
    }
    else
    {
        Console.WriteLine("Ni ingreso un valor valido como radian, intentelo una vez más");
    }
} while (vali == true);

static void convertCoordinates(double radian, double angle)
{
    double x = radian * Math.Cos(angle);
    double y = radian * Math.Sin(angle);

   Console.WriteLine($"Las coordenas rectangulares de la información que proporciono son: En x: {x}, en y: {y})");
}