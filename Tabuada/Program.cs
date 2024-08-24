int n1;

Console.WriteLine("Digite um numero: ");
try
{
    n1 = int.Parse(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(n1 + "x" + i + "=" + (n1*i));
    }
}
catch (Exception digitou_letra)
{
    Console.WriteLine("Voce digitou uma letra! ");
}
finally
{
    Console.WriteLine("Pressione uma tecla para sair. ");
    Console.ReadKey();
}