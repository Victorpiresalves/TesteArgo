using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteArgo.Api;
using TesteArgo.Api.Models;
using TesteArgo.Models;

namespace TesteArgo
{
    public class teste3
    {
        private OmdbAPI OmdbApi;
        public teste3()
        {
            OmdbApi = new OmdbAPI();
        }
        ///www.omdbapi.com/
        const string ApiKey = "18693fd6";

        /// <summary>
        /// By Search
        /// www.omdbapi.com/?s=titulo&apikey=18693fd6
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<Filme> ListarFilmes(string filtro)
        {
            var retornoJson = OmdbApi.ListarFilmesByFiltro(filtro);
            SearchObject searchObject = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchObject>(retornoJson);

            return new Filme().Parse(searchObject.Search);
        }

        /// <summary>
        /// By ID or Title
        /// www.omdbapi.com/?i=tt0372784&apikey=18693fd6
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Filme ListarPorId(string id)
        {
            var retornoJson = OmdbApi.ListarFilmeById(id);
            SearchValues searchValues = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchValues>(retornoJson);

            return new Filme().Parse(searchValues);
        }
    }
}
