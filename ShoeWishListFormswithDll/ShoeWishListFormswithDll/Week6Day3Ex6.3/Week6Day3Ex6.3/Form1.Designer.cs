
namespace Week6Day3Ex6._3
{
    partial class Form1
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
            this.btnAddShoe = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbrand = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblstyle = new System.Windows.Forms.Label();
            this.labelcolor = new System.Windows.Forms.Label();
            this.grdviewWishList = new System.Windows.Forms.DataGridView();
            this.textBxName = new System.Windows.Forms.TextBox();
            this.textBxBrand = new System.Windows.Forms.TextBox();
            this.textBxPrice = new System.Windows.Forms.TextBox();
            this.textBxColor = new System.Windows.Forms.TextBox();
            this.combobxStyle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdviewWishList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddShoe
            // 
            this.btnAddShoe.BackColor = System.Drawing.Color.Firebrick;
            this.btnAddShoe.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShoe.Location = new System.Drawing.Point(453, 92);
            this.btnAddShoe.Name = "btnAddShoe";
            this.btnAddShoe.Size = new System.Drawing.Size(136, 68);
            this.btnAddShoe.TabIndex = 0;
            this.btnAddShoe.Text = "Add Shoe";
            this.btnAddShoe.UseVisualStyleBackColor = false;
            this.btnAddShoe.Click += new System.EventHandler(this.btnAddShoe_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemove.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(616, 92);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(154, 68);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Shoe";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Firebrick;
            this.btnSelect.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(453, 167);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 68);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Select Shoe";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Firebrick;
            this.btnRefresh.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(634, 310);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(154, 68);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Wishlist";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Firebrick;
            this.btnUpdate.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(616, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 68);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Wishlist";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("High Tower Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(12, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(544, 57);
            this.labeltitle.TabIndex = 5;
            this.labeltitle.Text = "Christmas Shoe Wishlist";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.Firebrick;
            this.lblname.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(18, 78);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(66, 23);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "Name";
            // 
            // lblbrand
            // 
            this.lblbrand.AutoSize = true;
            this.lblbrand.BackColor = System.Drawing.Color.Firebrick;
            this.lblbrand.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrand.Location = new System.Drawing.Point(19, 116);
            this.lblbrand.Name = "lblbrand";
            this.lblbrand.Size = new System.Drawing.Size(65, 23);
            this.lblbrand.TabIndex = 7;
            this.lblbrand.Text = "Brand";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.BackColor = System.Drawing.Color.Firebrick;
            this.lblprice.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(20, 154);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(58, 23);
            this.lblprice.TabIndex = 8;
            this.lblprice.Text = "Price";
            // 
            // lblstyle
            // 
            this.lblstyle.AutoSize = true;
            this.lblstyle.BackColor = System.Drawing.Color.Firebrick;
            this.lblstyle.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstyle.Location = new System.Drawing.Point(24, 191);
            this.lblstyle.Name = "lblstyle";
            this.lblstyle.Size = new System.Drawing.Size(60, 23);
            this.lblstyle.TabIndex = 9;
            this.lblstyle.Text = "Style";
            // 
            // labelcolor
            // 
            this.labelcolor.AutoSize = true;
            this.labelcolor.BackColor = System.Drawing.Color.Firebrick;
            this.labelcolor.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcolor.Location = new System.Drawing.Point(22, 225);
            this.labelcolor.Name = "labelcolor";
            this.labelcolor.Size = new System.Drawing.Size(62, 23);
            this.labelcolor.TabIndex = 10;
            this.labelcolor.Text = "Color";
            // 
            // grdviewWishList
            // 
            this.grdviewWishList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdviewWishList.Location = new System.Drawing.Point(28, 257);
            this.grdviewWishList.Name = "grdviewWishList";
            this.grdviewWishList.RowHeadersWidth = 51;
            this.grdviewWishList.RowTemplate.Height = 24;
            this.grdviewWishList.Size = new System.Drawing.Size(595, 187);
            this.grdviewWishList.TabIndex = 11;
            this.grdviewWishList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdviewWishList_CellContentClick);
            // 
            // textBxName
            // 
            this.textBxName.Font = new System.Drawing.Font("High Tower Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxName.Location = new System.Drawing.Point(110, 78);
            this.textBxName.Name = "textBxName";
            this.textBxName.Size = new System.Drawing.Size(256, 23);
            this.textBxName.TabIndex = 12;
            // 
            // textBxBrand
            // 
            this.textBxBrand.Font = new System.Drawing.Font("High Tower Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxBrand.Location = new System.Drawing.Point(110, 116);
            this.textBxBrand.Name = "textBxBrand";
            this.textBxBrand.Size = new System.Drawing.Size(256, 23);
            this.textBxBrand.TabIndex = 13;
            this.textBxBrand.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBxPrice
            // 
            this.textBxPrice.Font = new System.Drawing.Font("High Tower Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxPrice.Location = new System.Drawing.Point(110, 154);
            this.textBxPrice.Name = "textBxPrice";
            this.textBxPrice.Size = new System.Drawing.Size(256, 23);
            this.textBxPrice.TabIndex = 14;
            this.textBxPrice.TextChanged += new System.EventHandler(this.textBxPrice_TextChanged);
            // 
            // textBxColor
            // 
            this.textBxColor.Font = new System.Drawing.Font("High Tower Text", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBxColor.Location = new System.Drawing.Point(110, 228);
            this.textBxColor.Name = "textBxColor";
            this.textBxColor.Size = new System.Drawing.Size(256, 23);
            this.textBxColor.TabIndex = 15;
            // 
            // combobxStyle
            // 
            this.combobxStyle.FormattingEnabled = true;
            this.combobxStyle.Location = new System.Drawing.Point(110, 190);
            this.combobxStyle.Name = "combobxStyle";
            this.combobxStyle.Size = new System.Drawing.Size(253, 24);
            this.combobxStyle.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combobxStyle);
            this.Controls.Add(this.textBxColor);
            this.Controls.Add(this.textBxPrice);
            this.Controls.Add(this.textBxBrand);
            this.Controls.Add(this.textBxName);
            this.Controls.Add(this.grdviewWishList);
            this.Controls.Add(this.labelcolor);
            this.Controls.Add(this.lblstyle);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblbrand);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddShoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdviewWishList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddShoe;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbrand;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblstyle;
        private System.Windows.Forms.Label labelcolor;
        private System.Windows.Forms.DataGridView grdviewWishList;
        private System.Windows.Forms.TextBox textBxName;
        private System.Windows.Forms.TextBox textBxBrand;
        private System.Windows.Forms.TextBox textBxPrice;
        private System.Windows.Forms.TextBox textBxColor;
        private System.Windows.Forms.ComboBox combobxStyle;
    }
}

