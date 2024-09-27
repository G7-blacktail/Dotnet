using System;

class Aula17 {
    static void Main() {
        // Arrays (VETOR)
         int[] valores = new int[5]; // uma forma de declarar, iniciar e colocar valores

         valores[0] = 15;
         valores[1] = 30;
         valores[2] = 60;
         valores[3] = 120;
         valores[4] = 240;

         Console.WriteLine(valores[0]);

         // Outra forma
         int[] numeros = new int[3] {55, 110, 220};

         Console.WriteLine(numeros[2]);

        // outra forma
         int[] contas = {45, 37, 90, 85};

         Console.WriteLine(contas[3]);
    }
}