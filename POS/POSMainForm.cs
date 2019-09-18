using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AddComputerTestDialogue;

using ProductInventory;

namespace POS
{
    public partial class POSMainForm : Form
    {
        List<PRODUCT> productInventory = new List<PRODUCT>();
        public POSMainForm()
        {
            InitializeComponent();
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            PRODUCT p;
            //determine the type of product being added .Switch based on the that
            //Calling the appropriate dialogu to get the necessary info
            //Create the object and add it to our inventory list and to the display 
            if (productTypeComboxbox.SelectedIndex == -1)
            {
                MessageBox.Show(" Must Select a product Type first before adding");
                return;
            }
            switch (productTypeComboxbox.SelectedIndex)
            {
                case 0: p = createComputerproduct(); break;
                case 1: p = createChocolate(); break;
                default:
                    MessageBox.Show("Unknown Product Selected ");
                    return;

            }
            if (p != null)
            {
                productInventory.Add(p);
                productListListbox.Items.Add(p.ToFormattedString());
            }
           

        }
        private PRODUCT createComputerproduct()
        {

            // pop add a computer dialog if return is cancelled give up.
            // if return is dialog ok.Try to create a computer object
            // return that reference
            AddComputerProductDialogue acpd = new AddComputerProductDialogue();
            DialogResult result = acpd.ShowDialog();
            if(result != DialogResult.OK)
            {
                return null;
            }
            PRODUCT p = new Computer(acpd.ProductName, acpd.ProductID, acpd.ProductCost, acpd.InitialQuantity, acpd.RamSize, acpd.CpuSpeed);
            return p;
        }
        private PRODUCT createChocolate()
        {
            MessageBox.Show("Under Construction ");
            return null;
        }







        private void restockButton_Click(object sender, EventArgs e)
        {
            int quantity;
            if (quantityRestockTextbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Must first enter the quantity to sell");
                return;
            }

            if (!int.TryParse(quantityRestockTextbox.Text.Trim(), out quantity))
            {
                MessageBox.Show("Non numeric value enter in the quanity sold");
            }
            int selectedItemIndex = productListListbox.SelectedIndex;
            if (selectedItemIndex == -1)
            {
                MessageBox.Show("Must Selected The product to be sold");
                return;
            }
            try
            {
                productInventory[selectedItemIndex].Stock(quantity);
            }
            catch (ArgumentException excp)
            {
                MessageBox.Show($"Error:Cannot Sell.{excp.Message}");
                return;
            }
            productListListbox.Items[selectedItemIndex] = productInventory[selectedItemIndex].ToFormattedString();
            quantityRestockTextbox.Clear();
            quantityRestockTextbox.Focus();
        }

      

        private void sellButton_Click(object sender, EventArgs e)
        {
            //verify that have a quantity to sell . if so convert to a number
            int quantity;

            if (quantitySoldTextbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Must first enter the quantity to sell");
                return;
            }

            if (! int.TryParse(quantitySoldTextbox.Text.Trim(), out quantity))
            {
                MessageBox.Show("Non numeric value enter in the quanity sold");
                return;
            }

            // find the item that is selected to be sold, then run the sell behaviour

            int selectedItemIndex = productListListbox.SelectedIndex;
            if (selectedItemIndex == -1)
            {
                MessageBox.Show("Must Selected The product to be sold");
                return;
            }
            try
            {
                productInventory[selectedItemIndex].Sell(quantity);
            }
            catch(ArgumentException excp)
            {
                MessageBox.Show($"Error:Cannot Sell.{excp.Message}");
                return;
            }
            productListListbox.Items[selectedItemIndex] = productInventory[selectedItemIndex].ToFormattedString();
            quantitySoldTextbox.Clear();
            quantitySoldTextbox.Focus();

            //The display list to show the new status of the product just sold 


        }
        private void POSMainForm_Load(object sender, EventArgs e)
        {/*
            PRODUCT p;
            p = new PRODUCT("Product 1 name", 12345656, 1.20M, 10);
            productInventory.Add(p);
            productListListbox.Items.Add(p.ToFormattedString());

            p = new PRODUCT("Product 2 name", 484884233, 1.50M, 10);
            productInventory.Add(p);
            productListListbox.Items.Add(p.ToFormattedString());

            p = new PRODUCT("Product 3 name", 484884233, 1.40M, 10);
            productInventory.Add(p);
            productListListbox.Items.Add(p.ToFormattedString());
            */

        }

