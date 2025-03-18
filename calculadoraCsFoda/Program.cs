namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float num1;
                float num2;
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
                    Console.WriteLine("Soma!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            num1 = float.Parse(Console.ReadLine());
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
                            num2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    float soma = num1 + num2;
                    Console.WriteLine("resultado: " + soma);
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Subtração!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            num1 = float.Parse(Console.ReadLine());
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
                            num2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    float subtracao = num1 - num2;
                    Console.WriteLine("resultado: " + subtracao);
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Multiplicação!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            num1 = float.Parse(Console.ReadLine());
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
                            num2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    float multiplicacao = num1 * num2;
                    Console.WriteLine("resultado: " + multiplicacao);
                }
                else
                {
                    Console.WriteLine("Divisão!");
                    while (true)
                    {
                        Console.WriteLine("Escreva seu número: ");
                        try
                        {
                            num1 = float.Parse(Console.ReadLine());
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
                            num2 = float.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Erro: Digite um número válido!");
                        }
                    }
                    if (num2 != 0)
                    {
                        float divisao = num1 / num2;
                        Console.WriteLine("resultado: " + divisao);
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero!");
                    }

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
    }
}