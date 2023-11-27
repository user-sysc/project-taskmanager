namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_Min = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_login = new Guna.UI2.WinForms.Guna2Panel();
            this.picbox_login = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picb_mostrar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picb_ocultar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.linkLabel_login = new System.Windows.Forms.LinkLabel();
            this.separador_login = new Guna.UI2.WinForms.Guna2Separator();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtB_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtB_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).BeginInit();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.topPanel.Controls.Add(this.btn_close);
            this.topPanel.Controls.Add(this.guna2PictureBox3);
            this.topPanel.Controls.Add(this.btn_Min);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(966, 32);
            this.topPanel.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageRotate = 0F;
            this.btn_close.Location = new System.Drawing.Point(931, 8);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(16, 16);
            this.btn_close.TabIndex = 1;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(909, 8);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(16, 16);
            this.guna2PictureBox3.TabIndex = 2;
            this.guna2PictureBox3.TabStop = false;
            // 
            // btn_Min
            // 
            this.btn_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Min.Image = ((System.Drawing.Image)(resources.GetObject("btn_Min.Image")));
            this.btn_Min.ImageRotate = 0F;
            this.btn_Min.Location = new System.Drawing.Point(887, 8);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(16, 16);
            this.btn_Min.TabIndex = 0;
            this.btn_Min.TabStop = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.topPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.panel_login.Controls.Add(this.picbox_login);
            this.panel_login.Controls.Add(this.picb_mostrar);
            this.panel_login.Controls.Add(this.picb_ocultar);
            this.panel_login.Controls.Add(this.guna2VSeparator1);
            this.panel_login.Controls.Add(this.linkLabel_login);
            this.panel_login.Controls.Add(this.separador_login);
            this.panel_login.Controls.Add(this.btnLogin);
            this.panel_login.Controls.Add(this.txtB_pass);
            this.panel_login.Controls.Add(this.txtB_email);
            this.panel_login.Controls.Add(this.txtLabel);
            this.panel_login.Controls.Add(this.guna2PictureBox1);
            this.panel_login.Location = new System.Drawing.Point(0, 32);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(966, 504);
            this.panel_login.TabIndex = 1;
            // 
            // picbox_login
            // 
            this.picbox_login.Image = ((System.Drawing.Image)(resources.GetObject("picbox_login.Image")));
            this.picbox_login.ImageRotate = 0F;
            this.picbox_login.Location = new System.Drawing.Point(-21, -205);
            this.picbox_login.Name = "picbox_login";
            this.picbox_login.Size = new System.Drawing.Size(248, 831);
            this.picbox_login.TabIndex = 2;
            this.picbox_login.TabStop = false;
            // 
            // picb_mostrar
            // 
            this.picb_mostrar.BackColor = System.Drawing.Color.Transparent;
            this.picb_mostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_mostrar.Image = ((System.Drawing.Image)(resources.GetObject("picb_mostrar.Image")));
            this.picb_mostrar.ImageRotate = 0F;
            this.picb_mostrar.Location = new System.Drawing.Point(573, 271);
            this.picb_mostrar.Name = "picb_mostrar";
            this.picb_mostrar.Size = new System.Drawing.Size(25, 25);
            this.picb_mostrar.TabIndex = 10;
            this.picb_mostrar.TabStop = false;
            this.picb_mostrar.UseTransparentBackground = true;
            this.picb_mostrar.Click += new System.EventHandler(this.picb_mostrar_Click);
            // 
            // picb_ocultar
            // 
            this.picb_ocultar.BackColor = System.Drawing.Color.Transparent;
            this.picb_ocultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picb_ocultar.Image = ((System.Drawing.Image)(resources.GetObject("picb_ocultar.Image")));
            this.picb_ocultar.ImageRotate = 0F;
            this.picb_ocultar.Location = new System.Drawing.Point(573, 271);
            this.picb_ocultar.Name = "picb_ocultar";
            this.picb_ocultar.Size = new System.Drawing.Size(25, 25);
            this.picb_ocultar.TabIndex = 9;
            this.picb_ocultar.TabStop = false;
            this.picb_ocultar.UseTransparentBackground = true;
            this.picb_ocultar.Click += new System.EventHandler(this.picb_ocultar_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(450, 391);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 15);
            this.guna2VSeparator1.TabIndex = 8;
            // 
            // linkLabel_login
            // 
            this.linkLabel_login.ActiveLinkColor = System.Drawing.Color.CadetBlue;
            this.linkLabel_login.AutoSize = true;
            this.linkLabel_login.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_login.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(99)))), ((int)(((byte)(113)))));
            this.linkLabel_login.Location = new System.Drawing.Point(374, 387);
            this.linkLabel_login.Name = "linkLabel_login";
            this.linkLabel_login.Size = new System.Drawing.Size(58, 19);
            this.linkLabel_login.TabIndex = 7;
            this.linkLabel_login.TabStop = true;
            this.linkLabel_login.Text = "Sign Up";
            this.linkLabel_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_login_LinkClicked);
            // 
            // separador_login
            // 
            this.separador_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.separador_login.Location = new System.Drawing.Point(349, 345);
            this.separador_login.Name = "separador_login";
            this.separador_login.Size = new System.Drawing.Size(258, 10);
            this.separador_login.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 4;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.CadetBlue;
            this.btnLogin.Font = new System.Drawing.Font("Impact", 12F);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogin.Location = new System.Drawing.Point(479, 375);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtB_pass
            // 
            this.txtB_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.txtB_pass.BorderRadius = 2;
            this.txtB_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtB_pass.DefaultText = "";
            this.txtB_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtB_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtB_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtB_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtB_pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.txtB_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtB_pass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtB_pass.ForeColor = System.Drawing.Color.White;
            this.txtB_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtB_pass.Location = new System.Drawing.Point(349, 263);
            this.txtB_pass.Name = "txtB_pass";
            this.txtB_pass.PasswordChar = '\0';
            this.txtB_pass.PlaceholderText = "Password";
            this.txtB_pass.SelectedText = "";
            this.txtB_pass.Size = new System.Drawing.Size(258, 43);
            this.txtB_pass.TabIndex = 4;
            // 
            // txtB_email
            // 
            this.txtB_email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.txtB_email.BorderRadius = 2;
            this.txtB_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtB_email.DefaultText = "";
            this.txtB_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtB_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtB_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtB_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtB_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.txtB_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtB_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtB_email.ForeColor = System.Drawing.Color.White;
            this.txtB_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtB_email.Location = new System.Drawing.Point(349, 196);
            this.txtB_email.Name = "txtB_email";
            this.txtB_email.PasswordChar = '\0';
            this.txtB_email.PlaceholderText = "Email";
            this.txtB_email.SelectedText = "";
            this.txtB_email.Size = new System.Drawing.Size(258, 43);
            this.txtB_email.TabIndex = 3;
            // 
            // txtLabel
            // 
            this.txtLabel.BackColor = System.Drawing.Color.Transparent;
            this.txtLabel.Font = new System.Drawing.Font("Impact", 26F);
            this.txtLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.txtLabel.IsSelectionEnabled = false;
            this.txtLabel.Location = new System.Drawing.Point(409, 93);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(144, 45);
            this.txtLabel.TabIndex = 0;
            this.txtLabel.Text = "TASKDESK";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(583, -17);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(458, 583);
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 536);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(966, 32);
            this.guna2Panel1.TabIndex = 2;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 568);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).EndInit();
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel panel_login;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox btn_close;
        private Guna.UI2.WinForms.Guna2PictureBox btn_Min;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtLabel;
        private Guna.UI2.WinForms.Guna2PictureBox picbox_login;
        private Guna.UI2.WinForms.Guna2TextBox txtB_email;
        private Guna.UI2.WinForms.Guna2TextBox txtB_pass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Separator separador_login;
        private System.Windows.Forms.LinkLabel linkLabel_login;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picb_ocultar;
        private Guna.UI2.WinForms.Guna2PictureBox picb_mostrar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}