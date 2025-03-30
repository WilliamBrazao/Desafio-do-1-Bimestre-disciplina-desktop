namespace TP_Final_Desafio
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lbNome = new System.Windows.Forms.Label();
            this.lblPrioridade = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataVencimento = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.cbxPrioridade = new System.Windows.Forms.ComboBox();
            this.rbPendente = new System.Windows.Forms.RadioButton();
            this.rbComcluido = new System.Windows.Forms.RadioButton();
            this.chartValores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(22, 51);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(115, 19);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome da tarefa";
            // 
            // lblPrioridade
            // 
            this.lblPrioridade.AutoSize = true;
            this.lblPrioridade.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioridade.Location = new System.Drawing.Point(22, 110);
            this.lblPrioridade.Name = "lblPrioridade";
            this.lblPrioridade.Size = new System.Drawing.Size(81, 19);
            this.lblPrioridade.TabIndex = 1;
            this.lblPrioridade.Text = "Prioridade";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataVencimento
            // 
            this.lblDataVencimento.AutoSize = true;
            this.lblDataVencimento.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVencimento.Location = new System.Drawing.Point(22, 82);
            this.lblDataVencimento.Name = "lblDataVencimento";
            this.lblDataVencimento.Size = new System.Drawing.Size(144, 19);
            this.lblDataVencimento.TabIndex = 2;
            this.lblDataVencimento.Text = "Data do vencimento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(23, 187);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 36);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGerar.Location = new System.Drawing.Point(110, 187);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(84, 36);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(174, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 7;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column1});
            this.dgvMostrar.Location = new System.Drawing.Point(23, 271);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(684, 201);
            this.dgvMostrar.TabIndex = 11;
            // 
            // cbxPrioridade
            // 
            this.cbxPrioridade.FormattingEnabled = true;
            this.cbxPrioridade.Location = new System.Drawing.Point(173, 111);
            this.cbxPrioridade.Name = "cbxPrioridade";
            this.cbxPrioridade.Size = new System.Drawing.Size(102, 21);
            this.cbxPrioridade.TabIndex = 12;
            this.cbxPrioridade.Text = "Escolher";
            // 
            // rbPendente
            // 
            this.rbPendente.AutoSize = true;
            this.rbPendente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbPendente.Location = new System.Drawing.Point(88, 145);
            this.rbPendente.Name = "rbPendente";
            this.rbPendente.Size = new System.Drawing.Size(90, 23);
            this.rbPendente.TabIndex = 14;
            this.rbPendente.TabStop = true;
            this.rbPendente.Text = "Pendente";
            this.rbPendente.UseVisualStyleBackColor = true;
            // 
            // rbComcluido
            // 
            this.rbComcluido.AutoSize = true;
            this.rbComcluido.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbComcluido.Location = new System.Drawing.Point(182, 145);
            this.rbComcluido.Name = "rbComcluido";
            this.rbComcluido.Size = new System.Drawing.Size(93, 23);
            this.rbComcluido.TabIndex = 15;
            this.rbComcluido.TabStop = true;
            this.rbComcluido.Text = "Concluída";
            this.rbComcluido.UseVisualStyleBackColor = true;
            // 
            // chartValores
            // 
            chartArea2.Name = "ChartArea1";
            this.chartValores.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartValores.Legends.Add(legend2);
            this.chartValores.Location = new System.Drawing.Point(289, 50);
            this.chartValores.Name = "chartValores";
            this.chartValores.Size = new System.Drawing.Size(418, 204);
            this.chartValores.TabIndex = 17;
            this.chartValores.Text = "chart1";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(173, 82);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(102, 20);
            this.txtData.TabIndex = 18;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(196, 187);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 36);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome da tarefa";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Data do vencimento";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prioridade";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Organizador de Tarefas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(149)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(731, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.chartValores);
            this.Controls.Add(this.rbComcluido);
            this.Controls.Add(this.rbPendente);
            this.Controls.Add(this.cbxPrioridade);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDataVencimento);
            this.Controls.Add(this.lblPrioridade);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lblPrioridade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataVencimento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.ComboBox cbxPrioridade;
        private System.Windows.Forms.RadioButton rbPendente;
        private System.Windows.Forms.RadioButton rbComcluido;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValores;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
    }
}

