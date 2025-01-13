// Calcular que recebe 2 numeros e apreseta + - * /

Console.WriteLine("Escreva o primeiro numero: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva o segundo numero: ");
int numero2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("+ : " + (numero1 + numero2));
Console.WriteLine("- : " + (numero1 - numero2));
Console.WriteLine("* : " + (numero1 * numero2));
Console.WriteLine("/ : " + (numero1 / numero2));

// Verificar se o segundo numero è diferente de zero antes de realizar a divisão 

if (numero2 != 0)
{
    Console.WriteLine("/ : " + (numero1 / numero2));
}
else
{
    Console.WriteLine("/ : DIVISÃÕ POR ZERO NÃO È PERMITIDA");
}

Console.WriteLine("Os numeros sãõ iguais? " + (numero1 == numero2));
Console.WriteLine("Numero1 émaior Numero2? " + (numero1 > numero2));
Console.WriteLine("Numero1 é menor Numero2?" + (numero1 < numero2));
Console.WriteLine("Numero1 é´maior igual Numero2? " + (numero1 > numero2));
Console.WriteLine("Numero1 é menor Numero2? " + (numero1 < numero2));

