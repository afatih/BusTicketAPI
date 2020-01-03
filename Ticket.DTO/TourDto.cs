using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket.DTO
{
    public class TourDto
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int UserCount { get; set; }
        public string Time { get; set; }
        public bool IsAvailable
        {
            get
            {
                return UserCount >= 44 ? false : true;
            }
        }
        public string buttonText
        {

            get
            {
                return UserCount >= 44 ? "Dolu" : "Seç";
            }
        }


    }
}
