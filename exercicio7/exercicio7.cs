//Curso IQS - Lógica de programação

// Exercicio 7
// Desenvolver uma calculadora simples que realiza os cálculos de Soma, Subtração,
// Multiplicação e Divisão. O programa deve ser capaz de receber dois números para o cálculo e 
// a operação escolhida pelo usuário. Obs: cada operação deve ter seu método próprio.

Console.WriteLine("Digite o nº da opereção que deseja realizar:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
int operacao = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o primeiro valor:");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o segundo valor:");
int valor2 = int.Parse(Console.ReadLine());

int resultado;

switch (operacao){
    case 1:
        resultado = valor1 + valor2 ;
        Console.WriteLine(valor1  + " + " + valor2 + " = " + resultado);
        break;
    case 2:
        resultado = valor1 - valor2 ;
        Console.WriteLine(valor1  + " - " + valor2 + " = " + resultado);
        break;
    case 3:
        resultado = valor1 * valor2 ;
        Console.WriteLine(valor1  + " X " + valor2 + " = " + resultado);
        break;
    case 4:
        resultado = valor1 / valor2 ;
        Console.WriteLine(valor1  + " / " + valor2 + " = " + resultado);
        break;
    
    default:
        Console.WriteLine("Você não seguiu os passos.");
        break;
}