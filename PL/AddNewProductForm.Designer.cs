
namespace PL
{
    partial class AddNewProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.salePercentTextBox = new System.Windows.Forms.TextBox();
            this.salePercentLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saleStartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.saleEndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.shortProductsData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.saleStartDateTextBox = new System.Windows.Forms.TextBox();
            this.saleEndDateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shortProductsData)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(15, 90);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(133, 25);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product name";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(19, 118);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(305, 22);
            this.productNameTextBox.TabIndex = 1;
            this.productNameTextBox.Text = "Enter product name...";
            // 
            // salePercentTextBox
            // 
            this.salePercentTextBox.Location = new System.Drawing.Point(19, 335);
            this.salePercentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salePercentTextBox.Name = "salePercentTextBox";
            this.salePercentTextBox.Size = new System.Drawing.Size(305, 22);
            this.salePercentTextBox.TabIndex = 3;
            this.salePercentTextBox.Text = "Enter sale percent...";
            this.salePercentTextBox.TextChanged += new System.EventHandler(this.salePercentTextBox_TextChanged);
            // 
            // salePercentLabel
            // 
            this.salePercentLabel.AutoSize = true;
            this.salePercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePercentLabel.Location = new System.Drawing.Point(16, 295);
            this.salePercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.salePercentLabel.Name = "salePercentLabel";
            this.salePercentLabel.Size = new System.Drawing.Size(122, 25);
            this.salePercentLabel.TabIndex = 2;
            this.salePercentLabel.Text = "Sale percent";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(19, 192);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(305, 22);
            this.costTextBox.TabIndex = 5;
            this.costTextBox.Text = "Enter product cost...";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(15, 164);
            this.costLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(134, 25);
            this.costLabel.TabIndex = 4;
            this.costLabel.Text = "Product\'s cost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sale information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 379);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sale start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 379);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sale end date";
            // 
            // saleStartDatePicker
            // 
            this.saleStartDatePicker.Enabled = false;
            this.saleStartDatePicker.Location = new System.Drawing.Point(229, 407);
            this.saleStartDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.saleStartDatePicker.Name = "saleStartDatePicker";
            this.saleStartDatePicker.Size = new System.Drawing.Size(27, 22);
            this.saleStartDatePicker.TabIndex = 10;
            this.saleStartDatePicker.ValueChanged += new System.EventHandler(this.saleStartDatePicker_ValueChanged);
            // 
            // saleEndDatePicker
            // 
            this.saleEndDatePicker.CustomFormat = "DD.MM.YYYY";
            this.saleEndDatePicker.Enabled = false;
            this.saleEndDatePicker.Location = new System.Drawing.Point(517, 407);
            this.saleEndDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.saleEndDatePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.saleEndDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.saleEndDatePicker.Name = "saleEndDatePicker";
            this.saleEndDatePicker.Size = new System.Drawing.Size(25, 22);
            this.saleEndDatePicker.TabIndex = 11;
            this.saleEndDatePicker.ValueChanged += new System.EventHandler(this.saleEndDatePicker_ValueChanged);
            // 
            // shortProductsData
            // 
            this.shortProductsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shortProductsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortProductsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.shortProductsData.Dock = System.Windows.Forms.DockStyle.Right;
            this.shortProductsData.Location = new System.Drawing.Point(576, 0);
            this.shortProductsData.Margin = new System.Windows.Forms.Padding(4);
            this.shortProductsData.Name = "shortProductsData";
            this.shortProductsData.RowHeadersWidth = 51;
            this.shortProductsData.Size = new System.Drawing.Size(491, 554);
            this.shortProductsData.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ProductID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cost";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 466);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(525, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add New Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saleStartDateTextBox
            // 
            this.saleStartDateTextBox.Enabled = false;
            this.saleStartDateTextBox.Location = new System.Drawing.Point(21, 406);
            this.saleStartDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.saleStartDateTextBox.Name = "saleStartDateTextBox";
            this.saleStartDateTextBox.Size = new System.Drawing.Size(199, 22);
            this.saleStartDateTextBox.TabIndex = 14;
            // 
            // saleEndDateTextBox
            // 
            this.saleEndDateTextBox.Enabled = false;
            this.saleEndDateTextBox.Location = new System.Drawing.Point(309, 407);
            this.saleEndDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.saleEndDateTextBox.Name = "saleEndDateTextBox";
            this.saleEndDateTextBox.Size = new System.Drawing.Size(199, 22);
            this.saleEndDateTextBox.TabIndex = 15;
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.saleEndDateTextBox);
            this.Controls.Add(this.saleStartDateTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shortProductsData);
            this.Controls.Add(this.saleEndDatePicker);
            this.Controls.Add(this.saleStartDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.salePercentTextBox);
            this.Controls.Add(this.salePercentLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNewProductForm";
            this.Text = "Add new product";
            ((System.ComponentModel.ISupportInitialize)(this.shortProductsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox salePercentTextBox;
        private System.Windows.Forms.Label salePercentLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker saleStartDatePicker;
        private System.Windows.Forms.DateTimePicker saleEndDatePicker;
        private System.Windows.Forms.DataGridView shortProductsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox saleStartDateTextBox;
        private System.Windows.Forms.TextBox saleEndDateTextBox;
    }
}