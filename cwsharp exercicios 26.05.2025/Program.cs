
//int numero;

//Console.WriteLine("escreva o numero correspondente da sua medalha 1 - ouro, 2- prata, 3 - bronze");
//numero = int.Parse(Console.ReadLine());


//string resultado = $"Você ficou na posicão {numero} {(numero == 1 ? "Você Ganhou a Medalanha de ouro" : numero == 2 ? "Você Ganhou a Medalha de prata" : numero == 3 ? "Você Ganhou a Medalha de bronze":
//    "Infelizmente você não ganhou nenhuma medalha")}.";

//Console.WriteLine(resultado);

//int numero;


//Console.WriteLine("qual posicão você ficou?");
//numero = int.Parse(Console.ReadLine());

//switch (numero)
//{
//    case 1 : Console.WriteLine("Você Ganhou a Medalanha de ouro");
//        break;  
//    case 2 : Console.WriteLine("Você Ganhou a Medalanha de prata");
//        break; 
//    case 3 : Console.WriteLine("Você Ganhou a Medalanha de bronze");
//        break;  
//    default : Console.WriteLine("Você não ganhou medalha");
//        break;
//}


using static System.Runtime.InteropServices.JavaScript.JSType;

int numero1, numero2;

Console.WriteLine("informe seu primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("informe seu segundo numero?");
numero2 = int.Parse(Console.ReadLine());

if (numero1 == 0)
{

    Console.WriteLine("o numero não pode ser 0");
} else if (numero2 == 0)
{
    Console.WriteLine("o numero 2 não pode ser 0");
};

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