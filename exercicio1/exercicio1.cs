//Curso IQS - Lógica de programação

// Exercicio 1
// Faça um algoritmo que leia a entrada de um número inteiro fornecido pelo usuário e some 5
// caso seja par ou 8 caso seja ímpar, imprimir o resultado desta operação.

Console.WriteLine("Insira um valor:");
int entradaUsuario = Int32.Parse(Console.ReadLine());

if (entradaUsuario % 2 == 0)
{
    Console.WriteLine(entradaUsuario + " é par. Adicionando + 5 o resultado é: " + (entradaUsuario + 5));
}
else
{
    Console.WriteLine(entradaUsuario + " é impar. Adicionando + 8 o resultado é: " + (entradaUsuario + 8));
}