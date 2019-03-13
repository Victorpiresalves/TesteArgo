using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Models;

namespace TesteArgo.Business.DAL
{
    public class DestinoDAL
    {
        private testecoreEntities _testecoreEntities = new testecoreEntities();
        public List<Destino> ListarDestino()
        {
            return _testecoreEntities.Destino.ToList();
        }
    }
}
