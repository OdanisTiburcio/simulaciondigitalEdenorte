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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tbMu = new System.Windows.Forms.TextBox();
            this.tbLamda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbProbabilidades = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbWq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la tanda:";
            // 
            // cbTanda
            // 
            this.cbTanda.FormattingEnabled = true;
            this.cbTanda.Items.AddRange(new object[] {
            "Tanda 1 (8:00am - 11:00am)",
            "Tanda 2 (11:01am - 3:00pm)",
            "Tanda 3 (3:01pm - 6:00pm)"});
            this.cbTanda.Location = new System.Drawing.Point(156, 10);
            this.cbTanda.Name = "cbTanda";
            this.cbTanda.Size = new System.Drawing.Size(138, 21);
            this.cbTanda.TabIndex = 1;
            this.cbTanda.SelectedIndexChanged += new System.EventHandler(this.cbTanda_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ctd. de Representantes ( c ):";
            // 
            // tbRepresentantes
            // 
            this.tbRepresentantes.Location = new System.Drawing.Point(156, 45);
            this.tbRepresentantes.Name = "tbRepresentantes";
            this.tbRepresentantes.Size = new System.Drawing.Size(45, 20);
            this.tbRepresentantes.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tasa de Servicio ( μ ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tasa de Llegada ( λ ):";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Enabled = false;
            this.btnCalcular.Location = new System.Drawing.Point(207, 38);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 27);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMu
            // 
            this.tbMu.Location = new System.Drawing.Point(169, 55);
            this.tbMu.Name = "tbMu";
            this.tbMu.Size = new System.Drawing.Size(82, 20);
            this.tbMu.TabIndex = 7;
            // 
            // tbLamda
            // 
            this.tbLamda.Location = new System.Drawing.Point(169, 19);
            this.tbLamda.Name = "tbLamda";
            this.tbLamda.Size = new System.Drawing.Size(82, 20);
            this.tbLamda.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbProbabilidades);
            this.groupBox1.Location = new System.Drawing.Point(300, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 198);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Probabilidades para n = 25 clientes";
            // 
            // lbProbabilidades
            // 
            this.lbProbabilidades.FormattingEnabled = true;
            this.lbProbabilidades.Location = new System.Drawing.Point(6, 16);
            this.lbProbabilidades.Name = "lbProbabilidades";
            this.lbProbabilidades.Size = new System.Drawing.Size(177, 173);
            this.lbProbabilidades.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbWq);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMu);
            this.groupBox2.Controls.Add(this.tbLamda);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 127);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // tbWq
            // 
            this.tbWq.Location = new System.Drawing.Point(169, 91);
            this.tbWq.Name = "tbWq";
            this.tbWq.Size = new System.Drawing.Size(82, 20);
            this.tbWq.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiempo prom. espera ( Wq ):";
            // 
            // frmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 218);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbRepresentantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTanda);
            this.Controls.Add(this.label1);
            this.Name = "frmSimulador";
            this.Text = "frmSimulador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTanda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRepresentantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox tbMu;
        private System.Windows.Forms.TextBox tbLamda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbProbabilidades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbWq;
        private System.Windows.Forms.Label label5;
    }
}