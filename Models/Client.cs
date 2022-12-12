using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    [Table("[Client]")]

    public class Client
    {

        public Client()
        {
        //    Cars = new List<Car>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Document { get; set; }

        public string Phone { get; set; }

        public bool Special { get; set; }


    }
}
