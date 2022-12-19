using System;

namespace Section6
{
    internal class Aula71
    {
        // Exercício de fixação (vetores)
        public static void Aula_71()
        {
            int numEstudantes;
            int quarto;
            const int numQuartos = 10;
            string nome;
            string email;
            Inquilinos[] quartos = new Inquilinos[numQuartos];

            Console.Write("Digite o número de estudantes que irão alugar quartos: ");
            numEstudantes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numEstudantes; i++)
            {
                Console.WriteLine($"\nAluguel #{i + 1}");
                Console.Write($"Nome: ");
                nome = Console.ReadLine();
                Console.Write($"E-mail: ");
                email = Console.ReadLine();
                Console.Write($"Quarto (entre 0 e {numQuartos - 1}): ");
                quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Inquilinos { Nome = nome, Email = email };
            }

            Console.WriteLine("\nQuartos ocupados:");
            for (int i = 0; i < numQuartos; i++)
            {
                if (quartos[i] != null)
                    Console.WriteLine($"{i}: {quartos[i].ToString()}");
            }

        }
    }
}
