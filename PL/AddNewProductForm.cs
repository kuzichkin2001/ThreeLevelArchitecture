using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectEntities;
using BL;
using BL_Interface;

namespace PL
{
    public partial class AddNewProductForm : Form
    {
        private IProductBl _productBl = new ProductBl();
        private List<Product> _allItems;
        private bool _isValueChanged = false;
        public AddNewProductForm()
        {
            _allItems = new List<Product>(_productBl.GetAllProducts());
            InitializeComponent();
            FillShortProductsInfo(shortProductsData, _allItems);
        }

        private void FillShortProductsInfo(DataGridView dataTable, List<Product> items)
        {
            dataTable.Rows.Clear();
            foreach (var item in items)
            {
                DataGridViewRow row = (DataGridViewRow)shortProductsData.Rows[0].Clone();
                row.Cells[0].Value = item.Id;
                row.Cells[1].Value = item.ProductName;
                row.Cells[2].Value = item.Cost;
                dataTable.Rows.Add(row);
            }
        }

        private void salePercentTextBox_TextChanged(object sender, EventArgs e)
        {
            string innerMessage = salePercentTextBox.Text;
            int cost;
            if (int.TryParse(innerMessage, out cost))
            {
                if (cost > 0 && cost <= 100)
                {
                    saleStartDatePicker.Enabled = true;
                    saleStartDateTextBox.Enabled = true;
                    saleEndDatePicker.Enabled = true;
                    saleEndDateTextBox.Enabled = true;
                }
                else
                {
                    saleStartDatePicker.Enabled = false;
                    saleStartDateTextBox.Enabled = false;
                    saleEndDatePicker.Enabled = false;
                    saleEndDateTextBox.Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Product newItem = new Product
            (
                productName: productNameTextBox.Text,
                cost: Convert.ToDouble(costTextBox.Text),
                saleInfo: new Sale(
                    salePercent: Convert.ToDouble(salePercentTextBox.Text),
                    saleStartDate: saleStartDateTextBox.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(saleStartDateTextBox.Text),
                    saleEndDate: saleEndDateTextBox.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(saleEndDateTextBox.Text)
                )
            );
            _productBl.AddNewProduct(newItem);
            this.Close();
        }

        private void saleStartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            saleStartDateTextBox.Text = saleStartDatePicker.Value.ToShortDateString();
        }

        private void saleEndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            saleEndDateTextBox.Text = saleEndDatePicker.Value.ToShortDateString();
        }
    }
}
