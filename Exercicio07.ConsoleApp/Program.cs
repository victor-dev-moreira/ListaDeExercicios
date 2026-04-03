Console.Write("Qual sua altura?(1,80) ");
double a = double.Parse(Console.ReadLine());

Console.Write("Qual seu peso?(80) ");
double p = double.Parse(Console.ReadLine());

double resultado = p / (a * a);

if (resultado < 18.5)
{
    Console.WriteLine($"Seu IMC é {resultado}");
    Console.WriteLine("Você esta abaixo do peso ideal!");
}
else if (resultado > 18.5 && resultado < 25)
{
    Console.WriteLine($"Seu IMC é {resultado}");
    Console.WriteLine("Você Esta no peso ideal!");
}
else if (resultado > 25 && resultado < 30)
{
    Console.WriteLine($"Seu IMC é {resultado}");
    Console.WriteLine("Você esta acima do peso!");
}
else
{
    Console.WriteLine($"Seu IMC é {resultado}");
    Console.WriteLine("Você esta obeso!");
}

Console.ReadKey();