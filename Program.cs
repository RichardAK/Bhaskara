double A, B, C;
double x1, x2;
double delta ; 

Console.WriteLine(" Equação do segundo grau \n");

Console.Write("A : ");
A = Convert.ToDouble(Console.ReadLine());

Console.Write("B : ");
B = Convert.ToDouble(Console.ReadLine());

Console.Write("C : ");
C = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(); 

if(A == 0)
{
    Console.WriteLine("Não é uma equação de segundo grau");
    Console.ForegroundColor=ConsoleColor.Red;
    Console.ResetColor();
}

else
{
    delta = B * B-4 * A * C; 

    if(delta < 0)
    {
        Console.WriteLine($"Como delta é {delta:n2} Não possui raízes reais");
    }

    else
    {
        x1 = (-B +Math.Sqrt(delta)) /2 * A; 
        x2 = (-B -Math.Sqrt(delta)) /2*A ; 

        Console.WriteLine($"x1:{x1:n2} e x2:{x2:n2}");
    }

}

 


