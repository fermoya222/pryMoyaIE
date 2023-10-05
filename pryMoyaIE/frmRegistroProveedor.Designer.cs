namespace pryMoyaIE
{
    partial class frmRegistroProveedor
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
            this.lblRegistroP = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblExpe = new System.Windows.Forms.Label();
            this.lblJusgJurisd = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbJuzg = new System.Windows.Forms.ComboBox();
            this.cmbLiqui = new System.Windows.Forms.ComboBox();
            this.mcrDatosP = new System.Windows.Forms.GroupBox();
            this.cmbJuri = new System.Windows.Forms.ComboBox();
            this.dtpApertura = new System.Windows.Forms.DateTimePicker();
            this.Nª = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JUZG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JURISD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LIQUIDADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.mcrDatosP.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegistroP
            // 
            this.lblRegistroP.AutoSize = true;
            this.lblRegistroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRegistroP.Location = new System.Drawing.Point(276, 18);
            this.lblRegistroP.Name = "lblRegistroP";
            this.lblRegistroP.Size = new System.Drawing.Size(316, 16);
            this.lblRegistroP.TabIndex = 0;
            this.lblRegistroP.Text = "REGISTRO DE PROVEEDOR DE SEGUROS ";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNum.Location = new System.Drawing.Point(6, 35);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(19, 13);
            this.lblNum.TabIndex = 1;
            this.lblNum.Text = "Nº";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEntidad.Location = new System.Drawing.Point(6, 67);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(43, 13);
            this.lblEntidad.TabIndex = 2;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblApertura.Location = new System.Drawing.Point(6, 98);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(66, 13);
            this.lblApertura.TabIndex = 3;
            this.lblApertura.Text = "APERTURA";
            // 
            // lblExpe
            // 
            this.lblExpe.AutoSize = true;
            this.lblExpe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExpe.Location = new System.Drawing.Point(6, 133);
            this.lblExpe.Name = "lblExpe";
            this.lblExpe.Size = new System.Drawing.Size(53, 13);
            this.lblExpe.TabIndex = 4;
            this.lblExpe.Text = "Nº EXPE.";
            // 
            // lblJusgJurisd
            // 
            this.lblJusgJurisd.AutoSize = true;
            this.lblJusgJurisd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJusgJurisd.Location = new System.Drawing.Point(6, 199);
            this.lblJusgJurisd.Name = "lblJusgJurisd";
            this.lblJusgJurisd.Size = new System.Drawing.Size(83, 13);
            this.lblJusgJurisd.TabIndex = 5;
            this.lblJusgJurisd.Text = "JUSG. JURISD.";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDireccion.Location = new System.Drawing.Point(6, 234);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(66, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "DIRECCIÓN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "LIQUIDADOR RESPONSABLE ";
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(95, 64);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(143, 20);
            this.txtEntidad.TabIndex = 8;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(95, 95);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(143, 20);
            this.txtApertura.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(95, 231);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(143, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(95, 32);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(143, 20);
            this.txtNro.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(26, 342);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(144, 342);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(26, 381);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(144, 381);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nª,
            this.Entidad,
            this.Apertura,
            this.NUM,
            this.JUZG,
            this.JURISD,
            this.DIRECCION,
            this.LIQUIDADOR});
            this.dgvProveedores.Location = new System.Drawing.Point(12, 47);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(569, 438);
            this.dgvProveedores.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "JUZG.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbJuzg
            // 
            this.cmbJuzg.FormattingEnabled = true;
            this.cmbJuzg.Location = new System.Drawing.Point(95, 162);
            this.cmbJuzg.Name = "cmbJuzg";
            this.cmbJuzg.Size = new System.Drawing.Size(143, 21);
            this.cmbJuzg.TabIndex = 22;
            // 
            // cmbLiqui
            // 
            this.cmbLiqui.FormattingEnabled = true;
            this.cmbLiqui.Location = new System.Drawing.Point(171, 267);
            this.cmbLiqui.Name = "cmbLiqui";
            this.cmbLiqui.Size = new System.Drawing.Size(67, 21);
            this.cmbLiqui.TabIndex = 23;
            // 
            // mcrDatosP
            // 
            this.mcrDatosP.Controls.Add(this.dtpApertura);
            this.mcrDatosP.Controls.Add(this.cmbJuri);
            this.mcrDatosP.Controls.Add(this.lblNum);
            this.mcrDatosP.Controls.Add(this.cmbLiqui);
            this.mcrDatosP.Controls.Add(this.btnLimpiar);
            this.mcrDatosP.Controls.Add(this.btnEliminar);
            this.mcrDatosP.Controls.Add(this.txtNro);
            this.mcrDatosP.Controls.Add(this.btnModificar);
            this.mcrDatosP.Controls.Add(this.cmbJuzg);
            this.mcrDatosP.Controls.Add(this.lblEntidad);
            this.mcrDatosP.Controls.Add(this.btnAgregar);
            this.mcrDatosP.Controls.Add(this.label2);
            this.mcrDatosP.Controls.Add(this.txtEntidad);
            this.mcrDatosP.Controls.Add(this.lblApertura);
            this.mcrDatosP.Controls.Add(this.label1);
            this.mcrDatosP.Controls.Add(this.txtDireccion);
            this.mcrDatosP.Controls.Add(this.txtApertura);
            this.mcrDatosP.Controls.Add(this.lblDireccion);
            this.mcrDatosP.Controls.Add(this.lblExpe);
            this.mcrDatosP.Controls.Add(this.lblJusgJurisd);
            this.mcrDatosP.Location = new System.Drawing.Point(599, 47);
            this.mcrDatosP.Name = "mcrDatosP";
            this.mcrDatosP.Size = new System.Drawing.Size(253, 438);
            this.mcrDatosP.TabIndex = 24;
            this.mcrDatosP.TabStop = false;
            this.mcrDatosP.Text = "Datos del proveedor";
            // 
            // cmbJuri
            // 
            this.cmbJuri.FormattingEnabled = true;
            this.cmbJuri.Location = new System.Drawing.Point(95, 200);
            this.cmbJuri.Name = "cmbJuri";
            this.cmbJuri.Size = new System.Drawing.Size(143, 21);
            this.cmbJuri.TabIndex = 24;
            // 
            // dtpApertura
            // 
            this.dtpApertura.Location = new System.Drawing.Point(95, 127);
            this.dtpApertura.Name = "dtpApertura";
            this.dtpApertura.Size = new System.Drawing.Size(143, 20);
            this.dtpApertura.TabIndex = 28;
            // 
            // Nª
            // 
            this.Nª.HeaderText = "Nª";
            this.Nª.Name = "Nª";
            // 
            // Entidad
            // 
            this.Entidad.HeaderText = "Entidad";
            this.Entidad.Name = "Entidad";
            // 
            // Apertura
            // 
            this.Apertura.HeaderText = "Apertura";
            this.Apertura.Name = "Apertura";
            // 
            // NUM
            // 
            this.NUM.HeaderText = "NUM";
            this.NUM.Name = "NUM";
            // 
            // JUZG
            // 
            this.JUZG.HeaderText = "JUZG";
            this.JUZG.Name = "JUZG";
            // 
            // JURISD
            // 
            this.JURISD.HeaderText = "JURISD";
            this.JURISD.Name = "JURISD";
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            // 
            // LIQUIDADOR
            // 
            this.LIQUIDADOR.HeaderText = "LIQUIDADOR";
            this.LIQUIDADOR.Name = "LIQUIDADOR";
            // 
            // frmRegistroProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(869, 538);
            this.Controls.Add(this.mcrDatosP);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.lblRegistroP);
            this.Name = "frmRegistroProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Proveedores";
            this.Load += new System.EventHandler(this.frmRegistroProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.mcrDatosP.ResumeLayout(false);
            this.mcrDatosP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistroP;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblExpe;
        private System.Windows.Forms.Label lblJusgJurisd;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbJuzg;
        private System.Windows.Forms.ComboBox cmbLiqui;
        private System.Windows.Forms.GroupBox mcrDatosP;
        private System.Windows.Forms.ComboBox cmbJuri;
        private System.Windows.Forms.DateTimePicker dtpApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nª;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn JUZG;
        private System.Windows.Forms.DataGridViewTextBoxColumn JURISD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIQUIDADOR;
    }
}