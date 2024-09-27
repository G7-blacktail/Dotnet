using System;

class Aula18 {
    static void Main() {
        // Arrays (Matizes)
         int[,] valores = new int[3, 5]; // uma forma de declarar, iniciar e colocar valores
         /*
         * 10  20  30  40  50
         * 60  70  80  90  100
         * 110 120 130 140 150
         */

         valores[0, 0] = 10;
         valores[0, 1] = 20;
         valores[0, 2] = 30;
         valores[0, 3] = 40;
         valores[0, 4] = 50;

         valores[1, 0] = 60;
         valores[1, 1] = 70;
         valores[1, 2] = 80;
         valores[1, 3] = 90;
         valores[1, 4] = 100;

         valores[2, 0] = 110;
         valores[2, 1] = 120;
         valores[2, 2] = 130;
         valores[2, 3] = 140;
         valores[2, 4] = 150;


         Console.WriteLine(valores[2,1]);

        //  // Outra forma
         int[,] numeros = new int[2,2] {{55, 110},{220, 440}};

         Console.WriteLine(numeros[1,1]);

        // // outra forma
        //  int[] contas = {45, 37, 90, 85};

        //  Console.WriteLine(contas[3]);
    
    }
}