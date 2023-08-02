using ManagerService.Model.Dto;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerService.Repository
{
    internal interface IBaseRepository
    {
        void Insert(object dto);

        void Update(object dto);

        void Delete(int id);
    }
}
