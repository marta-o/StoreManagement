namespace StoreManagement.Views.WorkerViews
{
    partial class WorkerUsersView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_add_edit = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.splitter_worker_add = new System.Windows.Forms.Splitter();
            this.dataGridView_users = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_add = new System.Windows.Forms.Button();
            this.comboBox_users = new System.Windows.Forms.ComboBox();
            this.button_filter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_add_edit
            // 
            this.label_add_edit.AutoSize = true;
            this.label_add_edit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_add_edit.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_add_edit.ForeColor = System.Drawing.Color.Black;
            this.label_add_edit.Location = new System.Drawing.Point(967, 73);
            this.label_add_edit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_add_edit.Name = "label_add_edit";
            this.label_add_edit.Size = new System.Drawing.Size(162, 60);
            this.label_add_edit.TabIndex = 64;
            this.label_add_edit.Text = "USERS";
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_logout.Location = new System.Drawing.Point(95, 508);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(297, 73);
            this.button_logout.TabIndex = 63;
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
            this.button_users.TabIndex = 62;
            this.button_users.Text = "USERS";
            this.button_users.UseVisualStyleBackColor = false;
            // 
            // button_orders
            // 
            this.button_orders.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_orders.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.button_orders.Location = new System.Drawing.Point(95, 218);
            this.button_orders.Margin = new System.Windows.Forms.Padding(4);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(297, 73);
            this.button_orders.TabIndex = 61;
            this.button_orders.Text = "ORDERS";
            this.button_orders.UseVisualStyleBackColor = false;
            this.button_orders.Click += new System.EventHandler(this.Button_orders_Click);
            // 
            // button_products
            // 
            this.button_products.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_products.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_products.Location = new System.Drawing.Point(95, 73);
            this.button_products.Margin = new System.Windows.Forms.Padding(4);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(297, 75);
            this.button_products.TabIndex = 60;
            this.button_products.Text = "PRODUCTS";
            this.button_products.UseVisualStyleBackColor = false;
            this.button_products.Click += new System.EventHandler(this.Button_products_Click);
            // 
            // splitter_worker_add
            // 
            this.splitter_worker_add.BackColor = System.Drawing.Color.Indigo;
            this.splitter_worker_add.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_worker_add.Location = new System.Drawing.Point(0, 0);
            this.splitter_worker_add.Margin = new System.Windows.Forms.Padding(4);
            this.splitter_worker_add.Name = "splitter_worker_add";
            this.splitter_worker_add.Size = new System.Drawing.Size(485, 677);
            this.splitter_worker_add.TabIndex = 59;
            this.splitter_worker_add.TabStop = false;
            // 
            // dataGridView_users
            // 
            this.dataGridView_users.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.address,
            this.phone,
            this.username,
            this.type});
            this.dataGridView_users.Location = new System.Drawing.Point(587, 176);
            this.dataGridView_users.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_users.Name = "dataGridView_users";
            this.dataGridView_users.RowHeadersWidth = 51;
            this.dataGridView_users.Size = new System.Drawing.Size(912, 324);
            this.dataGridView_users.TabIndex = 65;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 49;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.name.HeaderText = "NAME";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 75;
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.surname.HeaderText = "SURNAME";
            this.surname.MinimumWidth = 6;
            this.surname.Name = "surname";
            this.surname.Width = 104;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "ADDRESS";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.phone.HeaderText = "PHONE";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.Width = 84;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.username.HeaderText = "USERNAME";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 113;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.type.HeaderText = "TYPE";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 72;
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.MediumPurple;
            this.button_add.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(1261, 507);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(238, 74);
            this.button_add.TabIndex = 66;
            this.button_add.Text = "ADD EMPLOYEE";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // comboBox_users
            // 
            this.comboBox_users.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_users.FormattingEnabled = true;
            this.comboBox_users.Items.AddRange(new object[] {
            "client",
            "worker"});
            this.comboBox_users.Location = new System.Drawing.Point(587, 507);
            this.comboBox_users.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_users.Name = "comboBox_users";
            this.comboBox_users.Size = new System.Drawing.Size(160, 36);
            this.comboBox_users.TabIndex = 68;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.MediumPurple;
            this.button_filter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_filter.Location = new System.Drawing.Point(756, 507);
            this.button_filter.Margin = new System.Windows.Forms.Padding(4);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(166, 36);
            this.button_filter.TabIndex = 67;
            this.button_filter.Text = "FILTER";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.Button_filter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoreManagement.Properties.Resources.users;
            this.pictureBox1.Location = new System.Drawing.Point(495, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.MediumPurple;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_delete.ForeColor = System.Drawing.Color.Black;
            this.button_delete.Location = new System.Drawing.Point(1015, 508);
            this.button_delete.Margin = new System.Windows.Forms.Padding(4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(238, 74);
            this.button_delete.TabIndex = 70;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // WorkerUsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_users);
            this.Controls.Add(this.button_filter);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView_users);
            this.Controls.Add(this.label_add_edit);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.splitter_worker_add);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkerUsersView";
            this.Size = new System.Drawing.Size(1600, 677);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add_edit;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Splitter splitter_worker_add;
        private System.Windows.Forms.DataGridView dataGridView_users;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.ComboBox comboBox_users;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.Button button_delete;
    }
}
