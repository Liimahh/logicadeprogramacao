/ Console.WriteLine("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Voce possui autorização? (sim/não)");
string autorizacaoInput = Console.ReadLine().ToLower();
bool possuiAutorização = autorizacaoInput == "sim";

Console.Clear();

// Verificar se a pessoapode entrar no evento 

bool podeEntrar = (idade >= 18) || possuiAutorização;

if (podeEntrar)
{
    Console.WriteLine("Voce pode enrar no evento. ");
}
else
{
    Console.WriteLine("Voce NÂO pode entrar no evento. ");
}
    Console.WriteLine("==========================");

Console.WriteLine("Voce é maior de idade e tem autorização? ") +
    (idade >= 18 && possuiAutorização));
Console.WriteLine("Voce não è`maior de idade? " + (idade < 18));
Console.WriteLine("Voce è maior de idade ou tem autorizacao? " + (idade >= 18 || possuiAutorização));
    
    
