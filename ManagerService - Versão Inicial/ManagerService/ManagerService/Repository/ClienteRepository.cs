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
    internal class ClienteRepository : SqlController
    {
        private ClienteConverter _converter;

        public ClienteRepository() => _converter = new ClienteConverter();
        public List<ClienteGetAllDto> GetAllClientes()
        {            
            MySqlDataReader sqlDataReader = GetDataReader("select * from cliente");

            var list = new List<ClienteGetAllDto>();

            while (sqlDataReader.Read())
            {
                list.Add(_converter.SqlToClienteGetAllDto(sqlDataReader));
            }

            return list;
        }

        public Cliente GetById(int id) => _converter.SqlToCliente(GetDataReader("select * from cliente where id = " + id.ToString()));

    }
}
