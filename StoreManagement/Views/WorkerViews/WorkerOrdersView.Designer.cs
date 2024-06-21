namespace StoreManagement.Views
{
    partial class WorkerOrdersView
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
            this.button_delete = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.label_orders = new System.Windows.Forms.Label();
            this.dataGridView_orders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thing5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox_order = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_order)).BeginInit();
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
            this.splitter_worker_products.TabIndex = 9;
            this.splitter_worker_products.TabStop = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.MediumPurple;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_delete.Location = new System.Drawing.Point(905, 511);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(297, 70);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "DELETE ORDER";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_logout.Location = new System.Drawing.Point(95, 508);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(297, 73);
            this.button_logout.TabIndex = 13;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // button_users
            // 
            this.button_users.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_users.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_users.Location = new System.Drawing.Point(95, 363);
            this.button_users.Margin = new System.Windows.Forms.Padding(4);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(297, 73);
            this.button_users.TabIndex = 12;
            this.button_users.Text = "USERS";
            this.button_users.UseVisualStyleBackColor = false;
            this.button_users.Click += new System.EventHandler(this.Button_users_Click);
            // 
            // button_orders
            // 
            this.button_orders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_orders.Location = new System.Drawing.Point(95, 218);
            this.button_orders.Margin = new System.Windows.Forms.Padding(4);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(297, 73);
            this.button_orders.TabIndex = 11;
            this.button_orders.Text = "ORDERS";
            this.button_orders.UseVisualStyleBackColor = false;
            // 
            // button_products
            // 
            this.button_products.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_products.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_products.Location = new System.Drawing.Point(95, 73);
            this.button_products.Margin = new System.Windows.Forms.Padding(4);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(297, 75);
            this.button_products.TabIndex = 10;
            this.button_products.Text = "PRODUCTS";
            this.button_products.UseVisualStyleBackColor = false;
            this.button_products.Click += new System.EventHandler(this.Button_products_Click);
            // 
            // label_orders
            // 
            this.label_orders.AutoSize = true;
            this.label_orders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_orders.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_orders.ForeColor = System.Drawing.Color.Black;
            this.label_orders.Location = new System.Drawing.Point(953, 73);
            this.label_orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_orders.Name = "label_orders";
            this.label_orders.Size = new System.Drawing.Size(201, 60);
            this.label_orders.TabIndex = 17;
            this.label_orders.Text = "ORDERS";
            // 
            // dataGridView_orders
            // 
            this.dataGridView_orders.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.client,
            this.thing1,
            this.thing2,
            this.thing3,
            this.thing4,
            this.thing5});
            this.dataGridView_orders.Location = new System.Drawing.Point(587, 176);
            this.dataGridView_orders.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_orders.Name = "dataGridView_orders";
            this.dataGridView_orders.RowHeadersWidth = 51;
            this.dataGridView_orders.Size = new System.Drawing.Size(912, 324);
            this.dataGridView_orders.TabIndex = 18;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "DATE";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 110;
            // 
            // client
            // 
            this.client.HeaderText = "CLIENT";
            this.client.MinimumWidth = 6;
            this.client.Name = "client";
            this.client.Width = 110;
            // 
            // thing1
            // 
            this.thing1.HeaderText = "THING 1";
            this.thing1.MinimumWidth = 6;
            this.thing1.Name = "thing1";
            this.thing1.Width = 110;
            // 
            // thing2
            // 
            this.thing2.HeaderText = "THING 2";
            this.thing2.MinimumWidth = 6;
            this.thing2.Name = "thing2";
            this.thing2.Width = 110;
            // 
            // thing3
            // 
            this.thing3.HeaderText = "THING 3";
            this.thing3.MinimumWidth = 6;
            this.thing3.Name = "thing3";
            this.thing3.Width = 125;
            // 
            // thing4
            // 
            this.thing4.HeaderText = "THING 4";
            this.thing4.MinimumWidth = 6;
            this.thing4.Name = "thing4";
            this.thing4.Width = 125;
            // 
            // thing5
            // 
            this.thing5.HeaderText = "THING 5";
            this.thing5.MinimumWidth = 6;
            this.thing5.Name = "thing5";
            this.thing5.Width = 125;
            // 
            // pictureBox_order
            // 
            this.pictureBox_order.Image = global::StoreManagement.Properties.Resources.orders;
            this.pictureBox_order.Location = new System.Drawing.Point(487, 4);
            this.pictureBox_order.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_order.Name = "pictureBox_order";
            this.pictureBox_order.Size = new System.Drawing.Size(167, 154);
            this.pictureBox_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_order.TabIndex = 19;
            this.pictureBox_order.TabStop = false;
            // 
            // WorkerOrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.pictureBox_order);
            this.Controls.Add(this.dataGridView_orders);
            this.Controls.Add(this.label_orders);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.splitter_worker_products);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkerOrdersView";
            this.Size = new System.Drawing.Size(1600, 677);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Label label_orders;
        private System.Windows.Forms.Splitter splitter_worker_products;
        private System.Windows.Forms.DataGridView dataGridView_orders;
        private System.Windows.Forms.PictureBox pictureBox_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing2;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing3;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing4;
        private System.Windows.Forms.DataGridViewTextBoxColumn thing5;
    }
}