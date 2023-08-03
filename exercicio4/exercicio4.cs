//Curso IQS - Lógica de programação

// Exercicio 4
//Elabore um algoritmo que leia o peso e a altura de um adulto e mostre seu IMC

double peso;
double altura;
double imc;

Console.Write("Digite seu peso: ");
peso = double.Parse(Console.ReadLine());
Console.WriteLine(" ");

Console.Write("Digite sua altura(Ex: 1,70): ");
altura = double.Parse(Console.ReadLine());
Console.WriteLine(" ");

imc = peso/(altura * altura);

if(imc < 18.5){
    Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " - Você está abaixo do peso.");
} else if (imc >= 18.5 && imc <= 25){
    Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " - Você está com o peso normal.");
} else if (imc > 25 && imc <= 30){
    Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " - Você está acima do peso.");
} else {
    Console.WriteLine("Seu IMC é: " + Math.Round(imc, 2) + " - Você está com obesidade.");
}