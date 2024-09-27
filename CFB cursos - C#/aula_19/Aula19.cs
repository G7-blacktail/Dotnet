using System;

class Aula19 {
    static void Main() {
        // LOOP FOR (Para)
        for(int i = 0; i < 10; i++) {
            Console.WriteLine((i+1) + " CFB Cursos");
        }

        // usando com vetor
        int[] num = new int[10];

        for(int i = 0; i < num.Length; i++) {
            num[i] = 0;
            Console.Write("[{0}] ",num[i]);
        }

    }
}