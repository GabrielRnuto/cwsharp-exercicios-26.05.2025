int numero;

Console.WriteLine("Digite seu numero para sabermos se é maior que 10");
numero = int.Parse(Console.ReadLine());

string resultado = numero > 10
    ? "o seu numero é menor do que 10" : numero < 10 ? "o seu numero é maior que 10 " : "O seu número é 10";

Console.WriteLine(resultado);
