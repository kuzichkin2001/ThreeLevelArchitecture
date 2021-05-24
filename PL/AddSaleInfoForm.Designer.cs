
namespace PL
{
    partial class AddSaleInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.salePercentTextBox = new System.Windows.Forms.TextBox();
            this.salePercentLabel = new System.Windows.Forms.Label();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.startDateTextBox = new System.Windows.Forms.TextBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.saleEndDateLabel = new System.Windows.Forms.Label();
            this.saleStartDateLabel = new System.Windows.Forms.Label();
            this.updateInfoButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(40, 22);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(158, 25);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Enter product ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(43, 53);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // salePercentTextBox
            // 
            this.salePercentTextBox.Location = new System.Drawing.Point(43, 129);
            this.salePercentTextBox.Name = "salePercentTextBox";
            this.salePercentTextBox.Size = new System.Drawing.Size(201, 22);
            this.salePercentTextBox.TabIndex = 3;
            this.salePercentTextBox.TextChanged += new System.EventHandler(this.salePercent_TextChanged);
            // 
            // salePercentLabel
            // 
            this.salePercentLabel.AutoSize = true;
            this.salePercentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salePercentLabel.Location = new System.Drawing.Point(40, 98);
            this.salePercentLabel.Name = "salePercentLabel";
            this.salePercentLabel.Size = new System.Drawing.Size(122, 25);
            this.salePercentLabel.TabIndex = 2;
            this.salePercentLabel.Text = "Sale percent";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Enabled = false;
            this.endDateTextBox.Location = new System.Drawing.Point(329, 195);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.Size = new System.Drawing.Size(199, 22);
            this.endDateTextBox.TabIndex = 21;
            // 
            // startDateTextBox
            // 
            this.startDateTextBox.Enabled = false;
            this.startDateTextBox.Location = new System.Drawing.Point(45, 194);
            this.startDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.startDateTextBox.Name = "startDateTextBox";
            this.startDateTextBox.Size = new System.Drawing.Size(199, 22);
            this.startDateTextBox.TabIndex = 20;
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "DD.MM.YYYY";
            this.endDatePicker.Enabled = false;
            this.endDatePicker.Location = new System.Drawing.Point(537, 195);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.endDatePicker.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.endDatePicker.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(25, 22);
            this.endDatePicker.TabIndex = 19;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // startDatePicker
            // 
            this.startDatePicker.Enabled = false;
            this.startDatePicker.Location = new System.Drawing.Point(253, 195);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(27, 22);
            this.startDatePicker.TabIndex = 18;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // saleEndDateLabel
            // 
            this.saleEndDateLabel.AutoSize = true;
            this.saleEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleEndDateLabel.Location = new System.Drawing.Point(324, 167);
            this.saleEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saleEndDateLabel.Name = "saleEndDateLabel";
            this.saleEndDateLabel.Size = new System.Drawing.Size(133, 25);
            this.saleEndDateLabel.TabIndex = 17;
            this.saleEndDateLabel.Text = "Sale end date";
            // 
            // saleStartDateLabel
            // 
            this.saleStartDateLabel.AutoSize = true;
            this.saleStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleStartDateLabel.Location = new System.Drawing.Point(40, 167);
            this.saleStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saleStartDateLabel.Name = "saleStartDateLabel";
            this.saleStartDateLabel.Size = new System.Drawing.Size(137, 25);
            this.saleStartDateLabel.TabIndex = 16;
            this.saleStartDateLabel.Text = "Sale start date";
            // 
            // updateInfoButton
            // 
            this.updateInfoButton.Location = new System.Drawing.Point(168, 253);
            this.updateInfoButton.Name = "updateInfoButton";
            this.updateInfoButton.Size = new System.Drawing.Size(230, 43);
            this.updateInfoButton.TabIndex = 22;
            this.updateInfoButton.Text = "Add (update) sale information";
            this.updateInfoButton.UseVisualStyleBackColor = true;
            this.updateInfoButton.Click += new System.EventHandler(this.updateInfoButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 22);
            this.textBox1.TabIndex = 24;
            // 
            // costTextBox
            // 
            this.costTextBox.AutoSize = true;
            this.costTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costTextBox.Location = new System.Drawing.Point(324, 98);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(53, 25);
            this.costTextBox.TabIndex = 23;
            this.costTextBox.Text = "Cost";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddSaleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 308);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.updateInfoButton);
            this.Controls.Add(this.endDateTextBox);
            this.Controls.Add(this.startDateTextBox);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.saleEndDateLabel);
            this.Controls.Add(this.saleStartDateLabel);
            this.Controls.Add(this.salePercentTextBox);
            this.Controls.Add(this.salePercentLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.idLabel);
            this.Name = "AddSaleInfoForm";
            this.Text = "Add sale information";
            this.Load += new System.EventHandler(this.AddSaleInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox salePercentTextBox;
        private System.Windows.Forms.Label salePercentLabel;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.TextBox startDateTextBox;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label saleEndDateLabel;
        private System.Windows.Forms.Label saleStartDateLabel;
        private System.Windows.Forms.Button updateInfoButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label costTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}