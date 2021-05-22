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
    public partial class DeleteProductById : Form
    {
        private IProductBl _productBl = new ProductBl();
        private List<Product> _allItems;
        private List<int> _allIDs = new List<int>();
        public DeleteProductById()
        {
            _allItems = new List<Product>(_productBl.GetAllProducts());
            InitializeComponent();
            foreach (var item in _allItems)
            {
                if (!_allIDs.Contains(item.Id))
                {
                    _allIDs.Add(item.Id);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idToDeleteTextBox.Text);
            if (!_allIDs.Contains(id))
            {
                errorProvider1.SetError(deleteButton, "Товара с таким ID не существует");
                return;
            }
            _productBl.DeleteProduct(id);
            this.Close();
        }
    }
}
