using System;
using Section11.Aula152.Entities;

namespace Section11.Aula152
{
    internal class Aula152
    {
        //  Solução muito ruim

        //  Solução 1 (muito ruim): lógica de validação no programa principal
        //      - Lógica de validação não delegada à reserva

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
        public static void Aula_152()
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservation: Check-out date must be after check-in date");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
            
        }
    }
}
