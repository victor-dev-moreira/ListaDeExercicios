Console.Write("Digite o Comprimento? ");
decimal c = decimal.Parse(Console.ReadLine());

Console.Write("Digite o Largura? ");
decimal l = decimal.Parse(Console.ReadLine());

Console.Write("Digite o Altura? ");
decimal a = decimal.Parse(Console.ReadLine());

decimal v = c * l * a;

Console.WriteLine($"Volume dessa caixa é: {v:F2} cm³");

Console.ReadLine();