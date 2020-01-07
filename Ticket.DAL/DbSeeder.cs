using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ticket.Entity.Entities;

namespace Ticket.DAL
{
    public static class DbSeeder
    {
        public static void SeedDb(TicketDBContext context)
        {
            Seed(context);

        }


        private static void Seed(TicketDBContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cities.Count() == 0)
            {
                context.Cities.Add(new City { Name = "İstanbul", RowNumber = 1 });
                context.Cities.Add(new City { Name = "Ankara", RowNumber = 2 });
                context.Cities.Add(new City { Name = "İzmir", RowNumber = 3 });

                context.SaveChanges();
            }

            if (context.Tours.Count() == 0)
            {
                #region Eklenecek tur verileri
                context.Tours.Add(new Tour() { RowNumber = 1, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 2, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 3, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 4, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 5, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 6, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 7, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 8, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 9, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 10, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 11, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 12, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 13, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 14, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 15, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 16, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 17, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 18, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 19, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 20, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 21, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 22, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 23, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 24, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 25, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 26, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 27, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 28, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 29, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 30, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 31, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 32, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 33, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 34, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 35, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 36, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 37, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 38, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 39, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 40, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 41, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 42, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 43, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 44, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 45, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 46, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 47, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 48, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 49, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 50, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 51, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(10), Price = 50, UserCount = 43, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 52, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(10), Price = 50, UserCount = 44, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 53, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(10), Price = 50, UserCount = 42, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 54, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(10), Price = 50, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 55, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(10), Price = 50, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 56, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(11), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 57, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(12), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 58, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(13), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 59, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(14), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 60, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(15), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 61, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(16), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 62, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(17), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 63, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(18), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 64, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(19), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 65, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(20), Price = 30, UserCount = 20, Time = "10:00" });

                context.Tours.Add(new Tour() { RowNumber = 1, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 43, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 2, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 44, Time = "11:00" });
                context.Tours.Add(new Tour() { RowNumber = 3, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 42, Time = "12:00" });
                context.Tours.Add(new Tour() { RowNumber = 4, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 1, Time = "19:00" });
                context.Tours.Add(new Tour() { RowNumber = 5, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 2, Time = "20:00" });
                context.Tours.Add(new Tour() { RowNumber = 6, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(1), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 7, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(1), Price = 30, UserCount = 20, Time = "11:00" });
                context.Tours.Add(new Tour() { RowNumber = 8, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(2), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 9, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(3), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 10, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(4), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 11, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(5), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 12, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(6), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 13, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(7), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 14, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(8), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 15, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(9), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 16, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(10), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 17, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(11), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 18, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(12), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 19, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(13), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 20, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(14), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 21, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(15), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 22, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(16), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 23, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(17), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 24, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(18), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 25, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(19), Price = 30, UserCount = 20, Time = "10:00" });
                context.Tours.Add(new Tour() { RowNumber = 26, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(20), Price = 30, UserCount = 20, Time = "10:00" });

                context.Tours.Add(new Tour() { RowNumber = 1, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 43, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 2, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 44, Time = "15:00" });
                context.Tours.Add(new Tour() { RowNumber = 3, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 42, Time = "16:00" });
                context.Tours.Add(new Tour() { RowNumber = 4, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 1, Time = "17:00" });
                context.Tours.Add(new Tour() { RowNumber = 5, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 2, Time = "18:00" });
                context.Tours.Add(new Tour() { RowNumber = 6, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 7, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 20, UserCount = 20, Time = "15:00" });
                context.Tours.Add(new Tour() { RowNumber = 8, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 9, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 10, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 11, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 12, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 13, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 14, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 15, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 16, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(10), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 17, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(11), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 18, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(12), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 19, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(13), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 20, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(14), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 21, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(15), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 22, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(16), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 23, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(17), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 24, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(18), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 25, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(19), Price = 20, UserCount = 20, Time = "14:00" });
                context.Tours.Add(new Tour() { RowNumber = 26, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(20), Price = 20, UserCount = 20, Time = "14:00" });
                #endregion


                context.SaveChanges();
            }
        }

        //id ile ekelmek gerekirse bu kısım kullanılabilir.

        //private static void AddTour(TicketDBContext context, Tour tour)
        //{
        //    var existingTour = context.Tours.FirstOrDefault(x => x.Id == tour.Id);
        //    if (existingTour == null)
        //    {
        //        context.Tours.Add(tour);
        //    }
        //}

        //private static void AddCity(TicketDBContext context, City city)
        //{
        //    var existingCity = context.Cities.FirstOrDefault(x => x.Id == city.Id);
        //    if (existingCity == null)
        //    {
        //        context.Cities.Add(city);
        //    }
        //}
    }
}
