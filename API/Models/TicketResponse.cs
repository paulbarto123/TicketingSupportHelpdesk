using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_TicketResponse")]
    public class TicketResponse
    {
        [Key]
        public int Id { get; set; }
        public Ticket Ticket { get; set; }
        public Employee Employee { get; set; }
        public DateTime ResponDate { get; set; }
        public string Solution { get; set; }

    }
}
