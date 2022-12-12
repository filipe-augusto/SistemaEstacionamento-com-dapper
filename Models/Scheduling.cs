using Dapper.Contrib.Extensions;
using Microsoft.VisualBasic;

namespace SistemaEstacionamento.Models
{
    [Table("[Scheduling]")]
    public class Scheduling
    {

       public Scheduling()
        {
            Value = 0;
            AmountMinutes = 0;
            Finished = false;
            StartDate = DateTime.Now;
            EndDate = DateAndTime.Now.AddHours(1);
        }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Special { get; set; }
        public bool Finished { get; set; }
        public int IdCar { get; set; }
        public int IdClient { get; set; }
        public decimal Value { get; set; }
        public int AmountMinutes { get; set; }
    }
}
