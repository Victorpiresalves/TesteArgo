using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Business.DAL;
using TesteArgo.Models;

namespace TesteArgo.Business.Adapter
{
    public class DestinoAdapter
    {
        private readonly DestinoDAL _destinoDAL = new DestinoDAL();

        public List<Destino> ListarDestino()
        {
            return _destinoDAL.ListarDestino();
        }
    }
}
