int n;


Console.WriteLine("escreva o numero que deseja saber a tabuada");
n = int.Parse(Console.ReadLine());


for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{n} * {i} == {n * i}" );

}