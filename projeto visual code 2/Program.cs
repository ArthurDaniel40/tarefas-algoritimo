/*using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

void mensagem(){
    Console.WriteLine("ola ser vivo");
}
mensagem();

void escreva(string msg){
    Console.WriteLine(msg);
}
escreva("ola ser vivo... oque se ta fazendo aqui seu desoculpado!!!");
string mano = "meu mano!!!!!!!!!!!!!!!!!";
escreva($"{mano}");
void mostraridade(string nome, int idade)
{
escreva($"{nome} tem {idade} anos");
}
mostraridade("fulano", 16);
void calcularIdade(string nome, int ano)
{
    int idade = 2024 - ano;
    mostraridade(nome,idade);
}
Console.WriteLine("mano que ano tu nasceu mam");
int ano = int.Parse(Console.ReadLine());
calcularIdade("tu", ano);
int maiorEntre(int a, int b)
{
if (a > b){
    return a;
}
else{
    return b;
}
}
Console.WriteLine("escreve ai dois numeros mano, vou diser qual é o maior");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
Console.WriteLine(maiorEntre(x,y));
//exemplo de repetipção

float resutado;
resutado = (100 + 50) / 2f;
Console.WriteLine("a media é: " + resutado);
resutado = (2 + 567) / 2f;
Console.WriteLine("a media é: " + resutado);
resutado = (100 + 10) / 2f;
Console.WriteLine("a media é: " + resutado);
//exemplo de impedir repetição
void caucularmedia(int a, int b)
{
    float resutado = (a+b)/2f;
    Console.WriteLine("a media é: " + resutado);
}
caucularmedia(100,50);
float a;
float b;
void digitarAeB()
{
    Console.WriteLine("escrava o primeiro numero");
    float a = float.Parse (Console.ReadLine());
    Console.WriteLine("escrava o segundo numero");
    float b = float.Parse (Console.ReadLine());
}

*/
void soma(float a, float b){
    float resutado = a + b;
    Console.WriteLine($"a soma de {a} + {b} = {resutado} e tupara de usar cauculadora mané tem papel pra isso!");
}
void mutiplicacao(float a, float b){
    float resutado = a * b;
    Console.WriteLine($"a multiplicação de {a} x {b} = {resutado} e tu para de usar cauculadora mané tem papel pra isso!");
}
void divisao(float a, float b){
    float resutado = a / b;
    Console.WriteLine($"a divisao de {a} / {b} = {resutado} e tu para de usar cauculadora mané tem papel pra isso!");
    if(b == 0){
        Console.WriteLine("divissão por zero é impossivel menor!!!!");
        return;
    }
}
void subtração(float a, float b){
    float resutado = a - b;
    Console.WriteLine($"a diminuiçao de {a} - {b} = {resutado} e tu para de usar cauculadora mané tem papel pra isso!");

}
//menu
float a;
float b;
void digitarAeB(string v)
{
Console.WriteLine($"{v}");
    Console.WriteLine("escrava o primeiro numero");
    a = float.Parse (Console.ReadLine());
    Console.WriteLine("escrava o segundo numero");
    b = float.Parse (Console.ReadLine());
}
Console.WriteLine(" ------------------= CAUCULADORA =---------------------");
Console.WriteLine(" 1 = soma diferente de você num grupo                  ]");
Console.WriteLine(" 2 = subtração como quando você tenta somar em um grupo]");
Console.WriteLine(" 3 = mutiplicação como você nasceu                     ]");
Console.WriteLine(" 4 = divisão como teu amigo faz com você e sua namorada]");
Console.WriteLine(" 5 = sair igual seu pai saiu quando tu naceu           ]");
Console.WriteLine(" -------------------------------------------------------");
Console.WriteLine(" Digite o numero da sua opção");
int opcao = int.Parse(Console.ReadLine());
if(opcao == 1){
    digitarAeB("soma");
    soma(a,b);
}
else if(opcao == 2){
digitarAeB("subtração");
subtração(a, b);
}
else if(opcao == 3){
    digitarAeB("mutiplicação");
    mutiplicacao(a,b);
}
else if(opcao == 4){
    digitarAeB("divisao");
    divisao(a,b);
}