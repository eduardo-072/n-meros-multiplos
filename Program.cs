Console.WriteLine("---NÚMEROS MULTIPLOS---\n");

Console.Write("DIGITE UM NÚMERO.....:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("VERIFICAR SE O NÚMERO É MULTIPLO DE.....:");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 % n2 == 0)
{
    Console.WriteLine($"\n{n1} é multiplo de {n2}");
}
else
{
    Console.WriteLine($"\n{n1} não é multiplo de {n2}");

}