int numero1, numero2;

Console.WriteLine("informe seu primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("informe seu segundo numero?");
numero2 = int.Parse(Console.ReadLine());


int soma = numero1 + numero2;
int sub = numero1 - numero2;
int mult = numero1 * numero2;
int divi = numero1 / numero2;
int mod = numero1 % numero2;

Console.WriteLine("o resultado dessas operações são: ");


Console.WriteLine($"{numero1} + {numero2} = {soma.ToString("F2")}");
Console.WriteLine($"{numero1} - {numero2} = {sub.ToString("F2")}");
Console.WriteLine($"{numero1} * {numero2} = {mult.ToString("F2")}");
Console.WriteLine($"{numero1} / {numero2}  = {divi.ToString("F2")}");
Console.WriteLine($"{numero1} % {numero2}  =  {mod.ToString("F2")}");


