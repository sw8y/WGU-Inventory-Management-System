namespace XBYNUM_BFM1_TASK1
{
    partial class addPartForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inHouseRadioButtonPart = new System.Windows.Forms.RadioButton();
            this.outsourcedRadioButtonPart = new System.Windows.Forms.RadioButton();
            this.IdPart = new System.Windows.Forms.Label();
            this.idPartTextBox = new System.Windows.Forms.TextBox();
            this.NamePart = new System.Windows.Forms.Label();
            this.namePartTextBox = new System.Windows.Forms.TextBox();
            this.InventoryPart = new System.Windows.Forms.Label();
            this.inventoryPartTextBox = new System.Windows.Forms.TextBox();
            this.pricePartTextBox = new System.Windows.Forms.TextBox();
            this.PricePart = new System.Windows.Forms.Label();
            this.maxNumPartTextBox = new System.Windows.Forms.TextBox();
            this.MaxNumPart = new System.Windows.Forms.Label();
            this.MinNumPart = new System.Windows.Forms.Label();
            this.minNumPartTextBox = new System.Windows.Forms.TextBox();
            this.machineCompanyIdTextBox = new System.Windows.Forms.TextBox();
            this.MachineCompanyIdPart = new System.Windows.Forms.Label();
            this.addPartSaveButton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // inHouseRadioButtonPart
            // 
            this.inHouseRadioButtonPart.AutoSize = true;
            this.inHouseRadioButtonPart.Location = new System.Drawing.Point(240, 13);
            this.inHouseRadioButtonPart.Name = "inHouseRadioButtonPart";
            this.inHouseRadioButtonPart.Size = new System.Drawing.Size(68, 17);
            this.inHouseRadioButtonPart.TabIndex = 1;
            this.inHouseRadioButtonPart.TabStop = true;
            this.inHouseRadioButtonPart.Text = "In-House";
            this.inHouseRadioButtonPart.UseVisualStyleBackColor = true;
            this.inHouseRadioButtonPart.CheckedChanged += new System.EventHandler(this.inHouseRadioButton_CheckedChanged);
            // 
            // outsourcedRadioButtonPart
            // 
            this.outsourcedRadioButtonPart.AutoSize = true;
            this.outsourcedRadioButtonPart.Location = new System.Drawing.Point(433, 13);
            this.outsourcedRadioButtonPart.Name = "outsourcedRadioButtonPart";
            this.outsourcedRadioButtonPart.Size = new System.Drawing.Size(80, 17);
            this.outsourcedRadioButtonPart.TabIndex = 2;
            this.outsourcedRadioButtonPart.TabStop = true;
            this.outsourcedRadioButtonPart.Text = "Outsourced";
            this.outsourcedRadioButtonPart.UseVisualStyleBackColor = true;
            this.outsourcedRadioButtonPart.CheckedChanged += new System.EventHandler(this.outsourcedRadioButton_CheckedChanged);
            // 
            // IdPart
            // 
            this.IdPart.AutoSize = true;
            this.IdPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdPart.Location = new System.Drawing.Point(240, 89);
            this.IdPart.Name = "IdPart";
            this.IdPart.Size = new System.Drawing.Size(19, 15);
            this.IdPart.TabIndex = 3;
            this.IdPart.Text = "ID";
            // 
            // idPartTextBox
            // 
            this.idPartTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idPartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idPartTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.idPartTextBox.Location = new System.Drawing.Point(265, 88);
            this.idPartTextBox.Name = "idPartTextBox";
            this.idPartTextBox.Size = new System.Drawing.Size(145, 20);
            this.idPartTextBox.TabIndex = 4;
            // 
            // NamePart
            // 
            this.NamePart.AutoSize = true;
            this.NamePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePart.Location = new System.Drawing.Point(218, 133);
            this.NamePart.Name = "NamePart";
            this.NamePart.Size = new System.Drawing.Size(41, 15);
            this.NamePart.TabIndex = 5;
            this.NamePart.Text = "Name";
            // 
            // namePartTextBox
            // 
            this.namePartTextBox.BackColor = System.Drawing.Color.Tomato;
            this.namePartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namePartTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.namePartTextBox.Location = new System.Drawing.Point(265, 133);
            this.namePartTextBox.Name = "namePartTextBox";
            this.namePartTextBox.Size = new System.Drawing.Size(145, 20);
            this.namePartTextBox.TabIndex = 6;
            // 
            // InventoryPart
            // 
            this.InventoryPart.AutoSize = true;
            this.InventoryPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryPart.Location = new System.Drawing.Point(204, 177);
            this.InventoryPart.Name = "InventoryPart";
            this.InventoryPart.Size = new System.Drawing.Size(55, 15);
            this.InventoryPart.TabIndex = 7;
            this.InventoryPart.Text = "Inventory";
            // 
            // inventoryPartTextBox
            // 
            this.inventoryPartTextBox.BackColor = System.Drawing.Color.Tomato;
            this.inventoryPartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inventoryPartTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.inventoryPartTextBox.Location = new System.Drawing.Point(265, 177);
            this.inventoryPartTextBox.Name = "inventoryPartTextBox";
            this.inventoryPartTextBox.Size = new System.Drawing.Size(145, 20);
            this.inventoryPartTextBox.TabIndex = 8;
            // 
            // pricePartTextBox
            // 
            this.pricePartTextBox.BackColor = System.Drawing.Color.Tomato;
            this.pricePartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricePartTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pricePartTextBox.Location = new System.Drawing.Point(265, 215);
            this.pricePartTextBox.Name = "pricePartTextBox";
            this.pricePartTextBox.Size = new System.Drawing.Size(145, 20);
            this.pricePartTextBox.TabIndex = 10;
            // 
            // PricePart
            // 
            this.PricePart.AutoSize = true;
            this.PricePart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PricePart.Location = new System.Drawing.Point(191, 215);
            this.PricePart.Name = "PricePart";
            this.PricePart.Size = new System.Drawing.Size(68, 15);
            this.PricePart.TabIndex = 9;
            this.PricePart.Text = "Price / Cost";
            // 
            // maxNumPartTextBox
            // 
            this.maxNumPartTextBox.BackColor = System.Drawing.Color.Tomato;
            this.maxNumPartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxNumPartTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maxNumPartTextBox.Location = new System.Drawing.Point(265, 259);
            this.maxNumPartTextBox.Name = "maxNumPartTextBox";
            this.maxNumPartTextBox.Size = new System.Drawing.Size(67, 20);
            this.maxNumPartTextBox.TabIndex = 12;
            // 
            // MaxNumPart
            // 
            this.MaxNumPart.AutoSize = true;
            this.MaxNumPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxNumPart.Location = new System.Drawing.Point(228, 259);
            this.MaxNumPart.Name = "MaxNumPart";
            this.MaxNumPart.Size = new System.Drawing.Size(31, 15);
            this.MaxNumPart.TabIndex = 11;
            this.MaxNumPart.Text = "Max";
            // 
            // MinNumPart
            // 
            this.MinNumPart.AutoSize = true;
            this.MinNumPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinNumPart.Location = new System.Drawing.Point(352, 259);
            this.MinNumPart.Name = "MinNumPart";
            this.MinNumPart.Size = new System.Drawing.Size(28, 15);
            this.MinNumPart.TabIndex = 13;
            this.MinNumPart.Text = "Min";
            // 
            // minNumPartTextBox
            // 
            this.minNumPartTextBox.BackColor = System.Drawing.Color.Tomato;
            this.minNumPartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minNumPartTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.minNumPartTextBox.Location = new System.Drawing.Point(386, 259);
            this.minNumPartTextBox.Name = "minNumPartTextBox";
            this.minNumPartTextBox.Size = new System.Drawing.Size(67, 20);
            this.minNumPartTextBox.TabIndex = 14;
            // 
            // machineCompanyIdTextBox
            // 
            this.machineCompanyIdTextBox.BackColor = System.Drawing.Color.Tomato;
            this.machineCompanyIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.machineCompanyIdTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.machineCompanyIdTextBox.Location = new System.Drawing.Point(265, 310);
            this.machineCompanyIdTextBox.Name = "machineCompanyIdTextBox";
            this.machineCompanyIdTextBox.Size = new System.Drawing.Size(145, 20);
            this.machineCompanyIdTextBox.TabIndex = 16;
            // 
            // MachineCompanyIdPart
            // 
            this.MachineCompanyIdPart.AutoSize = true;
            this.MachineCompanyIdPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MachineCompanyIdPart.Location = new System.Drawing.Point(163, 310);
            this.MachineCompanyIdPart.Name = "MachineCompanyIdPart";
            this.MachineCompanyIdPart.Size = new System.Drawing.Size(70, 15);
            this.MachineCompanyIdPart.TabIndex = 15;
            this.MachineCompanyIdPart.Text = "Machine ID";
            // 
            // addPartSaveButton
            // 
            this.addPartSaveButton.Location = new System.Drawing.Point(552, 360);
            this.addPartSaveButton.Name = "addPartSaveButton";
            this.addPartSaveButton.Size = new System.Drawing.Size(74, 42);
            this.addPartSaveButton.TabIndex = 17;
            this.addPartSaveButton.Text = "Save";
            this.addPartSaveButton.UseVisualStyleBackColor = true;
            this.addPartSaveButton.Click += new System.EventHandler(this.addPartSaveButton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Location = new System.Drawing.Point(641, 360);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(74, 42);
            this.addPartCancelButton.TabIndex = 18;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.addPartCancelButton_Click);
            // 
            // addPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPartSaveButton);
            this.Controls.Add(this.machineCompanyIdTextBox);
            this.Controls.Add(this.MachineCompanyIdPart);
            this.Controls.Add(this.minNumPartTextBox);
            this.Controls.Add(this.MinNumPart);
            this.Controls.Add(this.maxNumPartTextBox);
            this.Controls.Add(this.MaxNumPart);
            this.Controls.Add(this.pricePartTextBox);
            this.Controls.Add(this.PricePart);
            this.Controls.Add(this.inventoryPartTextBox);
            this.Controls.Add(this.InventoryPart);
            this.Controls.Add(this.namePartTextBox);
            this.Controls.Add(this.NamePart);
            this.Controls.Add(this.idPartTextBox);
            this.Controls.Add(this.IdPart);
            this.Controls.Add(this.outsourcedRadioButtonPart);
            this.Controls.Add(this.inHouseRadioButtonPart);
            this.Controls.Add(this.label1);
            this.Name = "addPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton inHouseRadioButtonPart;
        private System.Windows.Forms.RadioButton outsourcedRadioButtonPart;
        private System.Windows.Forms.Label IdPart;
        private System.Windows.Forms.TextBox idPartTextBox;
        private System.Windows.Forms.Label NamePart;
        private System.Windows.Forms.TextBox namePartTextBox;
        private System.Windows.Forms.Label InventoryPart;
        private System.Windows.Forms.TextBox inventoryPartTextBox;
        private System.Windows.Forms.TextBox pricePartTextBox;
        private System.Windows.Forms.Label PricePart;
        private System.Windows.Forms.TextBox maxNumPartTextBox;
        private System.Windows.Forms.Label MaxNumPart;
        private System.Windows.Forms.Label MinNumPart;
        private System.Windows.Forms.TextBox minNumPartTextBox;
        private System.Windows.Forms.TextBox machineCompanyIdTextBox;
        private System.Windows.Forms.Label MachineCompanyIdPart;
        private System.Windows.Forms.Button addPartSaveButton;
        private System.Windows.Forms.Button addPartCancelButton;
    }
}