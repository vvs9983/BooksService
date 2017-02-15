using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksGUI
{
    class WebApi
    {
        HttpClient client;

        public WebApi()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50927/");
            client.DefaultRequestHeaders.Accept.Clear();
        }

        public async Task<Catalog> GetCatalog()
        {
            var catalogContent = string.Empty;

            try
            {
                HttpResponseMessage httpResposeMessage = await client.GetAsync("api/xmlrepository");

                if (httpResposeMessage.IsSuccessStatusCode)
                {
                    catalogContent = await httpResposeMessage.Content.ReadAsStringAsync();
                }
            }
            catch (Exception e) { }

            return Deserialize(catalogContent);
        }

        private Catalog Deserialize(string catalogContent)
        {
            Catalog catalog;
            
            var xmlSerializer = new XmlSerializer(typeof(Catalog));

            using (var stringReader = new StringReader(catalogContent))
            {
                catalog = xmlSerializer.Deserialize(stringReader) as Catalog;
            }

            return catalog;
        }
    }
}
