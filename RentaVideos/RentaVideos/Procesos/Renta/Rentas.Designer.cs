namespace RentaVideos.Procesos.Renta
{
    partial class Rentas
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
            this.Tbl_movimientoInventario = new System.Windows.Forms.TableLayoutPanel();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.Btn_MovInventario = new System.Windows.Forms.Button();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_desarrollo = new System.Windows.Forms.Panel();
            this.Grp_nuevo = new System.Windows.Forms.GroupBox();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Dgv_lista = new System.Windows.Forms.DataGridView();
            this.Renta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Membresia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tbl_movimientoInventario.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_desarrollo.SuspendLayout();
            this.Grp_nuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbl_movimientoInventario
            // 
            this.Tbl_movimientoInventario.ColumnCount = 1;
            this.Tbl_movimientoInventario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Tbl_movimientoInventario.Controls.Add(this.Pnl_titulo, 0, 0);
            this.Tbl_movimientoInventario.Controls.Add(this.Pnl_desarrollo, 0, 1);
            this.Tbl_movimientoInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbl_movimientoInventario.Location = new System.Drawing.Point(0, 0);
            this.Tbl_movimientoInventario.Name = "Tbl_movimientoInventario";
            this.Tbl_movimientoInventario.RowCount = 2;
            this.Tbl_movimientoInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.Tbl_movimientoInventario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.Tbl_movimientoInventario.Size = new System.Drawing.Size(800, 638);
            this.Tbl_movimientoInventario.TabIndex = 6;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Pnl_titulo.Controls.Add(this.Btn_MovInventario);
            this.Pnl_titulo.Controls.Add(this.Lbl_titulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_titulo.Location = new System.Drawing.Point(3, 3);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(794, 64);
            this.Pnl_titulo.TabIndex = 0;
            // 
            // Btn_MovInventario
            // 
            this.Btn_MovInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.BackgroundImage = global::RentaVideos.Properties.Resources._091_trolley;
            this.Btn_MovInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_MovInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_MovInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.BorderSize = 0;
            this.Btn_MovInventario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(208)))), ((int)(((byte)(68)))));
            this.Btn_MovInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MovInventario.Location = new System.Drawing.Point(656, 0);
            this.Btn_MovInventario.Name = "Btn_MovInventario";
            this.Btn_MovInventario.Size = new System.Drawing.Size(138, 64);
            this.Btn_MovInventario.TabIndex = 3;
            this.Btn_MovInventario.UseVisualStyleBackColor = false;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.Lbl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(162, 47);
            this.Lbl_titulo.TabIndex = 0;
            this.Lbl_titulo.Text = "RENTAS";
            // 
            // Pnl_desarrollo
            // 
            this.Pnl_desarrollo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Pnl_desarrollo.Controls.Add(this.Grp_nuevo);
            this.Pnl_desarrollo.Controls.Add(this.Dgv_lista);
            this.Pnl_desarrollo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_desarrollo.Location = new System.Drawing.Point(3, 73);
            this.Pnl_desarrollo.Name = "Pnl_desarrollo";
            this.Pnl_desarrollo.Size = new System.Drawing.Size(794, 562);
            this.Pnl_desarrollo.TabIndex = 1;
            // 
            // Grp_nuevo
            // 
            this.Grp_nuevo.Controls.Add(this.Btn_nuevo);
            this.Grp_nuevo.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Grp_nuevo.Location = new System.Drawing.Point(9, 3);
            this.Grp_nuevo.Name = "Grp_nuevo";
            this.Grp_nuevo.Size = new System.Drawing.Size(96, 55);
            this.Grp_nuevo.TabIndex = 27;
            this.Grp_nuevo.TabStop = false;
            this.Grp_nuevo.Text = "NUEVO";
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_nuevo.BackgroundImage = global::RentaVideos.Properties.Resources._108_inbox_4;
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(207)))), ((int)(((byte)(138)))));
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Location = new System.Drawing.Point(3, 20);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(90, 32);
            this.Btn_nuevo.TabIndex = 9;
            this.Btn_nuevo.UseVisualStyleBackColor = false;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Dgv_lista
            // 
            this.Dgv_lista.AllowUserToAddRows = false;
            this.Dgv_lista.AllowUserToDeleteRows = false;
            this.Dgv_lista.AllowUserToOrderColumns = true;
            this.Dgv_lista.AllowUserToResizeColumns = false;
            this.Dgv_lista.AllowUserToResizeRows = false;
            this.Dgv_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_lista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.Dgv_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Renta,
            this.Membresia,
            this.FechaRenta,
            this.Estado});
            this.Dgv_lista.Location = new System.Drawing.Point(8, 61);
            this.Dgv_lista.Name = "Dgv_lista";
            this.Dgv_lista.RowHeadersVisible = false;
            this.Dgv_lista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Dgv_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_lista.Size = new System.Drawing.Size(776, 498);
            this.Dgv_lista.TabIndex = 0;
            // 
            // Renta
            // 
            this.Renta.HeaderText = "Renta";
            this.Renta.Name = "Renta";
            // 
            // Membresia
            // 
            this.Membresia.HeaderText = "Membresia";
            this.Membresia.Name = "Membresia";
            // 
            // FechaRenta
            // 
            this.FechaRenta.HeaderText = "Fecha Renta";
            this.FechaRenta.Name = "FechaRenta";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Rentas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.Tbl_movimientoInventario);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Rentas";
            this.Text = "Rentas";
            this.Tbl_movimientoInventario.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_desarrollo.ResumeLayout(false);
            this.Grp_nuevo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Tbl_movimientoInventario;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Button Btn_MovInventario;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Panel Pnl_desarrollo;
        private System.Windows.Forms.GroupBox Grp_nuevo;
        private System.Windows.Forms.Button Btn_nuevo;
        public System.Windows.Forms.DataGridView Dgv_lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Renta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Membresia;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}