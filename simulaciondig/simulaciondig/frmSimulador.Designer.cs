﻿namespace simulaciondig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTanda = new System.Windows.Forms.ComboBox();
            this.tabsimular = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LbxRecomendaciones = new System.Windows.Forms.ListBox();
            this.LbxEventos = new System.Windows.Forms.ListBox();
            this.DgvResultados = new System.Windows.Forms.DataGridView();
            this.tbidsimulacion = new System.Windows.Forms.TextBox();
            this.lblidsimulacion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.NudServidores = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DgvEventos = new System.Windows.Forms.DataGridView();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosibTanda1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosibTanda2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PosibTanda3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atraso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnClear = new System.Windows.Forms.Button();
            this.NoSimulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lamda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ws = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsimular.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultados)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudServidores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temporada:";
            // 
            // cbTanda
            // 
            this.cbTanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTanda.FormattingEnabled = true;
            this.cbTanda.Items.AddRange(new object[] {
            "Baja",
            "Media",
            "Alta"});
            this.cbTanda.Location = new System.Drawing.Point(102, 83);
            this.cbTanda.Name = "cbTanda";
            this.cbTanda.Size = new System.Drawing.Size(100, 28);
            this.cbTanda.TabIndex = 1;
            this.cbTanda.SelectedIndexChanged += new System.EventHandler(this.cbTanda_SelectedIndexChanged);
            // 
            // tabsimular
            // 
            this.tabsimular.Controls.Add(this.tabPage2);
            this.tabsimular.Controls.Add(this.tabPage1);
            this.tabsimular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsimular.Location = new System.Drawing.Point(0, 0);
            this.tabsimular.Name = "tabsimular";
            this.tabsimular.SelectedIndex = 0;
            this.tabsimular.Size = new System.Drawing.Size(635, 543);
            this.tabsimular.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.LbxRecomendaciones);
            this.tabPage2.Controls.Add(this.LbxEventos);
            this.tabPage2.Controls.Add(this.DgvResultados);
            this.tabPage2.Controls.Add(this.tbidsimulacion);
            this.tabPage2.Controls.Add(this.lblidsimulacion);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.BtnClear);
            this.tabPage2.Controls.Add(this.BtnCalcular);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulación";
            // 
            // LbxRecomendaciones
            // 
            this.LbxRecomendaciones.FormattingEnabled = true;
            this.LbxRecomendaciones.Location = new System.Drawing.Point(6, 380);
            this.LbxRecomendaciones.Name = "LbxRecomendaciones";
            this.LbxRecomendaciones.Size = new System.Drawing.Size(302, 134);
            this.LbxRecomendaciones.TabIndex = 29;
            // 
            // LbxEventos
            // 
            this.LbxEventos.FormattingEnabled = true;
            this.LbxEventos.Location = new System.Drawing.Point(314, 379);
            this.LbxEventos.Name = "LbxEventos";
            this.LbxEventos.Size = new System.Drawing.Size(307, 134);
            this.LbxEventos.TabIndex = 29;
            // 
            // DgvResultados
            // 
            this.DgvResultados.AllowUserToAddRows = false;
            this.DgvResultados.AllowUserToDeleteRows = false;
            this.DgvResultados.AllowUserToResizeRows = false;
            this.DgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvResultados.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoSimulacion,
            this.lamda,
            this.M,
            this.Lq,
            this.Ls,
            this.Wq,
            this.Ws,
            this.PP,
            this.PP0});
            this.DgvResultados.Location = new System.Drawing.Point(6, 87);
            this.DgvResultados.Name = "DgvResultados";
            this.DgvResultados.RowHeadersVisible = false;
            this.DgvResultados.Size = new System.Drawing.Size(615, 264);
            this.DgvResultados.TabIndex = 28;
            // 
            // tbidsimulacion
            // 
            this.tbidsimulacion.Enabled = false;
            this.tbidsimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidsimulacion.Location = new System.Drawing.Point(122, 31);
            this.tbidsimulacion.Name = "tbidsimulacion";
            this.tbidsimulacion.Size = new System.Drawing.Size(50, 24);
            this.tbidsimulacion.TabIndex = 27;
            // 
            // lblidsimulacion
            // 
            this.lblidsimulacion.AutoSize = true;
            this.lblidsimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidsimulacion.Location = new System.Drawing.Point(7, 34);
            this.lblidsimulacion.Name = "lblidsimulacion";
            this.lblidsimulacion.Size = new System.Drawing.Size(109, 18);
            this.lblidsimulacion.TabIndex = 26;
            this.lblidsimulacion.Text = "No.Simulación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Resultados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Simulación Línea de Espera";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Eventos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Recomendaciones";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(498, 8);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(126, 44);
            this.BtnCalcular.TabIndex = 10;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.NudServidores);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DgvEventos);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbTanda);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Valores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Eventos";
            // 
            // NudServidores
            // 
            this.NudServidores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudServidores.Location = new System.Drawing.Point(127, 51);
            this.NudServidores.Name = "NudServidores";
            this.NudServidores.ReadOnly = true;
            this.NudServidores.Size = new System.Drawing.Size(75, 26);
            this.NudServidores.TabIndex = 26;
            this.NudServidores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudServidores.ValueChanged += new System.EventHandler(this.NudServidores_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Servidores ( s ):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Simulación Línea de Espera";
            // 
            // DgvEventos
            // 
            this.DgvEventos.AllowUserToAddRows = false;
            this.DgvEventos.AllowUserToDeleteRows = false;
            this.DgvEventos.AllowUserToResizeRows = false;
            this.DgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEventos.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Evento,
            this.PosibTanda1,
            this.PosibTanda2,
            this.PosibTanda3,
            this.Atraso});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEventos.DefaultCellStyle = dataGridViewCellStyle12;
            this.DgvEventos.Location = new System.Drawing.Point(6, 152);
            this.DgvEventos.Name = "DgvEventos";
            this.DgvEventos.RowHeadersVisible = false;
            this.DgvEventos.Size = new System.Drawing.Size(618, 356);
            this.DgvEventos.TabIndex = 9;
            // 
            // Evento
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Evento.DefaultCellStyle = dataGridViewCellStyle8;
            this.Evento.FillWeight = 340F;
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            // 
            // PosibTanda1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosibTanda1.DefaultCellStyle = dataGridViewCellStyle9;
            this.PosibTanda1.FillWeight = 80F;
            this.PosibTanda1.HeaderText = "Prob. Temporada Baja (%)";
            this.PosibTanda1.Name = "PosibTanda1";
            // 
            // PosibTanda2
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosibTanda2.DefaultCellStyle = dataGridViewCellStyle10;
            this.PosibTanda2.FillWeight = 80F;
            this.PosibTanda2.HeaderText = "Prob. Temporada Media (%)";
            this.PosibTanda2.Name = "PosibTanda2";
            // 
            // PosibTanda3
            // 
            this.PosibTanda3.FillWeight = 80F;
            this.PosibTanda3.HeaderText = "Prob. Temporada Alta (%)";
            this.PosibTanda3.Name = "PosibTanda3";
            // 
            // Atraso
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atraso.DefaultCellStyle = dataGridViewCellStyle11;
            this.Atraso.FillWeight = 80F;
            this.Atraso.HeaderText = "Atraso (en minutos)";
            this.Atraso.Name = "Atraso";
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(498, 58);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(126, 23);
            this.BtnClear.TabIndex = 10;
            this.BtnClear.Text = "Limpiar Grid";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // NoSimulacion
            // 
            this.NoSimulacion.HeaderText = "Nro. Simulación";
            this.NoSimulacion.Name = "NoSimulacion";
            // 
            // lamda
            // 
            this.lamda.HeaderText = "Lambda";
            this.lamda.Name = "lamda";
            this.lamda.ToolTipText = "Tasa de llegada";
            // 
            // M
            // 
            this.M.HeaderText = "Miu";
            this.M.Name = "M";
            this.M.ToolTipText = "Tasa de servicio";
            // 
            // Lq
            // 
            this.Lq.HeaderText = "Lq";
            this.Lq.Name = "Lq";
            this.Lq.ToolTipText = "Ctd. personas en cola";
            // 
            // Ls
            // 
            this.Ls.HeaderText = "Ls";
            this.Ls.Name = "Ls";
            this.Ls.ToolTipText = "Ctd. personas en sistema";
            // 
            // Wq
            // 
            this.Wq.HeaderText = "Wq (m)";
            this.Wq.Name = "Wq";
            this.Wq.ToolTipText = "Tiempo duración en cola";
            // 
            // Ws
            // 
            this.Ws.HeaderText = "Ws (m)";
            this.Ws.Name = "Ws";
            this.Ws.ToolTipText = "Tiempo duración en sistema";
            // 
            // PP
            // 
            this.PP.HeaderText = "P";
            this.PP.Name = "PP";
            this.PP.ToolTipText = "% saturación del sistema";
            // 
            // PP0
            // 
            this.PP0.HeaderText = "P0";
            this.PP0.Name = "PP0";
            this.PP0.ToolTipText = "% de ocio del sistema";
            // 
            // frmSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 543);
            this.Controls.Add(this.tabsimular);
            this.Name = "frmSimulador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación Digital";
            this.Load += new System.EventHandler(this.frmSimulador_Load);
            this.tabsimular.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvResultados)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudServidores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTanda;
        private System.Windows.Forms.TabControl tabsimular;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DgvEventos;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbidsimulacion;
        private System.Windows.Forms.Label lblidsimulacion;
        private System.Windows.Forms.NumericUpDown NudServidores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn P0;
        private System.Windows.Forms.DataGridViewTextBoxColumn P5;
        private System.Windows.Forms.DataGridViewTextBoxColumn P10;
        private System.Windows.Forms.DataGridView DgvResultados;
        private System.Windows.Forms.ListBox LbxEventos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox LbxRecomendaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosibTanda1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosibTanda2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PosibTanda3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atraso;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamda;
        private System.Windows.Forms.DataGridViewTextBoxColumn M;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wq;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ws;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP0;
    }
}