Console.Write("Digite primeiro numero: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite segundo numero: ");
int n2 = int.Parse(Console.ReadLine());

Console.Write("Digite terceiro numero: ");
int n3 = int.Parse(Console.ReadLine());

int soma = n1 + n2;
if (soma < n3)
{
    Console.WriteLine($"A soma entre {n1} + {n2} é igual a {soma}. {soma} é menor que {n3}");

}
else
{
    Console.WriteLine($"A soma entre {n1} + {n2} é igual a {soma}, é maior que {n3}");
}

Console.ReadKey();