namespace BeLifeMetro
{
    partial class CuadroCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblRut = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNom.Location = new System.Drawing.Point(81, 51);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(66, 24);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "label1";
            this.lblNom.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApe.ForeColor = System.Drawing.Color.Transparent;
            this.lblApe.Location = new System.Drawing.Point(81, 94);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(66, 24);
            this.lblApe.TabIndex = 1;
            this.lblApe.Text = "label2";
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.ForeColor = System.Drawing.Color.Transparent;
            this.lblRut.Location = new System.Drawing.Point(81, 132);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(66, 24);
            this.lblRut.TabIndex = 2;
            this.lblRut.Text = "label3";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(-3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(224, 224);
            this.btn1.TabIndex = 3;
            this.btn1.UseCompatibleTextRendering = true;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // CuadroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btn1);
            this.Name = "CuadroCliente";
            this.Size = new System.Drawing.Size(224, 224);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Button btn1;
    }
}
