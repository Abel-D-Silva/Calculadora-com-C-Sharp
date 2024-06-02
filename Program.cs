using System.ComponentModel.Design;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        //Menu();
        Tabuada();

    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Dividir");
        Console.WriteLine("4 - Multiplicar");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("----------------------------");
        Console.WriteLine("Selecione uma opção: ");
        short res = short.Parse(Console.ReadLine());

        switch (res)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicar(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;

        }


    }
    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Primeiro Valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Segundo Valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        float resultado = valor1 + valor2;


        //Console.WriteLine(valor1);
        //Console.WriteLine(valor2);

        //Console.WriteLine("O resultado da soma é: " + resultado);
        Console.WriteLine($"O resultado é {resultado}");
        //Console.WriteLine($"O resultado foi {valor1 + valor2} ");
        //Console.WriteLine("O novo resultado é: " + (valor1 + valor2));

        Console.ReadKey();
        Menu();

    }
    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = valor1 - valor2;

        Console.WriteLine($"Valor da subtração é: {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Escolha um valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Escola o segundo valor: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = valor1 / valor2;

        Console.WriteLine($"Valor da divisão é: {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicar()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valo: ");
        float valor2 = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        float resultado = valor1 * valor2;

        Console.WriteLine($"Valor da multiplicação é: {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Tabuada()
    {
        Console.Clear();
        Console.WriteLine("Escolha o número da tabuada: ");
        float numTabuada = float.Parse(Console.ReadLine());
        Console.WriteLine("");

        for (int i = 1; i <= 10; i++)
        {
            float resultado = numTabuada * i;
            Console.WriteLine($"{numTabuada} x {i} = {resultado}");
        }



    }


}
