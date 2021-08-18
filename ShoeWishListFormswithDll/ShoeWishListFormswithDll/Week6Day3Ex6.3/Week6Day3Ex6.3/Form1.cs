using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6Day3Ex6._3
{
    public partial class Form1 : Form
    {
        //This Project has a database connected to it and DOES NOT have a class library DLL
        //TODO TRY CATCH AND TRY PARSE 
        Entities newShoe; // must declare using the entities , can be found on context.cs
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newShoe = new Entities();//make an instance of the dbo
            grdviewWishList.DataSource = newShoe.ShoeWishTables.ToList();//getting all data from table create 
            //and attaching to the grid view in a list format
            btnUpdate.Visible = false; //therefore we cannot click update btn until statement is true
        }
        private void Clear()
        {// clears all the txt and combo boxes 
            textBxName.Clear();
            textBxBrand.Clear();
            textBxColor.Clear();
            textBxPrice .Clear();
            combobxStyle.Items.Clear();
        }
        private void ClearDataNew()
        {
            //clears data and gives options to enter new data
            textBxName.Clear();
            textBxBrand.Clear();
            textBxColor.Clear();
            textBxPrice.Clear();
            //foreach (var d in newShoe.ShoeWishTables) // not needed here bc we are entering the options at the bottom for oour cmbbox
            //{
            //  combobxStyle.Items.Add(d.Style);
            //}
            combobxStyle.Items.AddRange(new string[] { "Sneakers", "Boots", "Dress", "Slippers", "Sandals" });//items in combo box 
        }

            private void btnUpdate_Click(object sender, EventArgs e)
        {//TODO
         //update the whole obj or row 
            var id = textBxName.Text;
            //grid view = current row selected 
            var shoetoupdate = newShoe.ShoeWishTables.First(p => p.ShoeName == id.ToString());
            //                entities   table         first choice 
            shoetoupdate.ShoeName = textBxName.Text;
            shoetoupdate.Brand = textBxBrand.Text;
            shoetoupdate.Color = textBxColor.Text;
            shoetoupdate.Price = Convert.ToDecimal(textBxPrice.Text);
            shoetoupdate.Style = combobxStyle.SelectedItem.ToString();//converting obj to string 
            newShoe.SaveChanges();
            Clear();
        }

        private void btnAddShoe_Click(object sender, EventArgs e)
        {
            ClearDataNew();
            if (!string.IsNullOrWhiteSpace(textBxName.Text)&& !string.IsNullOrWhiteSpace(textBxBrand.Text) && !string.IsNullOrWhiteSpace(textBxColor.Text))
            {
                ShoeWishTable obj = new ShoeWishTable(); // create new shoe 
                obj.ShoeName = textBxName.Text;
                obj.Brand = textBxBrand.Text;
                obj.Color = textBxColor.Text;
                obj.Price = Convert.ToDecimal(textBxPrice.Text);
                obj.Style = Convert.ToString(combobxStyle.SelectedItem); //this is an obj need to convert to string
                newShoe.ShoeWishTables.Add(obj);//adding obj into shoewishtables which is going to entities dbo
                newShoe.SaveChanges(); //must call or it wont change in the dbo and wont reflect 
                Clear(); 
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {//TODO
            var id = grdviewWishList.CurrentRow.Cells[0].Value;//making temp variable id to hold the selected row from the 
            //grid view = current row selected 
            var shoetodel = newShoe.ShoeWishTables.First(p => p.ShoeName == id.ToString());
            // temp variable selecting the reference from the FIrst(refernce clicked on) in the ShoeWishtable
            newShoe.ShoeWishTables.Remove(shoetodel); //finally removing the shoe selected form the tables from entities
            newShoe.SaveChanges(); //save changes so it reflects in the dbo
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {//once again choosing the reference to do something with 
            var id = grdviewWishList.CurrentRow.Cells[0].Value;//making temp variable id to hold the selected row from the 
            //grid view = current row selected 
            var shoetoupdate = newShoe.ShoeWishTables.First(p => p.ShoeName == id.ToString());
            //populate in the text box the selected shoe in table 
            textBxName.Text = shoetoupdate.ShoeName;
            textBxBrand.Text = shoetoupdate.Brand;
            textBxColor.Text = shoetoupdate.Color;
            textBxPrice.Text = shoetoupdate.Price.ToString();
           
            combobxStyle.Items.AddRange(new string[] { "Sneakers", "Boots", "Dress", "Slippers", "Sandals" });//items in combo box 
            combobxStyle.SelectedItem = shoetoupdate.Style;//adding the selected item to the style column in dbo
            btnUpdate.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grdviewWishList.DataSource = null;
            grdviewWishList.DataSource = newShoe.ShoeWishTables.ToList(); // once again assign the table from the entities to the grid view
            //INCLASS LIBRARY = repository.tables.tolist
        }

        private void grdviewWishList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
