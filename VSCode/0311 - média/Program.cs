double numero = 0;
for(int i=0;i<4;i++)
{
    Console.WriteLine("Digite a nota: ");
    double n = double.Parse(Console.ReadLine());
    numero = n + numero;

}
Console.WriteLine($"A média é: {numero/4}");