            private void saveProductButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog cfd = new SaveFileDialog();
            cfd.Title = "Save a Product Inventory List";
            cfd.DefaultExt="txt";
            cfd.Filter = "Product Inventory File|*.pil|Text Files|*.txt|All Files|*.*";
            cfd.FilterIndex = 2;
            cfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = cfd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            // All inside a try catch
            // open a stream writer on productList on the desktop 
            // foreach product in my inventory run the tofilesstring) method and write that to file
            //close the file

            try
            {
                //string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "/productlist.txt";
                StreamWriter output = new StreamWriter(cfd.FileName);
                foreach(PRODUCT p in productInventory)
                {
                    if(p is Computer)
                    {
                        output.WriteLine(productTypeString(p));
                        output.WriteLine(p.ToFileString());
                    }
                        
                    
                }output.Close();

            }
            catch(Exception excp)
            {
                MessageBox.Show($"Error:File did not write.{excp.Message}");
                return;
            }
            MessageBox.Show($"Product have been saved in{cfd.FileName}");

        }
        private string productTypeString(PRODUCT p)
        {
            if (p is Computer)
                return "Computer";
            else if (p is Chocolate)
                return "Chocolate";
            else
                return "Unknown";
        }

        private void loadProductButton_Click(object sender, EventArgs e)
        {
            //let the user pick the file to open 
            ;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a Product Inventory List";
            ofd.Filter = "Product Inventory File|*.pil|Text Files|*.txt|All Files|*.*";
            ofd.FilterIndex = 2;
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult result = ofd.ShowDialog();
            if(result != DialogResult.OK)
            {
                return;
            }
            // All inside a try catch
            // open a stream reader on productList on the desktop 
            // foreach line in the file product call the constractor that takes a single string
            //and get a product object back . Add that object to my list and to the display close the file
            PRODUCT p = null;
            try
            {

                //string filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + "/productlist.txt";
                StreamReader input = new StreamReader(ofd.FileName);
                while (!input.EndOfStream)
                {
                    string productType = input.ReadLine();
                    switch (productType)
                    {
                        case "Computer":p = new Computer(input.ReadLine());break;
                        case "Chocolate": p = new Chocolate(input.ReadLine()); break;

                        default:
                            MessageBox.Show("Unkown Product");
                            p = null;
                            break;
                    }
                    string lineFromFile = input.ReadLine();
                    //PRODUCT p = new PRODUCT(lineFromFile);
                    if (p !=null)
                    {
                        productInventory.Add(p);
                        productListListbox.Items.Add(p.ToFormattedString());
                    }
                    
                }               
                input.Close();

            }
            catch (Exception excp)
            {
                MessageBox.Show($"Error:File did not Load.{excp.Message}");
                return;
            }
            MessageBox.Show($"Products have been save");
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = productListListbox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Must Selected The product to delete first");
                return;
            }
           
            PRODUCT p = productInventory[index];
            if (p is Computer)
            {
                EditComputer(index);
            }
            else
            {
                MessageBox.Show("Unknown product");
            }

       
        }
        private void EditComputer(int index)
        {
            AddComputerProductDialogue acpd = new AddComputerProductDialogue();
            acpd.EditMode = true;
            Computer c = (Computer)productInventory[index];
            acpd.ProductName = c.ProductName;
            acpd.ProductID = c.ID;
            acpd.ProductCost = c.Cost;
            acpd.InitialQuantity = c.QuantityOnHand;
            acpd.RamSize = c.RamSize;
            acpd.CpuSpeed = c.CpuSpeed;
            DialogResult result = acpd.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            DialogResult result1 = MessageBox.Show($"Are sure you wish to Edit {c.ProductName}?",
      "Confirmation", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                PRODUCT p = new Computer(acpd.ProductName, acpd.ProductID, acpd.ProductCost, acpd.InitialQuantity,
                    acpd.RamSize, acpd.CpuSpeed);
                productInventory[index] = p;
                productListListbox.Items[index] = p.ToFormattedString();
            }
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = productListListbox.SelectedIndex;
            PRODUCT p = productInventory[index];

            if (index == -1)
            {
                MessageBox.Show("Must Selected The product to delete first");
                return;
            }
            DialogResult result = MessageBox.Show($"are you sure you wish t0 delete {p.ProductName}");
            if(result == DialogResult.OK)
            {
                productInventory.RemoveAt(productListListbox.SelectedIndex);
                productListListbox.Items.RemoveAt(productListListbox.SelectedIndex);
                
            }

        }
    }
}
