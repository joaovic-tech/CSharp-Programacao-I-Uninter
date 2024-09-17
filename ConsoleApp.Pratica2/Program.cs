using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Pratica2;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        PraticaComArrays pratica = new();
        // PraticaComArrays.Exercicio1();
        // PraticaComArrays.Exercicio2();

        PraticaComFilasBoxing praticaComFilasBoxing = new PraticaComFilasBoxing();
        praticaComFilasBoxing.ExercicioBoxingfilas();
    }
}
