Console.WriteLine("Qual o código do pedido?");
int codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Quantos vai querer?");
int quant = int.Parse(Console.ReadLine());

float total = 0;

while(codigo!=100 && codigo!=101 && codigo!=102 && codigo!=103 && codigo!=104 && codigo!=105)
{
    Console.WriteLine("Código fora do cardápio, digite o código do item: ");   
    codigo = int.Parse(Console.ReadLine());
}
if (codigo == 100)
{
    total = 1.20f*quant;
    Console.WriteLine($"O valor a pagar será R${total}");
}
else if (codigo == 101)
{
    total = 1.30f*quant;
    Console.WriteLine($"O valor a pagar será R${total}");
}
else if (codigo == 102)
{
    total = 1.50f*quant;
    Console.WriteLine($"O valor a pagar será R${total}");
}
else if (codigo == 103)
{
    total = 1.20f*quant;
    Console.WriteLine($"O valor a pagar será R${total}");
}
else if (codigo == 104)
{
    total = 1.30f*quant;
    Console.WriteLine($"O valor a pagar será R${total}");
}
else if (codigo == 105)
{
    total = 1*quant;
    Console.WriteLine($"O valor a pagar será R${total}");
}

