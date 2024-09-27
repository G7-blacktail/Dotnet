using System;

class Aula11 {
    static void Main() {
        // TypeCast

        // Implicito
        int n1 = 10;
        float n2 = n1;

        Console.WriteLine(n2);

        // Explicito

        float n3 = 10.5f;
        int n4 = (int) n3;

        Console.WriteLine(n2);

        int vInt = 10;
        short vShort = (short) vInt;

        Console.WriteLine(vShort);

    }
}