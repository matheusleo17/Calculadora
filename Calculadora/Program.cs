using System;

class Calculadora
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("***______CALCULADORA_______***");

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Escolha a operação desejada: * + - / ");
            string op = Console.ReadLine();


            double resultado = 0;

            switch (op)
            {
                case "-":
                    resultado = num1 - num2;
                    break;
                case "+":
                    resultado = num1 + num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;

                    }
                    else
                    {
                        Console.WriteLine("A divisão não pode ser feita por zero.");
                    }
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;


            }
            Console.WriteLine($"Resultado: {resultado}");

            Console.WriteLine("Deseja continuar? (s/n)");
            string resposta = Console.ReadLine().ToLower();

            if (resposta != "s")
            {
                break;
            }
            Console.Clear(); 


        }
        Console.WriteLine("Calculadora encerrada!");

    }
}