static double factorial(int num)
{
    if (num == 0 || num == 1)
         return 1;
    return num * factorial(num - 1);
}


Console.Write("Digite el valor del factorial: ");
int Factorial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El Factorial de {0} es: {1}", Factorial, factorial(Factorial));

