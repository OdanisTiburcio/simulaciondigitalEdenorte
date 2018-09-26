namespace simulaciondig
{
    partial class frmSimulador
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTanda = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRepresentantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMu = new System.Windows.Forms.TextBox();
            this.tbLamda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbProbabilidades = new System.Windows.Forms.ListBox();
            this.tabsimular = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btncalcular = new System.Windows.Forms.Button();
            this.tbWq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabsimular.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la tanda:";
            // 
            // cbTanda
            // 
            this.cbTanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanda.FormattingEnabled = true;
            this.cbTanda.Items.AddRange(new object[] {
            "Tanda 1 (8:00am - 2:00pm)",
            "Tanda 2 (2:01pm - 6:00pm)"});
            this.cbTanda.Location = new System.Drawing.Point(16, 31);
            this.cbTanda.Name = "cbTanda";
            this.cbTanda.Size = new System.Drawing.Size(201, 28);
            this.cbTanda.TabIndex = 1;
            this.cbTanda.SelectedIndexChanged += new System.EventHandler(this.cbTanda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ctd. de Representantes ( c ):";
            // 
            // tbRepresentantes
            // 
            this.tbRepresentantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRepresentantes.Location = new System.Drawing.Point(16, 87);
            this.tbRepresentantes.Name = "tbRepresentantes";
            this.tbRepresentantes.Size = new System.Drawing.Size(82, 26);
            this.tbRepresentantes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tasa de Servicio ( μ ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tasa de Llegada ( λ ):";
            // 
            // tbMu
            // 
            this.tbMu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMu.Location = new System.Drawing.Point(16, 196);
            this.tbMu.Name = "tbMu";
            this.tbMu.Size = new System.Drawing.Size(82, 26);
            this.tbMu.TabIndex = 7;
            // 
            // tbLamda
            // 
            this.tbLamda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLamda.Location = new System.Drawing.Point(16, 143);
            this.tbLamda.Name = "tbLamda";
            this.tbLamda.Size = new System.Drawing.Size(82, 26);
            this.tbLamda.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbProbabilidades);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 272);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidades";
            // 
            // lbProbabilidades
            // 
            this.lbProbabilidades.FormattingEnabled = true;
            this.lbProbabilidades.Location = new System.Drawing.Point(6, 15);
            this.lbProbabilidades.Name = "lbProbabilidades";
            this.lbProbabilidades.Size = new System.Drawing.Size(143, 251);
            this.lbProbabilidades.TabIndex = 0;
            // 
            // tabsimular
            // 
            this.tabsimular.Controls.Add(this.tabPage1);
            this.tabsimular.Controls.Add(this.tabPage2);
            this.tabsimular.Location = new System.Drawing.Point(3, 3);
            this.tabsimular.Name = "tabsimular";
            this.tabsimular.SelectedIndex = 0;
            this.tabsimular.Size = new System.Drawing.Size(260, 310);
            this.tabsimular.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbTanda);
            this.tabPage1.Controls.Add(this.tbMu);
            this.tabPage1.Controls.Add(this.tbLamda);
            this.tabPage1.Controls.Add(this.tbRepresentantes);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Valores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbWq);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btncalcular);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulación";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(168, 12);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(71, 37);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // tbWq
            // 
            this.tbWq.Location = new System.Drawing.Point(168, 104);
            this.tbWq.Name = "tbWq";
            this.tbWq.Size = new System.Drawing.Size(71, 20);
            this.tbWq.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiempo prom.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "espera ( Wq):";
            // 
            // frmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 325);
            this.Controls.Add(this.tabsimular);
            this.Name = "frmSimulador";
            this.Text = "Simulación Digital";
            this.Load += new System.EventHandler(this.frmSimulador_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabsimular.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRepresentantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMu;
        private System.Windows.Forms.TextBox tbLamda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbProbabilidades;
        private System.Windows.Forms.TabControl tabsimular;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbWq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncalcular;
    }
}