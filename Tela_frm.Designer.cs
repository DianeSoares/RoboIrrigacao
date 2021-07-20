
namespace TesteBackend
{
    partial class Tela_frm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_frm));
            this.lblTamanhoHorta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudXTamanho = new System.Windows.Forms.NumericUpDown();
            this.nudYTamanho = new System.Windows.Forms.NumericUpDown();
            this.lblXTamanho = new System.Windows.Forms.Label();
            this.lblYTamanho = new System.Windows.Forms.Label();
            this.lblYPosicao = new System.Windows.Forms.Label();
            this.lblXPosicao = new System.Windows.Forms.Label();
            this.nudYPosicao = new System.Windows.Forms.NumericUpDown();
            this.nudXPosicao = new System.Windows.Forms.NumericUpDown();
            this.lblYIrrigar = new System.Windows.Forms.Label();
            this.lblXIrrigar = new System.Windows.Forms.Label();
            this.nudYIrrigar = new System.Windows.Forms.NumericUpDown();
            this.nudXIrrigar = new System.Windows.Forms.NumericUpDown();
            this.btnAddPosicao = new System.Windows.Forms.Button();
            this.btnIrrigar = new System.Windows.Forms.Button();
            this.dgvPosicoes = new System.Windows.Forms.DataGridView();
            this.xPosicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yPosicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbOrientacao = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultIrrigacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudXTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPosicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPosicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYIrrigar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXIrrigar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTamanhoHorta
            // 
            this.lblTamanhoHorta.AutoSize = true;
            this.lblTamanhoHorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamanhoHorta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTamanhoHorta.Location = new System.Drawing.Point(12, 169);
            this.lblTamanhoHorta.Name = "lblTamanhoHorta";
            this.lblTamanhoHorta.Size = new System.Drawing.Size(148, 20);
            this.lblTamanhoHorta.TabIndex = 0;
            this.lblTamanhoHorta.Text = "Tamanho da Horta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(527, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Posição Inicial do Robô";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(611, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orientação Inicial do Robô";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(12, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Posições da horta para Irrigar";
            // 
            // nudXTamanho
            // 
            this.nudXTamanho.Location = new System.Drawing.Point(88, 204);
            this.nudXTamanho.Name = "nudXTamanho";
            this.nudXTamanho.Size = new System.Drawing.Size(120, 22);
            this.nudXTamanho.TabIndex = 5;
            // 
            // nudYTamanho
            // 
            this.nudYTamanho.Location = new System.Drawing.Point(286, 204);
            this.nudYTamanho.Name = "nudYTamanho";
            this.nudYTamanho.Size = new System.Drawing.Size(120, 22);
            this.nudYTamanho.TabIndex = 6;
            // 
            // lblXTamanho
            // 
            this.lblXTamanho.AutoSize = true;
            this.lblXTamanho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblXTamanho.Location = new System.Drawing.Point(31, 206);
            this.lblXTamanho.Name = "lblXTamanho";
            this.lblXTamanho.Size = new System.Drawing.Size(51, 17);
            this.lblXTamanho.TabIndex = 7;
            this.lblXTamanho.Text = "Eixo X:";
            // 
            // lblYTamanho
            // 
            this.lblYTamanho.AutoSize = true;
            this.lblYTamanho.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblYTamanho.Location = new System.Drawing.Point(229, 206);
            this.lblYTamanho.Name = "lblYTamanho";
            this.lblYTamanho.Size = new System.Drawing.Size(51, 17);
            this.lblYTamanho.TabIndex = 8;
            this.lblYTamanho.Text = "Eixo Y:";
            // 
            // lblYPosicao
            // 
            this.lblYPosicao.AutoSize = true;
            this.lblYPosicao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblYPosicao.Location = new System.Drawing.Point(729, 204);
            this.lblYPosicao.Name = "lblYPosicao";
            this.lblYPosicao.Size = new System.Drawing.Size(51, 17);
            this.lblYPosicao.TabIndex = 12;
            this.lblYPosicao.Text = "Eixo Y:";
            // 
            // lblXPosicao
            // 
            this.lblXPosicao.AutoSize = true;
            this.lblXPosicao.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblXPosicao.Location = new System.Drawing.Point(531, 204);
            this.lblXPosicao.Name = "lblXPosicao";
            this.lblXPosicao.Size = new System.Drawing.Size(51, 17);
            this.lblXPosicao.TabIndex = 11;
            this.lblXPosicao.Text = "Eixo X:";
            // 
            // nudYPosicao
            // 
            this.nudYPosicao.Location = new System.Drawing.Point(786, 202);
            this.nudYPosicao.Name = "nudYPosicao";
            this.nudYPosicao.Size = new System.Drawing.Size(120, 22);
            this.nudYPosicao.TabIndex = 10;
            // 
            // nudXPosicao
            // 
            this.nudXPosicao.Location = new System.Drawing.Point(588, 202);
            this.nudXPosicao.Name = "nudXPosicao";
            this.nudXPosicao.Size = new System.Drawing.Size(120, 22);
            this.nudXPosicao.TabIndex = 9;
            // 
            // lblYIrrigar
            // 
            this.lblYIrrigar.AutoSize = true;
            this.lblYIrrigar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblYIrrigar.Location = new System.Drawing.Point(234, 284);
            this.lblYIrrigar.Name = "lblYIrrigar";
            this.lblYIrrigar.Size = new System.Drawing.Size(51, 17);
            this.lblYIrrigar.TabIndex = 18;
            this.lblYIrrigar.Text = "Eixo Y:";
            // 
            // lblXIrrigar
            // 
            this.lblXIrrigar.AutoSize = true;
            this.lblXIrrigar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblXIrrigar.Location = new System.Drawing.Point(36, 284);
            this.lblXIrrigar.Name = "lblXIrrigar";
            this.lblXIrrigar.Size = new System.Drawing.Size(51, 17);
            this.lblXIrrigar.TabIndex = 17;
            this.lblXIrrigar.Text = "Eixo X:";
            // 
            // nudYIrrigar
            // 
            this.nudYIrrigar.Location = new System.Drawing.Point(291, 282);
            this.nudYIrrigar.Name = "nudYIrrigar";
            this.nudYIrrigar.Size = new System.Drawing.Size(120, 22);
            this.nudYIrrigar.TabIndex = 16;
            // 
            // nudXIrrigar
            // 
            this.nudXIrrigar.Location = new System.Drawing.Point(93, 282);
            this.nudXIrrigar.Name = "nudXIrrigar";
            this.nudXIrrigar.Size = new System.Drawing.Size(120, 22);
            this.nudXIrrigar.TabIndex = 15;
            // 
            // btnAddPosicao
            // 
            this.btnAddPosicao.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddPosicao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPosicao.Location = new System.Drawing.Point(450, 278);
            this.btnAddPosicao.Name = "btnAddPosicao";
            this.btnAddPosicao.Size = new System.Drawing.Size(137, 29);
            this.btnAddPosicao.TabIndex = 19;
            this.btnAddPosicao.Text = "Adicionar Posição";
            this.btnAddPosicao.UseVisualStyleBackColor = false;
            this.btnAddPosicao.Click += new System.EventHandler(this.btnAddPosicao_Click);
            // 
            // btnIrrigar
            // 
            this.btnIrrigar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIrrigar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIrrigar.Location = new System.Drawing.Point(264, 455);
            this.btnIrrigar.Name = "btnIrrigar";
            this.btnIrrigar.Size = new System.Drawing.Size(447, 52);
            this.btnIrrigar.TabIndex = 21;
            this.btnIrrigar.Text = "Iniciar Irrigação";
            this.btnIrrigar.UseVisualStyleBackColor = false;
            this.btnIrrigar.Click += new System.EventHandler(this.btnIrrigar_Click);
            // 
            // dgvPosicoes
            // 
            this.dgvPosicoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPosicoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPosicoes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPosicoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosicoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xPosicao,
            this.yPosicao});
            this.dgvPosicoes.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPosicoes.Location = new System.Drawing.Point(39, 333);
            this.dgvPosicoes.Name = "dgvPosicoes";
            this.dgvPosicoes.RowHeadersVisible = false;
            this.dgvPosicoes.RowHeadersWidth = 51;
            this.dgvPosicoes.RowTemplate.Height = 24;
            this.dgvPosicoes.Size = new System.Drawing.Size(327, 98);
            this.dgvPosicoes.TabIndex = 22;
            // 
            // xPosicao
            // 
            this.xPosicao.HeaderText = "X";
            this.xPosicao.MinimumWidth = 6;
            this.xPosicao.Name = "xPosicao";
            // 
            // yPosicao
            // 
            this.yPosicao.HeaderText = "Y";
            this.yPosicao.MinimumWidth = 6;
            this.yPosicao.Name = "yPosicao";
            // 
            // cmbOrientacao
            // 
            this.cmbOrientacao.FormattingEnabled = true;
            this.cmbOrientacao.Items.AddRange(new object[] {
            "Norte",
            "Sul",
            "Leste",
            "Oeste"});
            this.cmbOrientacao.Location = new System.Drawing.Point(643, 281);
            this.cmbOrientacao.Name = "cmbOrientacao";
            this.cmbOrientacao.Size = new System.Drawing.Size(174, 24);
            this.cmbOrientacao.TabIndex = 23;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblResultado.Location = new System.Drawing.Point(11, 557);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(122, 29);
            this.lblResultado.TabIndex = 24;
            this.lblResultado.Text = "Resultado";
            // 
            // lblResultIrrigacao
            // 
            this.lblResultIrrigacao.AutoSize = true;
            this.lblResultIrrigacao.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblResultIrrigacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultIrrigacao.Location = new System.Drawing.Point(18, 597);
            this.lblResultIrrigacao.Name = "lblResultIrrigacao";
            this.lblResultIrrigacao.Size = new System.Drawing.Size(0, 25);
            this.lblResultIrrigacao.TabIndex = 25;
            this.lblResultIrrigacao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(602, 154);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Tela_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1114, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultIrrigacao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOrientacao);
            this.Controls.Add(this.dgvPosicoes);
            this.Controls.Add(this.btnIrrigar);
            this.Controls.Add(this.btnAddPosicao);
            this.Controls.Add(this.lblYIrrigar);
            this.Controls.Add(this.lblXIrrigar);
            this.Controls.Add(this.nudYIrrigar);
            this.Controls.Add(this.nudXIrrigar);
            this.Controls.Add(this.lblYPosicao);
            this.Controls.Add(this.lblXPosicao);
            this.Controls.Add(this.nudYPosicao);
            this.Controls.Add(this.nudXPosicao);
            this.Controls.Add(this.lblYTamanho);
            this.Controls.Add(this.lblXTamanho);
            this.Controls.Add(this.nudYTamanho);
            this.Controls.Add(this.nudXTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTamanhoHorta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tela_frm";
            this.Text = "Robô Irrigação";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tela_frm_Close);
            ((System.ComponentModel.ISupportInitialize)(this.nudXTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYPosicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXPosicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYIrrigar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudXIrrigar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTamanhoHorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudXTamanho;
        private System.Windows.Forms.NumericUpDown nudYTamanho;
        private System.Windows.Forms.Label lblXTamanho;
        private System.Windows.Forms.Label lblYTamanho;
        private System.Windows.Forms.Label lblYPosicao;
        private System.Windows.Forms.Label lblXPosicao;
        private System.Windows.Forms.NumericUpDown nudYPosicao;
        private System.Windows.Forms.NumericUpDown nudXPosicao;
        private System.Windows.Forms.Label lblYIrrigar;
        private System.Windows.Forms.Label lblXIrrigar;
        private System.Windows.Forms.NumericUpDown nudYIrrigar;
        private System.Windows.Forms.NumericUpDown nudXIrrigar;
        private System.Windows.Forms.Button btnAddPosicao;
        private System.Windows.Forms.Button btnIrrigar;
        private System.Windows.Forms.DataGridView dgvPosicoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn xPosicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn yPosicao;
        private System.Windows.Forms.ComboBox cmbOrientacao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultIrrigacao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

