using Dapper;
using Microsoft.Data.SqlClient;
using SistemaEstacionamento.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Repositories
{
    public class SchedulingRepository
    {
        private readonly SqlConnection _connection;
        public SchedulingRepository(SqlConnection connection)
         => _connection = connection;

      public  IEnumerable<SchedulingModelView> CarrosEstacionados(SqlConnection connection)
        {
            var sql = @"SELECT * FROM Scheduling s inner join Car car ON s.IdCar = car.Id " +
              @" inner join Client cli ON s.IdCar = cli.Id where Finished = 0";

            var items = connection.Query<SchedulingModelView, Car,Client, SchedulingModelView>(
                sql,
                (agendamento, car, client) =>
                {
                    agendamento.Car = car;
                    agendamento.Client = client;
                    return agendamento;
                },
                splitOn: "Id"
                );
            //foreach (var item in items)
            //{
            //    Console.WriteLine($" carro: {item.Car.Modelo} " +
            //        $" cliente: {item.Client.Name}");
            //}
            return items;
        }




    }
}
