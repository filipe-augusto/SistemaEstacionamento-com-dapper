using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Client
    {

        public Client()
        {

        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Document { get; set; }

        public string Phone { get; set; }

        public bool Special { get; set; }
    }
}
