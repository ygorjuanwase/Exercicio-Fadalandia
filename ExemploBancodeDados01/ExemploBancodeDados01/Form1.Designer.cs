namespace ExemploBancodeDados01
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
            this.lbnome = new System.Windows.Forms.Label();
            this.txtcor = new System.Windows.Forms.TextBox();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbcores = new System.Windows.Forms.Label();
            this.btnatualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbApagar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnovoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.ForeColor = System.Drawing.Color.Blue;
            this.lbnome.Location = new System.Drawing.Point(12, 28);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(64, 33);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "nome";
            // 
            // txtcor
            // 
            this.txtcor.Location = new System.Drawing.Point(73, 39);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(412, 20);
            this.txtcor.TabIndex = 1;
            // 
            // btnCadastar
            // 
            this.btnCadastar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadastar.Location = new System.Drawing.Point(491, 28);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(151, 33);
            this.btnCadastar.TabIndex = 2;
            this.btnCadastar.Text = "Cadastrar";
            this.btnCadastar.UseVisualStyleBackColor = true;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 125);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 317);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // lbcores
            // 
            this.lbcores.AutoSize = true;
            this.lbcores.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcores.ForeColor = System.Drawing.Color.Blue;
            this.lbcores.Location = new System.Drawing.Point(12, 89);
            this.lbcores.Name = "lbcores";
            this.lbcores.Size = new System.Drawing.Size(66, 33);
            this.lbcores.TabIndex = 4;
            this.lbcores.Text = "Cores";
            // 
            // btnatualizar
            // 
            this.btnatualizar.Location = new System.Drawing.Point(366, 125);
            this.btnatualizar.Name = "btnatualizar";
            this.btnatualizar.Size = new System.Drawing.Size(96, 33);
            this.btnatualizar.TabIndex = 5;
            this.btnatualizar.Text = "Atualizar";
            this.btnatualizar.UseVisualStyleBackColor = true;
            this.btnatualizar.Click += new System.EventHandler(this.btnatualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apagar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbApagar
            // 
            this.cbApagar.FormattingEnabled = true;
            this.cbApagar.Location = new System.Drawing.Point(360, 197);
            this.cbApagar.Name = "cbApagar";
            this.cbApagar.Size = new System.Drawing.Size(262, 21);
            this.cbApagar.TabIndex = 7;
            this.cbApagar.DropDown += new System.EventHandler(this.cbApagar_DropDown);
            this.cbApagar.SelectedIndexChanged += new System.EventHandler(this.cbApagar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(360, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cor";
            // 
            // txtnovoNome
            // 
            this.txtnovoNome.Location = new System.Drawing.Point(360, 266);
            this.txtnovoNome.Name = "txtnovoNome";
            this.txtnovoNome.Size = new System.Drawing.Size(149, 20);
            this.txtnovoNome.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(360, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Novo nome";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(521, 262);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 27);
            this.btnAlterar.TabIndex = 12;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 454);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnovoNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbApagar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnatualizar);
            this.Controls.Add(this.lbcores);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnCadastar);
            this.Controls.Add(this.txtcor);
            this.Controls.Add(this.lbnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtcor;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbcores;
        private System.Windows.Forms.Button btnatualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnovoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlterar;
    }
}

