int n1, n2;


Console.WriteLine("Qual a potuação do robo 1? ");
n1 = int.Parse(Console.ReadLine());


Console.WriteLine("Qual a potuação do robo 2? ");
n2 = int.Parse(Console.ReadLine());


string resultado = n1 < n2 ? "O robo numero 2 venceu a partida" : n1 > n2 ? "o Robo 1 venceu a partida" : "Os dois robos empataram";

Console.WriteLine(resultado);

