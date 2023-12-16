namespace SeguridadHack
{
    partial class AdminPermisos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.DDLPermiso = new System.Windows.Forms.ComboBox();
            this.DDLRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRolPermiso = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoPermiso = new System.Windows.Forms.TextBox();
            this.BtnPermisoInsert = new System.Windows.Forms.Button();
            this.DGVPermisosNew = new System.Windows.Forms.DataGridView();
            this.BtnPermisoAnular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolPermiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPermisosNew)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel1.Controls.Add(this.BtnPermisoAnular);
            this.panel1.Controls.Add(this.DGVPermisosNew);
            this.panel1.Controls.Add(this.BtnPermisoInsert);
            this.panel1.Controls.Add(this.txtNuevoPermiso);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.btnAnular);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Controls.Add(this.DDLPermiso);
            this.panel1.Controls.Add(this.DDLRol);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvRolPermiso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1305, 376);
            this.panel1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.LightGray;
            this.btnVolver.Location = new System.Drawing.Point(16, 332);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(404, 30);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.DimGray;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.LightGray;
            this.btnAnular.Location = new System.Drawing.Point(16, 282);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(404, 30);
            this.btnAnular.TabIndex = 15;
            this.btnAnular.Text = "ANULAR";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.DimGray;
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnInsertar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.LightGray;
            this.btnInsertar.Location = new System.Drawing.Point(16, 234);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(404, 30);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // DDLPermiso
            // 
            this.DDLPermiso.FormattingEnabled = true;
            this.DDLPermiso.Location = new System.Drawing.Point(108, 146);
            this.DDLPermiso.Name = "DDLPermiso";
            this.DDLPermiso.Size = new System.Drawing.Size(312, 24);
            this.DDLPermiso.TabIndex = 8;
            // 
            // DDLRol
            // 
            this.DDLRol.FormattingEnabled = true;
            this.DDLRol.Location = new System.Drawing.Point(108, 69);
            this.DDLRol.Name = "DDLRol";
            this.DDLRol.Size = new System.Drawing.Size(312, 24);
            this.DDLRol.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Permisos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(41, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Roles:";
            // 
            // dgvRolPermiso
            // 
            this.dgvRolPermiso.AllowUserToAddRows = false;
            this.dgvRolPermiso.AllowUserToDeleteRows = false;
            this.dgvRolPermiso.AllowUserToOrderColumns = true;
            this.dgvRolPermiso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolPermiso.Location = new System.Drawing.Point(436, 32);
            this.dgvRolPermiso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRolPermiso.Name = "dgvRolPermiso";
            this.dgvRolPermiso.ReadOnly = true;
            this.dgvRolPermiso.RowHeadersWidth = 62;
            this.dgvRolPermiso.RowTemplate.Height = 28;
            this.dgvRolPermiso.Size = new System.Drawing.Size(469, 330);
            this.dgvRolPermiso.TabIndex = 4;
            this.dgvRolPermiso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolPermiso_CellContentClick);
            this.dgvRolPermiso.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolPermiso_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(176, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADMINISTRACION DE PERMISOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(931, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nuevo Permiso:";
            // 
            // txtNuevoPermiso
            // 
            this.txtNuevoPermiso.Location = new System.Drawing.Point(935, 69);
            this.txtNuevoPermiso.Name = "txtNuevoPermiso";
            this.txtNuevoPermiso.Size = new System.Drawing.Size(333, 22);
            this.txtNuevoPermiso.TabIndex = 18;
            // 
            // BtnPermisoInsert
            // 
            this.BtnPermisoInsert.BackColor = System.Drawing.Color.DimGray;
            this.BtnPermisoInsert.FlatAppearance.BorderSize = 0;
            this.BtnPermisoInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPermisoInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPermisoInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPermisoInsert.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPermisoInsert.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPermisoInsert.Location = new System.Drawing.Point(947, 282);
            this.BtnPermisoInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPermisoInsert.Name = "BtnPermisoInsert";
            this.BtnPermisoInsert.Size = new System.Drawing.Size(135, 30);
            this.BtnPermisoInsert.TabIndex = 19;
            this.BtnPermisoInsert.Text = "INSERTAR";
            this.BtnPermisoInsert.UseVisualStyleBackColor = false;
            this.BtnPermisoInsert.Click += new System.EventHandler(this.BtnPermisoInsert_Click);
            // 
            // DGVPermisosNew
            // 
            this.DGVPermisosNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPermisosNew.Location = new System.Drawing.Point(935, 114);
            this.DGVPermisosNew.Name = "DGVPermisosNew";
            this.DGVPermisosNew.RowHeadersWidth = 51;
            this.DGVPermisosNew.RowTemplate.Height = 24;
            this.DGVPermisosNew.Size = new System.Drawing.Size(333, 150);
            this.DGVPermisosNew.TabIndex = 20;
            // 
            // BtnPermisoAnular
            // 
            this.BtnPermisoAnular.BackColor = System.Drawing.Color.DimGray;
            this.BtnPermisoAnular.FlatAppearance.BorderSize = 0;
            this.BtnPermisoAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPermisoAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPermisoAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPermisoAnular.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPermisoAnular.ForeColor = System.Drawing.Color.LightGray;
            this.BtnPermisoAnular.Location = new System.Drawing.Point(1121, 282);
            this.BtnPermisoAnular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPermisoAnular.Name = "BtnPermisoAnular";
            this.BtnPermisoAnular.Size = new System.Drawing.Size(135, 30);
            this.BtnPermisoAnular.TabIndex = 21;
            this.BtnPermisoAnular.Text = "ANULAR";
            this.BtnPermisoAnular.UseVisualStyleBackColor = false;
            this.BtnPermisoAnular.Click += new System.EventHandler(this.BtnPermisoAnular_Click);
            // 
            // AdminPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1329, 400);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPermisos";
            this.Text = "AdminPermisos";
            this.Load += new System.EventHandler(this.AdminPermisos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolPermiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPermisosNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRolPermiso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DDLPermiso;
        private System.Windows.Forms.ComboBox DDLRol;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridView DGVPermisosNew;
        private System.Windows.Forms.Button BtnPermisoInsert;
        private System.Windows.Forms.TextBox txtNuevoPermiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPermisoAnular;
    }
}