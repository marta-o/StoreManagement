using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.Utilities;
using System;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace StoreManagement.Views
{
    partial class ClientProductsView
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
            this.splitter_client_products = new System.Windows.Forms.Splitter();
            this.button_shopping = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.button_my_orders = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.comboBox_colour = new System.Windows.Forms.ComboBox();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.button_add_cart = new System.Windows.Forms.Button();
            this.label_type = new System.Windows.Forms.Label();
            this.label_colour = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.dataGridView_client_products = new System.Windows.Forms.DataGridView();
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter_client_products
            // 
            this.splitter_client_products.BackColor = System.Drawing.Color.Indigo;
            this.splitter_client_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_client_products.Location = new System.Drawing.Point(0, 0);
            this.splitter_client_products.Margin = new System.Windows.Forms.Padding(4);
            this.splitter_client_products.Name = "splitter_client_products";
            this.splitter_client_products.Size = new System.Drawing.Size(485, 677);
            this.splitter_client_products.TabIndex = 1;
            this.splitter_client_products.TabStop = false;
            // 
            // button_shopping
            // 
            this.button_shopping.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_shopping.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shopping.Location = new System.Drawing.Point(95, 73);
            this.button_shopping.Margin = new System.Windows.Forms.Padding(4);
            this.button_shopping.Name = "button_shopping";
            this.button_shopping.Size = new System.Drawing.Size(297, 75);
            this.button_shopping.TabIndex = 2;
            this.button_shopping.Text = "SHOPPING";
            this.button_shopping.UseVisualStyleBackColor = false;
            // 
            // button_cart
            // 
            this.button_cart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cart.Location = new System.Drawing.Point(95, 218);
            this.button_cart.Margin = new System.Windows.Forms.Padding(4);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(297, 73);
            this.button_cart.TabIndex = 3;
            this.button_cart.Text = "CART";
            this.button_cart.UseVisualStyleBackColor = false;
            this.button_cart.Click += new System.EventHandler(this.Button_cart_Click);
            // 
            // button_my_orders
            // 
            this.button_my_orders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_my_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_my_orders.Location = new System.Drawing.Point(95, 363);
            this.button_my_orders.Margin = new System.Windows.Forms.Padding(4);
            this.button_my_orders.Name = "button_my_orders";
            this.button_my_orders.Size = new System.Drawing.Size(297, 73);
            this.button_my_orders.TabIndex = 4;
            this.button_my_orders.Text = "MY ORDERS";
            this.button_my_orders.UseVisualStyleBackColor = false;
            this.button_my_orders.Click += new System.EventHandler(this.Button_my_orders_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.Location = new System.Drawing.Point(95, 508);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(297, 73);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "trousers",
            "dress",
            "t-shirt",
            "skirt",
            "shorts",
            "sweater",
            "hoodie",
            "blouse"});
            this.comboBox_type.Location = new System.Drawing.Point(587, 112);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(160, 36);
            this.comboBox_type.TabIndex = 7;
            // 
            // comboBox_colour
            // 
            this.comboBox_colour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_colour.FormattingEnabled = true;
            this.comboBox_colour.Items.AddRange(new object[] {
            "white",
            "black",
            "green",
            "red",
            "blue",
            "orange",
            "yellow",
            "purple",
            "pink",
            "gray",
            "brown"});
            this.comboBox_colour.Location = new System.Drawing.Point(807, 112);
            this.comboBox_colour.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_colour.Name = "comboBox_colour";
            this.comboBox_colour.Size = new System.Drawing.Size(160, 36);
            this.comboBox_colour.TabIndex = 8;
            // 
            // comboBox_size
            // 
            this.comboBox_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            "s",
            "l",
            "m"});
            this.comboBox_size.Location = new System.Drawing.Point(1028, 112);
            this.comboBox_size.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(160, 36);
            this.comboBox_size.TabIndex = 10;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.MediumPurple;
            this.button_filter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_filter.Location = new System.Drawing.Point(1276, 112);
            this.button_filter.Margin = new System.Windows.Forms.Padding(4);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(223, 36);
            this.button_filter.TabIndex = 11;
            this.button_filter.Text = "FILTER";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_sort_Click);
            // 
            // button_add_cart
            // 
            this.button_add_cart.BackColor = System.Drawing.Color.MediumPurple;
            this.button_add_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_cart.Location = new System.Drawing.Point(1201, 508);
            this.button_add_cart.Margin = new System.Windows.Forms.Padding(4);
            this.button_add_cart.Name = "button_add_cart";
            this.button_add_cart.Size = new System.Drawing.Size(297, 73);
            this.button_add_cart.TabIndex = 12;
            this.button_add_cart.Text = "ADD TO CART";
            this.button_add_cart.UseVisualStyleBackColor = false;
            this.button_add_cart.Click += new System.EventHandler(this.button_add_cart_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_type.Location = new System.Drawing.Point(633, 82);
            this.label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(59, 28);
            this.label_type.TabIndex = 13;
            this.label_type.Text = "TYPE";
            // 
            // label_colour
            // 
            this.label_colour.AutoSize = true;
            this.label_colour.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_colour.Location = new System.Drawing.Point(845, 84);
            this.label_colour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_colour.Name = "label_colour";
            this.label_colour.Size = new System.Drawing.Size(88, 25);
            this.label_colour.TabIndex = 14;
            this.label_colour.Text = "COLOUR";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_size.Location = new System.Drawing.Point(1079, 82);
            this.label_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(52, 28);
            this.label_size.TabIndex = 16;
            this.label_size.Text = "SIZE";
            // 
            // dataGridView_client_products
            // 
            this.dataGridView_client_products.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_client_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_client_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.colour,
            this.size,
            this.price});
            this.dataGridView_client_products.Location = new System.Drawing.Point(587, 176);
            this.dataGridView_client_products.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_client_products.Name = "dataGridView_client_products";
            this.dataGridView_client_products.RowHeadersWidth = 51;
            this.dataGridView_client_products.Size = new System.Drawing.Size(912, 324);
            this.dataGridView_client_products.TabIndex = 17;
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.Image = global::StoreManagement.Properties.Resources.products;
            this.pictureBox_product.Location = new System.Drawing.Point(495, 4);
            this.pictureBox_product.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(100, 92);
            this.pictureBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_product.TabIndex = 18;
            this.pictureBox_product.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.HeaderText = "TYPE";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 120;
            // 
            // colour
            // 
            this.colour.HeaderText = "COLOUR";
            this.colour.MinimumWidth = 6;
            this.colour.Name = "colour";
            this.colour.Width = 120;
            // 
            // size
            // 
            this.size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.size.HeaderText = "SIZE";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.Width = 65;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 76;
            // 
            // ClientProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.pictureBox_product);
            this.Controls.Add(this.dataGridView_client_products);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_colour);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_add_cart);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.comboBox_colour);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_my_orders);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.button_shopping);
            this.Controls.Add(this.splitter_client_products);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientProductsView";
            this.Size = new System.Drawing.Size(1600, 677);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter_client_products;
        private System.Windows.Forms.Button button_shopping;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_my_orders;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.ComboBox comboBox_colour;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Button button_add_cart;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_colour;
        private System.Windows.Forms.Label label_size;
        private DataGridView dataGridView_client_products;
        private PictureBox pictureBox_product;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn colour;
        private DataGridViewTextBoxColumn size;
        private DataGridViewTextBoxColumn price;
    }
}