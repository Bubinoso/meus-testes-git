Console.WriteLine("Qual o valor de A?");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor de B?");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor de C?");
double c = double.Parse(Console.ReadLine());

double delta = (b*b)-4*(a*c);
Console.WriteLine($"Delta é igual a {delta}");
if (delta >= 0)
{
    double etapa1 = (-b + Math.Sqrt(delta));
    double x1 = etapa1 / (2*a);
    double etapa2 = (-b - Math.Sqrt(delta));
    double x2 = etapa2 / (2*a);
    Console.WriteLine($"XI é igual a {x1} e XII é igual a {x2}");
}
else
{
    Console.WriteLine("Delta é negativo, a equação não possui ráizes reais");
}

