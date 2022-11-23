using Microsoft.Data.SqlClient;
using SistemaEstacionamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Repositories
{
    public class CarRepository : Repository<Car>
    {
        private readonly SqlConnection _conection;

        public CarRepository(SqlConnection connection)
        : base(connection)
          => _conection = connection;

      //  public List


    }
}
