Console.Write("Qual numero deseja receber o fatorial? ");
int n = int.Parse(Console.ReadLine());
int numero = n;

for (int i = n - 1; i > 0; i--)
{
    int n1 = n * i;
    Console.WriteLine($"Fatorial de {numero} X {i} = {n1}");
    n = n1;
    numero = n;
}

Console.ReadKey();