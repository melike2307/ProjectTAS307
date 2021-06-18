using System;
using System.Collections.Generic;
using System.Text;

namespace se307project
{
    class Tours
    {
        private int id;
        private string name;
        private string startDate;
        private string finishDate;
        private string destinationPlace;
        private string departurePlace;
        private int tourCapacity;
        private string tourStatus;

        //Setters and Getters
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string FinishDate { get => finishDate; set => finishDate = value; }
        public string DestinationPlace { get => destinationPlace; set => destinationPlace = value; }
        public string DeparturePlace { get => departurePlace; set => departurePlace = value; }
        public int TourCapacity { get => tourCapacity; set => tourCapacity = value; }
        public string TourStatus { get => tourStatus; set => tourStatus = value; }

        //Parameterized Constructor
        public Tours(string name, int ıd, string startDate, string finishDate, string destinationPlace, string departurePlace, int tourCapacity, string tourStatus)
        {

            Name = name;
            Id = ıd;
            StartDate = startDate;
            FinishDate = finishDate;
            DestinationPlace = destinationPlace;
            DeparturePlace = departurePlace;
            TourCapacity = tourCapacity;
            TourStatus = tourStatus;
        }

        //Non-Parameterized Constructor
        public Tours() { }
    }
}
