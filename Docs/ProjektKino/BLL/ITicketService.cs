﻿using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ITicketService
    {
        TicketResponseDTO GetTicket(int id);
        IEnumerable<SeatResponseDTO> GetSeats(int id);
        void DeleteTicket(int id);
        void PutTicket(int id, TicketRequestDTO ticketRequestDTO);
        void PostTicket(TicketRequestDTO ticketRequestDTO);
    }
}
