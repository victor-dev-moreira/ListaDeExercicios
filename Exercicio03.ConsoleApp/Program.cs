Console.Write("Qual Temperatura em graus celsius? ");
double c = double.Parse(Console.ReadLine());

double f = (c * 1.8) + 32;

Console.WriteLine($"Convertendo graus celcius {c} para fahrenheit: {f}F");

Console.ReadKey();