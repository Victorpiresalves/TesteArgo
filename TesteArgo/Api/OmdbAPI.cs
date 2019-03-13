using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TesteArgo.Api
{
    public class OmdbAPI
    {
        private static readonly HttpClient client = new HttpClient();
        private static string apiKey = "18693fd6";

        private static string urlListarFilmesByFiltro = "http://www.omdbapi.com/?s={0}&apikey={1}";
        private static string urlListarFilmesByID = "http://www.omdbapi.com/?i={0}&apikey={1}";

        public string ListarFilmesByFiltro(string filtro)
        {
            var url = string.Format(urlListarFilmesByFiltro, filtro, apiKey);

            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }

        public string ListarFilmeById(string id)
        {
            var url = string.Format(urlListarFilmesByID, id, apiKey);

            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }
    }
}
