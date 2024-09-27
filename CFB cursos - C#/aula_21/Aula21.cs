using System;

class Aula21 {
    static void Main() {
        //DO While (faça quando)
        // int num = 5;
        // do {
        //     Console.WriteLine("Fazer a base é necessário para avançar com concistência");
        // } while (num < 5);
        // Exemplo básico finalizado aqui

        string senha = "123";
        string senhauser;
        int tentativas = 0;

        do {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhauser = Console.ReadLine();
            tentativas++;
        } while(senha != senhauser);

        Console.WriteLine("Senha Correta!");
        Console.WriteLine("Número de tentativas: {0}", tentativas);

    }
}