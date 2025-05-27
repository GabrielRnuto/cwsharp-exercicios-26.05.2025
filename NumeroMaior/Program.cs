
int numero1, numero2;

Console.WriteLine("escreva o seu primeiro número");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("escreva o seu segundo número");
numero2 = int.Parse(Console.ReadLine());

string resultado = numero1 < numero2
    ? "O seu segundo número maior do que o seu primeiro" :
    numero1 > numero2
    ? "o Seu primeiro primeiro numero é maior que o segundo" : "os numeros são iguais";