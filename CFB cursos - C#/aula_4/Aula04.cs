using System;

    class Aula04
    {

        // Desta forma a variavél se torna global visivél para todos os metodos porém nenhuma outra pode ter o mesmo nome dessa. 
        // int num = 10;
        // Também deve ser declarada como static pois é uma variavél estática.
        static int num = 10;

        static void Main()
        {
            int num2 = 0; // atribuir assim a variavél permanece LOCAL apenas visivél ao seu metodo
            // acessando a variavél global
            Console.WriteLine(num);
        }

        // void Test()
        // {
        //    // int num3 = 0;
        //     Console.Write(num);
        // }
    }