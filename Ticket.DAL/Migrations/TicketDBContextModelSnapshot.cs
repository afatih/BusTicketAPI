﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ticket.DAL;

namespace Ticket.DAL.Migrations
{
    [DbContext(typeof(TicketDBContext))]
    partial class TicketDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ticket.Entity.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RowNumber");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = 1, Name = "İstanbul", RowNumber = 1 },
                        new { Id = 2, Name = "Ankara", RowNumber = 2 },
                        new { Id = 3, Name = "İzmir", RowNumber = 3 }
                    );
                });

            modelBuilder.Entity("Ticket.Entity.Entities.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("From");

                    b.Property<int>("Price");

                    b.Property<string>("Time");

                    b.Property<string>("To");

                    b.Property<int>("UserCount");

                    b.HasKey("Id");

                    b.ToTable("Tours");

                    b.HasData(
                        new { Id = 1, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 43 },
                        new { Id = 2, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "17:00", To = "Ankara", UserCount = 44 },
                        new { Id = 3, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "18:00", To = "Ankara", UserCount = 42 },
                        new { Id = 4, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "19:00", To = "Ankara", UserCount = 1 },
                        new { Id = 5, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "20:00", To = "Ankara", UserCount = 2 },
                        new { Id = 6, Date = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 7, Date = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "17:00", To = "Ankara", UserCount = 20 },
                        new { Id = 8, Date = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 9, Date = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 10, Date = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 11, Date = new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 12, Date = new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 13, Date = new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 14, Date = new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 15, Date = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 16, Date = new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 17, Date = new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 18, Date = new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 19, Date = new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 20, Date = new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 21, Date = new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 22, Date = new DateTime(2020, 1, 22, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 23, Date = new DateTime(2020, 1, 23, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 24, Date = new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 25, Date = new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 26, Date = new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 50, Time = "16:00", To = "Ankara", UserCount = 20 },
                        new { Id = 27, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 43 },
                        new { Id = 28, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "11:00", To = "İzmir", UserCount = 44 },
                        new { Id = 29, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "12:00", To = "İzmir", UserCount = 42 },
                        new { Id = 30, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "19:00", To = "İzmir", UserCount = 1 },
                        new { Id = 31, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "20:00", To = "İzmir", UserCount = 2 },
                        new { Id = 32, Date = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 33, Date = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "11:00", To = "İzmir", UserCount = 20 },
                        new { Id = 34, Date = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 35, Date = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 36, Date = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 37, Date = new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 38, Date = new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 39, Date = new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 40, Date = new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 41, Date = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 42, Date = new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 43, Date = new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 44, Date = new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 45, Date = new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 46, Date = new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 47, Date = new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 48, Date = new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 49, Date = new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 50, Date = new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 51, Date = new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 52, Date = new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), From = "İstanbul", Price = 30, Time = "10:00", To = "İzmir", UserCount = 20 },
                        new { Id = 53, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 43 },
                        new { Id = 54, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "15:00", To = "Ankara", UserCount = 44 },
                        new { Id = 55, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "16:00", To = "Ankara", UserCount = 42 },
                        new { Id = 56, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "17:00", To = "Ankara", UserCount = 1 },
                        new { Id = 57, Date = new DateTime(2020, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "18:00", To = "Ankara", UserCount = 2 },
                        new { Id = 58, Date = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 59, Date = new DateTime(2020, 1, 7, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "15:00", To = "Ankara", UserCount = 20 },
                        new { Id = 60, Date = new DateTime(2020, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 61, Date = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 62, Date = new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 63, Date = new DateTime(2020, 1, 11, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 64, Date = new DateTime(2020, 1, 12, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 65, Date = new DateTime(2020, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 66, Date = new DateTime(2020, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 67, Date = new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 68, Date = new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 69, Date = new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 70, Date = new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 71, Date = new DateTime(2020, 1, 19, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 72, Date = new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 73, Date = new DateTime(2020, 1, 21, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 74, Date = new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 75, Date = new DateTime(2020, 1, 17, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 76, Date = new DateTime(2020, 1, 18, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 77, Date = new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 78, Date = new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 },
                        new { Id = 79, Date = new DateTime(2020, 1, 27, 0, 0, 0, 0, DateTimeKind.Local), From = "İzmir", Price = 20, Time = "14:00", To = "Ankara", UserCount = 20 }
                    );
                });

            modelBuilder.Entity("Ticket.Entity.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("Surname");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ticket.Entity.Entities.UserKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivationKey");

                    b.Property<string>("Email");

                    b.HasKey("Id");

                    b.ToTable("UserKeys");
                });

            modelBuilder.Entity("Ticket.Entity.Entities.UserTour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TourId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserTours");
                });
#pragma warning restore 612, 618
        }
    }
}
