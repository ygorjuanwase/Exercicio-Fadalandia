namespace ExemploBancoDados02
{
    partial class Lista_Usuaroi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbContabancaria = new System.Windows.Forms.RadioButton();
            this.rbRaca = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbASc = new System.Windows.Forms.RadioButton();
            this.rbDESC = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Raca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1ContaBancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1nome,
            this.Column1Raca,
            this.Column1ContaBancaria,
            this.Column1Conta});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(755, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-2, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(157, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(316, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Apagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(480, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Atualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(654, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "Estatisticas";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(346, 37);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "coluna";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rbNome);
            this.groupBox1.Controls.Add(this.rbContabancaria);
            this.groupBox1.Controls.Add(this.rbRaca);
            this.groupBox1.Location = new System.Drawing.Point(421, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 46);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.Location = new System.Drawing.Point(6, 19);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(55, 18);
            this.rbNome.TabIndex = 12;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // rbContabancaria
            // 
            this.rbContabancaria.AutoSize = true;
            this.rbContabancaria.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContabancaria.Location = new System.Drawing.Point(122, 19);
            this.rbContabancaria.Name = "rbContabancaria";
            this.rbContabancaria.Size = new System.Drawing.Size(40, 18);
            this.rbContabancaria.TabIndex = 14;
            this.rbContabancaria.TabStop = true;
            this.rbContabancaria.Text = "CB";
            this.rbContabancaria.UseVisualStyleBackColor = true;
            // 
            // rbRaca
            // 
            this.rbRaca.AutoSize = true;
            this.rbRaca.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRaca.Location = new System.Drawing.Point(65, 19);
            this.rbRaca.Name = "rbRaca";
            this.rbRaca.Size = new System.Drawing.Size(51, 18);
            this.rbRaca.TabIndex = 13;
            this.rbRaca.TabStop = true;
            this.rbRaca.Text = "Raça";
            this.rbRaca.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbASc);
            this.groupBox2.Controls.Add(this.rbDESC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(605, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 46);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // rbASc
            // 
            this.rbASc.AutoSize = true;
            this.rbASc.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbASc.Location = new System.Drawing.Point(9, 23);
            this.rbASc.Name = "rbASc";
            this.rbASc.Size = new System.Drawing.Size(47, 18);
            this.rbASc.TabIndex = 15;
            this.rbASc.TabStop = true;
            this.rbASc.Text = "ASC";
            this.rbASc.UseVisualStyleBackColor = true;
            // 
            // rbDESC
            // 
            this.rbDESC.AutoSize = true;
            this.rbDESC.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDESC.Location = new System.Drawing.Point(83, 23);
            this.rbDESC.Name = "rbDESC";
            this.rbDESC.Size = new System.Drawing.Size(56, 18);
            this.rbDESC.TabIndex = 16;
            this.rbDESC.TabStop = true;
            this.rbDESC.Text = "DESC";
            this.rbDESC.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ordem";
            // 
            // Column1nome
            // 
            this.Column1nome.HeaderText = "id";
            this.Column1nome.Name = "Column1nome";
            this.Column1nome.ReadOnly = true;
            // 
            // Column1Raca
            // 
            this.Column1Raca.HeaderText = "Nome Heroi";
            this.Column1Raca.Name = "Column1Raca";
            this.Column1Raca.ReadOnly = true;
            // 
            // Column1ContaBancaria
            // 
            this.Column1ContaBancaria.HeaderText = "Raça Heroi";
            this.Column1ContaBancaria.Name = "Column1ContaBancaria";
            this.Column1ContaBancaria.ReadOnly = true;
            // 
            // Column1Conta
            // 
            this.Column1Conta.HeaderText = "Conta Bancaria";
            this.Column1Conta.Name = "Column1Conta";
            this.Column1Conta.ReadOnly = true;
            // 
            // Lista_Usuaroi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lista_Usuaroi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Herois";
            this.Load += new System.EventHandler(this.Lista_Usuaroi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbContabancaria;
        private System.Windows.Forms.RadioButton rbRaca;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbASc;
        private System.Windows.Forms.RadioButton rbDESC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Raca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1ContaBancaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Conta;
    }
}