namespace StoreManagement.Views
{
    partial class ClientOrdersView
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
            this.button_logout = new System.Windows.Forms.Button();
            this.button_my_orders = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.button_shopping = new System.Windows.Forms.Button();
            this.splitter_client_products = new System.Windows.Forms.Splitter();
            this.label_orders = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.dataGridView_client_orders = new System.Windows.Forms.DataGridView();
            this.pictureBox_orders = new System.Windows.Forms.PictureBox();
            this.ORDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_logout.Location = new System.Drawing.Point(95, 508);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(297, 73);
            this.button_logout.TabIndex = 21;
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
            this.button_my_orders.TabIndex = 20;
            this.button_my_orders.Text = "MY ORDERS";
            this.button_my_orders.UseVisualStyleBackColor = false;
            // 
            // button_cart
            // 
            this.button_cart.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_cart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_cart.Location = new System.Drawing.Point(95, 218);
            this.button_cart.Margin = new System.Windows.Forms.Padding(4);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(297, 73);
            this.button_cart.TabIndex = 19;
            this.button_cart.Text = "CART";
            this.button_cart.UseVisualStyleBackColor = false;
            this.button_cart.Click += new System.EventHandler(this.Button_cart_Click);
            // 
            // button_shopping
            // 
            this.button_shopping.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_shopping.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_shopping.Location = new System.Drawing.Point(95, 73);
            this.button_shopping.Margin = new System.Windows.Forms.Padding(4);
            this.button_shopping.Name = "button_shopping";
            this.button_shopping.Size = new System.Drawing.Size(297, 75);
            this.button_shopping.TabIndex = 18;
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
            this.splitter_client_products.TabIndex = 17;
            this.splitter_client_products.TabStop = false;
            // 
            // label_orders
            // 
            this.label_orders.AutoSize = true;
            this.label_orders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_orders.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_orders.ForeColor = System.Drawing.Color.Black;
            this.label_orders.Location = new System.Drawing.Point(904, 73);
            this.label_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(285, 60);
            this.label_orders.TabIndex = 25;
            this.label_orders.Text = "MY ORDERS";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.MediumPurple;
            this.button_cancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_cancel.Location = new System.Drawing.Point(904, 508);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(297, 70);
            this.button_cancel.TabIndex = 23;
            this.button_cancel.Text = "CANCEL ORDER";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // dataGridView_client_orders
            // 
            this.dataGridView_client_orders.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_client_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_client_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ORDER,
            this.DATE,
            this.thing1,
            this.thing2,
            this.thing3,
            this.thing4,
            this.thing5});
            this.dataGridView_client_orders.Location = new System.Drawing.Point(587, 176);
            this.dataGridView_client_orders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_client_orders.Name = "dataGridView_client_orders";
            this.dataGridView_client_orders.RowHeadersWidth = 51;
            this.dataGridView_client_orders.Size = new System.Drawing.Size(912, 324);
            this.dataGridView_client_orders.TabIndex = 26;
            // 
            // pictureBox_orders
            // 
            this.pictureBox_orders.Image = global::StoreManagement.Properties.Resources.myOrders;
            this.pictureBox_orders.Location = new System.Drawing.Point(495, 4);
            this.pictureBox_orders.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_orders.Name = "pictureBox_orders";
            this.pictureBox_orders.Size = new System.Drawing.Size(167, 154);
            this.pictureBox_orders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_orders.TabIndex = 27;
            this.pictureBox_orders.TabStop = false;
            // 
            // ORDER
            // 
            this.ORDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ORDER.FillWeight = 30F;
            this.ORDER.HeaderText = "ORDER";
            this.ORDER.MinimumWidth = 6;
            this.ORDER.Name = "ORDER";
            this.ORDER.Width = 85;
            // 
            // DATE
            // 
            this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE.HeaderText = "DATE";
            this.DATE.MinimumWidth = 6;
            this.DATE.Name = "DATE";
            // 
            // thing1
            // 
            this.thing1.HeaderText = "THING 1";
            this.thing1.MinimumWidth = 6;
            this.thing1.Name = "thing1";
            this.thing1.Width = 88;
            // 
            // thing2
            // 
            this.thing2.HeaderText = "THING 2";
            this.thing2.MinimumWidth = 6;
            this.thing2.Name = "thing2";
            this.thing2.Width = 88;
            // 
            // thing3
            // 
            this.thing3.HeaderText = "THING 3";
            this.thing3.MinimumWidth = 6;
            this.thing3.Name = "thing3";
            this.thing3.Width = 88;
            // 
            // thing4
            // 
            this.thing4.HeaderText = "THING 4";
            this.thing4.MinimumWidth = 6;
            this.thing4.Name = "thing4";
            this.thing4.Width = 88;
            // 
            // thing5
            // 
            this.thing5.HeaderText = "THING 5";
            this.thing5.MinimumWidth = 6;
            this.thing5.Name = "thing5";
            this.thing5.Width = 88;
            // 
            // ClientOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.pictureBox_orders);
            this.Controls.Add(this.dataGridView_client_orders);
            this.Controls.Add(this.label_orders);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_my_orders);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.button_shopping);
            this.Controls.Add(this.splitter_client_products);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientOrdersView";
            this.Size = new System.Drawing.Size(1600, 677);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_client_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_my_orders;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.Button button_shopping;
        private System.Windows.Forms.Splitter splitter_client_products;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.DataGridView dataGridView_client_orders;
        private System.Windows.Forms.PictureBox pictureBox_orders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing2;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing3;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing4;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing5;
    }
}