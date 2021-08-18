using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoesCL; //using the Class DLL that has the database in it 


namespace ShoeWishListFormswithDll
{

    public partial class Form1 : Form
    {
        ShoeRepository repository; //call instance of shoe repository to use it 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //add btn
        {
            cmbboxStyle.Visible = true;
            txtboxName.Visible = true;
            txtboxName.Enabled = true;
            if (string.IsNullOrWhiteSpace(txtboxName.Text)) // need this to check if the text box is empty then you can add items 
            {
                ClearNewData();
            }
            if (!string.IsNullOrWhiteSpace(txtboxbrand.Text) && !string.IsNullOrWhiteSpace(txtboxcolor.Text) && !string.IsNullOrWhiteSpace(txtboxPrice.Text))
            {
                var obj = new ShoesCL.ShoeWishTable(); // create new shoe 
                obj.ShoeName = txtboxName.Text;
                obj.Brand = txtboxbrand.Text;
                obj.Color = txtboxcolor.Text;
                obj.Price = Convert.ToDecimal(txtboxPrice.Text);
                obj.Style = Convert.ToString(cmbboxStyle.SelectedItem); //this is an obj need to convert to string
                repository.AddShoe(obj);//adding obj into shoewishtables which is going to entities dbo
                                        //repository. //must call or it wont change in the dbo and wont reflect 
                Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repository = new ShoeRepository(); //create instance of repository that has CRUD interfaces
            gridviewwishlist.DataSource = repository.ReadData();
            btnUpdate.Enabled = false;
        }
        private void ClearNewData()
        {
            //clears data and gives options to enter new data
            txtboxName.Clear();
            txtboxbrand.Clear();
            txtboxcolor.Clear();
            txtboxPrice.Clear();
            cmbboxStyle.SelectedItem = null; // shows nothing selected at first 
            //foreach (var d in newShoe.ShoeWishTables) // not needed here bc we are entering the options at the bottom for oour cmbbox
            //{
            //  combobxStyle.Items.Add(d.Style);
            //}
            cmbboxStyle.Items.AddRange(new string[] { "Sneakers", "Boots", "Dress", "Slippers", "Sandals" });//items in combo box         

        }
        private void Clear()
        {// clears all the txt and combo boxes 
            txtboxName.Clear();
            txtboxbrand.Clear();
            txtboxcolor.Clear();
            txtboxPrice.Clear();
            cmbboxStyle.Items.Clear();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var id = gridviewwishlist.CurrentRow.Cells[0].Value;//making temp variable id to hold the selected row from the 
            //grid view = current row selected 
            var shoetodel = repository.FindShoe(id.ToString());// temp variable selecting the reference from the FIrst(refernce clicked on) in the ShoeWishtable
            repository.RemoveShoe(shoetodel); //finally removing the shoe selected form the tables from entities
           // repository.SaveChanges();
           //repository.
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //once again choosing the reference to do something with 
            var id = gridviewwishlist.CurrentRow.Cells[0].Value;//making temp variable id to hold the selected row from the 
            //grid view = current row selected 
            var shoetoupdate = repository.FindShoe(id.ToString());//calling find shoe method to get obj in repository 
            //newShoe.ShoeWishTables.First(p => p.ShoeName == id.ToString());

            //populate in the text box the selected shoe in table 
            txtboxName.Text = shoetoupdate.ShoeName;
            txtboxName.Enabled = false;
            txtboxbrand.Text = shoetoupdate.Brand;
            txtboxcolor.Text = shoetoupdate.Color;
            txtboxPrice.Text = shoetoupdate.Price.ToString();

            cmbboxStyle.Items.AddRange(new string[] { "Sneakers", "Boots", "Dress", "Slippers", "Sandals" });//items in combo box 
            cmbboxStyle.SelectedItem = shoetoupdate.Style;//adding the selected item to the style column in dbo
            btnUpdate.Enabled = true;
            cmbboxStyle.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            gridviewwishlist.DataSource = null;
            gridviewwishlist.DataSource = repository.ReadData();
            // once again assign the table from the entities to the grid view
            //INCLASS LIBRARY = repository.tables.tolist
            cmbboxStyle.Visible = false;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var id = txtboxName.Text;
            var shoetoUpd = repository.FindShoe(id.ToString());
            shoetoUpd.Brand = txtboxbrand.Text;
            shoetoUpd.Color = txtboxcolor.Text;
            shoetoUpd.Price = Convert.ToDecimal(txtboxPrice.Text);
            shoetoUpd.Style = cmbboxStyle.SelectedItem.ToString();//converting obj to string 
            repository.UpdateShoe(id.ToString(), shoetoUpd);
            Clear();

            // PREVIOUS WITH OUT HAVING A CLASS LIBRARY
            ////update the whole obj or row 
            //var id = txtboxName.Text;
            ////grid view = current row selected 
            //var shoetoupdate = newShoe.ShoeWishTables.First(p => p.ShoeName == id.ToString());
            ////                entities   table         first choice 
            //shoetoupdate. = txtboxName.Text;
            //shoetoupdate.Brand = txtboxbrand.Text;
            //shoetoupdate.Color = txtboxcolor.Text;
            //shoetoupdate.Price = Convert.ToDecimal(txtboxPrice.Text);
            //shoetoupdate.Style = cmbboxStyle.SelectedItem.ToString();//converting obj to string 
            //newShoe.SaveChanges();
            //Clear();
        }

        private void txtboxcolor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
