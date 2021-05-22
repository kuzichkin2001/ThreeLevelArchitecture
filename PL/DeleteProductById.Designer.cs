
namespace PL
{
    partial class DeleteProductById
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
            this.idToDeleteLabel = new System.Windows.Forms.Label();
            this.idToDeleteTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idToDeleteLabel
            // 
            this.idToDeleteLabel.AutoSize = true;
            this.idToDeleteLabel.Location = new System.Drawing.Point(139, 55);
            this.idToDeleteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idToDeleteLabel.Name = "idToDeleteLabel";
            this.idToDeleteLabel.Size = new System.Drawing.Size(170, 17);
            this.idToDeleteLabel.TabIndex = 0;
            this.idToDeleteLabel.Text = "Enter product ID to delete";
            // 
            // idToDeleteTextBox
            // 
            this.idToDeleteTextBox.Location = new System.Drawing.Point(83, 87);
            this.idToDeleteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idToDeleteTextBox.Name = "idToDeleteTextBox";
            this.idToDeleteTextBox.Size = new System.Drawing.Size(285, 22);
            this.idToDeleteTextBox.TabIndex = 1;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(176, 149);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete product";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeleteProductById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 209);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.idToDeleteTextBox);
            this.Controls.Add(this.idToDeleteLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteProductById";
            this.Text = "DeleteProductById";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idToDeleteLabel;
        private System.Windows.Forms.TextBox idToDeleteTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}