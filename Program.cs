using System.Drawing;

internal class Program
{

    private static void Main(string[] args)
    {
        Menu();
    }
    static void Soma()
    {
        float valor1;
        float valor2;

        Console.Clear();
        Console.WriteLine(" digite o primeiro valor");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" digite o segundo valor");
        valor2 = float.Parse(Console.ReadLine());
        float resultSoma = valor1 + valor2;
        Console.WriteLine($" o resultado da some é {resultSoma}");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {

        float valor1;
        float valor2;

        Console.Clear();
        Console.WriteLine(" digite o primeiro valor");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" digite o segundo valor");
        valor2 = float.Parse(Console.ReadLine());
        float resultSub = valor1 - valor2;
        Console.WriteLine($" o resultado da subtração é {resultSub}");
        Console.ReadKey();
        Menu();

    }
    static void Multiplicacao()
    {

        float valor1;
        float valor2;

        Console.Clear();
        Console.WriteLine(" digite o primeiro valor");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" digite o segundo valor");
        valor2 = float.Parse(Console.ReadLine());
        float resultMult = valor1 * valor2;
        Console.WriteLine($" o resultado da multipliação é {resultMult}");
        Console.ReadKey();
        Menu();

    }
    static void Divisao()
    {

        float valor1;
        float valor2;

        Console.Clear();
        Console.WriteLine(" digite o primeiro valor");
        valor1 = float.Parse(Console.ReadLine());
        Console.WriteLine(" digite o segundo valor");
        valor2 = float.Parse(Console.ReadLine());
        float resultDiv = valor1 / valor2;
        Console.WriteLine($" o resultado da divisão é {resultDiv}");
        Console.ReadKey();
        Menu();

    }
    static void Conversao()
    {
        Console.Clear();
        Console.WriteLine("selecione a unidade base");
        Console.WriteLine("1--Centimetros");
        Console.WriteLine("2--Metros");
        Console.WriteLine("3--Quilometros");
        Console.WriteLine("4--Voltar ao menu principal");
        int unidadeBase = int.Parse(Console.ReadLine());

        switch (unidadeBase)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("selecione para qual medida deseja converter");
                Console.WriteLine("1--Kilometros");
                Console.WriteLine("2--Metros");
                int medidaDeConversao = int.Parse(Console.ReadLine());

                if (medidaDeConversao == 1)
                {
                    Console.Clear();
                    Console.WriteLine("conversão centimetros(cm) para kilometros(km)");
                    Console.WriteLine("digite o valor em centimetros");
                    var valor1 = double.Parse(Console.ReadLine());
                    var valorconvet = valor1 * Math.Pow(10, -5);
                    Console.WriteLine($"{valor1}cm são {valorconvet}km");
                    Console.ReadKey();
                    Conversao();
                }
                else if (medidaDeConversao == 2)
                {
                    Console.Clear();
                    Console.WriteLine("conversão centimetros(cm) para Metros(M)");
                    Console.WriteLine("digite o valor em centimetros");
                    var valor2 = double.Parse(Console.ReadLine());
                    var valorconvet2 = valor2 * Math.Pow(10, -2);
                    Console.WriteLine($"{valor2}cm são {valorconvet2}M");
                    Console.ReadKey();
                    Conversao();

                }
                else
                {
                    Console.WriteLine("opção invalida");
                    Console.ReadKey();
                    Conversao();
                }
                break;


            case 2:

                Console.Clear();
                Console.WriteLine("selecione para qual medida deseja converter");
                Console.WriteLine("1--Quilometro");
                Console.WriteLine("2--Centimetros");
                int medidaDeConversao2 = int.Parse(Console.ReadLine());

                if (medidaDeConversao2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("conversão Metros(M) para Quilometros(km)");
                    Console.WriteLine("digite o valor em Metros");
                    var valor1 = double.Parse(Console.ReadLine());
                    var valorconvet = valor1 * Math.Pow(10, -3);
                    Console.WriteLine($"{valor1}M são {valorconvet}km");
                    Console.ReadKey();
                    Conversao();
                }

                else if (medidaDeConversao2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("conversão Metros(M) para Centimetros(cm)");
                    Console.WriteLine("digite o valor em Metros");
                    var valor1 = double.Parse(Console.ReadLine());
                    var valorconvet = valor1 * Math.Pow(10, 2);
                    Console.WriteLine($"{valor1}M são {valorconvet}cm");
                    Console.ReadKey();
                    Conversao();
                }
                else
                {
                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                    Conversao();

                }

                break;

            case 3:
                Console.Clear();
                Console.WriteLine("selecione para qual medida deseja converter");
                Console.WriteLine("1-Metros");
                Console.WriteLine("2--Centimetros");
                int medidaDeConversao3 = int.Parse(Console.ReadLine());

                if (medidaDeConversao3 == 1)
                {
                    Console.Clear();
                    Console.WriteLine("conversão Quilometros(Km) para Metros(M)");
                    Console.WriteLine("digite o valor em Quilometros");
                    var valor1 = double.Parse(Console.ReadLine());
                    var valorconvet = valor1 * Math.Pow(10, 3);
                    Console.WriteLine($"{valor1}Km são {valorconvet}M");
                    Console.ReadKey();
                    Conversao();
                }
                else if (medidaDeConversao3 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("conversão Quilometros(Km) para Centimetros(Cm)");
                    Console.WriteLine("digite o valor em Quilometros");
                    var valor1 = double.Parse(Console.ReadLine());
                    var valorconvet = valor1 * Math.Pow(10, 5);
                    Console.WriteLine($"{valor1}Km são {valorconvet}Cm");
                    Console.ReadKey();
                    Conversao();
                }
                else
                {
                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                    Conversao();
                }

                break;

            case 4:
                Menu();
                break;
            default:
                Conversao();
                break;

        }
    }
    static void Menu()
    {


        Console.Clear();
        int operacao;
        Console.WriteLine("digite o numero correspondente a função desejada");
        Console.WriteLine("1 = soma");
        Console.WriteLine("2 = subtração");
        Console.WriteLine("3 = multiplicação");
        Console.WriteLine("4 = divisão");
        Console.WriteLine("5 = converão da unidade de medida de metros");
        Console.WriteLine("6 = fechar programa");
        Console.WriteLine("======================================");
        operacao = int.Parse(Console.ReadLine());

        switch (operacao)
        {
            case 1:
                Soma();
                break;

            case 2:
                Subtracao();
                break;

            case 3:
                Multiplicacao();
                break;

            case 4:
                Divisao();
                break;
            case 5:
                Conversao();
                break;
            case 6:
                System.Environment.Exit(0);
                break;

            default:
                Menu();
                break;
        }
    }
}