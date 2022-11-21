using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace SistemaEstacionamento.Repositories
{
    public class Repository<Model> where Model : class
    {
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection)
         => _connection = connection;

        public IEnumerable<Model>  Get() => _connection.GetAll<Model> ();

        public Model Get(int id)
            => _connection.Get<Model> (id);

        public void Create(Model model)
            => _connection.Insert<Model> (model);

        public void Update(Model model)
        => _connection.Update<Model> (model);

        public void Delete(Model model)
                => _connection.Delete<Model> (model);

        public void Delete(int id)
        {
            var model = _connection.Get<Model> (id);
            _connection.Delete<Model> (model);
        }

    }
}
