using System;

class Aula09 {
    static void Main() {
        int num = 2; // bits: 00000010

        // ISto é um bitwise forma de dobrar ou diminuir um valor
        num=num<<2; 

        Console.WriteLine(num); // bits : 00001000
    }
}