namespace StoreManagement.Views.StartViews
{
    partial class LoginView
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitter_login = new System.Windows.Forms.Splitter();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_username = new System.Windows.Forms.Label();
            this.button_log_in = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.maskedTextBox_password = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox_login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter_login
            // 
            this.splitter_login.BackColor = System.Drawing.Color.Indigo;
            this.splitter_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter_login.Location = new System.Drawing.Point(0, 0);
            this.splitter_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter_login.Name = "splitter_login";
            this.splitter_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitter_login.Size = new System.Drawing.Size(485, 677);
            this.splitter_login.TabIndex = 0;
            this.splitter_login.TabStop = false;
            this.splitter_login.UseWaitCursor = true;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(959, 295);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(316, 22);
            this.textBox_username.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_username.Location = new System.Drawing.Point(803, 293);
            this.label_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(115, 25);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "USERNAME";
            // 
            // button_log_in
            // 
            this.button_log_in.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_log_in.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_log_in.Location = new System.Drawing.Point(95, 218);
            this.button_log_in.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(297, 75);
            this.button_log_in.TabIndex = 4;
            this.button_log_in.Text = "LOG IN";
            this.button_log_in.UseVisualStyleBackColor = false;
            // 
            // button_create
            // 
            this.button_create.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button_create.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_create.Location = new System.Drawing.Point(95, 363);
            this.button_create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(297, 75);
            this.button_create.TabIndex = 5;
            this.button_create.Text = "CREATE ACCOUNT";
            this.button_create.UseVisualStyleBackColor = false;
            this.button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label_login.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold);
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(953, 73);
            this.label_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(166, 60);
            this.label_login.TabIndex = 6;
            this.label_login.Text = "LOGIN";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_password.Location = new System.Drawing.Point(803, 341);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(122, 28);
            this.label_password.TabIndex = 7;
            this.label_password.Text = "PASSWORD";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.MediumPurple;
            this.button_login.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(885, 508);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(297, 74);
            this.button_login.TabIndex = 9;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.Button_login_Click);
            // 
            // maskedTextBox_password
            // 
            this.maskedTextBox_password.Location = new System.Drawing.Point(959, 345);
            this.maskedTextBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox_password.Name = "maskedTextBox_password";
            this.maskedTextBox_password.Size = new System.Drawing.Size(316, 22);
            this.maskedTextBox_password.TabIndex = 10;
            // 
            // pictureBox_login
            // 
            this.pictureBox_login.Image = global::StoreManagement.Properties.Resources.login;
            this.pictureBox_login.Location = new System.Drawing.Point(964, 134);
            this.pictureBox_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_login.Name = "pictureBox_login";
            this.pictureBox_login.Size = new System.Drawing.Size(133, 123);
            this.pictureBox_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_login.TabIndex = 11;
            this.pictureBox_login.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.pictureBox_login);
            this.Controls.Add(this.maskedTextBox_password);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.splitter_login);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(1600, 677);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter_login;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_log_in;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_password;
        private System.Windows.Forms.PictureBox pictureBox_login;
    }
}

