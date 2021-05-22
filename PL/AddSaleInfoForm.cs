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
    public partial class AddSaleInfoForm : Form
    {
        private IProductBl _productBl = new ProductBl();
        private List<Product> _allItems;
        private List<int> _allIDs = new List<int>();
        public AddSaleInfoForm()
        {
            InitializeComponent();
        }

        private void salePercent_TextChanged(object sender, EventArgs e)
        {
            string innerMessage = salePercentTextBox.Text;
            int cost;
            if (int.TryParse(innerMessage, out cost))
            {
                if (cost > 0 && cost <= 100)
                {
                    startDatePicker.Enabled = true;
                    startDateTextBox.Enabled = true;
                    endDatePicker.Enabled = true;
                    endDateTextBox.Enabled = true;
                }
                else
                {
                    startDatePicker.Enabled = false;
                    startDateTextBox.Enabled = false;
                    endDatePicker.Enabled = false;
                    endDateTextBox.Enabled = false;
                }
            }
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDateTextBox.Text = startDatePicker.Value.ToShortDateString();
        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTextBox.Text = endDatePicker.Value.ToShortDateString();
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            int id = Convert.ToInt32(idTextBox.Text);
            if (!_allIDs.Contains(id))
            {
                MessageBox.Show("a");
                errorProvider1.SetError(updateInfoButton, "Товара с таким ID не существует");
                return;
            }
            double cost = Convert.ToDouble(textBox1.Text);
            double salePercent = Convert.ToDouble(salePercentTextBox.Text);
            DateTime? startDate = startDateTextBox.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(startDateTextBox.Text);
            DateTime? endDate = endDateTextBox.Text.Length == 0 ? null : (DateTime?)Convert.ToDateTime(endDateTextBox.Text);
            _productBl.UpdateSaleInfo(id, cost, salePercent, startDate, endDate);
            this.Close();
        }

        private void AddSaleInfoForm_Load(object sender, EventArgs e)
        {
            _allItems = new List<Product>(_productBl.GetAllProducts());
            foreach (var item in _allItems)
            {
                if (!_allIDs.Contains(item.Id))
                {
                    _allIDs.Add(item.Id);
                }
            }
        }
    }
}
