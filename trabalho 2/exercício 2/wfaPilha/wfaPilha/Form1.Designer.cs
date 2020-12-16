namespace wfaPilha
{
    partial class formPilha
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
            this.lbPilha = new System.Windows.Forms.Label();
            this.btPush = new System.Windows.Forms.Button();
            this.tbPilha = new System.Windows.Forms.TextBox();
            this.tbPush = new System.Windows.Forms.TextBox();
            this.tbPilha2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPilha3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPilha4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPop = new System.Windows.Forms.TextBox();
            this.btPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPilha
            // 
            this.lbPilha.AutoSize = true;
            this.lbPilha.Location = new System.Drawing.Point(12, 17);
            this.lbPilha.Name = "lbPilha";
            this.lbPilha.Size = new System.Drawing.Size(39, 13);
            this.lbPilha.TabIndex = 0;
            this.lbPilha.Text = "Pilha 1";
            this.lbPilha.Click += new System.EventHandler(this.lbPilha_Click);
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(555, 42);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(75, 23);
            this.btPush.TabIndex = 1;
            this.btPush.Text = "Push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // tbPilha
            // 
            this.tbPilha.Location = new System.Drawing.Point(57, 14);
            this.tbPilha.Multiline = true;
            this.tbPilha.Name = "tbPilha";
            this.tbPilha.ReadOnly = true;
            this.tbPilha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPilha.Size = new System.Drawing.Size(73, 158);
            this.tbPilha.TabIndex = 7;
            this.tbPilha.TextChanged += new System.EventHandler(this.tbPilha_TextChanged);
            // 
            // tbPush
            // 
            this.tbPush.Location = new System.Drawing.Point(636, 45);
            this.tbPush.Name = "tbPush";
            this.tbPush.Size = new System.Drawing.Size(43, 20);
            this.tbPush.TabIndex = 8;
            // 
            // tbPilha2
            // 
            this.tbPilha2.Location = new System.Drawing.Point(184, 12);
            this.tbPilha2.Multiline = true;
            this.tbPilha2.Name = "tbPilha2";
            this.tbPilha2.ReadOnly = true;
            this.tbPilha2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPilha2.Size = new System.Drawing.Size(73, 158);
            this.tbPilha2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pilha 2";
            // 
            // tbPilha3
            // 
            this.tbPilha3.Location = new System.Drawing.Point(321, 12);
            this.tbPilha3.Multiline = true;
            this.tbPilha3.Name = "tbPilha3";
            this.tbPilha3.ReadOnly = true;
            this.tbPilha3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPilha3.Size = new System.Drawing.Size(73, 158);
            this.tbPilha3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pilha 3";
            // 
            // tbPilha4
            // 
            this.tbPilha4.Location = new System.Drawing.Point(459, 9);
            this.tbPilha4.Multiline = true;
            this.tbPilha4.Name = "tbPilha4";
            this.tbPilha4.ReadOnly = true;
            this.tbPilha4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPilha4.Size = new System.Drawing.Size(73, 161);
            this.tbPilha4.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pilha 4";
            // 
            // tbPop
            // 
            this.tbPop.Location = new System.Drawing.Point(636, 102);
            this.tbPop.Name = "tbPop";
            this.tbPop.Size = new System.Drawing.Size(43, 20);
            this.tbPop.TabIndex = 17;
            this.tbPop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(555, 99);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(75, 23);
            this.btPop.TabIndex = 18;
            this.btPop.Text = "Pop";
            this.btPop.UseVisualStyleBackColor = true;
            this.btPop.Click += new System.EventHandler(this.btPop_Click);
            // 
            // formPilha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 196);
            this.Controls.Add(this.btPop);
            this.Controls.Add(this.tbPop);
            this.Controls.Add(this.tbPilha4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPilha3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPilha2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPush);
            this.Controls.Add(this.tbPilha);
            this.Controls.Add(this.btPush);
            this.Controls.Add(this.lbPilha);
            this.Name = "formPilha";
            this.Text = "Pilha de Inteiros";
            this.Load += new System.EventHandler(this.formPilha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPilha;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.TextBox tbPilha;
        private System.Windows.Forms.TextBox tbPush;
        private System.Windows.Forms.TextBox tbPilha2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPilha3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPilha4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPop;
        private System.Windows.Forms.Button btPop;
    }
}

