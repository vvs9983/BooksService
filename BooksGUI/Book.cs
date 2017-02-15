using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksGUI
{
    public class Book
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("author")]
        public string Author { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("genre")]
        public string Genre { get; set; }
        [XmlElement("price")]
        public string Price { get; set; }
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
    }
}
