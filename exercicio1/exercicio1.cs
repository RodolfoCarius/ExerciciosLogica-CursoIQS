//Curso IQS - Lógica de programação

// Exercicio 1
// Faça um algoritmo que leia a entrada de um número inteiro fornecido pelo usuário e some 5
// caso seja par ou 8 caso seja ímpar, imprimir o resultado desta operação.

internal class Program
{
    public static void Main(string[] args)
{
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
}
    }

//Exercicio 2

    // int valor1 = 2;
    // int valor2 = 5;
    // int valor3 = 1;

    // static int decrescente(int n1, int n2, int n3){
    //     if(n1 != n2 && n1 != n3 && n2 != n3){
    //         Console.WriteLine(OrderByDescending);
    //     IE
    //     }
        
    //     return n1;
    // }
    
    // decrescente(valor1, valor2, valor3);

    // int[] valores = new int[3];

    // IEnumerable<int> query = from valor in valores
    //                         orderby valor descending
    //                         select valor; 
    // foreach (int val in query)
    // Console.WriteLine(val);


