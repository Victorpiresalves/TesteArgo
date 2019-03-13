using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo
{
    public class teste2
    {
        public List<int> CriarLista(int quantidade)
        {
            List<int> listaComQuantide = new List<int>();
            for (int i = 0; i < quantidade; i++)
            {
                listaComQuantide.Add(i);
            }
            return listaComQuantide;
        }

        public List<int> OrdenarLista(params int[] valores)
        {
            var listaDeValores = new List<int>();
            for (int i = 0; i < valores.Count(); i++)
            {
                listaDeValores.Add(valores[i]);
            }
            return listaDeValores.OrderBy(x => x).ToList();
        }
    }
}
