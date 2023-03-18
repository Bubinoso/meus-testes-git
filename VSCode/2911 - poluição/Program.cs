Console.WriteLine("Qual o nível de poluição?: ");
double poluicao = double.Parse(Console.ReadLine());

if(poluicao >= 0.5)
{
    Console.WriteLine("Os 3 grupos de indústria devem parar");
}
else if (poluicao >= 0.4)
{
    Console.WriteLine("2 grupos de indústria devem parar");
}
else if (poluicao >= 0.3)
{
    Console.WriteLine("Um grupo de indústria deve parar");
}
else 
{
    Console.WriteLine("A poluição está dentro do nível suportado");
}
