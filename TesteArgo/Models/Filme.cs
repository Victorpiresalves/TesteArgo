using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Api.Models;

namespace TesteArgo.Models
{
    public class Filme
    {
        /// <summary>
        /// Title
        /// </summary>
        public string Titulo { get; set; }
        /// <summary>
        /// Year
        /// </summary>
        public string Ano { get; set; }
        /// <summary>
        /// imdbID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// Poster
        /// </summary>
        public string Imagem { get; set; }

        public Filme Parse(SearchValues searchValues)
        {
            return new Filme
            {
                ID = searchValues.imdbID,
                Titulo = searchValues.Title,
                Ano = searchValues.Year,
                Imagem = searchValues.Poster,
            };
        }

        public List<Filme> Parse(List<SearchValues> listSearchValues)
        {
            List<Filme> listaDeFilmes = new List<Filme>();
            listSearchValues.ForEach(s => listaDeFilmes.Add(Parse(s)));

            return listaDeFilmes;
        }
    }
}
