namespace WindowsFormsApp1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMax = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelFormularios = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imgbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelFormularios.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.btnMin);
            this.guna2Panel1.Controls.Add(this.btnMax);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(966, 32);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(58, 19);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "TASK DESK";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageRotate = 0F;
            this.btnMin.Location = new System.Drawing.Point(887, 8);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(16, 16);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageRotate = 0F;
            this.btnMax.Location = new System.Drawing.Point(909, 8);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(16, 16);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMax.TabIndex = 2;
            this.btnMax.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.Location = new System.Drawing.Point(931, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2Panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 536);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(966, 32);
            this.guna2Panel2.TabIndex = 1;
            // 
            // panelFormularios
            // 
            this.panelFormularios.Controls.Add(this.lblTitle);
            this.panelFormularios.Controls.Add(this.guna2ImageButton2);
            this.panelFormularios.Controls.Add(this.imgbtn);
            this.panelFormularios.Controls.Add(this.guna2Panel3);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(0, 32);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(966, 504);
            this.panelFormularios.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 52F);
            this.lblTitle.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTitle.Location = new System.Drawing.Point(442, 242);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(403, 87);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "TASKMANAGER";
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(256, 256);
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(256, 256);
            this.guna2ImageButton2.Location = new System.Drawing.Point(116, 66);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(256, 256);
            this.guna2ImageButton2.Size = new System.Drawing.Size(300, 438);
            this.guna2ImageButton2.TabIndex = 3;
            // 
            // imgbtn
            // 
            this.imgbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgbtn.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.imgbtn.Image = ((System.Drawing.Image)(resources.GetObject("imgbtn.Image")));
            this.imgbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtn.ImageRotate = 0F;
            this.imgbtn.ImageSize = new System.Drawing.Size(34, 34);
            this.imgbtn.Location = new System.Drawing.Point(919, 461);
            this.imgbtn.Name = "imgbtn";
            this.imgbtn.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.imgbtn.Size = new System.Drawing.Size(35, 34);
            this.imgbtn.TabIndex = 1;
            this.imgbtn.Click += new System.EventHandler(this.imgbtn_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.CadetBlue;
            this.guna2Panel3.BorderRadius = 4;
            this.guna2Panel3.Controls.Add(this.btnAdd);
            this.guna2Panel3.Controls.Add(this.btnShow);
            this.guna2Panel3.Controls.Add(this.btnDelete);
            this.guna2Panel3.Controls.Add(this.btnFilter);
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(966, 64);
            this.guna2Panel3.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnAdd.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(91, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 45);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD TASK";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.BorderRadius = 4;
            this.btnShow.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnShow.Font = new System.Drawing.Font("Impact", 12F);
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnShow.Location = new System.Drawing.Point(697, 9);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(180, 45);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "SHOW TASK\'S";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 4;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnDelete.Font = new System.Drawing.Font("Impact", 12F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(294, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "DELETE TASK";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BorderRadius = 4;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnFilter.Font = new System.Drawing.Font("Impact", 12F);
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFilter.Location = new System.Drawing.Point(496, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(180, 45);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "FILTER TASK";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(966, 568);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskDesk";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private Guna.UI2.WinForms.Guna2PictureBox btnMin;
        private Guna.UI2.WinForms.Guna2PictureBox btnMax;
        private Guna.UI2.WinForms.Guna2Panel panelFormularios;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnShow;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton imgbtn;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
    }
}

