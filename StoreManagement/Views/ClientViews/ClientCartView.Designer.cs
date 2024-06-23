namespace StoreManagement.Views
{
    partial class ClientCartView
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
            this.label_price = new System.Windows.Forms.Label();
            this.label_cart = new System.Windows.Forms.Label();
            this.button_purchase = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_my_orders = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.button_shopping = new System.Windows.Forms.Button();
            this.splitter_client_products = new System.Windows.Forms.Splitter();
            this.dataGridView_cart = new System.Windows.Forms.DataGridView();
            this.pictureBox_cart = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cart)).BeginInit();
            this.SuspendLayout();
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.BackColor = System.Drawing.Color.White;
            this.label_price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label_price.Location = new System.Drawing.Point(1404, 508);
            this.label_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(61, 37);
            this.label_price.TabIndex = 36;
            this.label_price.Text = "0 zł";
            // 
            // label_cart
            // 
            this.label_cart.AutoSize = true;
            this.label_cart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_cart.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_cart.ForeColor = System.Drawing.Color.Black;
            this.label_cart.Location = new System.Drawing.Point(967, 73);
            this.label_cart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cart.Name = "label_cart";
            this.label_cart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_cart.Size = new System.Drawing.Size(144, 60);
            this.label_cart.TabIndex = 35;
            this.label_cart.Text = "CART";
            // 
            // button_purchase
            // 
            this.button_purchase.BackColor = System.Drawing.Color.MediumPurple;
            this.button_purchase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_purchase.Location = new System.Drawing.Point(905, 508);
            this.button_purchase.Margin = new System.Windows.Forms.Padding(4);
            this.button_purchase.Name = "button_purchase";
            this.button_purchase.Size = new System.Drawing.Size(297, 70);
            this.button_purchase.TabIndex = 34;
            this.button_purchase.Text = "PURCHASE";
            this.button_purchase.UseVisualStyleBackColor = false;
            this.button_purchase.Click += new System.EventHandler(this.Button_purchase_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.MediumPurple;
            this.button_remove.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_remove.Location = new System.Drawing.Point(587, 508);
            this.button_remove.Margin = new System.Windows.Forms.Padding(4);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(297, 70);
            this.button_remove.TabIndex = 33;
            this.button_remove.Text = "REMOVE PRODUCT";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.Button_remove_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.Location = new System.Drawing.Point(95, 508);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(297, 73);
            this.button_logout.TabIndex = 31;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // button_my_orders
            // 
            this.button_my_orders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_my_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_my_orders.Location = new System.Drawing.Point(95, 363);
            this.button_my_orders.Margin = new System.Windows.Forms.Padding(4);
            this.button_my_orders.Name = "button_my_orders";
            this.button_my_orders.Size = new System.Drawing.Size(297, 73);
            this.button_my_orders.TabIndex = 30;
            this.button_my_orders.Text = "MY ORDERS";
            this.button_my_orders.UseVisualStyleBackColor = false;
            this.button_my_orders.Click += new System.EventHandler(this.Button_my_orders_Click);
            // 
            // button_cart
            // 
            this.button_cart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cart.Location = new System.Drawing.Point(95, 218);
            this.button_cart.Margin = new System.Windows.Forms.Padding(4);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(297, 73);
            this.button_cart.TabIndex = 29;
            this.button_cart.Text = "CART";
            this.button_cart.UseVisualStyleBackColor = false;
            // 
            // button_shopping
            // 
            this.button_shopping.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_shopping.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shopping.Location = new System.Drawing.Point(95, 73);
            this.button_shopping.Margin = new System.Windows.Forms.Padding(4);
            this.button_shopping.Name = "button_shopping";
            this.button_shopping.Size = new System.Drawing.Size(297, 75);
            this.button_shopping.TabIndex = 28;
            this.button_shopping.Text = "SHOPPING";
            this.button_shopping.UseVisualStyleBackColor = false;
            this.button_shopping.Click += new System.EventHandler(this.Button_shopping_Click);
            // 
            // splitter_client_products
            // 
            this.splitter_client_products.BackColor = System.Drawing.Color.Indigo;
            this.splitter_client_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_client_products.Location = new System.Drawing.Point(0, 0);
            this.splitter_client_products.Margin = new System.Windows.Forms.Padding(4);
            this.splitter_client_products.Name = "splitter_client_products";
            this.splitter_client_products.Size = new System.Drawing.Size(485, 677);
            this.splitter_client_products.TabIndex = 27;
            this.splitter_client_products.TabStop = false;
            // 
            // dataGridView_cart
            // 
            this.dataGridView_cart.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.colour,
            this.size,
            this.price});
            this.dataGridView_cart.Location = new System.Drawing.Point(587, 176);
            this.dataGridView_cart.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_cart.Name = "dataGridView_cart";
            this.dataGridView_cart.RowHeadersWidth = 51;
            this.dataGridView_cart.Size = new System.Drawing.Size(912, 324);
            this.dataGridView_cart.TabIndex = 37;
            // 
            // pictureBox_cart
            // 
            this.pictureBox_cart.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_cart.Image = global::StoreManagement.Properties.Resources.cart;
            this.pictureBox_cart.Location = new System.Drawing.Point(495, 4);
            this.pictureBox_cart.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_cart.Name = "pictureBox_cart";
            this.pictureBox_cart.Size = new System.Drawing.Size(167, 154);
            this.pictureBox_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_cart.TabIndex = 38;
            this.pictureBox_cart.TabStop = false;
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
            // ClientCartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.pictureBox_cart);
            this.Controls.Add(this.dataGridView_cart);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.label_cart);
            this.Controls.Add(this.button_purchase);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_my_orders);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.button_shopping);
            this.Controls.Add(this.splitter_client_products);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientCartView";
            this.Size = new System.Drawing.Size(1600, 677);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_cart;
        private System.Windows.Forms.Button button_purchase;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_my_orders;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_shopping;
        private System.Windows.Forms.Splitter splitter_client_products;
        private System.Windows.Forms.DataGridView dataGridView_cart;
        private System.Windows.Forms.PictureBox pictureBox_cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}