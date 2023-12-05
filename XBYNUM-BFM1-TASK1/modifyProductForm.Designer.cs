namespace XBYNUM_BFM1_TASK1
{
    partial class modifyProductForm
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
            this.searchBoxAddProductButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.modifyProductSaveButton = new System.Windows.Forms.Button();
            this.modifyProductCancelButton = new System.Windows.Forms.Button();
            this.modifyProductDeleteAssociatedPartButton = new System.Windows.Forms.Button();
            this.modifyProductAddAssociatedButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minNumProductTextBox = new System.Windows.Forms.TextBox();
            this.MinNumProduct = new System.Windows.Forms.Label();
            this.maxNumProductTextBox = new System.Windows.Forms.TextBox();
            this.MaxNumProduct = new System.Windows.Forms.Label();
            this.priceProductTextBox = new System.Windows.Forms.TextBox();
            this.PriceProduct = new System.Windows.Forms.Label();
            this.inventoryProductTextBox = new System.Windows.Forms.TextBox();
            this.InventoryProduct = new System.Windows.Forms.Label();
            this.nameProductTextBox = new System.Windows.Forms.TextBox();
            this.NameProduct = new System.Windows.Forms.Label();
            this.idProductTextBox = new System.Windows.Forms.TextBox();
            this.IdProduct = new System.Windows.Forms.Label();
            this.productsAddDataGridView = new System.Windows.Forms.DataGridView();
            this.associatedPartsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productsAddDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBoxAddProductButton
            // 
            this.searchBoxAddProductButton.Location = new System.Drawing.Point(454, 28);
            this.searchBoxAddProductButton.Name = "searchBoxAddProductButton";
            this.searchBoxAddProductButton.Size = new System.Drawing.Size(74, 24);
            this.searchBoxAddProductButton.TabIndex = 60;
            this.searchBoxAddProductButton.Text = "Search";
            this.searchBoxAddProductButton.UseVisualStyleBackColor = true;
            this.searchBoxAddProductButton.Click += new System.EventHandler(this.searchBoxAddProductButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(534, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(189, 20);
            this.searchTextBox.TabIndex = 59;
            // 
            // modifyProductSaveButton
            // 
            this.modifyProductSaveButton.Location = new System.Drawing.Point(534, 510);
            this.modifyProductSaveButton.Name = "modifyProductSaveButton";
            this.modifyProductSaveButton.Size = new System.Drawing.Size(76, 40);
            this.modifyProductSaveButton.TabIndex = 58;
            this.modifyProductSaveButton.Text = "Save";
            this.modifyProductSaveButton.UseVisualStyleBackColor = true;
            this.modifyProductSaveButton.Click += new System.EventHandler(this.modifyProductSaveButton_Click);
            // 
            // modifyProductCancelButton
            // 
            this.modifyProductCancelButton.Location = new System.Drawing.Point(632, 510);
            this.modifyProductCancelButton.Name = "modifyProductCancelButton";
            this.modifyProductCancelButton.Size = new System.Drawing.Size(76, 40);
            this.modifyProductCancelButton.TabIndex = 57;
            this.modifyProductCancelButton.Text = "Cancel";
            this.modifyProductCancelButton.UseVisualStyleBackColor = true;
            this.modifyProductCancelButton.Click += new System.EventHandler(this.modifyProductCancelButton_Click);
            // 
            // modifyProductDeleteAssociatedPartButton
            // 
            this.modifyProductDeleteAssociatedPartButton.Location = new System.Drawing.Point(632, 453);
            this.modifyProductDeleteAssociatedPartButton.Name = "modifyProductDeleteAssociatedPartButton";
            this.modifyProductDeleteAssociatedPartButton.Size = new System.Drawing.Size(76, 40);
            this.modifyProductDeleteAssociatedPartButton.TabIndex = 56;
            this.modifyProductDeleteAssociatedPartButton.Text = "Delete";
            this.modifyProductDeleteAssociatedPartButton.UseVisualStyleBackColor = true;
            this.modifyProductDeleteAssociatedPartButton.Click += new System.EventHandler(this.modifyProductDeleteAssociatedPartButton_Click);
            // 
            // modifyProductAddAssociatedButton
            // 
            this.modifyProductAddAssociatedButton.Location = new System.Drawing.Point(632, 240);
            this.modifyProductAddAssociatedButton.Name = "modifyProductAddAssociatedButton";
            this.modifyProductAddAssociatedButton.Size = new System.Drawing.Size(76, 40);
            this.modifyProductAddAssociatedButton.TabIndex = 55;
            this.modifyProductAddAssociatedButton.Text = "Add";
            this.modifyProductAddAssociatedButton.UseVisualStyleBackColor = true;
            this.modifyProductAddAssociatedButton.Click += new System.EventHandler(this.modifyProductAddAssociatedPartButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(368, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Parts Associated with this Product";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(368, 69);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(95, 13);
            this.partsLabel.TabIndex = 51;
            this.partsLabel.Text = "All candidate Parts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Modify Product";
            // 
            // minNumProductTextBox
            // 
            this.minNumProductTextBox.BackColor = System.Drawing.Color.White;
            this.minNumProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minNumProductTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.minNumProductTextBox.Location = new System.Drawing.Point(211, 351);
            this.minNumProductTextBox.Name = "minNumProductTextBox";
            this.minNumProductTextBox.Size = new System.Drawing.Size(67, 20);
            this.minNumProductTextBox.TabIndex = 49;
            // 
            // MinNumProduct
            // 
            this.MinNumProduct.AutoSize = true;
            this.MinNumProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinNumProduct.Location = new System.Drawing.Point(177, 351);
            this.MinNumProduct.Name = "MinNumProduct";
            this.MinNumProduct.Size = new System.Drawing.Size(28, 15);
            this.MinNumProduct.TabIndex = 48;
            this.MinNumProduct.Text = "Min";
            // 
            // maxNumProductTextBox
            // 
            this.maxNumProductTextBox.BackColor = System.Drawing.Color.White;
            this.maxNumProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxNumProductTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maxNumProductTextBox.Location = new System.Drawing.Point(90, 351);
            this.maxNumProductTextBox.Name = "maxNumProductTextBox";
            this.maxNumProductTextBox.Size = new System.Drawing.Size(67, 20);
            this.maxNumProductTextBox.TabIndex = 47;
            // 
            // MaxNumProduct
            // 
            this.MaxNumProduct.AutoSize = true;
            this.MaxNumProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxNumProduct.Location = new System.Drawing.Point(53, 351);
            this.MaxNumProduct.Name = "MaxNumProduct";
            this.MaxNumProduct.Size = new System.Drawing.Size(31, 15);
            this.MaxNumProduct.TabIndex = 46;
            this.MaxNumProduct.Text = "Max";
            // 
            // priceProductTextBox
            // 
            this.priceProductTextBox.BackColor = System.Drawing.Color.White;
            this.priceProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceProductTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.priceProductTextBox.Location = new System.Drawing.Point(90, 307);
            this.priceProductTextBox.Name = "priceProductTextBox";
            this.priceProductTextBox.Size = new System.Drawing.Size(145, 20);
            this.priceProductTextBox.TabIndex = 45;
            // 
            // PriceProduct
            // 
            this.PriceProduct.AutoSize = true;
            this.PriceProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceProduct.Location = new System.Drawing.Point(49, 307);
            this.PriceProduct.Name = "PriceProduct";
            this.PriceProduct.Size = new System.Drawing.Size(35, 15);
            this.PriceProduct.TabIndex = 44;
            this.PriceProduct.Text = "Price";
            // 
            // inventoryProductTextBox
            // 
            this.inventoryProductTextBox.BackColor = System.Drawing.Color.White;
            this.inventoryProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryProductTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inventoryProductTextBox.Location = new System.Drawing.Point(90, 269);
            this.inventoryProductTextBox.Name = "inventoryProductTextBox";
            this.inventoryProductTextBox.Size = new System.Drawing.Size(145, 20);
            this.inventoryProductTextBox.TabIndex = 43;
            // 
            // InventoryProduct
            // 
            this.InventoryProduct.AutoSize = true;
            this.InventoryProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryProduct.Location = new System.Drawing.Point(29, 269);
            this.InventoryProduct.Name = "InventoryProduct";
            this.InventoryProduct.Size = new System.Drawing.Size(55, 15);
            this.InventoryProduct.TabIndex = 42;
            this.InventoryProduct.Text = "Inventory";
            // 
            // nameProductTextBox
            // 
            this.nameProductTextBox.BackColor = System.Drawing.Color.White;
            this.nameProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameProductTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nameProductTextBox.Location = new System.Drawing.Point(90, 225);
            this.nameProductTextBox.Name = "nameProductTextBox";
            this.nameProductTextBox.Size = new System.Drawing.Size(145, 20);
            this.nameProductTextBox.TabIndex = 41;
            // 
            // NameProduct
            // 
            this.NameProduct.AutoSize = true;
            this.NameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameProduct.Location = new System.Drawing.Point(43, 225);
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.Size = new System.Drawing.Size(41, 15);
            this.NameProduct.TabIndex = 40;
            this.NameProduct.Text = "Name";
            // 
            // idProductTextBox
            // 
            this.idProductTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idProductTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idProductTextBox.Location = new System.Drawing.Point(90, 180);
            this.idProductTextBox.Name = "idProductTextBox";
            this.idProductTextBox.Size = new System.Drawing.Size(145, 20);
            this.idProductTextBox.TabIndex = 39;
            // 
            // IdProduct
            // 
            this.IdProduct.AutoSize = true;
            this.IdProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProduct.Location = new System.Drawing.Point(65, 181);
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.Size = new System.Drawing.Size(19, 15);
            this.IdProduct.TabIndex = 38;
            this.IdProduct.Text = "ID";
            // 
            // productsAddDataGridView
            // 
            this.productsAddDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsAddDataGridView.Location = new System.Drawing.Point(368, 85);
            this.productsAddDataGridView.Name = "productsAddDataGridView";
            this.productsAddDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsAddDataGridView.Size = new System.Drawing.Size(355, 139);
            this.productsAddDataGridView.TabIndex = 63;
            // 
            // associatedPartsDataGridView
            // 
            this.associatedPartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.associatedPartsDataGridView.Location = new System.Drawing.Point(368, 308);
            this.associatedPartsDataGridView.Name = "associatedPartsDataGridView";
            this.associatedPartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.associatedPartsDataGridView.Size = new System.Drawing.Size(355, 139);
            this.associatedPartsDataGridView.TabIndex = 64;
            // 
            // modifyProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 572);
            this.Controls.Add(this.associatedPartsDataGridView);
            this.Controls.Add(this.productsAddDataGridView);
            this.Controls.Add(this.searchBoxAddProductButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.modifyProductSaveButton);
            this.Controls.Add(this.modifyProductCancelButton);
            this.Controls.Add(this.modifyProductDeleteAssociatedPartButton);
            this.Controls.Add(this.modifyProductAddAssociatedButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minNumProductTextBox);
            this.Controls.Add(this.MinNumProduct);
            this.Controls.Add(this.maxNumProductTextBox);
            this.Controls.Add(this.MaxNumProduct);
            this.Controls.Add(this.priceProductTextBox);
            this.Controls.Add(this.PriceProduct);
            this.Controls.Add(this.inventoryProductTextBox);
            this.Controls.Add(this.InventoryProduct);
            this.Controls.Add(this.nameProductTextBox);
            this.Controls.Add(this.NameProduct);
            this.Controls.Add(this.idProductTextBox);
            this.Controls.Add(this.IdProduct);
            this.Name = "modifyProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.productsAddDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.associatedPartsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBoxAddProductButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button modifyProductSaveButton;
        private System.Windows.Forms.Button modifyProductCancelButton;
        private System.Windows.Forms.Button modifyProductDeleteAssociatedPartButton;
        private System.Windows.Forms.Button modifyProductAddAssociatedButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minNumProductTextBox;
        private System.Windows.Forms.Label MinNumProduct;
        private System.Windows.Forms.TextBox maxNumProductTextBox;
        private System.Windows.Forms.Label MaxNumProduct;
        private System.Windows.Forms.TextBox priceProductTextBox;
        private System.Windows.Forms.Label PriceProduct;
        private System.Windows.Forms.TextBox inventoryProductTextBox;
        private System.Windows.Forms.Label InventoryProduct;
        private System.Windows.Forms.TextBox nameProductTextBox;
        private System.Windows.Forms.Label NameProduct;
        private System.Windows.Forms.TextBox idProductTextBox;
        private System.Windows.Forms.Label IdProduct;
        private System.Windows.Forms.DataGridView productsAddDataGridView;
        private System.Windows.Forms.DataGridView associatedPartsDataGridView;
    }
}