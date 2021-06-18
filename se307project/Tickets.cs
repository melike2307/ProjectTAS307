using System;
using System.Collections.Generic;
using System.Text;

namespace se307project
{
    class Tickets
    {
        private int ticketID;
        private int tourID;
        private string status;
        private double price;

        //Setters and Getters
        public int TicketID { get => ticketID; set => ticketID = value; }
        public int TourID { get => tourID; set => tourID = value; }
        public string Status { get => status; set => status = value; }
        public double Price { get => price; set => price = value; }

        //Parameterized Constructor
        public Tickets(int ticketID, int tourID, string status, double price)
        {
            TicketID = ticketID;
            TourID = tourID;
            Status = status;
            Price = price;
        }

        //Non-Parameterized Constructor
        public Tickets() { }
    }
}
