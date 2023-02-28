
int num;

Console.WriteLine("Ingrese en como entero el total de números que desea generar");
if (int.TryParse(Console.ReadLine(),out num ))
{
    Console.WriteLine($"La sumatorio de los cuadrados es de los números generados es: {SumatoriaCuadrados(num)}");
}
else
{
    Console.WriteLine("No ingreso un valor valido");
}


static float SumatoriaCuadrados(int nValues)
{
    Random newRan = new Random();
    float sum = 0;

    for (int i = 0; i < nValues; i++)
    {
        float value = (float)newRan.Next(1000, 2510) /100;
        Console.WriteLine($"El valor #{i+1} generado es: {value}");
        sum += value * value;
    }

    return sum;
}
