
int n1;
int tabuada = 1;
int resultado;

Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("\n");

if (n1 > 0)
{
   for (int i = 1; i <= 10;  i++)
    {
        tabuada = i;
        resultado = n1 * tabuada;
        Console.WriteLine("{0} X {1} = {2} ", n1, tabuada, resultado);

    }

}

else 
{
    Console.WriteLine("Número inválido. Digite números positivos inteiros.");
}
