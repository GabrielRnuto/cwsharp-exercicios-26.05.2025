int nota1, nota2;

Console.WriteLine("Digite a primeira nota: ");
nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a primeira nota: ");
nota2 = int.Parse(Console.ReadLine());

string resultado = $"sua media é {(nota1 + nota2 /2)} e você está {((nota1 + nota2) /2 >=7 ? "Aprovado" : (nota1 + nota2) /2 >=6 ? "Recuperação" : "Reprovado")}.";

Console.WriteLine(resultado);
