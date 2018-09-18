﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebHotel.Models
{
    public class Booking
    {
        public int ID { get; set; }
        public int RoomID { get; set; }
        public string CustomerEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }

        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }

        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        public ICollection<Room> TheRoom { get; set; }
        public ICollection<Customer> TheCustomer { get; set; }

    }
}
