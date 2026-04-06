for (int i = 1; i <= 100; i++)
{
    string n = i.ToString();

    if (i % 3 == 0 && i % 5 == 0)
    {
        n = "FizzBuzz";
    }
    else if (i % 3 == 0)
    {

        n = "Fizz";
    }
    else if (i % 5 == 0)
    {

        n = "Buzz";
    }

    Console.WriteLine($"{n} ");
}

Console.ReadKey();