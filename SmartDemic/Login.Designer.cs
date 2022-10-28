namespace SmartDemic
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_login_titulo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtb_login_user = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtb_login_password = new Telerik.WinControls.UI.RadTextBox();
            this.btn_login_ingresar = new Telerik.WinControls.UI.RadButton();
            this.btn_login_cancelar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_login_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_login_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_ingresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.BackColor = System.Drawing.Color.Crimson;
            this.lbl_login.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_login.Location = new System.Drawing.Point(0, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(296, 378);
            this.lbl_login.TabIndex = 0;
            // 
            // lbl_login_titulo
            // 
            this.lbl_login_titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_login_titulo.AutoSize = true;
            this.lbl_login_titulo.BackColor = System.Drawing.Color.Crimson;
            this.lbl_login_titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_login_titulo.Location = new System.Drawing.Point(9, 216);
            this.lbl_login_titulo.Name = "lbl_login_titulo";
            this.lbl_login_titulo.Size = new System.Drawing.Size(284, 37);
            this.lbl_login_titulo.TabIndex = 1;
            this.lbl_login_titulo.Text = "SmartDemic Software";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SchoolFlag;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 127;
            this.iconPictureBox1.Location = new System.Drawing.Point(89, 73);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(137, 127);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtb_login_user
            // 
            this.txtb_login_user.Location = new System.Drawing.Point(498, 73);
            this.txtb_login_user.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtb_login_user.Name = "txtb_login_user";
            this.txtb_login_user.Size = new System.Drawing.Size(229, 32);
            this.txtb_login_user.TabIndex = 4;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(409, 81);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(71, 27);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Usuario:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(396, 144);
            this.radLabel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(85, 27);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Password:";
            // 
            // txtb_login_password
            // 
            this.txtb_login_password.Location = new System.Drawing.Point(498, 142);
            this.txtb_login_password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtb_login_password.Name = "txtb_login_password";
            this.txtb_login_password.PasswordChar = '*';
            this.txtb_login_password.Size = new System.Drawing.Size(229, 32);
            this.txtb_login_password.TabIndex = 7;
            // 
            // btn_login_ingresar
            // 
            this.btn_login_ingresar.BackColor = System.Drawing.Color.White;
            this.btn_login_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_ingresar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_ingresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_ingresar.Image")));
            this.btn_login_ingresar.Location = new System.Drawing.Point(366, 254);
            this.btn_login_ingresar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_login_ingresar.Name = "btn_login_ingresar";
            this.btn_login_ingresar.Size = new System.Drawing.Size(146, 57);
            this.btn_login_ingresar.TabIndex = 8;
            this.btn_login_ingresar.Text = "Ingresar";
            this.btn_login_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login_ingresar.Click += new System.EventHandler(this.btn_login_ingresar_Click);
            // 
            // btn_login_cancelar
            // 
            this.btn_login_cancelar.BackColor = System.Drawing.Color.White;
            this.btn_login_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_cancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_login_cancelar.Image")));
            this.btn_login_cancelar.Location = new System.Drawing.Point(587, 254);
            this.btn_login_cancelar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_login_cancelar.Name = "btn_login_cancelar";
            this.btn_login_cancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_login_cancelar.Size = new System.Drawing.Size(160, 57);
            this.btn_login_cancelar.TabIndex = 9;
            this.btn_login_cancelar.Text = "Cancelar";
            this.btn_login_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login_cancelar.TextWrap = true;
            this.btn_login_cancelar.Click += new System.EventHandler(this.btn_login_cancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.btn_login_cancelar);
            this.Controls.Add(this.btn_login_ingresar);
            this.Controls.Add(this.txtb_login_password);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtb_login_user);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lbl_login_titulo);
            this.Controls.Add(this.lbl_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_login_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtb_login_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_ingresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_login_cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_login_titulo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Telerik.WinControls.UI.RadTextBox txtb_login_user;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtb_login_password;
        private Telerik.WinControls.UI.RadButton btn_login_ingresar;
        private Telerik.WinControls.UI.RadButton btn_login_cancelar;
    }
}
