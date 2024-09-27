using System;

class Aula10 {

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main() {
        //ENUM | Enumeradores

        // DiasSemana ds = DiasSemana.Domingo;
        // DiasSemana ds = (DiasSemana)3; // Fazendo cast para encontrar o indice do Enum

        int ds = (int) DiasSemana.Sexta;

        Console.WriteLine(ds);
    }
}