using System;
using System.Collections.Generic;
using System.Text;
using udemy_console_csharp_intermidle_exception.Entities;

namespace udemy_console_csharp_intermidle_exception.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }



        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Datad e Check Out não pode ser menor que a data de Check in");
            }


            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (CheckIn < now || CheckOut < now)
            {
                throw new DomainException("Data informada não pode ser menor que a data atual.");
            }

            if(checkOut <= checkIn)
            {
                throw new DomainException("Datad e Check Out não pode ser menor que a data de Check in");
            }


            CheckOut = checkOut;
            CheckIn = CheckIn;

        }

public void UpdateDatesOffRoladay(DateTime checkIn, DateTime checkOut,DateTime rolday)
        {
            DateTime now = DateTime.Now;

            if (CheckIn < rolday || CheckOut < rolday)
            {
                throw new DomainException("Data informada não pode ser menor que a data de feriado.");
            }

            if(checkOut <= checkIn)
            {
                throw new DomainException("Datad e Check Out não pode ser menor que a data de Check in");
            }


            CheckOut = checkOut;
            CheckIn = CheckIn;

        }

        

        public override string ToString()
        {
            return $"Reservation Data: Room numer: {RoomNumber} Check-In: {CheckIn} Check-Out: {CheckOut} ";
        }


    }
}
