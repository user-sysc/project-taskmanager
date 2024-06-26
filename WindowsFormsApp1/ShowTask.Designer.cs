﻿namespace WindowsFormsApp1
{
    partial class ShowTask
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataview_show = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_show = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblShow = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxShow = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupShow = new System.Windows.Forms.GroupBox();
            this.btnCompleted = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataview_show)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 4;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(788, 430);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 47);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(106, 39);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(175, 41);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "SHOW TASK\'S";
            // 
            // dataview_show
            // 
            this.dataview_show.AllowUserToAddRows = false;
            this.dataview_show.AllowUserToDeleteRows = false;
            this.dataview_show.AllowUserToResizeColumns = false;
            this.dataview_show.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataview_show.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview_show.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataview_show.ColumnHeadersHeight = 40;
            this.dataview_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnDescripcion,
            this.ColumnCategoria,
            this.ColumnFecha,
            this.ColumnEstado});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview_show.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataview_show.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataview_show.Location = new System.Drawing.Point(108, 149);
            this.dataview_show.MultiSelect = false;
            this.dataview_show.Name = "dataview_show";
            this.dataview_show.ReadOnly = true;
            this.dataview_show.RowHeadersVisible = false;
            this.dataview_show.RowHeadersWidth = 50;
            this.dataview_show.RowTemplate.Height = 40;
            this.dataview_show.Size = new System.Drawing.Size(650, 309);
            this.dataview_show.TabIndex = 3;
            this.dataview_show.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dataview_show.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataview_show.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataview_show.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataview_show.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataview_show.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataview_show.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataview_show.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataview_show.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dataview_show.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataview_show.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataview_show.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dataview_show.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataview_show.ThemeStyle.HeaderStyle.Height = 40;
            this.dataview_show.ThemeStyle.ReadOnly = true;
            this.dataview_show.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataview_show.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataview_show.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataview_show.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataview_show.ThemeStyle.RowsStyle.Height = 40;
            this.dataview_show.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dataview_show.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 91.1287F;
            this.ColumnID.HeaderText = "ID TAREA";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.FillWeight = 204.5703F;
            this.ColumnDescripcion.HeaderText = "DESCRIPCION";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            this.ColumnDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.FillWeight = 111.0079F;
            this.ColumnCategoria.HeaderText = "CATEGORÍA";
            this.ColumnCategoria.Name = "ColumnCategoria";
            this.ColumnCategoria.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.FillWeight = 150.9909F;
            this.ColumnFecha.HeaderText = "FECHA FINALIZADO";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            this.ColumnFecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.FillWeight = 104.0412F;
            this.ColumnEstado.HeaderText = "ESTADO";
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            this.ColumnEstado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_show);
            this.groupBox1.Location = new System.Drawing.Point(109, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lbl_show
            // 
            this.lbl_show.BackColor = System.Drawing.Color.Transparent;
            this.lbl_show.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_show.ForeColor = System.Drawing.Color.White;
            this.lbl_show.Location = new System.Drawing.Point(68, 14);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(63, 22);
            this.lbl_show.TabIndex = 0;
            this.lbl_show.Text = "TASK LIST";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this.dataview_show;
            // 
            // lblShow
            // 
            this.lblShow.BackColor = System.Drawing.Color.Transparent;
            this.lblShow.Font = new System.Drawing.Font("Impact", 12F);
            this.lblShow.ForeColor = System.Drawing.Color.White;
            this.lblShow.Location = new System.Drawing.Point(36, 14);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(17, 22);
            this.lblShow.TabIndex = 5;
            this.lblShow.Text = "ID ";
            // 
            // txtBoxShow
            // 
            this.txtBoxShow.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxShow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxShow.DefaultText = "";
            this.txtBoxShow.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxShow.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxShow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxShow.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxShow.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxShow.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBoxShow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxShow.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxShow.Location = new System.Drawing.Point(86, 12);
            this.txtBoxShow.Name = "txtBoxShow";
            this.txtBoxShow.PasswordChar = '\0';
            this.txtBoxShow.PlaceholderText = "ID";
            this.txtBoxShow.SelectedText = "";
            this.txtBoxShow.Size = new System.Drawing.Size(108, 26);
            this.txtBoxShow.TabIndex = 6;
            this.txtBoxShow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxShow_KeyPress);
            // 
            // groupShow
            // 
            this.groupShow.Controls.Add(this.lblShow);
            this.groupShow.Controls.Add(this.txtBoxShow);
            this.groupShow.Location = new System.Drawing.Point(537, 86);
            this.groupShow.Name = "groupShow";
            this.groupShow.Size = new System.Drawing.Size(221, 45);
            this.groupShow.TabIndex = 7;
            this.groupShow.TabStop = false;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BorderRadius = 4;
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnCompleted.Font = new System.Drawing.Font("Impact", 12F);
            this.btnCompleted.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.Location = new System.Drawing.Point(788, 88);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(139, 47);
            this.btnCompleted.TabIndex = 8;
            this.btnCompleted.Text = "COMPLETE";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // ShowTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(964, 504);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.groupShow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataview_show);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnBack);
            this.Name = "ShowTask";
            this.Text = "ShowTask";
            ((System.ComponentModel.ISupportInitialize)(this.dataview_show)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupShow.ResumeLayout(false);
            this.groupShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataview_show;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_show;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShow;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxShow;
        private System.Windows.Forms.GroupBox groupShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private Guna.UI2.WinForms.Guna2Button btnCompleted;
    }
}