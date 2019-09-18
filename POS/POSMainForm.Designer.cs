namespace POS
{
    partial class POSMainForm
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
            this.ProductListGroupbox = new System.Windows.Forms.GroupBox();
            this.fileoperationGroupbox = new System.Windows.Forms.GroupBox();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.loadProductButton = new System.Windows.Forms.Button();
            this.restockGroupBox = new System.Windows.Forms.GroupBox();
            this.restockButton = new System.Windows.Forms.Button();
            this.quantityRestockTextbox = new System.Windows.Forms.TextBox();
            this.quantityRestockLabel = new System.Windows.Forms.Label();
            this.sellGroupBox = new System.Windows.Forms.GroupBox();
            this.sellButton = new System.Windows.Forms.Button();
            this.quantitySoldTextbox = new System.Windows.Forms.TextBox();
            this.quantitySoldLabel = new System.Windows.Forms.Label();
            this.addaNewProductGroupBox = new System.Windows.Forms.GroupBox();
            this.productTypeComboxbox = new System.Windows.Forms.ComboBox();
            this.addNewProductButton = new System.Windows.Forms.Button();
            this.productListListbox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductListGroupbox.SuspendLayout();
            this.fileoperationGroupbox.SuspendLayout();
            this.restockGroupBox.SuspendLayout();
            this.sellGroupBox.SuspendLayout();
            this.addaNewProductGroupBox.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductListGroupbox
            // 
            this.ProductListGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductListGroupbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ProductListGroupbox.Controls.Add(this.fileoperationGroupbox);
            this.ProductListGroupbox.Controls.Add(this.restockGroupBox);
            this.ProductListGroupbox.Controls.Add(this.sellGroupBox);
            this.ProductListGroupbox.Controls.Add(this.addaNewProductGroupBox);
            this.ProductListGroupbox.Controls.Add(this.productListListbox);
            this.ProductListGroupbox.Location = new System.Drawing.Point(-2, 5);
            this.ProductListGroupbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductListGroupbox.Name = "ProductListGroupbox";
            this.ProductListGroupbox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductListGroupbox.Size = new System.Drawing.Size(967, 489);
            this.ProductListGroupbox.TabIndex = 0;
            this.ProductListGroupbox.TabStop = false;
            this.ProductListGroupbox.Text = "Product List";
            // 
            // fileoperationGroupbox
            // 
            this.fileoperationGroupbox.Controls.Add(this.saveProductButton);
            this.fileoperationGroupbox.Controls.Add(this.loadProductButton);
            this.fileoperationGroupbox.Location = new System.Drawing.Point(660, 232);
            this.fileoperationGroupbox.Name = "fileoperationGroupbox";
            this.fileoperationGroupbox.Size = new System.Drawing.Size(171, 69);
            this.fileoperationGroupbox.TabIndex = 2;
            this.fileoperationGroupbox.TabStop = false;
            this.fileoperationGroupbox.Text = "File Operation";
            // 
            // saveProductButton
            // 
            this.saveProductButton.Location = new System.Drawing.Point(6, 46);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(149, 23);
            this.saveProductButton.TabIndex = 0;
            this.saveProductButton.Text = "Save Product";
            this.saveProductButton.UseVisualStyleBackColor = true;
            this.saveProductButton.Click += new System.EventHandler(this.saveProductButton_Click);
            // 
            // loadProductButton
            // 
            this.loadProductButton.Location = new System.Drawing.Point(6, 17);
            this.loadProductButton.Name = "loadProductButton";
            this.loadProductButton.Size = new System.Drawing.Size(149, 23);
            this.loadProductButton.TabIndex = 0;
            this.loadProductButton.Text = "Load Product";
            this.loadProductButton.UseVisualStyleBackColor = true;
            this.loadProductButton.Click += new System.EventHandler(this.loadProductButton_Click);
            // 
            // restockGroupBox
            // 
            this.restockGroupBox.Controls.Add(this.restockButton);
            this.restockGroupBox.Controls.Add(this.quantityRestockTextbox);
            this.restockGroupBox.Controls.Add(this.quantityRestockLabel);
            this.restockGroupBox.Location = new System.Drawing.Point(344, 232);
            this.restockGroupBox.Name = "restockGroupBox";
            this.restockGroupBox.Size = new System.Drawing.Size(310, 101);
            this.restockGroupBox.TabIndex = 1;
            this.restockGroupBox.TabStop = false;
            this.restockGroupBox.Text = "Restock a Product";
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(167, 57);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(124, 26);
            this.restockButton.TabIndex = 5;
            this.restockButton.Text = "Restock Product";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // quantityRestockTextbox
            // 
            this.quantityRestockTextbox.Location = new System.Drawing.Point(168, 25);
            this.quantityRestockTextbox.Name = "quantityRestockTextbox";
            this.quantityRestockTextbox.Size = new System.Drawing.Size(123, 36);
            this.quantityRestockTextbox.TabIndex = 4;
            // 
            // quantityRestockLabel
            // 
            this.quantityRestockLabel.AutoSize = true;
            this.quantityRestockLabel.Location = new System.Drawing.Point(7, 28);
            this.quantityRestockLabel.Name = "quantityRestockLabel";
            this.quantityRestockLabel.Size = new System.Drawing.Size(220, 28);
            this.quantityRestockLabel.TabIndex = 0;
            this.quantityRestockLabel.Text = "Quantity Restock";
            // 
            // sellGroupBox
            // 
            this.sellGroupBox.Controls.Add(this.sellButton);
            this.sellGroupBox.Controls.Add(this.quantitySoldTextbox);
            this.sellGroupBox.Controls.Add(this.quantitySoldLabel);
            this.sellGroupBox.Location = new System.Drawing.Point(344, 339);
            this.sellGroupBox.Name = "sellGroupBox";
            this.sellGroupBox.Size = new System.Drawing.Size(310, 97);
            this.sellGroupBox.TabIndex = 1;
            this.sellGroupBox.TabStop = false;
            this.sellGroupBox.Text = "Sell a Products";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(167, 53);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(124, 26);
            this.sellButton.TabIndex = 5;
            this.sellButton.Text = "Sell Product";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // quantitySoldTextbox
            // 
            this.quantitySoldTextbox.Location = new System.Drawing.Point(168, 21);
            this.quantitySoldTextbox.Name = "quantitySoldTextbox";
            this.quantitySoldTextbox.Size = new System.Drawing.Size(123, 36);
            this.quantitySoldTextbox.TabIndex = 4;
            // 
            // quantitySoldLabel
            // 
            this.quantitySoldLabel.AutoSize = true;
            this.quantitySoldLabel.Location = new System.Drawing.Point(7, 28);
            this.quantitySoldLabel.Name = "quantitySoldLabel";
            this.quantitySoldLabel.Size = new System.Drawing.Size(181, 28);
            this.quantitySoldLabel.TabIndex = 0;
            this.quantitySoldLabel.Text = "Quantity Sold";
            // 
            // addaNewProductGroupBox
            // 
            this.addaNewProductGroupBox.Controls.Add(this.productTypeComboxbox);
            this.addaNewProductGroupBox.Controls.Add(this.addNewProductButton);
            this.addaNewProductGroupBox.Location = new System.Drawing.Point(16, 232);
            this.addaNewProductGroupBox.Name = "addaNewProductGroupBox";
            this.addaNewProductGroupBox.Size = new System.Drawing.Size(322, 204);
            this.addaNewProductGroupBox.TabIndex = 1;
            this.addaNewProductGroupBox.TabStop = false;
            this.addaNewProductGroupBox.Text = "Add a New Product";
            // 
            // productTypeComboxbox
            // 
            this.productTypeComboxbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeComboxbox.FormattingEnabled = true;
            this.productTypeComboxbox.Items.AddRange(new object[] {
            "Computer",
            "Chocolate"});
            this.productTypeComboxbox.Location = new System.Drawing.Point(6, 29);
            this.productTypeComboxbox.Name = "productTypeComboxbox";
            this.productTypeComboxbox.Size = new System.Drawing.Size(163, 36);
            this.productTypeComboxbox.TabIndex = 6;
            // 
            // addNewProductButton
            // 
            this.addNewProductButton.Location = new System.Drawing.Point(175, 28);
            this.addNewProductButton.Name = "addNewProductButton";
            this.addNewProductButton.Size = new System.Drawing.Size(120, 28);
            this.addNewProductButton.TabIndex = 5;
            this.addNewProductButton.Text = "Add to List";
            this.addNewProductButton.UseVisualStyleBackColor = true;
            this.addNewProductButton.Click += new System.EventHandler(this.addNewProductButton_Click);
            // 
            // productListListbox
            // 
            this.productListListbox.ContextMenuStrip = this.contextMenuStrip1;
            this.productListListbox.FormattingEnabled = true;
            this.productListListbox.ItemHeight = 28;
            this.productListListbox.Location = new System.Drawing.Point(16, 27);
            this.productListListbox.Name = "productListListbox";
            this.productListListbox.Size = new System.Drawing.Size(815, 172);
            this.productListListbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 101);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.editToolStripMenuItem.Text = "Edit....";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.deleteToolStripMenuItem.Text = "Delete....";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // POSMainForm
            // 
            this.AcceptButton = this.addNewProductButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(963, 481);
            this.Controls.Add(this.ProductListGroupbox);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POSMainForm";
            this.Text = "Point of Sale";
            this.Load += new System.EventHandler(this.POSMainForm_Load);
            this.ProductListGroupbox.ResumeLayout(false);
            this.fileoperationGroupbox.ResumeLayout(false);
            this.restockGroupBox.ResumeLayout(false);
            this.restockGroupBox.PerformLayout();
            this.sellGroupBox.ResumeLayout(false);
            this.sellGroupBox.PerformLayout();
            this.addaNewProductGroupBox.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProductListGroupbox;
        private System.Windows.Forms.GroupBox addaNewProductGroupBox;
        private System.Windows.Forms.Button addNewProductButton;
        private System.Windows.Forms.ListBox productListListbox;
        private System.Windows.Forms.GroupBox sellGroupBox;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.TextBox quantitySoldTextbox;
        private System.Windows.Forms.Label quantitySoldLabel;
        private System.Windows.Forms.GroupBox restockGroupBox;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.TextBox quantityRestockTextbox;
        private System.Windows.Forms.Label quantityRestockLabel;
        private System.Windows.Forms.GroupBox fileoperationGroupbox;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.Button loadProductButton;
        private System.Windows.Forms.ComboBox productTypeComboxbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

