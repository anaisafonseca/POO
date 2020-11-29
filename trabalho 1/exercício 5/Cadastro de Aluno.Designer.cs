namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Aluno = new System.Windows.Forms.TabPage();
            this.Campo_Nome = new System.Windows.Forms.TextBox();
            this.Campo_Matricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.Matéria = new System.Windows.Forms.TabPage();
            this.listaaluno = new System.Windows.Forms.ComboBox();
            this.botaomatricula = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listamateria = new System.Windows.Forms.CheckedListBox();
            this.Relatório = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.materiarelatorio = new System.Windows.Forms.TextBox();
            this.listarelatorio = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.botaoaluno = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Aluno.SuspendLayout();
            this.Matéria.SuspendLayout();
            this.Relatório.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Aluno);
            this.tabControl1.Controls.Add(this.Matéria);
            this.tabControl1.Controls.Add(this.Relatório);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // Aluno
            // 
            this.Aluno.Controls.Add(this.Campo_Nome);
            this.Aluno.Controls.Add(this.botaoaluno);
            this.Aluno.Controls.Add(this.Campo_Matricula);
            this.Aluno.Controls.Add(this.label2);
            this.Aluno.Controls.Add(this.Nome);
            this.Aluno.Location = new System.Drawing.Point(4, 22);
            this.Aluno.Name = "Aluno";
            this.Aluno.Padding = new System.Windows.Forms.Padding(3);
            this.Aluno.Size = new System.Drawing.Size(794, 423);
            this.Aluno.TabIndex = 0;
            this.Aluno.Text = "Aluno";
            this.Aluno.UseVisualStyleBackColor = true;
            this.Aluno.Click += new System.EventHandler(this.Aluno_Click);
            // 
            // Campo_Nome
            // 
            this.Campo_Nome.Location = new System.Drawing.Point(3, 20);
            this.Campo_Nome.Name = "Campo_Nome";
            this.Campo_Nome.Size = new System.Drawing.Size(307, 20);
            this.Campo_Nome.TabIndex = 5;
            this.Campo_Nome.TextChanged += new System.EventHandler(this.Campo_Nome_TextChanged);
            // 
            // Campo_Matricula
            // 
            this.Campo_Matricula.Location = new System.Drawing.Point(0, 77);
            this.Campo_Matricula.Name = "Campo_Matricula";
            this.Campo_Matricula.Size = new System.Drawing.Size(310, 20);
            this.Campo_Matricula.TabIndex = 3;
            this.Campo_Matricula.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de Matrícula";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(0, 3);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome:";
            // 
            // Matéria
            // 
            this.Matéria.Controls.Add(this.listaaluno);
            this.Matéria.Controls.Add(this.botaomatricula);
            this.Matéria.Controls.Add(this.label3);
            this.Matéria.Controls.Add(this.listamateria);
            this.Matéria.Location = new System.Drawing.Point(4, 22);
            this.Matéria.Name = "Matéria";
            this.Matéria.Padding = new System.Windows.Forms.Padding(3);
            this.Matéria.Size = new System.Drawing.Size(794, 423);
            this.Matéria.TabIndex = 1;
            this.Matéria.Text = "Matéria";
            this.Matéria.UseVisualStyleBackColor = true;
            // 
            // listaaluno
            // 
            this.listaaluno.FormattingEnabled = true;
            this.listaaluno.Location = new System.Drawing.Point(0, 3);
            this.listaaluno.Name = "listaaluno";
            this.listaaluno.Size = new System.Drawing.Size(121, 21);
            this.listaaluno.TabIndex = 6;
            this.listaaluno.Text = "Aluno";
            this.listaaluno.SelectedIndexChanged += new System.EventHandler(this.listaaluno_SelectedIndexChanged);
            // 
            // botaomatricula
            // 
            this.botaomatricula.Location = new System.Drawing.Point(134, 199);
            this.botaomatricula.Name = "botaomatricula";
            this.botaomatricula.Size = new System.Drawing.Size(75, 23);
            this.botaomatricula.TabIndex = 5;
            this.botaomatricula.Text = "Cadastrar";
            this.botaomatricula.UseVisualStyleBackColor = true;
            this.botaomatricula.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Matérias";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listamateria
            // 
            this.listamateria.FormattingEnabled = true;
            this.listamateria.Items.AddRange(new object[] {
            "ITC",
            "Matemática",
            "Física",
            "Inglês"});
            this.listamateria.Location = new System.Drawing.Point(165, 34);
            this.listamateria.Name = "listamateria";
            this.listamateria.Size = new System.Drawing.Size(120, 94);
            this.listamateria.TabIndex = 0;
            // 
            // Relatório
            // 
            this.Relatório.Controls.Add(this.label1);
            this.Relatório.Controls.Add(this.materiarelatorio);
            this.Relatório.Controls.Add(this.listarelatorio);
            this.Relatório.Location = new System.Drawing.Point(4, 22);
            this.Relatório.Name = "Relatório";
            this.Relatório.Padding = new System.Windows.Forms.Padding(3);
            this.Relatório.Size = new System.Drawing.Size(794, 423);
            this.Relatório.TabIndex = 2;
            this.Relatório.Text = "Relatório";
            this.Relatório.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Matérias";
            // 
            // materiarelatorio
            // 
            this.materiarelatorio.Location = new System.Drawing.Point(166, 31);
            this.materiarelatorio.Name = "materiarelatorio";
            this.materiarelatorio.Size = new System.Drawing.Size(311, 20);
            this.materiarelatorio.TabIndex = 8;
            // 
            // listarelatorio
            // 
            this.listarelatorio.FormattingEnabled = true;
            this.listarelatorio.Location = new System.Drawing.Point(3, 6);
            this.listarelatorio.Name = "listarelatorio";
            this.listarelatorio.Size = new System.Drawing.Size(121, 21);
            this.listarelatorio.TabIndex = 7;
            this.listarelatorio.Text = "Aluno";
            this.listarelatorio.SelectedIndexChanged += new System.EventHandler(this.listarelatorio_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // botaoaluno
            // 
            this.botaoaluno.Location = new System.Drawing.Point(235, 156);
            this.botaoaluno.Name = "botaoaluno";
            this.botaoaluno.Size = new System.Drawing.Size(75, 23);
            this.botaoaluno.TabIndex = 4;
            this.botaoaluno.Text = "Cadastrar";
            this.botaoaluno.UseVisualStyleBackColor = true;
            this.botaoaluno.Click += new System.EventHandler(this.botaoaluno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 353);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Aluno.ResumeLayout(false);
            this.Aluno.PerformLayout();
            this.Matéria.ResumeLayout(false);
            this.Matéria.PerformLayout();
            this.Relatório.ResumeLayout(false);
            this.Relatório.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Matéria;
        private System.Windows.Forms.TabPage Relatório;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button botaomatricula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox listamateria;
        private System.Windows.Forms.TabPage Aluno;
        private System.Windows.Forms.TextBox Campo_Matricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox Campo_Nome;
        private System.Windows.Forms.ComboBox listaaluno;
        private System.Windows.Forms.ComboBox listarelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox materiarelatorio;
        private System.Windows.Forms.Button botaoaluno;
    }
}

