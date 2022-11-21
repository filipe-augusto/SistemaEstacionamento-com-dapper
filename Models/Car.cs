using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Car
    {
        public Car()
        {

        }
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Color { get; set; }

        public string LicensePlate { get; set; }
    }
}
