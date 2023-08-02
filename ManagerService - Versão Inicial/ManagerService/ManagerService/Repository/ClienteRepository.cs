using Manager01;
using ManagerService.Converter;
using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Repository
{
    internal class ClienteRepository
    {
        private ClienteConverter _converter;

        public ClienteRepository() => _converter = new ClienteConverter();
        public List<ClienteGetAllDto> GetAllClientes()
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader sqlDataReader = sqlController.GetDataReader("select * from cliente");

            var list = new List<ClienteGetAllDto>();

            while (sqlDataReader.Read())
            {
                list.Add(_converter.SqlToClienteGetAllDto(sqlDataReader));
            }

            return list;
        }

        public Cliente GetById(int id)
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader sqlDataReader = sqlController.GetDataReader("select * from cliente where id = "+ id.ToString());

            return _converter.SqlToCliente(sqlDataReader);
        }

    }
}
