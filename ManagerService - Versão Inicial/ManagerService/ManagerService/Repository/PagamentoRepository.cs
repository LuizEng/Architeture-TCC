using Manager01;
using ManagerService.Converter;
using ManagerService.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Repository
{
    public class PagamentoRepository
    {
        private PagamentoConverter _converter;

        public PagamentoRepository() => _converter = new PagamentoConverter();
        public Pagamento GetById(int id)
        {
            SqlController sqlController = new SqlController();
            MySqlDataReader reader = sqlController.GetDataReader("select * from pagamento");

            return _converter.SqlToPagamento(reader);
        }
    }
}
