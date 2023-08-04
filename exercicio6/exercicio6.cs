//Curso IQS - Lógica de programação

// Exercicio 6
// Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada
// de N. Mostre a tabuada:

Console.WriteLine("Insira um número:");
int number = int.Parse(Console.ReadLine());

for(int i = 0; i <= 10; i++){
    Console.WriteLine(number + " X " + i + " = " + (i * number));
}