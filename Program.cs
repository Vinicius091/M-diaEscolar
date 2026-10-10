Console.WriteLine("---Média Escolar---");

Console.Write("Nota 1:.. ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Nota 2:.. ");
double nota2 = Convert.ToDouble(Console.ReadLine());

if (nota1 < 0 || nota2 < 0 || nota1 > 10 || nota2 > 10)
{
    Console.WriteLine("Notas inválidas. Tente novamente.");
}

else 
{
    double media = (nota1 + nota2) / 2;
    Console.WriteLine($"Sua media é {media:N1}");

    if (media >= 7)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Você está aprovado!");

        if(media == 10)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Parabéns, vc tirou a nota máxima!");
        }

    }

    else
    {
        if (media >= 5)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Você está em recuperação!");
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Você está reprovado!");
        }
    }
}

Console.ResetColor();
Console.WriteLine("Obrigado por usar nosso programa.");