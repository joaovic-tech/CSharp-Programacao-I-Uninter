using System;

namespace ConsoleApp.Pratica1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World - Aula Prática 1!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("       Tipos de dados");

            // char
            char letra = 'A';
            Console.WriteLine($"char letra = 'A'; // {letra}");

            // string
            string nome = "João";
            Console.WriteLine($"string nome = 'João' // {nome}");

            // int
            int int1 = 10;
            Console.WriteLine($"int int1 = 10; // {int1}");

            // Boolean
            bool bool1 = true;
            bool bool2 = false;
            Console.WriteLine($"bool bool1 = bool1; // {bool1}");
            Console.WriteLine($"bool bool2 = bool2; // {bool2}");

            // long
            long long1 = 65456456464654;
            Console.WriteLine($"long long1 = long1; // {long1}");

            // decimal
            decimal decimal1 = 123.234M;
            Console.WriteLine($"decimal decimal1 = decimal1; // {decimal1}");

            // float
            float float1 = 123.234f;
            Console.WriteLine($"float float1 = float1; // {float1}");


            Console.WriteLine("------------------------------");
            Console.WriteLine("       Tipos reference types");

            object obj1 = new object();
            var obj2 = new object();
            var obj3 = obj2;

            Console.WriteLine("Comparando objs");
            Console.WriteLine($"{obj1.GetType().Name} | {obj2.GetType().Name} | {obj3.GetType().Name}");
            Console.WriteLine($"{obj2 == obj3}");


            Console.WriteLine("------------------------------");
            Console.WriteLine("Inicializando strings por tipos");

            string s1 = new string('a', 5);
            string s2 = new string(new char[5] { 'a', 'a', 'a', 'a', 'a' });

            Console.WriteLine($"{s1 == s2}");

            string s3 = string.Concat((new char[5] { 'a', 'a', 'a', 'a', 'a' }).AsEnumerable());

            var s4 = $"{s3} string 3";

            Console.WriteLine($"{s4.ToString()}");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Comparando value types");

            ClasseCompareString compare1 = new ClasseCompareString()
            {
                testeComparacao = "123"
            };
            var compare2 = new ClasseCompareString()
            {
                testeComparacao = "123"
            };

            Console.WriteLine($"campare1 == compare 2 => {compare1 == compare2}");
            Console.WriteLine($"compare1.testeComparacao == compare2.testeComparacao => {compare1.testeComparacao == compare2.testeComparacao}");
            Console.WriteLine($"compare1.testeComparacao.Equals(compare2.testeComparacao) => {compare1.testeComparacao.Equals(compare2.testeComparacao)}");

            Console.WriteLine("------------------------------");

            ClasseComplexa classeComplexa = new ClasseComplexa();
            classeComplexa.PropInterface = "123";

            IImprimirValores interfaceX = classeComplexa;

            Console.WriteLine($"{interfaceX.PropInterface}"); // 30 minutos
        }
    }
}
