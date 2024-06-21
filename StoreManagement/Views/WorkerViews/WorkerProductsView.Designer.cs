namespace StoreManagement.Views
{
    partial class WorkerProductsView
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
            this.splitter_worker_products = new System.Windows.Forms.Splitter();
            this.button_products = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView_products = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_size = new System.Windows.Forms.Label();
            this.label_colour = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.button_filter = new System.Windows.Forms.Button();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.pictureBox_product = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter_worker_products
            // 
            this.splitter_worker_products.BackColor = System.Drawing.Color.Indigo;
            this.splitter_worker_products.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_worker_products.Location = new System.Drawing.Point(0, 0);
            this.splitter_worker_products.Margin = new System.Windows.Forms.Padding(4);
            this.splitter_worker_products.Name = "splitter_worker_products";
            this.splitter_worker_products.Size = new System.Drawing.Size(477, 677);
            this.splitter_worker_products.TabIndex = 0;
            this.splitter_worker_products.TabStop = false;
            // 
            // button_products
            // 
            this.button_products.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_products.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_products.Location = new System.Drawing.Point(95, 73);
            this.button_products.Margin = new System.Windows.Forms.Padding(4);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(297, 75);
            this.button_products.TabIndex = 2;
            this.button_products.Text = "PRODUCTS";
            this.button_products.UseVisualStyleBackColor = false;
            // 
            // button_orders
            // 
            this.button_orders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_orders.Location = new System.Drawing.Point(95, 218);
            this.button_orders.Margin = new System.Windows.Forms.Padding(4);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(297, 73);
            this.button_orders.TabIndex = 3;
            this.button_orders.Text = "ORDERS";
            this.button_orders.UseVisualStyleBackColor = false;
            this.button_orders.Click += new System.EventHandler(this.Button_orders_Click);
            // 
            // button_users
            // 
            this.button_users.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_users.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_users.Location = new System.Drawing.Point(95, 363);
            this.button_users.Margin = new System.Windows.Forms.Padding(4);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(297, 73);
            this.button_users.TabIndex = 4;
            this.button_users.Text = "USERS";
            this.button_users.UseVisualStyleBackColor = false;
            this.button_users.Click += new System.EventHandler(this.Button_users_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_logout.Location = new System.Drawing.Point(95, 508);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(297, 73);
            this.button_logout.TabIndex = 5;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.MediumPurple;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_edit.Location = new System.Drawing.Point(587, 508);
            this.button_edit.Margin = new System.Windows.Forms.Padding(4);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(297, 70);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "EDIT PRODUCT";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.Button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.MediumPurple;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_add.Location = new System.Drawing.Point(1201, 508);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(297, 70);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "ADD PRODUCT";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // dataGridView_products
            // 
            this.dataGridView_products.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.type,
            this.colour,
            this.size,
            this.price,
            this.amount});
            this.dataGridView_products.Location = new System.Drawing.Point(587, 176);
            this.dataGridView_products.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_products.Name = "dataGridView_products";
            this.dataGridView_products.RowHeadersWidth = 51;
            this.dataGridView_products.Size = new System.Drawing.Size(912, 324);
            this.dataGridView_products.TabIndex = 19;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 110;
            // 
            // type
            // 
            this.type.HeaderText = "TYPE";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 110;
            // 
            // colour
            // 
            this.colour.HeaderText = "COLOUR";
            this.colour.MinimumWidth = 6;
            this.colour.Name = "colour";
            this.colour.Width = 110;
            // 
            // size
            // 
            this.size.HeaderText = "SIZE";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.Width = 110;
            // 
            // price
            // 
            this.price.HeaderText = "PRICE";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 110;
            // 
            // amount
            // 
            this.amount.HeaderText = "AMOUNT";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.Width = 110;
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_size.Location = new System.Drawing.Point(984, 82);
            this.label_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(52, 28);
            this.label_size.TabIndex = 26;
            this.label_size.Text = "SIZE";
            // 
            // label_colour
            // 
            this.label_colour.AutoSize = true;
            this.label_colour.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_colour.Location = new System.Drawing.Point(803, 84);
            this.label_colour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_colour.Name = "label_colour";
            this.label_colour.Size = new System.Drawing.Size(88, 25);
            this.label_colour.TabIndex = 25;
            this.label_colour.Text = "COLOUR";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_type.Location = new System.Drawing.Point(636, 82);
            this.label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(59, 28);
            this.label_type.TabIndex = 24;
            this.label_type.Text = "TYPE";
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.MediumPurple;
            this.button_filter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_filter.Location = new System.Drawing.Point(1276, 112);
            this.button_filter.Margin = new System.Windows.Forms.Padding(4);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(223, 36);
            this.button_filter.TabIndex = 23;
            this.button_filter.Text = "FILTER";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.Button_filter_Click);
            // 
            // comboBox_size
            // 
            this.comboBox_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            "s",
            "l",
            "m"});
            this.comboBox_size.Location = new System.Drawing.Point(933, 112);
            this.comboBox_size.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(160, 36);
            this.comboBox_size.TabIndex = 22;
            // 
            // comboBox_color
            // 
            this.comboBox_color.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Items.AddRange(new object[] {
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
            this.comboBox_color.Location = new System.Drawing.Point(760, 112);
            this.comboBox_color.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(160, 36);
            this.comboBox_color.TabIndex = 21;
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
            this.comboBox_type.TabIndex = 20;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_amount.Location = new System.Drawing.Point(1133, 84);
            this.label_amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(102, 28);
            this.label_amount.TabIndex = 28;
            this.label_amount.Text = "AMOUNT";
            // 
            // pictureBox_product
            // 
            this.pictureBox_product.Image = global::StoreManagement.Properties.Resources.products;
            this.pictureBox_product.Location = new System.Drawing.Point(487, 4);
            this.pictureBox_product.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_product.Name = "pictureBox_product";
            this.pictureBox_product.Size = new System.Drawing.Size(100, 92);
            this.pictureBox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_product.TabIndex = 29;
            this.pictureBox_product.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 30;
            // 
            // textBox_amount
            // 
            this.textBox_amount.Location = new System.Drawing.Point(1111, 115);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(149, 22);
            this.textBox_amount.TabIndex = 31;
            // 
            // WorkerProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox_product);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_colour);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.dataGridView_products);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.splitter_worker_products);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkerProductsView";
            this.Size = new System.Drawing.Size(1600, 677);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Splitter splitter_worker_products;
        private System.Windows.Forms.DataGridView dataGridView_products;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_colour;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.ComboBox comboBox_color;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.PictureBox pictureBox_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn colour;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox_amount;
    }
}