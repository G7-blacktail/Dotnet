using System;

class Aula12 {
    static void Main() {
        //condicional IF | Se
        int nota = 0;
        Console.Write("Digite o valor da nota do aluno: ");
        nota = int.Parse(Console.ReadLine());
        string resultado = "reprovado";

            if(nota >= 60) {
                resultado = "aprovado";
            } 

        Console.WriteLine("O aluno está {0}", resultado);

    }
}