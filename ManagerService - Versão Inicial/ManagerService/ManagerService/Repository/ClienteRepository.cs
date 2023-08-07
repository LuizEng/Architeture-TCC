using Manager01;
using ManagerService.Converter;
using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Repository
{
    internal class ClienteRepository: SqlController
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

        public ClienteDto GetByIdDto(int id)
        {
            MySqlDataReader sqlDataReader = GetDataReader("select * from cliente where id = " + id.ToString());

            if (sqlDataReader.Read())
                return _converter.SqlToClienteDto(sqlDataReader);

            return null;
        }

        public List<ClienteDto> GetAllClienteDto()
        {
            MySqlDataReader sqlDataReader = GetDataReader("select * from cliente");

            var list = new List<ClienteDto>();

            while (sqlDataReader.Read())
            {
                list.Add(_converter.SqlToClienteDto(sqlDataReader));
            }

            return list;
        }

        public ClienteDto GetByNome(string nome)
        {
            MySqlDataReader sqlDataReader = GetDataReader("select * from cliente where nome = '" + nome + "'");
            if (sqlDataReader.Read())
               return _converter.SqlToClienteDto(sqlDataReader);
            return null;
        }


        public void Insert(ClientePostDto dto) => this.Insert<ClientePostDto>(dto, "cliente");

        public void Delete(int id) => this.Delete("cliente", "id", id);
       
        public void Update(ClienteDto dto) => this.Update<ClienteDto>(dto, "cliente", "Id");

    }
}
