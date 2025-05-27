
int numero;

Console.WriteLine("escreva o numero correspondente da sua medalha 1 - ouro, 2- prata, 3 - bronze");
numero = int.Parse(Console.ReadLine());


string resultado = $"Você ficou na posicão {numero} {(numero == 1 ? "Você Ganhou a Medalanha de ouro" : numero == 2 ? "Você Ganhou a Medalha de prata" : numero == 3 ? "Você Ganhou a Medalha de bronze" :
    "Infelizmente você não ganhou nenhuma medalha")}.";

Console.WriteLine(resultado);