using System;
using Section11.Aula154.Entities;
using Section11.Aula154.Entities.Exceptions;

namespace Section11.Aula154
{
    //  Solução boa
    //  Solução 3 (boa): Criando exceções personalizadas

    //  - Cláusula throw: lança a exceção / "corta" o método
    //  - O modelo de tratamento de exceções permite que erros sejam tratados de forma
    //    consistente e flexível, usando boas práticas
    //  - Vantagens:
    //      - Lógica delegada
    //      - Construtores podem ter exceções
    //      - Código mais simples. Não há aninhamento de condicionais: a qualquer momento que uma
    //        exceção for disparada, a execução é interrompida e cai no bloco catch correspondente.
    //      - É possível capturar inclusive outras exceções de sistema 

    /*
        Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
        de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
        dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
        novamente a reserva com os dados atualizados. O programa não deve aceitar dados
        inválidos para a reserva, conforme as seguintes regras:
        - Alterações de reserva só podem ocorrer para datas futuras
        - A data de saída deve ser maior que a data de entrada 

         +----------------------------------------------------+
         |                     Reservation                    |
         +----------------------------------------------------+
         | - roomNumber: integer                              |
         | - chekin: Date                                     |
         | - checkout: Date                                   |
         +----------------------------------------------------+
         | + duration(): integer                              |
         | + updateDates(checkin: Date, chockout: Date): void |
         +----------------------------------------------------+
 */
    internal class Aula154
    {
        public static void Aula_154()
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e) 
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
