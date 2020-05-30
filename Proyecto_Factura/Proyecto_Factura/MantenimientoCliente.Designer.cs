namespace Proyecto_Factura
{
    partial class MantenimientoCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomcli = new System.Windows.Forms.TextBox();
            this.txtApecli = new System.Windows.Forms.TextBox();
            this.txtidcli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNomcli);
            this.groupBox1.Controls.Add(this.txtApecli);
            this.groupBox1.Controls.Add(this.txtidcli);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 213);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id_Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre ";
            // 
            // txtNomcli
            // 
            this.txtNomcli.Location = new System.Drawing.Point(139, 81);
            this.txtNomcli.Name = "txtNomcli";
            this.txtNomcli.Size = new System.Drawing.Size(149, 20);
            this.txtNomcli.TabIndex = 17;
            // 
            // txtApecli
            // 
            this.txtApecli.Location = new System.Drawing.Point(139, 143);
            this.txtApecli.Name = "txtApecli";
            this.txtApecli.Size = new System.Drawing.Size(149, 20);
            this.txtApecli.TabIndex = 16;
            // 
            // txtidcli
            // 
            this.txtidcli.Location = new System.Drawing.Point(139, 31);
            this.txtidcli.Name = "txtidcli";
            this.txtidcli.Size = new System.Drawing.Size(149, 20);
            this.txtidcli.TabIndex = 15;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomcli;
        private System.Windows.Forms.TextBox txtApecli;
        private System.Windows.Forms.TextBox txtidcli;
    }
}