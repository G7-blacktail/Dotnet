using System;

class Aula16 {
    static void Main() {
        //GOTO 
        int tempo = 0;
        char escolha;
        string transporte = "";

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG à Vitória/ES");
        Console.WriteLine("Escolha o transporte: [a]= Avião | [c]=Carro | [o]=Ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha) {
            case 'a':
            case 'A':
                tempo = 50;
                transporte = "Avião";
                break;
            case 'c':
            case 'C':
                tempo = 480;
                transporte = "Carro";
                break;
            case 'o':
            case 'O':
                tempo = 660;
                transporte = "Ônibus";
                break;
            default:
                tempo=-1;
                break;
        }

        if( tempo < 0) {
            Console.WriteLine("Escolha inválida");
        } else {
        Console.WriteLine("O usuário irá de {0} e o tempo de viagem será {1} minutos", transporte, tempo);
        }

        Console.Write("\nCalcular outro transporte? [s/n]: ");
        escolha=char.Parse(Console.ReadLine());
        if(escolha == 's' || escolha== 'S') {
            goto inicio;
        } else {
            Console.Clear();
            Console.WriteLine("Fim do programa!");
        }
    }
}