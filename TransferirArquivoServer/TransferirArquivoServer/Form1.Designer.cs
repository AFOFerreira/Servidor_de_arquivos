namespace TransferirArquivoServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEstabelecerConexao = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPasta = new System.Windows.Forms.LinkLabel();
            this.btnPararServidor = new System.Windows.Forms.Button();
            this.listaLogs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 75);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servidor para Compartilhar Arquivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEstabelecerConexao
            // 
            this.btnEstabelecerConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstabelecerConexao.Location = new System.Drawing.Point(24, 150);
            this.btnEstabelecerConexao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
            this.btnEstabelecerConexao.Size = new System.Drawing.Size(349, 54);
            this.btnEstabelecerConexao.TabIndex = 9;
            this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
            this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
            this.btnEstabelecerConexao.Click += new System.EventHandler(this.btnEstabelecerConexao_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(381, 107);
            this.txtPorta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(93, 34);
            this.txtPorta.TabIndex = 8;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoIP.Location = new System.Drawing.Point(24, 107);
            this.txtEnderecoIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(348, 34);
            this.txtEnderecoIP.TabIndex = 7;
            this.txtEnderecoIP.Text = "127.0.0.1";
            // 
            // txtPasta
            // 
            this.txtPasta.AutoEllipsis = true;
            this.txtPasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasta.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.txtPasta.Location = new System.Drawing.Point(12, 223);
            this.txtPasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(729, 36);
            this.txtPasta.TabIndex = 12;
            this.txtPasta.TabStop = true;
            this.txtPasta.Text = "Clique para selecionar a pasta...";
            this.txtPasta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtPasta_LinkClicked);
            // 
            // btnPararServidor
            // 
            this.btnPararServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararServidor.Location = new System.Drawing.Point(381, 150);
            this.btnPararServidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPararServidor.Name = "btnPararServidor";
            this.btnPararServidor.Size = new System.Drawing.Size(349, 54);
            this.btnPararServidor.TabIndex = 13;
            this.btnPararServidor.Text = "Parar Servidor";
            this.btnPararServidor.UseVisualStyleBackColor = true;
            this.btnPararServidor.Click += new System.EventHandler(this.btnPararServidor_Click);
            // 
            // listaLogs
            // 
            this.listaLogs.BackColor = System.Drawing.SystemColors.Info;
            this.listaLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLogs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listaLogs.FormattingEnabled = true;
            this.listaLogs.ItemHeight = 25;
            this.listaLogs.Location = new System.Drawing.Point(13, 289);
            this.listaLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaLogs.Name = "listaLogs";
            this.listaLogs.Size = new System.Drawing.Size(724, 179);
            this.listaLogs.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 481);
            this.Controls.Add(this.listaLogs);
            this.Controls.Add(this.btnPararServidor);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEstabelecerConexao);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtEnderecoIP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstabelecerConexao;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.LinkLabel txtPasta;
        private System.Windows.Forms.Button btnPararServidor;
        private System.Windows.Forms.ListBox listaLogs;
    }
}

