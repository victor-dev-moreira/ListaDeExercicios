Console.Write("Qual Seu Salario Base? ");
double s = double.Parse(Console.ReadLine());

Console.Write("Qual o percentual de comissão?(Porcentagem) ");
double p = double.Parse(Console.ReadLine());

Console.Write("Qual total de vendas? ");
double v = double.Parse(Console.ReadLine());

double salarioTotal = s + (v * (p / 100));

Console.WriteLine($"Seu salario total é {salarioTotal}");

Console.ReadKey();