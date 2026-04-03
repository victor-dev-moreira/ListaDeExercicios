Console.Write("Digite um numero para saber se é par ou impar: ");
double n = double.Parse(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine($"O numero {n} é par");
}
else
{
    Console.WriteLine($"O numero {n} é impar");
}

Console.ReadKey();