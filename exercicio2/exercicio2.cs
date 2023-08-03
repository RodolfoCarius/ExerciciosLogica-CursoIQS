//Curso IQS - Lógica de programação

// Exercicio 2
// Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem
// decrescente

int[] valores = new int[3];

Console.WriteLine("Insira um número inteiro");
valores[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insira outro número inteiro diferente");
valores[1] = Convert.ToInt32(Console.ReadLine());
while (valores[1] == valores[0])
{
    Console.WriteLine("Número já inserido! Insira outro número diferente");
    valores[1] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Insira outro número inteiro diferente");
valores[2] = Convert.ToInt32(Console.ReadLine());
while (valores[2] == valores[0] || valores[2] == valores[1])
{
    Console.WriteLine("Número já inserido! Insira outro número diferente");
    valores[2] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(" ");

Array.Sort(valores);
Array.Reverse(valores);

Console.WriteLine("Os números inseridos em ordem decrescente são:");
foreach (int valor in valores)
{
    Console.WriteLine(Convert.ToInt32(valor));
}