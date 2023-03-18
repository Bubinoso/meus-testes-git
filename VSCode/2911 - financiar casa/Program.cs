Console.WriteLine("Qual será o valor da casa?");
double casa = double.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu salário?");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Por quantos anos irá pagar?");
double anos = double.Parse(Console.ReadLine());

double meses = anos * 12;
double por_mes = casa / meses;
double Por = salario * 0.30;

if (por_mes > Por)
{
    Console.WriteLine("Empréstimo não aprovado");
}
else
{
    Console.WriteLine("Empréstimo aprovado");
}
