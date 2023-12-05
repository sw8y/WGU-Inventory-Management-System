using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XBYNUM_BFM1_TASK1
{
    public partial class modifyProductForm : Form
    {
        public static string selectedProductID;
        DataTable associatedPartsTable = new DataTable("Associated Parts");
        private DataSet dSet;
        public modifyProductForm()
        {
            InitializeComponent();
            CreatePartsTable();
            CreateAssociatedPartsTable();
            idProductTextBox.Enabled = false;
            foreach (Product item in Inventory.AllProducts)
            {
                if (item.ProductID == Convert.ToInt32(selectedProductID)) 
                {
                    nameProductTextBox.Text = item.Name;
                    inventoryProductTextBox.Text = Convert.ToString(item.InStock);
                    priceProductTextBox.Text = Convert.ToString(item.Price);
                    minNumProductTextBox.Text = Convert.ToString(item.Min);
                    maxNumProductTextBox.Text = Convert.ToString(item.Max);
                    break;
                }
            }
            idProductTextBox.Text = Convert.ToString(selectedProductID);
        }

        private bool valueChecker()
        {
            bool status = false;
            Dictionary<string, string> fields = new Dictionary<string, string> {
                {InventoryProduct.Text, inventoryProductTextBox.Text},
                {MinNumProduct.Text, minNumProductTextBox.Text},
                {MaxNumProduct.Text, maxNumProductTextBox.Text},
            };

            foreach (KeyValuePair<string, string> field in fields)
            {
                if (field.Value.All(char.IsDigit) == false)
                {
                    MessageBox.Show($"The {field.Key} field must contain a numerical value only. Please correct.");
                    status = false;
                    break;
                }
                else { status = true; }
            }
            try
            {
                if (status) 
                {
                    decimal val;
                    if (!decimal.TryParse(priceProductTextBox.Text, out val))
                    {
                        MessageBox.Show($"The {PriceProduct.Text} field must contain a numerical value only. Please correct.");
                        status = false;
                    }
                    else if (Convert.ToInt32(fields[MinNumProduct.Text]) > Convert.ToInt32(fields[MaxNumProduct.Text]))
                    {
                        MessageBox.Show($"The {MinNumProduct.Text} field cannot be higher than the Max field. Please correct.");
                        status = false;
                    }
                    else if (Convert.ToInt32(fields[InventoryProduct.Text]) < Convert.ToInt32(fields[MinNumProduct.Text]))
                    {
                        MessageBox.Show($"The {InventoryProduct.Text} field must be higher than or equal to the Min field. Please correct.");
                        status = false;
                    }
                    else if (Convert.ToInt32(fields[InventoryProduct.Text]) > Convert.ToInt32(fields[MaxNumProduct.Text]))
                    {
                        MessageBox.Show($"The {InventoryProduct.Text} field must be lower than or equal to the Max field. Please correct.");
                        status = false;
                    }
                    else { status = true; }
                }
              
            }
            catch (FormatException)
            {
                status = false;
            }

            return status;
        }
        private void modifyProductAddAssociatedPartButton_Click(object sender, EventArgs e)
        {
            int partToAdd = Convert.ToInt32(productsAddDataGridView.CurrentRow.Cells["Part ID"].Value);
            try
            {
                Part part = Inventory.AllParts.Single(c => c.PartID == partToAdd);
                Product product = new Product();
                product.addAssociatedPart(part);

                DataRow drToAdd = (associatedPartsDataGridView.DataSource as DataTable).NewRow();

                drToAdd["Part ID"] = part.PartID;
                drToAdd["Name"] = part.Name;
                drToAdd["Inventory"] = part.InStock;
                drToAdd["Price"] = part.Price;
                drToAdd["Min"] = part.Min;
                drToAdd["Max"] = part.Max;
                try
                {
                    associatedPartsTable.Rows.Add(drToAdd);
                    associatedPartsTable.AcceptChanges();
                }
                catch (ConstraintException) { MessageBox.Show("This part has already been added to the associated parts list."); }
            }
            catch (InvalidOperationException) { MessageBox.Show("Nothing selected to add!"); }
        }

        private void modifyProductDeleteAssociatedPartButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            int partToRemove = Convert.ToInt32(associatedPartsDataGridView.CurrentRow.Cells["Part ID"].Value);

            // confirmation Message Box source: https://stackoverflow.com/questions/5414270/messagebox-buttons
            var message = "Are you sure you want to delete this part?";
            var title = "DELETION Event Detected!";
            var result = MessageBox.Show(
                message, title,                 // will display the message
                MessageBoxButtons.YesNo,  // will show two buttons: Yes and No
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete from Associated Part list
                    product.removeAssociatedPart(partToRemove);

                    // Delete from Associate Parts Table
                    associatedPartsTable.Rows.Remove(associatedPartsTable.Rows.Find(partToRemove));
                    associatedPartsTable.AcceptChanges();
                }
                catch (NullReferenceException) { MessageBox.Show("Nothing has been selected to Delete!"); }
            }
        }

        private void modifyProductSaveButton_Click(object sender, EventArgs e)
        {
            var success = valueChecker();
            if (success)
            {
                Product product = new Product();
                product.ProductID = Convert.ToInt32(idProductTextBox.Text);
                product.Name = nameProductTextBox.Text;
                product.InStock = Convert.ToInt32(inventoryProductTextBox.Text);
                product.Price = Convert.ToDecimal(priceProductTextBox.Text);
                product.Max = Convert.ToInt32(maxNumProductTextBox.Text);
                product.Min = Convert.ToInt32(minNumProductTextBox.Text);
                Inventory.updateProduct(Convert.ToInt32(idProductTextBox.Text), product);
                this.Hide();
                MainScreen MS = new MainScreen();
                MS.ShowDialog();
                this.Close();
            }
        }

        private void modifyProductCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MS = new MainScreen();
            MS.ShowDialog();
            this.Close();
        }

        private void searchBoxAddProductButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = searchTextBox.Text;
            productsAddDataGridView.ClearSelection();

            if (searchCriteria.All(char.IsDigit) == true)
            {
                try
                {
                    Part returnedData = Inventory.lookupPart(Convert.ToInt32(searchCriteria));
                    Debug.WriteLine($"{returnedData.PartID}");
                    foreach (DataGridViewRow row in productsAddDataGridView.Rows)
                    {
                        // 0 is the column index
                        if (row.Cells[0].Value.ToString().Equals(Convert.ToString(returnedData.PartID)))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
                catch (FormatException) { MessageBox.Show("Part could not be found!"); }

            }
            else
            {
                foreach (DataGridViewRow row in productsAddDataGridView.Rows)
                {
                    // 1 is the column index
                    if (row.Cells[1].Value.ToString().Equals(searchCriteria))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }
        public void CreatePartsTable()
        {

            DataTable partsTable = new DataTable("All Parts");
            // Creating a new DataTable.

            DataColumn partsDataColumn;

            DataRow partsDataRow;

            // Create Part ID column

            partsDataColumn = new DataColumn();
            partsDataColumn.DataType = typeof(Int32);
            partsDataColumn.ColumnName = "Part ID";
            partsDataColumn.Caption = "Part ID";
            partsDataColumn.ReadOnly = true;
            partsDataColumn.Unique = true;

            // Add column to the DataColumnCollection.
            partsTable.Columns.Add(partsDataColumn);

            // Create Parts Name column.

            partsDataColumn = new DataColumn();
            partsDataColumn.DataType = typeof(String);
            partsDataColumn.ColumnName = "Name";
            partsDataColumn.Caption = "Part Name";
            partsDataColumn.AutoIncrement = false;
            partsDataColumn.ReadOnly = false;
            partsDataColumn.Unique = false;

            /// Add column to the DataColumnCollection.
            partsTable.Columns.Add(partsDataColumn);

            // Create Inventory column.

            partsDataColumn = new DataColumn();
            partsDataColumn.DataType = typeof(Int32);
            partsDataColumn.ColumnName = "Inventory";
            partsDataColumn.Caption = "Inventory";
            partsDataColumn.ReadOnly = false;
            partsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            partsTable.Columns.Add(partsDataColumn);

            // Create Price column.

            partsDataColumn = new DataColumn();
            partsDataColumn.DataType = typeof(Decimal);
            partsDataColumn.ColumnName = "Price";
            partsDataColumn.Caption = "Price";
            partsDataColumn.ReadOnly = false;
            partsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            partsTable.Columns.Add(partsDataColumn);

            // Create Min column.

            partsDataColumn = new DataColumn();
            partsDataColumn.DataType = typeof(Int32);
            partsDataColumn.ColumnName = "Min";
            partsDataColumn.Caption = "Min";
            partsDataColumn.ReadOnly = false;
            partsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            partsTable.Columns.Add(partsDataColumn);

            // Create Max column.

            partsDataColumn = new DataColumn();
            partsDataColumn.DataType = typeof(Int32);
            partsDataColumn.ColumnName = "Max";
            partsDataColumn.Caption = "Max";
            partsDataColumn.ReadOnly = false;
            partsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            partsTable.Columns.Add(partsDataColumn);


            // Make Part ID column the primary key column.

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = partsTable.Columns["Part ID"];
            partsTable.PrimaryKey = PrimaryKeyColumns;

            // Create a new DataSet

            dSet = new DataSet();

            // Add Parts Table to the DataSet.

            dSet.Tables.Add(partsTable);

            // Add data rows to the Parts Table using NewRow method

            foreach (Part part in Inventory.AllParts)
            {
                partsDataRow = partsTable.NewRow();

                partsDataRow["Part ID"] = part.PartID;
                partsDataRow["Name"] = part.Name;
                partsDataRow["Inventory"] = part.InStock;
                partsDataRow["Price"] = part.Price;
                partsDataRow["Min"] = part.Min;
                partsDataRow["Max"] = part.Max;

                partsTable.Rows.Add(partsDataRow);
            }

            // Bind data to DataGridView.DataSource
            productsAddDataGridView.DataSource = dSet.Tables["All Parts"];
        }
        public void CreateAssociatedPartsTable()
        {


            // Creating a new DataTable.

            DataColumn associatedPartsDataColumn;
            DataRow associatedPartsDataRow;

            // Create Part ID column

            associatedPartsDataColumn = new DataColumn();
            associatedPartsDataColumn.DataType = typeof(Int32);
            associatedPartsDataColumn.ColumnName = "Part ID";
            associatedPartsDataColumn.Caption = "Part ID";
            associatedPartsDataColumn.ReadOnly = true;
            associatedPartsDataColumn.Unique = true;

            // Add column to the DataColumnCollection.
            associatedPartsTable.Columns.Add(associatedPartsDataColumn);

            // Create Parts Name column.

            associatedPartsDataColumn = new DataColumn();
            associatedPartsDataColumn.DataType = typeof(String);
            associatedPartsDataColumn.ColumnName = "Name";
            associatedPartsDataColumn.Caption = "Product Name";
            associatedPartsDataColumn.AutoIncrement = false;
            associatedPartsDataColumn.ReadOnly = false;
            associatedPartsDataColumn.Unique = false;

            /// Add column to the DataColumnCollection.
            associatedPartsTable.Columns.Add(associatedPartsDataColumn);

            // Create Inventory column.

            associatedPartsDataColumn = new DataColumn();
            associatedPartsDataColumn.DataType = typeof(Int32);
            associatedPartsDataColumn.ColumnName = "Inventory";
            associatedPartsDataColumn.Caption = "Inventory";
            associatedPartsDataColumn.ReadOnly = false;
            associatedPartsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            associatedPartsTable.Columns.Add(associatedPartsDataColumn);

            // Create Price column.

            associatedPartsDataColumn = new DataColumn();
            associatedPartsDataColumn.DataType = typeof(Decimal);
            associatedPartsDataColumn.ColumnName = "Price";
            associatedPartsDataColumn.Caption = "Price";
            associatedPartsDataColumn.ReadOnly = false;
            associatedPartsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            associatedPartsTable.Columns.Add(associatedPartsDataColumn);

            // Create Min column.

            associatedPartsDataColumn = new DataColumn();
            associatedPartsDataColumn.DataType = typeof(Int32);
            associatedPartsDataColumn.ColumnName = "Min";
            associatedPartsDataColumn.Caption = "Min";
            associatedPartsDataColumn.ReadOnly = false;
            associatedPartsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            associatedPartsTable.Columns.Add(associatedPartsDataColumn);

            // Create Max column.

            associatedPartsDataColumn = new DataColumn();
            associatedPartsDataColumn.DataType = typeof(Int32);
            associatedPartsDataColumn.ColumnName = "Max";
            associatedPartsDataColumn.Caption = "Max";
            associatedPartsDataColumn.ReadOnly = false;
            associatedPartsDataColumn.Unique = false;

            // Add column to the DataColumnCollection.
            associatedPartsTable.Columns.Add(associatedPartsDataColumn);


            // Make Part ID column the primary key column.

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = associatedPartsTable.Columns["Part ID"];
            associatedPartsTable.PrimaryKey = PrimaryKeyColumns;

            // Create a new DataSet

            dSet = new DataSet();

            // add data to the table

            foreach (Part part in Product.AssociatedParts)
            {
                associatedPartsDataRow = associatedPartsTable.NewRow();

                associatedPartsDataRow["Part ID"]   = part.PartID;
                associatedPartsDataRow["Name"]      = part.Name;
                associatedPartsDataRow["Inventory"] = part.InStock;
                associatedPartsDataRow["Price"]     = part.Price;
                associatedPartsDataRow["Min"]       = part.Min;
                associatedPartsDataRow["Max"]       = part.Max;

                associatedPartsTable.Rows.Add(associatedPartsDataRow);
            }

            // Add Parts Table to the DataSet.

            dSet.Tables.Add(associatedPartsTable);

            // Bind data to DataGridView.DataSource
           
            associatedPartsDataGridView.DataSource = dSet.Tables["Associated Parts"];

        }
    }
}
