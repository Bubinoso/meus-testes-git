Console.WriteLine("Qual o seu peso em quilos?: ");
float peso = float.Parse(Console.ReadLine());
Console.WriteLine("Qual sua altura?: ");
float altura = float.Parse(Console.ReadLine());

float imc = peso / (altura * altura);
string estado = "";

if (imc <= 18.5)
{
    estado = "magreza";
}
else if (imc <= 24.9)
{
    estado = "normal";
}
else if (imc <= 29.9)
{
    estado = "sobrepeso";
}
else if (imc <= 39.9)
{
    estado = "obesidade";
}
else
{
    estado = "obesidade grave";
}

Console.WriteLine($"O seu IMC é {imc.ToString("N2")} kg/m² e o seu estado é: {estado}.");
