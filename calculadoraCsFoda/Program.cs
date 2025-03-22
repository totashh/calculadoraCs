namespace calculadora
{
    class Program
    {
        float num1;
        float num2;
        static void Main(string[] args)
        {
            while (true)
            {
                
                int escolha;

                Console.WriteLine("Calculadora");
                Console.WriteLine("Qual operação vamos fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                while (true)
                {
                    try
                    {
                        escolha = int.Parse(Console.ReadLine());
                        if (escolha < 1 || escolha > 4)
                        {
                            Console.WriteLine("Erro: Escolha um valor de 1 a 4!");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erro: Escolha um valor de 1 a 4!");
                    }
                }

                if (escolha == 1)
                {
                    Soma ();
                }
                else if (escolha == 2)
                {
                    subtracao();
                }
                else if (escolha == 3)
                {
                    multiplicacao();
                }
                else
                {
                    divisao();
                }
                Console.WriteLine("Deseja fazer outra conta? (sim/não)");
                string resposta = Console.ReadLine();
                if (resposta != "sim")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                }

            }
        }
        static void Soma()
        {
            float somaN1;
            float somaN2;
            Console.WriteLine("Soma!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            somaN1 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("digite seu outro número: ");
                        try
                        {
                            somaN2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    float soma = somaN1 + somaN2;
                    Console.WriteLine("resultado: " + soma);
                }
        static void subtracao()
        {
            float subN1;
            float subN2;

            Console.WriteLine("Subtração!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            subN1 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("digite seu outro número: ");
                        try
                        {
                            subN2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    float subtracao = subN1 - subN2;
                    Console.WriteLine("resultado: " + subtracao);
        }
        static void multiplicacao()
        {
            float multN1;
            float multN2;
            Console.WriteLine("Multiplicação!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            multN1 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Quer multiplicar por quantas vezes? ");
                        try
                        {
                            multN2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    float multiplicacao = multN1 * multN2;
                    Console.WriteLine("resultado: " + multiplicacao);
        }
        static void divisao()
        {
            float divN1;
            float divN2;
            Console.WriteLine("Divisão!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            divN1 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Quer dividir por qual número? ");
                        try
                        {
                            divN2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    if (divN2 != 0)
                    {
                        float divisao = divN1 / divN2;
                        Console.WriteLine("resultado: " + divisao);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero!");
                    }
        }
    }
}