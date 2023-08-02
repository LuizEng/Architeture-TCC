using Manager01;
using ManagerService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Model.Dto
{
    public class BaseRepository : SqlController, IBaseRepository
    {
        public string tabela { get; set; }
        public string campoChave { get; set; }    

        public void Delete(int id) => this.Delete(tabela, campoChave, id);

        public void Insert(object dto) => this.Insert<object>(dto, tabela);

        public void Update(object dto) => this.Update<object>(dto, tabela, campoChave);
    }
}
