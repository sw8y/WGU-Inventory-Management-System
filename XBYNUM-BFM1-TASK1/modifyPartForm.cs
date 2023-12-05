using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XBYNUM_BFM1_TASK1
{
    public partial class modifyPartForm : Form
    {
        // variable to hold Part ID from MainScreen if modify is selected
        public static string selectedPartID;

        private bool valueChecker()
        {
            bool status = false;
            Dictionary<string, string> fields = new Dictionary<string, string> {
                {InventoryPart.Text, inventoryPartTextBox.Text},
                {MinNumPart.Text, minNumPartTextBox.Text},
                {MaxNumPart.Text, maxNumPartTextBox.Text},
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
        public modifyPartForm()
        {
      
            InitializeComponent();
            foreach (Part item in Inventory.AllParts)
            {
                if (item.PartID == Convert.ToInt32(selectedPartID)) 
                {
                    if (item.GetType() == typeof(InHouse)) 
                    {
                        inHouseRadioButtonPart.Checked = true;
                        InHouse data = (InHouse)item;
                        namePartTextBox.Text = data.Name;
                        inventoryPartTextBox.Text = Convert.ToString(data.InStock);
                        pricePartTextBox.Text = Convert.ToString(data.Price);
                        minNumPartTextBox.Text = Convert.ToString(data.Min);
                        maxNumPartTextBox.Text = Convert.ToString(data.Max);
                        machineCompanyIdTextBox.Text = Convert.ToString(data.MachineID);

                    } 
                    else if (item.GetType() == typeof(Outsourced))
                    {
                        outsourcedRadioButtonPart.Checked = true;
                        Outsourced data = (Outsourced)item;
                        namePartTextBox.Text = data.Name;
                        inventoryPartTextBox.Text = Convert.ToString(data.InStock);
                        pricePartTextBox.Text = Convert.ToString(data.Price);
                        minNumPartTextBox.Text = Convert.ToString(data.Min);
                        maxNumPartTextBox.Text = Convert.ToString(data.Max);
                        machineCompanyIdTextBox.Text = Convert.ToString(data.CompanyName);
                    }
                    break;
                }
            }
            idPartTextBox.Text = Convert.ToString(selectedPartID);                                                                              
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachineCompanyIdPart.Text = "Machine ID";
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MachineCompanyIdPart.Text = "Company Name";
        }

        private void modifyPartSaveButton_Click(object sender, EventArgs e)
        {
            bool success = valueChecker();
            if (success) 
            {
                if (inHouseRadioButtonPart.Checked == true)
                {
                    InHouse modifiedPart = new InHouse();
                    modifiedPart.Name = namePartTextBox.Text;
                    modifiedPart.InStock = Convert.ToInt32(inventoryPartTextBox.Text);
                    modifiedPart.Price = Convert.ToDecimal(pricePartTextBox.Text);
                    modifiedPart.Min = Convert.ToInt32(minNumPartTextBox.Text);
                    modifiedPart.Max = Convert.ToInt32(maxNumPartTextBox.Text);
                    modifiedPart.MachineID = Convert.ToInt32(machineCompanyIdTextBox.Text);

                    Inventory.updatePart(Convert.ToInt32(selectedPartID), modifiedPart);
                }
                else
                {
                    Outsourced modifiedPart = new Outsourced();
                    modifiedPart.Name = namePartTextBox.Text;
                    modifiedPart.InStock = Convert.ToInt32(inventoryPartTextBox.Text);
                    modifiedPart.Price = Convert.ToDecimal(pricePartTextBox.Text);
                    modifiedPart.Min = Convert.ToInt32(minNumPartTextBox.Text);
                    modifiedPart.Max = Convert.ToInt32(maxNumPartTextBox.Text);
                    modifiedPart.CompanyName = machineCompanyIdTextBox.Text;

                    Inventory.updatePart(Convert.ToInt32(selectedPartID), modifiedPart);
                }
                this.Hide();
                MainScreen MS = new MainScreen();
                MS.ShowDialog();
                this.Close();
            }
        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MS = new MainScreen();
            MS.ShowDialog();
            this.Close();
        }
    }
}
