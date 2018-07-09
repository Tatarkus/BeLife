using System.Windows.Forms;

namespace BeLifeMetro
{
    partial class VentanaContrato
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTerminarContrato = new System.Windows.Forms.Button();
            this.btnAgregarContrato = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.listListaContratos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPoliza = new System.Windows.Forms.ComboBox();
            this.txtFiltrarRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltrarContrato = new System.Windows.Forms.TextBox();
            this.btnActualizarContrato = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.btnActualizarContrato);
            this.panel1.Controls.Add(this.btnTerminarContrato);
            this.panel1.Controls.Add(this.btnAgregarContrato);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnClr);
            this.panel1.Controls.Add(this.listListaContratos);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbPoliza);
            this.panel1.Controls.Add(this.txtFiltrarRut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFiltrarContrato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 558);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTerminarContrato
            // 
            this.btnTerminarContrato.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_material_content_clear;
            this.btnTerminarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTerminarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarContrato.Location = new System.Drawing.Point(343, 448);
            this.btnTerminarContrato.Name = "btnTerminarContrato";
            this.btnTerminarContrato.Size = new System.Drawing.Size(70, 70);
            this.btnTerminarContrato.TabIndex = 29;
            this.btnTerminarContrato.UseVisualStyleBackColor = true;
            this.btnTerminarContrato.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAgregarContrato
            // 
            this.btnAgregarContrato.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_material_content_add;
            this.btnAgregarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarContrato.Location = new System.Drawing.Point(127, 448);
            this.btnAgregarContrato.Name = "btnAgregarContrato";
            this.btnAgregarContrato.Size = new System.Drawing.Size(70, 70);
            this.btnAgregarContrato.TabIndex = 28;
            this.btnAgregarContrato.UseVisualStyleBackColor = true;
            this.btnAgregarContrato.Click += new System.EventHandler(this.btnAgregarContrato_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label12.Location = new System.Drawing.Point(87, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Filtros";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label11.Location = new System.Drawing.Point(502, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Poliza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(294, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Rut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(56, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Contrato:";
            // 
            // btnClr
            // 
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(742, 138);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(95, 35);
            this.btnClr.TabIndex = 23;
            this.btnClr.Text = "Limpiar";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // listListaContratos
            // 
            this.listListaContratos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listListaContratos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listListaContratos.FullRowSelect = true;
            this.listListaContratos.GridLines = true;
            this.listListaContratos.Location = new System.Drawing.Point(106, 209);
            this.listListaContratos.Name = "listListaContratos";
            this.listListaContratos.Size = new System.Drawing.Size(534, 233);
            this.listListaContratos.TabIndex = 17;
            this.listListaContratos.UseCompatibleStateImageBehavior = false;
            this.listListaContratos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RUT Titular";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nº Contrato";
            this.columnHeader2.Width = 137;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Vigente";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Poliza";
            this.columnHeader5.Width = 181;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label10.Location = new System.Drawing.Point(519, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Actualizar Contrato";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(311, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Terminar Contrato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label8.Location = new System.Drawing.Point(94, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Agregar Contrato";
            // 
            // cbPoliza
            // 
            this.cbPoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPoliza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPoliza.FormattingEnabled = true;
            this.cbPoliza.Location = new System.Drawing.Point(562, 142);
            this.cbPoliza.Name = "cbPoliza";
            this.cbPoliza.Size = new System.Drawing.Size(113, 29);
            this.cbPoliza.TabIndex = 11;
            this.cbPoliza.SelectedIndexChanged += new System.EventHandler(this.cbPoliza_SelectedIndexChanged);
            // 
            // txtFiltrarRut
            // 
            this.txtFiltrarRut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(107)))));
            this.txtFiltrarRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarRut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarRut.ForeColor = System.Drawing.Color.White;
            this.txtFiltrarRut.Location = new System.Drawing.Point(336, 142);
            this.txtFiltrarRut.Name = "txtFiltrarRut";
            this.txtFiltrarRut.Size = new System.Drawing.Size(129, 27);
            this.txtFiltrarRut.TabIndex = 9;
            this.txtFiltrarRut.TextChanged += new System.EventHandler(this.txtFiltrarRut_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(115, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BeLife Contratos";
            // 
            // txtFiltrarContrato
            // 
            this.txtFiltrarContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(107)))));
            this.txtFiltrarContrato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarContrato.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarContrato.ForeColor = System.Drawing.Color.White;
            this.txtFiltrarContrato.Location = new System.Drawing.Point(139, 142);
            this.txtFiltrarContrato.Name = "txtFiltrarContrato";
            this.txtFiltrarContrato.Size = new System.Drawing.Size(129, 27);
            this.txtFiltrarContrato.TabIndex = 4;
            this.txtFiltrarContrato.TextChanged += new System.EventHandler(this.txtFiltrarContrato_TextChanged);
            // 
            // btnActualizarContrato
            // 
            this.btnActualizarContrato.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_material_action_cached;
            this.btnActualizarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarContrato.Location = new System.Drawing.Point(557, 448);
            this.btnActualizarContrato.Name = "btnActualizarContrato";
            this.btnActualizarContrato.Size = new System.Drawing.Size(70, 70);
            this.btnActualizarContrato.TabIndex = 30;
            this.btnActualizarContrato.UseVisualStyleBackColor = true;
            this.btnActualizarContrato.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // VentanaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "VentanaContrato";
            this.Size = new System.Drawing.Size(924, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPoliza;
        private System.Windows.Forms.TextBox txtFiltrarRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltrarContrato;
        private System.Windows.Forms.ListView listListaContratos;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private Label label6;
        private Label label11;
        private Label label7;
        private Label label12;
        private Button btnAgregarContrato;
        private Button btnTerminarContrato;
        private Button btnActualizarContrato;
    }
}
