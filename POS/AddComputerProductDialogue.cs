using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddComputerTestDialogue
{
    public partial class AddComputerProductDialogue : Form
    {
        public bool EditMode = false;
        public string ProductName;
        public long ProductID;
        public int InitialQuantity;
        public decimal ProductCost;
        public int RamSize;
        public float CpuSpeed;

        private bool haveValidProductName = false ;
        private bool haveValidProductID = false;
        private bool haveValidInitialQuantity = false;
        private bool haveValidProductCost  = false;
        public bool haveValidRamSize = false;
        public bool haveValidCpuSpeed = false;


        public AddComputerProductDialogue()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult  = DialogResult.Cancel;
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            string BadFieldName=null;
            string adviceString=null;
            if (!haveValidProductName)
            {
                BadFieldName = "Product Name";
                adviceString = "Must enter the name of product";

            }
            else if (!haveValidProductID)
            {
                BadFieldName = "Product ID";
                adviceString = "Product ID must be numberic, at least 6 digit but no more than 10";

            }
            else if (!haveValidProductCost)
            {
                BadFieldName = "Product Cost";
                adviceString = "Cost must greater than zero";

            }
            else if (!haveValidInitialQuantity)
            {
                BadFieldName = "Initial Quantity";
                adviceString = " Initial Quantity must equal or greater than zero";

            }
            else if (!haveValidRamSize)
            {
                BadFieldName = "Ram Size";
                adviceString = "Ram size must be a whole number";

            }
            else if (!haveValidCpuSpeed)
            {
                BadFieldName = "Cpu Speed";
                adviceString = " Cpu Speed must be a numeric value larger than zero";

            }

            if (BadFieldName != null)
            {
                MessageBox.Show($"Invalid {BadFieldName}.\n {adviceString}", "Data Entry Error");
                return;
            }

            DialogResult = DialogResult.OK;
            
        }

        private void productNameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (productNameTextbox.Text.Trim().Length == 0)
            {
                haveValidProductName = false;
            }
            else
            {
                haveValidProductName = true;
                ProductName = productNameTextbox.Text.Trim();
            }
            ///*adjustAddButton*/();
            Console.WriteLine(ProductName);
        }
        //private void adjustAddButton()
        //{
        //    if (haveValidProductName && haveValidProductID && haveValidProductCost && haveValidInitialQuantity &&
        //        haveValidRamSize&& haveValidCpuSpeed)
        //    {
        //        addButton.Enabled=true;
        //    }
        //    else
        //    {
        //        addButton.Enabled = false;
        //    }
        //}

        private void productIdTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidProductID = false;
            if(long.TryParse(productIdTextbox.Text.Trim(), out ProductID))
            {
                if((ProductID>=1000) && (ProductID <= 9999999999))
                {
                    haveValidProductID = true;
                }
                ///*adjustAddButton()*/;

            }
            Console.WriteLine(ProductID);
        }

        private void productCostTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidProductCost = false;
            if (decimal.TryParse(productCostTextbox.Text.Trim(), out ProductCost))
            {
                if (ProductCost > 0)
                {
                    haveValidProductCost = true;
                }
                ///*adjustAddButton*/();
            }
          
        }

        private void initialQuantityTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidInitialQuantity = false;
            if (int.TryParse(initialQuantityTextbox.Text.Trim(), out InitialQuantity))
            {
                if (InitialQuantity > 0)
                {
                    haveValidInitialQuantity = true;
                }
                //adjustAddButton();
            }
        }

        private void ramSizeTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidRamSize = false;
            if (int.TryParse(ramSizeTextbox.Text.Trim(), out RamSize))
            {
                if (RamSize > 0)
                {
                    haveValidRamSize = true;
                }
                //adjustAddButton();
            }
           
        }

        private void cpuSpeedTextbox_TextChanged(object sender, EventArgs e)
        {
            haveValidCpuSpeed = false;
            if (float.TryParse(cpuSpeedTextbox.Text.Trim(), out CpuSpeed))
            {
                if (CpuSpeed > 0)
                {
                    haveValidCpuSpeed = true;
                }
                //adjustAddButton();
            }
            
        }

        private void AddComputerProductDialogue_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                productNameTextbox.Text = ProductName;
                productIdTextbox.Text = ProductID.ToString();
                productCostTextbox.Text = ProductCost.ToString();
                initialQuantityTextbox.Text = InitialQuantity.ToString();
                ramSizeTextbox.Text = RamSize.ToString();
                cpuSpeedTextbox.Text = CpuSpeed.ToString();
                addButton.Text = "update";
                this.Text = "Update Product";

;            }
        }
    }
}
