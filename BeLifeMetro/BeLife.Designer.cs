namespace BeLifeMetro
{
    partial class BeLife
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
            this.panMenu = new System.Windows.Forms.Panel();
            this.panPrincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientesMenu = new System.Windows.Forms.Button();
            this.btnContratosMenu = new System.Windows.Forms.Button();
            this.btnOpcionesMenu = new System.Windows.Forms.Button();
            this.btnSalirMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnContratos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panMenu.SuspendLayout();
            this.panPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panMenu.Controls.Add(this.label5);
            this.panMenu.Controls.Add(this.label4);
            this.panMenu.Controls.Add(this.label3);
            this.panMenu.Controls.Add(this.label2);
            this.panMenu.Controls.Add(this.btnSalirMenu);
            this.panMenu.Controls.Add(this.btnOpcionesMenu);
            this.panMenu.Controls.Add(this.btnContratosMenu);
            this.panMenu.Controls.Add(this.btnClientesMenu);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenu.Location = new System.Drawing.Point(0, 0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(121, 562);
            this.panMenu.TabIndex = 0;
            this.panMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panMenu_Paint);
            // 
            // panPrincipal
            // 
            this.panPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.panPrincipal.Controls.Add(this.btnClientes);
            this.panPrincipal.Controls.Add(this.btnContratos);
            this.panPrincipal.Controls.Add(this.label1);
            this.panPrincipal.Location = new System.Drawing.Point(118, -1);
            this.panPrincipal.Name = "panPrincipal";
            this.panPrincipal.Size = new System.Drawing.Size(911, 573);
            this.panPrincipal.TabIndex = 1;
            this.panPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panPrincipal_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(145)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(292, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 112);
            this.label1.TabIndex = 8;
            this.label1.Text = "BeLife ";
            // 
            // btnClientesMenu
            // 
            this.btnClientesMenu.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_male_i;
            this.btnClientesMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientesMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientesMenu.Location = new System.Drawing.Point(20, 26);
            this.btnClientesMenu.Name = "btnClientesMenu";
            this.btnClientesMenu.Size = new System.Drawing.Size(80, 80);
            this.btnClientesMenu.TabIndex = 9;
            this.btnClientesMenu.UseVisualStyleBackColor = true;
            this.btnClientesMenu.Click += new System.EventHandler(this.btnClientesMenu_Click);
            // 
            // btnContratosMenu
            // 
            this.btnContratosMenu.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_file_text_o_i;
            this.btnContratosMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContratosMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContratosMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratosMenu.Location = new System.Drawing.Point(20, 155);
            this.btnContratosMenu.Name = "btnContratosMenu";
            this.btnContratosMenu.Size = new System.Drawing.Size(80, 80);
            this.btnContratosMenu.TabIndex = 10;
            this.btnContratosMenu.UseVisualStyleBackColor = true;
            this.btnContratosMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpcionesMenu
            // 
            this.btnOpcionesMenu.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_wrench_i;
            this.btnOpcionesMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpcionesMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcionesMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpcionesMenu.Location = new System.Drawing.Point(20, 284);
            this.btnOpcionesMenu.Name = "btnOpcionesMenu";
            this.btnOpcionesMenu.Size = new System.Drawing.Size(80, 80);
            this.btnOpcionesMenu.TabIndex = 11;
            this.btnOpcionesMenu.UseVisualStyleBackColor = true;
            // 
            // btnSalirMenu
            // 
            this.btnSalirMenu.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_sign_in_i;
            this.btnSalirMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalirMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMenu.Location = new System.Drawing.Point(20, 413);
            this.btnSalirMenu.Name = "btnSalirMenu";
            this.btnSalirMenu.Size = new System.Drawing.Size(80, 80);
            this.btnSalirMenu.TabIndex = 12;
            this.btnSalirMenu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(11, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contratos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(11, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(35, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Salir";
            // 
            // btnContratos
            // 
            this.btnContratos.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_material_action_description;
            this.btnContratos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnContratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContratos.Location = new System.Drawing.Point(188, 252);
            this.btnContratos.Name = "btnContratos";
            this.btnContratos.Size = new System.Drawing.Size(166, 166);
            this.btnContratos.TabIndex = 13;
            this.btnContratos.UseVisualStyleBackColor = true;
            this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::BeLifeMetro.Properties.Resources.icon_users;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(554, 252);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(166, 166);
            this.btnClientes.TabIndex = 14;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1028, 562);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panPrincipal);
            this.Name = "Form1";
            this.Text = "BeLife";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panPrincipal.ResumeLayout(false);
            this.panPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientesMenu;
        private System.Windows.Forms.Button btnContratosMenu;
        private System.Windows.Forms.Button btnOpcionesMenu;
        private System.Windows.Forms.Button btnSalirMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btnClientes;
    }
}

