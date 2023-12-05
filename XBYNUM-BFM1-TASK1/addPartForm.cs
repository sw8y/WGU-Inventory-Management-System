using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XBYNUM_BFM1_TASK1
{
    public partial class addPartForm : Form
    {

        public static int partID = 1;


        public bool valueChecker()
        {
            bool status = false;
            Dictionary<string, string> fields = new Dictionary<string, string> {
                {InventoryPart.Text, inventoryPartTextBox.Text},
                {MinNumPart.Text, minNumPartTextBox.Text},
                {MaxNumPart.Text, maxNumPartTextBox.Text},
            };


            foreach (KeyValuePair<string,string> field in fields)
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
                decimal val;
                if (!decimal.TryParse(pricePartTextBox.Text, out val))
                {
                    MessageBox.Show($"The {PricePart.Text} field must contain a numerical value only. Please correct.");
                    status = false;
                }
                else if (Convert.ToInt32(fields[MinNumPart.Text]) > Convert.ToInt32(fields[MaxNumPart.Text]))
                {
                    MessageBox.Show($"The {MinNumPart.Text} field cannot be higher than the Max field. Please correct.");
                    status = false;
                }
                else if (Convert.ToInt32(fields[InventoryPart.Text]) < Convert.ToInt32(fields[MinNumPart.Text]))
                {
                    MessageBox.Show($"The {InventoryPart.Text} field must be higher than or equal to the Min field. Please correct.");
                    status = false;
                }
                else if (Convert.ToInt32(fields[InventoryPart.Text]) > Convert.ToInt32(fields[MaxNumPart.Text]))
                {
                    MessageBox.Show($"The {InventoryPart.Text} field must be lower than or equal to the Max field. Please correct.");
                    status = false;
                }
                else if (inHouseRadioButtonPart.Checked == true)
                {
                    if (machineCompanyIdTextBox.Text.All(char.IsDigit) == false)
                    {
                        MessageBox.Show($"The {MachineCompanyIdPart.Text} field must contain a numerical value only. Please correct.");
                        status = false;
                    }
                } 
                else { status = true; }
            }
            catch (FormatException) 
            {
                status = false; 
            }
            return status;
        }

        public addPartForm()
        {
            InitializeComponent();
            addPartSaveButton.Enabled = true;
            idPartTextBox.Enabled = false;
            idPartTextBox.Text = Convert.ToString(partID);

        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachineCompanyIdPart.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachineCompanyIdPart.Text = "Company Name";
        }

        private void addPartSaveButton_Click(object sender, EventArgs e)
        {
            bool success = valueChecker();
            if (success)
            {
                if (inHouseRadioButtonPart.Checked)
                {

                    InHouse inHouseParts = new InHouse();
                    inHouseParts.PartID = Convert.ToInt32(idPartTextBox.Text);
                    inHouseParts.Name = namePartTextBox.Text;
                    inHouseParts.Price = Convert.ToDecimal(pricePartTextBox.Text);
                    inHouseParts.InStock = Convert.ToInt32(inventoryPartTextBox.Text);
                    inHouseParts.Max = Convert.ToInt32(maxNumPartTextBox.Text);
                    inHouseParts.Min = Convert.ToInt32(minNumPartTextBox.Text);
                    inHouseParts.MachineID = Convert.ToInt32(machineCompanyIdTextBox.Text);
                    Inventory.addPart(inHouseParts);
                }
                else
                {
                    Outsourced outsourcedParts = new Outsourced();
                    outsourcedParts.PartID = Convert.ToInt32(idPartTextBox.Text);
                    outsourcedParts.Name = namePartTextBox.Text;
                    outsourcedParts.InStock = Convert.ToInt32(inventoryPartTextBox.Text);
                    outsourcedParts.Price = Convert.ToDecimal(pricePartTextBox.Text);
                    outsourcedParts.Min = Convert.ToInt32(minNumPartTextBox.Text);
                    outsourcedParts.Max = Convert.ToInt32(maxNumPartTextBox.Text);
                    outsourcedParts.CompanyName = machineCompanyIdTextBox.Text;
                    Inventory.addPart(outsourcedParts);
                }
                partID++;
                this.Hide();
                MainScreen MS = new MainScreen();
                MS.ShowDialog();
                this.Close();
            }
        }

        private void addPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MS = new MainScreen();
            MS.ShowDialog();
            this.Close();
        }
    }

}
