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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTanda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabsimular = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblidsimulacion = new System.Windows.Forms.Label();
            this.tbidsimulacion = new System.Windows.Forms.TextBox();
            this.nudtasallegada = new System.Windows.Forms.NumericUpDown();
            this.nudtasaservicio = new System.Windows.Forms.NumericUpDown();
            this.nudctdservidores = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.nudctdclientes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrecomendaciones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posibleevento1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posibleevento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoatraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsimular.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtasallegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtasaservicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudctdservidores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudctdclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanda:";
            // 
            // cbTanda
            // 
            this.cbTanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanda.FormattingEnabled = true;
            this.cbTanda.Items.AddRange(new object[] {
            "Tanda 1 (8:00am - 2:00pm)",
            "Tanda 2 (2:01pm - 6:00pm)"});
            this.cbTanda.Location = new System.Drawing.Point(271, 81);
            this.cbTanda.Name = "cbTanda";
            this.cbTanda.Size = new System.Drawing.Size(202, 28);
            this.cbTanda.TabIndex = 1;
            this.cbTanda.SelectedIndexChanged += new System.EventHandler(this.cbTanda_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tasa de Servicio ( μ ):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tasa de Llegada ( λ ):";
            // 
            // tabsimular
            // 
            this.tabsimular.Controls.Add(this.tabPage1);
            this.tabsimular.Controls.Add(this.tabPage2);
            this.tabsimular.Location = new System.Drawing.Point(3, 3);
            this.tabsimular.Name = "tabsimular";
            this.tabsimular.SelectedIndex = 0;
            this.tabsimular.Size = new System.Drawing.Size(496, 387);
            this.tabsimular.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.nudctdclientes);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nudtasaservicio);
            this.tabPage1.Controls.Add(this.nudtasallegada);
            this.tabPage1.Controls.Add(this.tbidsimulacion);
            this.tabPage1.Controls.Add(this.lblidsimulacion);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbTanda);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Valores";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbrecomendaciones);
            this.tabPage2.Controls.Add(this.nudctdservidores);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btncalcular);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(488, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulación";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.posibleevento1,
            this.posibleevento2,
            this.tiempoatraso});
            this.dataGridView1.Location = new System.Drawing.Point(6, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 234);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblidsimulacion
            // 
            this.lblidsimulacion.AutoSize = true;
            this.lblidsimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidsimulacion.Location = new System.Drawing.Point(309, 15);
            this.lblidsimulacion.Name = "lblidsimulacion";
            this.lblidsimulacion.Size = new System.Drawing.Size(109, 18);
            this.lblidsimulacion.TabIndex = 10;
            this.lblidsimulacion.Text = "No.Simulación:";
            // 
            // tbidsimulacion
            // 
            this.tbidsimulacion.Enabled = false;
            this.tbidsimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidsimulacion.Location = new System.Drawing.Point(423, 12);
            this.tbidsimulacion.Name = "tbidsimulacion";
            this.tbidsimulacion.Size = new System.Drawing.Size(50, 24);
            this.tbidsimulacion.TabIndex = 11;
            // 
            // nudtasallegada
            // 
            this.nudtasallegada.DecimalPlaces = 2;
            this.nudtasallegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudtasallegada.Location = new System.Drawing.Point(164, 47);
            this.nudtasallegada.Name = "nudtasallegada";
            this.nudtasallegada.Size = new System.Drawing.Size(64, 26);
            this.nudtasallegada.TabIndex = 12;
            // 
            // nudtasaservicio
            // 
            this.nudtasaservicio.DecimalPlaces = 2;
            this.nudtasaservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudtasaservicio.Location = new System.Drawing.Point(409, 47);
            this.nudtasaservicio.Name = "nudtasaservicio";
            this.nudtasaservicio.Size = new System.Drawing.Size(64, 26);
            this.nudtasaservicio.TabIndex = 13;
            // 
            // nudctdservidores
            // 
            this.nudctdservidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudctdservidores.Location = new System.Drawing.Point(218, 14);
            this.nudctdservidores.Name = "nudctdservidores";
            this.nudctdservidores.Size = new System.Drawing.Size(64, 26);
            this.nudctdservidores.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ctd. de Representantes ( c ):";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(342, 14);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(107, 60);
            this.btncalcular.TabIndex = 10;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // nudctdclientes
            // 
            this.nudctdclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudctdclientes.Location = new System.Drawing.Point(110, 82);
            this.nudctdclientes.Name = "nudctdclientes";
            this.nudctdclientes.Size = new System.Drawing.Size(64, 26);
            this.nudctdclientes.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ctd. Clientes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Simulación Línea de Espera";
            // 
            // tbrecomendaciones
            // 
            this.tbrecomendaciones.Location = new System.Drawing.Point(5, 252);
            this.tbrecomendaciones.Multiline = true;
            this.tbrecomendaciones.Name = "tbrecomendaciones";
            this.tbrecomendaciones.Size = new System.Drawing.Size(473, 103);
            this.tbrecomendaciones.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Recomendaciones:";
            // 
            // cliente
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.Width = 70;
            // 
            // posibleevento1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posibleevento1.DefaultCellStyle = dataGridViewCellStyle2;
            this.posibleevento1.HeaderText = "Evento_1";
            this.posibleevento1.Name = "posibleevento1";
            this.posibleevento1.Width = 120;
            // 
            // posibleevento2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posibleevento2.DefaultCellStyle = dataGridViewCellStyle3;
            this.posibleevento2.HeaderText = "Evento_2";
            this.posibleevento2.Name = "posibleevento2";
            this.posibleevento2.Width = 120;
            // 
            // tiempoatraso
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoatraso.DefaultCellStyle = dataGridViewCellStyle4;
            this.tiempoatraso.HeaderText = "Atraso";
            this.tiempoatraso.Name = "tiempoatraso";
            this.tiempoatraso.Width = 70;
            // 
            // frmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 394);
            this.Controls.Add(this.tabsimular);
            this.Name = "frmSimulador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación Digital";
            this.Load += new System.EventHandler(this.frmSimulador_Load);
            this.tabsimular.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtasallegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtasaservicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudctdservidores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudctdclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTanda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabsimular;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbidsimulacion;
        private System.Windows.Forms.Label lblidsimulacion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nudtasaservicio;
        private System.Windows.Forms.NumericUpDown nudtasallegada;
        private System.Windows.Forms.NumericUpDown nudctdclientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudctdservidores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbrecomendaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn posibleevento1;
        private System.Windows.Forms.DataGridViewTextBoxColumn posibleevento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoatraso;
    }
}