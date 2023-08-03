//Curso IQS - Lógica de programação

// Exercicio 3
// Implemente um programa tomador de decisão que considera as seguintes opções para
// determinar se o usuário usará a fila preferencial ou a fila comum.
// O usuário usa a fila preferencial caso :
// ● Possui mais de 60 anos : Usa fila preferencial
// ● É deficiente físico : Usa fila preferencial
// ● É mulher gestante : Usa fila preferencial
// O programa recebe como entrada a Idade, Sexo e a condição especial do usuário,se houver.

int idade;
string sexo;
string condicao;

Console.Write("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("Digite sue sexo: ");
sexo = Console.ReadLine();
Console.WriteLine("");

Console.Write("Informe sua condição: ");
condicao = Console.ReadLine();
Console.WriteLine("");

if(idade > 65 || condicao == "gestante" && sexo == "feminino" || condicao == "deficiente"){
    Console.Write("Use a fila preferencial.");
} else {
    Console.Write("Use a fila comum.");
}
