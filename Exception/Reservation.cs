using System;
using Exception.Exception;

namespace Exception
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public TimeSpan Duracao { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
                throw new DomainException("Erro na reserva. Data de saída deve ser maior à data de entrada!!!");

            this.RoomNumber = roomNumber;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duracao = CheckOut.Subtract(CheckIn);
            return (int)duracao.TotalDays;
        }

        public override string ToString()
        {
            return "Room " 
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }

        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (now > checkIn || now > checkOut)
                throw new DomainException("Erro na Reserva!! As datas devem ser posteriores à data atual.");

            if (checkOut <= checkIn)
                throw new DomainException("Erro na reserva. Data de saída deve ser maior à data de entrada!!!");

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
