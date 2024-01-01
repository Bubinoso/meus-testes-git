double maior = 0;
double menor = 0;
bool chave = true;

while (chave)
{
    Console.WriteLine("número: ");
    double numero = double.Parse(Console.ReadLine());

    if (numero > maior && numero > menor)
    {
        maior = numero;
    }
    else if (numero < maior)
    {
        menor = numero;
    }

    Console.WriteLine("Deseja continuar? Escreva S ou N");
    string resposta = Console.ReadLine();
    if (resposta == "N")
    {
        chave = false;
    }
}
Console.WriteLine($"O maior número foi: {maior}; e o menor: {menor}");
