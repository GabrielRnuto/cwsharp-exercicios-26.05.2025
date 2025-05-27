int n1, n2;


Console.WriteLine("Qual a carta carta n° 1?");
n1 = int.Parse(Console.ReadLine());


Console.WriteLine("Qual a carta n° 2? ");
n2 = int.Parse(Console.ReadLine());


string resultado = n1 < n2 ? $"a carta 2 tem o valor de {n2} e é maior que a primeira carta" : n1 > n2 ? $"a primeira carta tem o valor de {n1} e é maior que a segunda" 
    : "as duas cartas tem o mesmo valor";

Console.WriteLine(resultado);

