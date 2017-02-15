using BooksService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BooksService.Models;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace BooksService.Repository
{
    public class XmlRepository : IXmlRepository
    {
        string xmlPath = "Books.xml";

        public async Task<string> GetCatalogAsync()
        {
            return await DeserializeAsync();
        }

        private async Task<string> DeserializeAsync() => File.ReadAllText(xmlPath);

        //private async Task<Catalog> DeserializeAsync()
        //{
        //    Catalog catalog;

        //    var xmlContent = File.ReadAllText(xmlPath);
        //    var xmlSerializer = new XmlSerializer(typeof(Catalog));

        //    using (var stringReader = new StringReader(xmlContent))
        //    {
        //        catalog = xmlSerializer.Deserialize(stringReader) as Catalog;
        //    }

        //    return catalog;
        //}

        //private async Task<Catalog> SerializeAsync()
        //{
        //    var serializer = new XmlSerializer(typeof(Catalog));
        //    var stringBuilder = new StringBuilder();

        //    using (var stringWriter = new StringWriter(stringBuilder))
        //    {
        //        serializer.Serialize(stringWriter, answer);
        //    }

        //    return stringBuilder.ToString();
        //}
    }
}
