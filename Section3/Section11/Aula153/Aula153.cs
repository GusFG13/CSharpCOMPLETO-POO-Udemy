using System;
using Section11.Aula153.Entities;

namespace Section11.Aula153
{
    internal class Aula153
    {
        //  Solução ruim

        //  Solução 2 (ruim): método retornando string
        //      - A semântica da operação é prejudicada
        //          - Retornar string não tem nada a ver com atualização de reserva
        //          - E se a operação tivesse que retornar um string?
        //      - Ainda não é possível tratar exceções em construtores
        //      - A lógica fica estruturada em condicionais aninhadas

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
        public static void Aula_153()
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

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                else
                { 
                    Console.WriteLine("Reservation: " + reservation);
                }
            }
        }
    }
}
