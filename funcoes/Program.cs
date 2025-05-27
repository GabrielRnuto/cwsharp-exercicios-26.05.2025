void ExibirMensagem()
{
    Console.WriteLine("mensagem ");
}

Console.WriteLine(ExibirMensagem);
//ExibirMensagem();

somar(10, 5);
Ehpar(12);
CalculaMedia(10, 5);


int somar(int a, int b)
{
    Console.WriteLine(a + b);
    return a + b;
}


bool Ehpar(int a)
{
    if (true)
    {
        Console.WriteLine(true);
        return a % 2 == 0;
    }
    else
    {
        Console.WriteLine(false);
        return false;
    }
}

double CalculaMedia(double a, double b)
{
    Console.WriteLine((a + b / 2).ToString("F"));
    return a * b /2;
}