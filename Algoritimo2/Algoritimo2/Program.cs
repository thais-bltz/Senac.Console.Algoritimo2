int idade = 19;
string nomeCliente = "Thais Bublitz";
decimal preco = 20M;
char letra = 'a';
var nomeCompleto = "Thais Camila Bublitz";
var altura = 180;
Console.WriteLine("Digite seu nome:");
nomeCompleto = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Bem vindo " + nomeCompleto);
Console.WriteLine();
Console.Write("Digite sua idade: ");
var Linha = Console.ReadLine();
idade = int.Parse(Linha);
Console.WriteLine("idade informada" + idade);
if (idade < 18)
    Console.WriteLine("Você não pode estar aqui!");

Console.ReadKey();