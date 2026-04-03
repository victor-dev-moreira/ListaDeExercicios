Console.Write("Qual quilometragem inicial? ");
double quilometragemInicial = double.Parse(Console.ReadLine());

Console.Write("Qual a quilometragem final? ");
double quilometragemFinal = double.Parse(Console.ReadLine());

Console.Write("Qual a quantidade consumida(litros)? ");
double combustivel = double.Parse(Console.ReadLine());

double resultado = combustivel / (quilometragemFinal - quilometragemInicial);

Console.WriteLine($"O consumo de combustível por km percorrido é: {resultado} L/km");

Console.ReadKey();