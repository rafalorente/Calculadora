internal class Program
{
    private static void Main(string[] args)
    {
        Soma();
        Subtracao();
        Divisao();
        Multiplicacao();

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("---------- Opções ----------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Selecione uma opçõ: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma()
        {

            Console.Clear();

            Console.WriteLine("informe o primeiro numero");
            float n1 = float.Parse(Console.ReadLine());


            Console.WriteLine("informe o segundo numero");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 + n2;

            Console.WriteLine($"Soma: {resultado}");

            Console.ReadKey();

            Menu();

        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("informe o primeiro numero");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o segundo numero");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 - n2;

            Console.WriteLine($"Subtração: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("informe o primeiro numero");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o segundo numero");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 / n2;

            Console.WriteLine($"Divisão: {resultado}");

            Console.ReadKey();

            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("informe o primeiro numero");
            float n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o segundo numero");
            float n2 = float.Parse(Console.ReadLine());

            float resultado = n1 * n2;

            Console.WriteLine($"Multiplicação: {resultado}");

            Console.ReadKey();

            Menu();
        }
    }
}