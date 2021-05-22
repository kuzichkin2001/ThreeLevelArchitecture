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
    public partial class ShowSaleInformationForm : Form
    {
        private IProductBl _productBl = new ProductBl();
        private List<Product> _allItems;
        public ShowSaleInformationForm()
        {
            _allItems = new List<Product>(_productBl.GetAllSaleInfo());
            InitializeComponent();
            RenderSaleInfo(fullSaleInformation, _allItems);
        }
        public void RenderSaleInfo(DataGridView dataTable, List<Product> items)
        {
            dataTable.Rows.Clear();
            foreach (var item in items)
            {
                DataGridViewRow row = (DataGridViewRow)fullSaleInformation.Rows[0].Clone();
                row.Cells[0].Value = item.ProductName;
                row.Cells[1].Value = item.SaleInfo.SalePercent == 0 ? '-' : '+';
                row.Cells[2].Value = item.SaleInfo.SalePercent;
                row.Cells[3].Value = item.SaleInfo.SalePercent <= 0
                    ? "--"
                    : ((DateTime)item.SaleInfo.SaleStartDate).ToShortDateString();
                row.Cells[4].Value = item.SaleInfo.SalePercent <= 0
                    ? "--"
                    : ((DateTime)item.SaleInfo.SaleEndDate).ToShortDateString();
                dataTable.Rows.Add(row);
            }
        }
    }
}
