using System;

namespace Exception
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public TimeSpan Duracao { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            this.RoomNumber = roomNumber;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
        }

        public int Duration()
        {
            Duracao = CheckOut.Subtract(CheckIn);
            return (int)Duracao.TotalDays;
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

        //public void UpdateDate(DateTime CeckIn, DateTime CheckOut)
        //{

        //}
    }
}
