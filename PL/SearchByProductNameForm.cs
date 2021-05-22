using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BL_Interface;
using ProjectEntities;

namespace PL
{
    public partial class SearchByProductNameForm : Form
    {
        private IProductBl _productBl = new ProductBl();
        private List<Product> _allItems;
        public SearchByProductNameForm()
        {
            _allItems = new List<Product>(_productBl.GetAllProducts());
            InitializeComponent();
            RenderDataGridView(DataTable, _allItems);
        }
        private void RenderDataGridView(DataGridView dataTable, List<Product> items)
        {
            dataTable.Rows.Clear();
            foreach (var item in items)
            {
                DataGridViewRow row = (DataGridViewRow)dataTable.Rows[0].Clone();
                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.ProductName;
                row.Cells[2].Value = item.Cost;
                row.Cells[3].Value = item.SaleInfo.SalePercent <= 0 ? '-' : '+';
                row.Cells[4].Value = item.SaleInfo.SalePercent <= 0 ? 0 : item.SaleInfo.SalePercent;
                row.Cells[5].Value = item.SaleInfo.SalePercent <= 0
                    ? "--"
                    : ((DateTime)item.SaleInfo.SaleStartDate).ToShortDateString();
                row.Cells[6].Value = item.SaleInfo.SalePercent <= 0
                    ? "--"
                    : ((DateTime)item.SaleInfo.SaleEndDate).ToShortDateString();
                dataTable.Rows.Add(row);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (productNameTextBox.Text.Length == 0)
            {
                RenderDataGridView(DataTable, _allItems);
            }
            else
            {
                List<Product> searchResult = new List<Product>(_productBl.SearchByProductName(productNameTextBox.Text));
                RenderDataGridView(DataTable, searchResult);
            }
        }
    }
}
