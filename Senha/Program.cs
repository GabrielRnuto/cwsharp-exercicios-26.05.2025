
string senha = "1234";

Console.WriteLine("Digite a senha:");
senha = Console.ReadLine();

string resultado = senha == "1234" ? "senha Correta" : "senha incorreta";

Console.WriteLine(resultado);
