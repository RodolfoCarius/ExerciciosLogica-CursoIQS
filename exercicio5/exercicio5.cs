//Curso IQS - Lógica de programação

// Exercicio 5
// Palavras palíndromos são aquelas que são lidas da direita para a esquerda da mesma
// maneira que da esquerda para a direita. Exemplo ARARA. Dado uma palavra, informar se ela
// é palíndroma ou não


Console.WriteLine("Insira uma palavra:");
string palavra = Console.ReadLine();

string palavraReversa = new string(palavra.Reverse().ToArray());

if(palavra == palavraReversa){
    Console.WriteLine("Você inseriu uma palavra palíndromo!");
}else{
    Console.WriteLine("Está palavra não é palíndromo!");
}
    Console.WriteLine(palavra);
    Console.WriteLine(palavraReversa);
    