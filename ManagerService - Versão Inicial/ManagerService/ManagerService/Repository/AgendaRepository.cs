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
    public class AgendaRepository
    {
        private AgendaConverter _converter;
        public Agenda GetById(int id)
        {
            SqlController  sqlController = new SqlController();
            MySqlDataReader reader = sqlController.GetDataReader("select * from agenda");

            return _converter.SqlToAgenda(reader);
        }
    }
}
