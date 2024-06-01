using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Ticket Title")]
        public string ticketTitle { get; set; }
        [DisplayName("Ticket Description")]
        public string ticketDesc { get; set; }

        public Ticket()
        {
          
        }
    }
}
