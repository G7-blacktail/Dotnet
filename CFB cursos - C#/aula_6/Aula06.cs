using System;

class Aula06 {
    
    static void Main() {
        // int n1, n2,n3;

        // n1=10; n2=20; n3=30;

        // Console.Write("n1=\t{0}, \nn2=\t{1}, \nn3=\t{2}.\n",n1, n2, n3); // Usando caracteres de scapes

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Macarrão";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto....: {0,15}", produto);
        Console.WriteLine("Compra.....: {0,15:c}", valorCompra);
        Console.WriteLine("Lucro......: {0,15:p}", lucro);
        Console.WriteLine("Venda......: {0,15:c}", valorVenda);
    }
}