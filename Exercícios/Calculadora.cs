using System;
using System.Collections.Generic;

namespace ControleDeVersaoComGit.Exercicios
{
    class Calculadora
    {
        public static void Executar()
        {   
            int num1;
            int num2;

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 ==> Somar");
            Console.WriteLine("2 ==> Subtrair");
            Console.WriteLine("3 ==> Multiplicar");
            Console.WriteLine("4 ==> Dividir");
            Console.WriteLine("0 ==> Sair");
            int.TryParse(Console.ReadLine(), out int menu);

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                Console.WriteLine($"Seu resultado é: " + (num1 + num2));
                break;

                case 2:
                Console.WriteLine($"Seu resultado é: " + (num1 - num2));
                break;

                case 3:
                Console.WriteLine($"Seu resultado é: " + (num1 * num2));
                break;

                case 4:
                Console.WriteLine($"Seu resultado é: " + (num1 / num2));
                break;

                case 0:
                Console.WriteLine("Pressione Enter para finalizar.");
                Console.ReadKey();
                break;
            }
            
        }
    }
}