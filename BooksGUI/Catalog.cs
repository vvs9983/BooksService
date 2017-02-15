using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksGUI
{
    [XmlRoot("catalog")]
    public class Catalog
    {
        [XmlElement("book")]
        public List<Book> catalog { get; set; }
    }
}
