using System.Reflection.Metadata;

Console.WriteLine("Digite a primeira nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
double nota2 = double. Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota");
double nota3 = double.Parse(Console.ReadLine());

// Calcular a média 
double media = (nota1 + nota2 + nota3) / 3;
Console.Clear();
Console.WriteLine("A media de aluno(a) e: " + media);

// Verificar a situacao do aluno
if (media >= 7)
{
    Console.WriteLine("ituaçao: Aprovado(a)");
}
else if (media >= 4)
{
    Console.WriteLine("Situcao: Recuperacao");
}
else
{
    Console.WriteLine("Situacao: Recuprovado(a) ");

}


