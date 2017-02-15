using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksGUI
{
    public partial class Books : Form
    {
        private Catalog catalog;
        private readonly WebApi webApi;
        public Books()
        {
            InitializeComponent();

            webApi = new WebApi();
            GetCatalog();
        }

        private async void GetCatalog()
        {
            catalog = await webApi.GetCatalog();

            dataGridViewCatalog.DataSource = catalog.catalog;
        }
    }
}
