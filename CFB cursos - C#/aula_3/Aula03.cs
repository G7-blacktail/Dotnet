using System;

    class Aula03
    {
        static void Main()
        {

            /* Tipos de variaveis
            *  Tipo não primitivo
            */ 
            string nome = "Gustavo";
            int numero = 0;
            char caracter = 'I';
            float flutuante = 1.6f;

            byte b = 10; // 0 ~ 255
            var aux = nome;

            // declarando várias variáveis ao mesmo tempo (é necessário que todas sejam do mesmo tipo)
            int num1, num2, res;

            num1= 10;
            num2 = 2;
            res= num1 * num2;


            Console.WriteLine("Nome do usário: " + aux + " !");
            Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + res);
        }
    }