using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksService.Models
{
    [XmlRoot("catalog")]
    public class Catalog
    {
        [XmlArray("book")]
        public List<Book> catalog { get; set; }
    }
}
