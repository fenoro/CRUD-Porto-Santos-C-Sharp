namespace crud_porto
{
    partial class Form2
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
            this.tbConteiner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMovimentacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mtbDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbHoraInicial = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbHoraFinal = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbConteiner
            // 
            this.tbConteiner.Location = new System.Drawing.Point(119, 12);
            this.tbConteiner.Name = "tbConteiner";
            this.tbConteiner.Size = new System.Drawing.Size(167, 23);
            this.tbConteiner.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº Conteiner";
            // 
            // cbMovimentacao
            // 
            this.cbMovimentacao.FormattingEnabled = true;
            this.cbMovimentacao.Items.AddRange(new object[] {
            "Embarque",
            "Descarga",
            "Gate In",
            "Gate Out",
            "Reposicionamento",
            "Pesagem",
            "Scanner"});
            this.cbMovimentacao.Location = new System.Drawing.Point(119, 58);
            this.cbMovimentacao.Name = "cbMovimentacao";
            this.cbMovimentacao.Size = new System.Drawing.Size(167, 23);
            this.cbMovimentacao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Movimentação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Data Inicial";
            // 
            // mtbDataInicial
            // 
            this.mtbDataInicial.Location = new System.Drawing.Point(104, 106);
            this.mtbDataInicial.Mask = "##/##/####";
            this.mtbDataInicial.Name = "mtbDataInicial";
            this.mtbDataInicial.Size = new System.Drawing.Size(100, 23);
            this.mtbDataInicial.TabIndex = 9;
            // 
            // mtbDataFinal
            // 
            this.mtbDataFinal.Location = new System.Drawing.Point(313, 106);
            this.mtbDataFinal.Mask = "##/##/####";
            this.mtbDataFinal.Name = "mtbDataFinal";
            this.mtbDataFinal.Size = new System.Drawing.Size(100, 23);
            this.mtbDataFinal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Final";
            // 
            // mtbHoraInicial
            // 
            this.mtbHoraInicial.Location = new System.Drawing.Point(104, 152);
            this.mtbHoraInicial.Mask = "##:##";
            this.mtbHoraInicial.Name = "mtbHoraInicial";
            this.mtbHoraInicial.Size = new System.Drawing.Size(100, 23);
            this.mtbHoraInicial.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Horário Inicial";
            // 
            // mtbHoraFinal
            // 
            this.mtbHoraFinal.Location = new System.Drawing.Point(313, 152);
            this.mtbHoraFinal.Mask = "##:##";
            this.mtbHoraFinal.Name = "mtbHoraFinal";
            this.mtbHoraFinal.Size = new System.Drawing.Size(100, 23);
            this.mtbHoraFinal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Horário Final";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(303, 208);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(166, 249);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 19;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(211, 208);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(119, 208);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 17;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(22, 208);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 289);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtbHoraFinal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbHoraInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbDataFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbDataInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMovimentacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConteiner);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbConteiner;
        private Label label1;
        private ComboBox cbMovimentacao;
        private Label label3;
        private Label label2;
        private MaskedTextBox mtbDataInicial;
        private MaskedTextBox mtbDataFinal;
        private Label label4;
        private MaskedTextBox mtbHoraInicial;
        private Label label5;
        private MaskedTextBox mtbHoraFinal;
        private Label label6;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnLer;
        private Button btnSalvar;
    }
}