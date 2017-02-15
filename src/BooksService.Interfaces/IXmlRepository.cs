using BooksService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksService.Interfaces
{
    public interface IXmlRepository
    {
        Task<string> GetCatalogAsync();
    }
}
