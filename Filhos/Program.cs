
int i1, i2;
int soma;



Console.WriteLine("Digite a idade do 1 filho");
i1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a idade do 2 filho");
i2 = int.Parse(Console.ReadLine());

soma = i1 + i2 +1;

if (soma >= 16)
{
    Console.WriteLine("O sistema não permite idade menor que 16");
}
else
{
    Console.WriteLine($"a idade da mãe é {soma}");
}





