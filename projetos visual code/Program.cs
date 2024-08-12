using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

Console.WriteLine("iniciando...");
bool jogoRodado = true;

while(jogoRodado){
bool resposta1(){
    iniciarPergunta:
        string Resposta = Console.ReadLine();
        if (Resposta == "s"){
        return true;
    }
    else if(Resposta == "n"){
        return false;

    }
    else{
        Console.WriteLine("não pode escrever outra coisa que não seja s ou n");
        goto iniciarPergunta;
    }

}


Console.WriteLine("ei man eu vou pensar em um numero e tu tenta adivinhar o numero");
Console.WriteLine(" dis s se quizer jogar e n se não quizer");
if(resposta1() == false){
    goto FinalJogo;
}

iniciojogo:

int menor = 0;
int maior = 100;
int tentativas = 10;
bool jogorodado = true;

Random rand = new Random();
int sorteado = rand.Next(menor, maior + 1);
Console.WriteLine($"pensei em um numero rapá ele é entre {menor} e {maior}. tenta adivinha e se ganha 1 REAL");
while(jogorodado){
    Console.WriteLine($"tentativa {tentativas}:");
    int numdigitado = int.Parse(Console.ReadLine());
    if(numdigitado < sorteado){
        Console.Write("errado para baixo");
        tentativas--;
    }
    else if(numdigitado > sorteado){
        Console.WriteLine("ERRO para cima");
        tentativas--;
    }
    else{
        Console.WriteLine("que isso? toma teu um real aqui logo!");
        jogorodado = false;
    }
    if(tentativas > 0){
        Console.WriteLine("tenta denovo mano");
    }
    else{
        Console.WriteLine("acabou meano!!! me da meu 1 real ai hahahah");
        jogorodado = false;
    }
}
Console.WriteLine("quer jogar denovo? sim/não");
if(resposta1() == true){
    goto iniciojogo;
}
}

bool Resposta()
{
    throw new NotImplementedException();
}

FinalJogo:
Console.WriteLine("finalisando...");