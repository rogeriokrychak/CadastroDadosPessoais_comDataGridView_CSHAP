
namespace CadastroDadosPessoais_comDataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.campoNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.campoSobrenome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campoEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoCidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoCep = new System.Windows.Forms.TextBox();
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.campoData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFeminino = new System.Windows.Forms.RadioButton();
            this.radioOutros = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.campoTelefone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.campoEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GridNome = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridNome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE DADOS PESSOAIS COM DATAGRIDVIEW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME";
            // 
            // campoNome
            // 
            this.campoNome.Location = new System.Drawing.Point(13, 74);
            this.campoNome.Name = "campoNome";
            this.campoNome.Size = new System.Drawing.Size(368, 27);
            this.campoNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SOBRENOME";
            // 
            // campoSobrenome
            // 
            this.campoSobrenome.Location = new System.Drawing.Point(403, 74);
            this.campoSobrenome.Name = "campoSobrenome";
            this.campoSobrenome.Size = new System.Drawing.Size(368, 27);
            this.campoSobrenome.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ENDEREÇO";
            // 
            // campoEndereco
            // 
            this.campoEndereco.Location = new System.Drawing.Point(13, 140);
            this.campoEndereco.Name = "campoEndereco";
            this.campoEndereco.Size = new System.Drawing.Size(368, 27);
            this.campoEndereco.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "CIDADE";
            // 
            // campoCidade
            // 
            this.campoCidade.Location = new System.Drawing.Point(403, 140);
            this.campoCidade.Name = "campoCidade";
            this.campoCidade.Size = new System.Drawing.Size(368, 27);
            this.campoCidade.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "CEP";
            // 
            // campoCep
            // 
            this.campoCep.Location = new System.Drawing.Point(12, 208);
            this.campoCep.Name = "campoCep";
            this.campoCep.Size = new System.Drawing.Size(217, 27);
            this.campoCep.TabIndex = 10;
            // 
            // comboEstados
            // 
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Items.AddRange(new object[] {
            "PR",
            "SC",
            "RG",
            "SP",
            "RJ",
            "MG",
            "GO",
            "MT",
            "MS"});
            this.comboEstados.Location = new System.Drawing.Point(294, 208);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(151, 28);
            this.comboEstados.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "UF";
            // 
            // campoData
            // 
            this.campoData.Location = new System.Drawing.Point(485, 209);
            this.campoData.Name = "campoData";
            this.campoData.Size = new System.Drawing.Size(286, 27);
            this.campoData.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(485, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "DATA DE NASCIMENTO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "ORIENTAÇÃO SEXUAL";
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(13, 283);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(113, 24);
            this.radioMasculino.TabIndex = 16;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "MASCULINO";
            this.radioMasculino.UseVisualStyleBackColor = true;
            this.radioMasculino.CheckedChanged += new System.EventHandler(this.radioMasculino_CheckedChanged);
            // 
            // radioFeminino
            // 
            this.radioFeminino.AutoSize = true;
            this.radioFeminino.Location = new System.Drawing.Point(130, 283);
            this.radioFeminino.Name = "radioFeminino";
            this.radioFeminino.Size = new System.Drawing.Size(99, 24);
            this.radioFeminino.TabIndex = 17;
            this.radioFeminino.TabStop = true;
            this.radioFeminino.Text = "FEMININO";
            this.radioFeminino.UseVisualStyleBackColor = true;
            this.radioFeminino.CheckedChanged += new System.EventHandler(this.radioFeminino_CheckedChanged);
            // 
            // radioOutros
            // 
            this.radioOutros.AutoSize = true;
            this.radioOutros.Location = new System.Drawing.Point(235, 283);
            this.radioOutros.Name = "radioOutros";
            this.radioOutros.Size = new System.Drawing.Size(87, 24);
            this.radioOutros.TabIndex = 18;
            this.radioOutros.TabStop = true;
            this.radioOutros.Text = "OUTROS";
            this.radioOutros.UseVisualStyleBackColor = true;
            this.radioOutros.CheckedChanged += new System.EventHandler(this.radioOutros_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "TELEFONE";
            // 
            // campoTelefone
            // 
            this.campoTelefone.Location = new System.Drawing.Point(328, 280);
            this.campoTelefone.Name = "campoTelefone";
            this.campoTelefone.Size = new System.Drawing.Size(217, 27);
            this.campoTelefone.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "EMAIL";
            // 
            // campoEmail
            // 
            this.campoEmail.Location = new System.Drawing.Point(555, 280);
            this.campoEmail.Name = "campoEmail";
            this.campoEmail.Size = new System.Drawing.Size(217, 27);
            this.campoEmail.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 60);
            this.button1.TabIndex = 23;
            this.button1.Text = "CADASTRAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridNome
            // 
            this.GridNome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridNome.Location = new System.Drawing.Point(13, 391);
            this.GridNome.Name = "GridNome";
            this.GridNome.RowHeadersWidth = 51;
            this.GridNome.RowTemplate.Height = 29;
            this.GridNome.Size = new System.Drawing.Size(758, 350);
            this.GridNome.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.GridNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.campoEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.campoTelefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radioOutros);
            this.Controls.Add(this.radioFeminino);
            this.Controls.Add(this.radioMasculino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.campoData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboEstados);
            this.Controls.Add(this.campoCep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.campoCidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.campoEndereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.campoSobrenome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.campoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CADASTRO DE DADOS PESSOAIS COM DATAGRIDVIEW";
            ((System.ComponentModel.ISupportInitialize)(this.GridNome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoSobrenome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoCidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoCep;
        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker campoData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFeminino;
        private System.Windows.Forms.RadioButton radioOutros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox campoTelefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox campoEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GridNome;
    }
}

