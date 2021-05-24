
namespace PL
{
    partial class DeleteSaleInfoForm
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
            this.deleteSaleInfoLabel = new System.Windows.Forms.Label();
            this.deleteSaleInfoTextBox = new System.Windows.Forms.TextBox();
            this.deleteSaleInfoButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteSaleInfoLabel
            // 
            this.deleteSaleInfoLabel.AutoSize = true;
            this.deleteSaleInfoLabel.Location = new System.Drawing.Point(72, 58);
            this.deleteSaleInfoLabel.Name = "deleteSaleInfoLabel";
            this.deleteSaleInfoLabel.Size = new System.Drawing.Size(316, 17);
            this.deleteSaleInfoLabel.TabIndex = 0;
            this.deleteSaleInfoLabel.Text = "Delete sale information on existing product by ID:";
            // 
            // deleteSaleInfoTextBox
            // 
            this.deleteSaleInfoTextBox.Location = new System.Drawing.Point(170, 90);
            this.deleteSaleInfoTextBox.Name = "deleteSaleInfoTextBox";
            this.deleteSaleInfoTextBox.Size = new System.Drawing.Size(100, 22);
            this.deleteSaleInfoTextBox.TabIndex = 1;
            // 
            // deleteSaleInfoButton
            // 
            this.deleteSaleInfoButton.Location = new System.Drawing.Point(116, 155);
            this.deleteSaleInfoButton.Name = "deleteSaleInfoButton";
            this.deleteSaleInfoButton.Size = new System.Drawing.Size(209, 33);
            this.deleteSaleInfoButton.TabIndex = 2;
            this.deleteSaleInfoButton.Text = "Delete sale information";
            this.deleteSaleInfoButton.UseVisualStyleBackColor = true;
            this.deleteSaleInfoButton.Click += new System.EventHandler(this.deleteSaleInfoButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeleteSaleInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 209);
            this.Controls.Add(this.deleteSaleInfoButton);
            this.Controls.Add(this.deleteSaleInfoTextBox);
            this.Controls.Add(this.deleteSaleInfoLabel);
            this.Name = "DeleteSaleInfoForm";
            this.Text = "Delete sale information";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deleteSaleInfoLabel;
        private System.Windows.Forms.TextBox deleteSaleInfoTextBox;
        private System.Windows.Forms.Button deleteSaleInfoButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}