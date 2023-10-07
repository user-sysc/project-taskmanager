namespace WindowsFormsApp1
{
    partial class AddTask
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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_descripcion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbox_descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtbox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_fecha = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtbox_fecha = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.check_completed = new Guna.UI2.WinForms.Guna2CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check_pending = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DimGray;
            this.btnBack.BorderRadius = 4;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(789, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 47);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(224, 130);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(57, 22);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "ID TAREA";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.ForeColor = System.Drawing.Color.White;
            this.lbl_descripcion.Location = new System.Drawing.Point(205, 182);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(90, 22);
            this.lbl_descripcion.TabIndex = 3;
            this.lbl_descripcion.Text = "DESCRIPCION";
            // 
            // txtbox_descripcion
            // 
            this.txtbox_descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_descripcion.DefaultText = "";
            this.txtbox_descripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_descripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_descripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_descripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_descripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_descripcion.Location = new System.Drawing.Point(346, 178);
            this.txtbox_descripcion.Name = "txtbox_descripcion";
            this.txtbox_descripcion.PasswordChar = '\0';
            this.txtbox_descripcion.PlaceholderText = "";
            this.txtbox_descripcion.SelectedText = "";
            this.txtbox_descripcion.Size = new System.Drawing.Size(200, 31);
            this.txtbox_descripcion.TabIndex = 4;
            // 
            // txtbox_id
            // 
            this.txtbox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_id.DefaultText = "";
            this.txtbox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_id.Location = new System.Drawing.Point(346, 125);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.PasswordChar = '\0';
            this.txtbox_id.PlaceholderText = "";
            this.txtbox_id.SelectedText = "";
            this.txtbox_id.Size = new System.Drawing.Size(200, 31);
            this.txtbox_id.TabIndex = 5;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fecha.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(195, 234);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(113, 22);
            this.lbl_fecha.TabIndex = 6;
            this.lbl_fecha.Text = "FECHA FINALIZADO";
            // 
            // txtbox_fecha
            // 
            this.txtbox_fecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbox_fecha.DefaultText = "";
            this.txtbox_fecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbox_fecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbox_fecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_fecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbox_fecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_fecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbox_fecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox_fecha.Location = new System.Drawing.Point(346, 229);
            this.txtbox_fecha.Name = "txtbox_fecha";
            this.txtbox_fecha.PasswordChar = '\0';
            this.txtbox_fecha.PlaceholderText = "";
            this.txtbox_fecha.SelectedText = "";
            this.txtbox_fecha.Size = new System.Drawing.Size(200, 31);
            this.txtbox_fecha.TabIndex = 7;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(106, 39);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(126, 41);
            this.guna2HtmlLabel4.TabIndex = 8;
            this.guna2HtmlLabel4.Text = "ADD TASK";
            // 
            // check_completed
            // 
            this.check_completed.AutoSize = true;
            this.check_completed.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.check_completed.CheckedState.BorderRadius = 0;
            this.check_completed.CheckedState.BorderThickness = 0;
            this.check_completed.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.check_completed.Font = new System.Drawing.Font("Impact", 12F);
            this.check_completed.ForeColor = System.Drawing.Color.White;
            this.check_completed.Location = new System.Drawing.Point(65, 27);
            this.check_completed.Name = "check_completed";
            this.check_completed.Size = new System.Drawing.Size(101, 24);
            this.check_completed.TabIndex = 9;
            this.check_completed.Text = "COMPLETED";
            this.check_completed.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_completed.UncheckedState.BorderRadius = 0;
            this.check_completed.UncheckedState.BorderThickness = 0;
            this.check_completed.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check_completed);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(180, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 71);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ESTADO";
            // 
            // check_pending
            // 
            this.check_pending.AutoSize = true;
            this.check_pending.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.check_pending.CheckedState.BorderRadius = 0;
            this.check_pending.CheckedState.BorderThickness = 0;
            this.check_pending.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.check_pending.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_pending.ForeColor = System.Drawing.Color.White;
            this.check_pending.Location = new System.Drawing.Point(428, 304);
            this.check_pending.Name = "check_pending";
            this.check_pending.Size = new System.Drawing.Size(84, 24);
            this.check_pending.TabIndex = 12;
            this.check_pending.Text = "PENDING";
            this.check_pending.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.check_pending.UncheckedState.BorderRadius = 0;
            this.check_pending.UncheckedState.BorderThickness = 0;
            this.check_pending.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 4;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(37)))));
            this.btnAdd.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(180, 375);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "ADD";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(964, 504);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.check_pending);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtbox_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txtbox_id);
            this.Controls.Add(this.txtbox_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btnBack);
            this.Name = "AddTask";
            this.Text = "AddTask";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_descripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_descripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_fecha;
        private Guna.UI2.WinForms.Guna2TextBox txtbox_fecha;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2CheckBox check_completed;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox check_pending;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
    }
}