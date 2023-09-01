using Manager01;
using ManagerService.Model.Dto;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Converter
{
    internal class ServicoConverter
    {
        [Obsolete("Tratar os relacionamentos para conversarem com o DTO. MapDtoToEntity")]
        public Servico SqlToServico(MySqlDataReader reader)
        {
            return new Servico()
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Descricao = reader.GetString(reader.GetOrdinal("descricao")),
                Valor = reader.GetFloat(reader.GetOrdinal("valor")),
            };
        }

        public ServicoDto SqlToServicoDto(MySqlDataReader reader)
        {
            ServicoDto dto = new ServicoDto();

            dto.Id = reader.GetInt32(reader.GetOrdinal("id"));
            dto.Descricao = reader.GetString(reader.GetOrdinal("descricao"));
            dto.Valor = reader.GetFloat(reader.GetOrdinal("valor"));
            dto.CustoMedio = reader.GetFloat(reader.GetOrdinal("custoMedio"));

            SqlController sqlController = new SqlController();
            MySqlDataReader sqlReader = sqlController.GetDataReader($" Select nome from usuario where id = {reader.GetInt32(reader.GetOrdinal("fk_usuario"))}");

            sqlReader.Read();
            dto.usuario = sqlReader.GetString(0);


            return dto;
        }
    }
}
