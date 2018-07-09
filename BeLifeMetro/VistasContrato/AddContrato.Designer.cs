namespace BeLifeMetro
{
    partial class AddContrato
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
            this.btnAgregarContrato = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtrut = new System.Windows.Forms.TextBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.cbPoliza = new System.Windows.Forms.ComboBox();
            this.dateInicioVigencia = new System.Windows.Forms.DateTimePicker();
            this.rbSiDeclaraCionSalud = new System.Windows.Forms.RadioButton();
            this.rbNoDeclaracionSalud = new System.Windows.Forms.RadioButton();
            this.txtBoxObservaciones = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.btnAgregarContrato);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txtrut);
            this.panel1.Controls.Add(this.cbPlan);
            this.panel1.Controls.Add(this.cbPoliza);
            this.panel1.Controls.Add(this.dateInicioVigencia);
            this.panel1.Controls.Add(this.rbSiDeclaraCionSalud);
            this.panel1.Controls.Add(this.rbNoDeclaracionSalud);
            this.panel1.Controls.Add(this.txtBoxObservaciones);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 558);
            this.panel1.TabIndex = 3;
            // 
            // btnAgregarContrato
            // 
            this.btnAgregarContrato.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_material_content_add;
            this.btnAgregarContrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarContrato.Location = new System.Drawing.Point(351, 437);
            this.btnAgregarContrato.Name = "btnAgregarContrato";
            this.btnAgregarContrato.Size = new System.Drawing.Size(70, 70);
            this.btnAgregarContrato.TabIndex = 32;
            this.btnAgregarContrato.UseVisualStyleBackColor = true;
            this.btnAgregarContrato.Click += new System.EventHandler(this.btnAgregarContrato_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_users;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(565, 92);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(50, 50);
            this.btnBuscarCliente.TabIndex = 31;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtrut
            // 
            this.txtrut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(107)))));
            this.txtrut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrut.ForeColor = System.Drawing.Color.White;
            this.txtrut.Location = new System.Drawing.Point(387, 108);
            this.txtrut.Name = "txtrut";
            this.txtrut.Size = new System.Drawing.Size(129, 20);
            this.txtrut.TabIndex = 4;
            // 
            // cbPlan
            // 
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(387, 156);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 29;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged);
            // 
            // cbPoliza
            // 
            this.cbPoliza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliza.Enabled = false;
            this.cbPoliza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPoliza.FormattingEnabled = true;
            this.cbPoliza.Location = new System.Drawing.Point(387, 198);
            this.cbPoliza.Name = "cbPoliza";
            this.cbPoliza.Size = new System.Drawing.Size(121, 21);
            this.cbPoliza.TabIndex = 11;
            // 
            // dateInicioVigencia
            // 
            this.dateInicioVigencia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInicioVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateInicioVigencia.Location = new System.Drawing.Point(387, 249);
            this.dateInicioVigencia.Name = "dateInicioVigencia";
            this.dateInicioVigencia.Size = new System.Drawing.Size(130, 23);
            this.dateInicioVigencia.TabIndex = 22;
            // 
            // rbSiDeclaraCionSalud
            // 
            this.rbSiDeclaraCionSalud.AutoSize = true;
            this.rbSiDeclaraCionSalud.Location = new System.Drawing.Point(387, 292);
            this.rbSiDeclaraCionSalud.Name = "rbSiDeclaraCionSalud";
            this.rbSiDeclaraCionSalud.Size = new System.Drawing.Size(34, 17);
            this.rbSiDeclaraCionSalud.TabIndex = 24;
            this.rbSiDeclaraCionSalud.TabStop = true;
            this.rbSiDeclaraCionSalud.Text = "Si";
            this.rbSiDeclaraCionSalud.UseVisualStyleBackColor = true;
            // 
            // rbNoDeclaracionSalud
            // 
            this.rbNoDeclaracionSalud.AutoSize = true;
            this.rbNoDeclaracionSalud.Location = new System.Drawing.Point(478, 294);
            this.rbNoDeclaracionSalud.Name = "rbNoDeclaracionSalud";
            this.rbNoDeclaracionSalud.Size = new System.Drawing.Size(39, 17);
            this.rbNoDeclaracionSalud.TabIndex = 25;
            this.rbNoDeclaracionSalud.TabStop = true;
            this.rbNoDeclaracionSalud.Text = "No";
            this.rbNoDeclaracionSalud.UseVisualStyleBackColor = true;
            // 
            // txtBoxObservaciones
            // 
            this.txtBoxObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxObservaciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxObservaciones.ForeColor = System.Drawing.Color.White;
            this.txtBoxObservaciones.Location = new System.Drawing.Point(376, 330);
            this.txtBoxObservaciones.Multiline = true;
            this.txtBoxObservaciones.Name = "txtBoxObservaciones";
            this.txtBoxObservaciones.Size = new System.Drawing.Size(211, 85);
            this.txtBoxObservaciones.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(512, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(236, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Observaciones:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(209, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Declaración Salud:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(234, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Inicio VIgencia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label8.Location = new System.Drawing.Point(319, 510);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Agregar Contrato";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label7.Location = new System.Drawing.Point(537, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Buscar Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(304, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Poliza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label5.Location = new System.Drawing.Point(316, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Plan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BeLife Registrar Contratos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(305, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Titular:";
            // 
            // AddContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AddContrato";
            this.Size = new System.Drawing.Size(924, 558);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPoliza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateInicioVigencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbNoDeclaracionSalud;
        private System.Windows.Forms.RadioButton rbSiDeclaraCionSalud;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.TextBox txtBoxObservaciones;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnAgregarContrato;
    }
}
