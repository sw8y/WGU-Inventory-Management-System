using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XBYNUM_BFM1_TASK1
{
    public partial class MainScreen : Form
    {
        DataTable partsTable = new DataTable("All Parts");
        DataTable productsTable = new DataTable("All Products");
        private DataSet dSet;
   
        public MainScreen()
        {

            InitializeComponent();
            CreatePartsTable();
            CreateProductsTable();
        }
        private void partSearchButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = partSearchTextBox.Text;
            partsDataGridView.ClearSelection();
      
            if (searchCriteria.All(char.IsDigit) == true) 
            {
                try 
                {
                    Part returnedData = Inventory.lookupPart(Convert.ToInt32(searchCriteria));
                    Debug.WriteLine($"{returnedData.PartID}");
                    foreach (DataGridViewRow row in partsDataGridView.Rows)
                    {
                        // 0 is the column index
                        if (row.Cells[0].Value.ToString().Equals(Convert.ToString(returnedData.PartID)))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                } catch (FormatException) { MessageBox.Show("Part could not be found!"); }
                
            }
            else
            {
                foreach (DataGridViewRow row in partsDataGridView.Rows)
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

        private void productSearchButton_Click(object sender, EventArgs e)
        {
            string searchCriteria = productSearchTextBox.Text;
            productsDataGridView.ClearSelection();
           
            if (searchCriteria.All(char.IsDigit) == true)
            {
                try
                {
                    Product returnedData = Inventory.lookupProduct(Convert.ToInt32(searchCriteria));
                    Debug.WriteLine($"{returnedData.ProductID}");
                    foreach (DataGridViewRow row in productsDataGridView.Rows)
                    {
                        // 0 is the column index
                        if (row.Cells[0].Value.ToString().Equals(Convert.ToString(returnedData.ProductID)))
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
                foreach (DataGridViewRow row in productsDataGridView.Rows)
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

        public void addPartsButton_Click(object sender, EventArgs e)
        {
            addPartForm APF = new addPartForm();
            this.Hide();
            APF.ShowDialog();
            this.Close();
        }

        private void modifyPartsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyPartForm.selectedPartID = partsDataGridView.CurrentRow.Cells["Part ID"].Value.ToString();
            modifyPartForm MPF = new modifyPartForm();
            MPF.ShowDialog();
            this.Close();
        }

        private void deletePartsButton_Click(object sender, EventArgs e)
        {
            Part remove = Inventory.lookupPart(Convert.ToInt32(partsDataGridView.CurrentRow.Cells["Part ID"].Value));

            // confirmation Message Box source: https://stackoverflow.com/questions/5414270/messagebox-buttons
            var message = $"Are you sure you want to delete this part?\n\n Part ID:{remove.PartID}, Part Name: {remove.Name}";
            var title = "DELETION Event Detected!";
            var result = MessageBox.Show(
                message, title,                 // will display the message
                MessageBoxButtons.YesNo,  // will show two buttons: Yes and No
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try 
                {
                    Inventory.deletePart(remove);
                    partsTable.Rows.Remove(partsTable.Rows.Find(remove.PartID));
                    partsTable.AcceptChanges();
                }
                catch (NullReferenceException) { MessageBox.Show("Nothing has been selected to Delete!"); }
            }
        }

        private void addProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addProductForm APDF = new addProductForm();
            APDF.ShowDialog();
            this.Close();
        }

        private void modifyProductsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            modifyProductForm.selectedProductID = productsDataGridView.CurrentRow.Cells["Product ID"].Value.ToString();
            modifyProductForm MPDF = new modifyProductForm();
            MPDF.ShowDialog();
            this.Close();
        }

        private void deleteProductsButton_Click(object sender, EventArgs e)
        {
            Product remove = Inventory.lookupProduct(Convert.ToInt32(productsDataGridView.CurrentRow.Cells["Product ID"].Value));

            // confirmation Message Box source: https://stackoverflow.com/questions/5414270/messagebox-buttons
            var message = $"Are you sure you want to delete this product?\n\n Product ID:{remove.ProductID}, Product Name: {remove.Name}";
            var title = "DELETION Event Detected!";
            var result = MessageBox.Show(
                message, title,                 // will display the message
                MessageBoxButtons.YesNo,  // will show two buttons: Yes and No
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (!Product.AssociatedParts.Any())
                {
                    Inventory.removeProduct(remove.ProductID);
                    productsTable.Rows.Remove(productsTable.Rows.Find(remove.ProductID));
                    productsTable.AcceptChanges();
                }
                else { MessageBox.Show("This list of associated parts is not empty! Please disassociate parts first."); }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CreatePartsTable() 
        {
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

                partsDataRow["Part ID"]   = part.PartID;
                partsDataRow["Name"]      = part.Name;
                partsDataRow["Inventory"] = part.InStock;
                partsDataRow["Price"]     = part.Price;
                partsDataRow["Min"]       = part.Min;
                partsDataRow["Max"]       = part.Max;

                partsTable.Rows.Add(partsDataRow);
            }

            // Bind data to DataGridView.DataSource
            partsDataGridView.DataSource = dSet.Tables["All Parts"];

        }
        
        private void CreateProductsTable()
        { 
            DataColumn productsDataColumn;
            DataRow productsDataRow;

            // Create Product ID column

            productsDataColumn = new DataColumn();
            productsDataColumn.DataType = Type.GetType("System.Int32");
            productsDataColumn.ColumnName = "Product ID";
            productsDataColumn.Caption = "Product ID";
            productsDataColumn.ReadOnly = true;
            productsDataColumn.Unique = true;
            productsTable.Columns.Add(productsDataColumn);

            // Create Name column.

            productsDataColumn = new DataColumn();
            productsDataColumn.DataType = Type.GetType("System.String");
            productsDataColumn.ColumnName = "Name";
            productsDataColumn.Caption = "Name";
            productsTable.Columns.Add(productsDataColumn);

            // Create Inventory column.

            productsDataColumn = new DataColumn();
            productsDataColumn.DataType = typeof(Int32);
            productsDataColumn.ColumnName = "Inventory";
            productsDataColumn.Caption = "Inventory";
            productsDataColumn.ReadOnly = false;
            productsDataColumn.Unique = false;
            productsTable.Columns.Add(productsDataColumn);

            // Create Price column.

            productsDataColumn = new DataColumn();
            productsDataColumn.DataType = typeof(Decimal);
            productsDataColumn.ColumnName = "Price";
            productsDataColumn.Caption = "Price";
            productsDataColumn.ReadOnly = false;
            productsDataColumn.Unique = false;
            productsTable.Columns.Add(productsDataColumn);

            // Create Min column.

            productsDataColumn = new DataColumn();
            productsDataColumn.DataType = typeof(Int32);
            productsDataColumn.ColumnName = "Min";
            productsDataColumn.Caption = "Min";
            productsDataColumn.ReadOnly = false;
            productsDataColumn.Unique = false;
            productsTable.Columns.Add(productsDataColumn);

            // Create Max column.

            productsDataColumn = new DataColumn();
            productsDataColumn.DataType = typeof(Int32);
            productsDataColumn.ColumnName = "Max";
            productsDataColumn.Caption = "Max";
            productsDataColumn.ReadOnly = false;
            productsDataColumn.Unique = false;
            productsTable.Columns.Add(productsDataColumn);

            // Make Part ID column the primary key column.

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = productsTable.Columns["Product ID"];
            productsTable.PrimaryKey = PrimaryKeyColumns;

            // Add Products Table to DataSet

            dSet.Tables.Add(productsTable);

            // Add data to table using NewRow method

            foreach (Product product in Inventory.AllProducts)
            {
                productsDataRow = productsTable.NewRow();

                productsDataRow["Product ID"]   = product.ProductID;
                productsDataRow["Name"]         = product.Name;
                productsDataRow["Inventory"]    = product.InStock;
                productsDataRow["Price"]        = product.Price;
                productsDataRow["Min"]          = product.Min;
                productsDataRow["Max"]          = product.Max;

                productsTable.Rows.Add(productsDataRow);
            }
            // Bind data to DataGridView.DataSource
            productsDataGridView.DataSource = dSet.Tables["All Products"];
        }
     
    }
}
