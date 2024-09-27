using System;

class Aula14 {

    static int nota1, nota2, nota3, nota4;
    static void Main() {
        // IF aninhado
        int count = 0;
        while(count < 4){
        Console.Write("Digite o valor da nota do aluno: ");
        nota1 = int.Parse(Console.ReadLine());
        count++;
        Console.Write("Digite o valor da nota do aluno: ");
        nota2 = int.Parse(Console.ReadLine());
        count++;
        Console.Write("Digite o valor da nota do aluno: ");
        nota3 = int.Parse(Console.ReadLine());
        count++;
        Console.Write("Digite o valor da nota do aluno: ");
        nota4 = int.Parse(Console.ReadLine());
        count++;

        }

        float notas = (float) (nota1 + nota2 + nota3 + nota4) / 4;
        string resultado = "";

        if(notas >= 60) {
            if(notas >= 90) {
                if(notas == 100) {
                    resultado = "aprovado com nota máxima";
                } else {
                resultado = "aprovado com louvor";
                }
            } else {
                resultado = "aprovado";
            }
        } else {
            if(notas >= 40) {
                resultado = "recuperação";
            } else {
            resultado = "reprovado";
            }
        }

        Console.WriteLine("Média {0:f}", notas);
        Console.WriteLine("O aluno está {0}", resultado);

    }
}