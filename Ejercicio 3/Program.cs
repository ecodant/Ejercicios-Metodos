
using System;
using System.Collections;

int intager1 = enter_Nums();
int intager2 = enter_Nums();
show_Nums(intager1, intager2);
Console.WriteLine($"La cantidad de números fue: {count_Nums(intager1, intager2)}");
Console.WriteLine($"La cantidad de números impares fue: {odd_Nums(intager1, intager2)}");
Console.WriteLine($"La suma de los números pares fue: {add_Up_Nums(intager1, intager2)}");


static int enter_Nums()
{
    int intager;
    
    bool vali = true;
    do
    {
        Console.WriteLine("Ingrese un entero");
        if (int.TryParse(Console.ReadLine(), out intager))
        {
           vali= false;
        }
        else
        {
            Console.WriteLine("No ingresó un valor valido como entero, intentelo de nuevo");
        }

    } while (vali == true);
    return intager;
}
static void show_Nums(int num1, int num2)
{
    int[] order = new int[2];
    order[0] = num1;
    order[1] = num2;
    Array.Sort(order);
    Console.Write("Los números existentes entre los números proporcionados son: ");
    for (int i = order[0]; i <= order[1]; i++)
    {
        Console.Write($" {i}");
    }
    Console.Write("\n");
   
}
static int count_Nums(int num1, int num2)
{
    int count = 0;
    int[] order = new int[2];
    order[0] = num1;
    order[1] = num2;
    Array.Sort(order);
    for (int i = order[0]; i <= order[1]; i++)
    {
        count++;
    }
    return count;
}

static int odd_Nums(int num1, int num2)
{
    int impares = 0;
    int[] order = new int[2];
    order[0] = num1;
    order[1] = num2;
    Array.Sort(order);
    for (int i = order[0]; i <= order[1]; i++)
    {
        if (i % 2 != 0)
        {
            impares++;
        }
    }
    return impares;
}
static int add_Up_Nums(int num1, int num2)
{
    int sum = 0;
    int[] order = new int[2];
    order[0] = num1;
    order[1] = num2;
    Array.Sort(order);
    for (int i = order[0]; i <= order[1]; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }
    return sum;
}
