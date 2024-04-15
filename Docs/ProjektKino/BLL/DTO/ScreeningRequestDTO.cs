﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ScreeningRequestDTO
    {
        public int HallID { get; set; }
        public int MovieID { get; set; }
        public DateTime Date { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}