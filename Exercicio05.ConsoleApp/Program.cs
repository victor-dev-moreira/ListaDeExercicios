Console.Write("Qual nota da prova 1? ");
double n1 = double.Parse(Console.ReadLine());

Console.Write("Qual nota da prova 2? ");
double n2 = double.Parse(Console.ReadLine());

Console.Write("Qual peso da prova 1? ");
double p1 = double.Parse(Console.ReadLine());

Console.Write("Qual peso da prova 2? ");
double p2 = double.Parse(Console.ReadLine());

double m = (n1 * p1 + n2 * p2) / (p1 + p2);

Console.WriteLine($"Média ponderada: {m:F2}");

Console.ReadKey();