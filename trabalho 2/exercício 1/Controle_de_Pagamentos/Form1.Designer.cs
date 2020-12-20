
namespace Controle_de_Pagamentos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lb_adicional = new System.Windows.Forms.Label();
            this.lb_titulo_natureza = new System.Windows.Forms.Label();
            this.lb_titulo_valor = new System.Windows.Forms.Label();
            this.lb_titulo_cpf = new System.Windows.Forms.Label();
            this.lb_titulo_cadastro = new System.Windows.Forms.Label();
            this.cb_natureza = new System.Windows.Forms.ComboBox();
            this.button_enviar = new System.Windows.Forms.Button();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_titulo_extrato = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Código = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Natureza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adicional = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_adicional = new System.Windows.Forms.TextBox();
            this.lb_aviso = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 450);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_enviar);
            this.tabPage1.Controls.Add(this.lb_aviso);
            this.tabPage1.Controls.Add(this.tb_adicional);
            this.tabPage1.Controls.Add(this.lb_adicional);
            this.tabPage1.Controls.Add(this.lb_titulo_natureza);
            this.tabPage1.Controls.Add(this.lb_titulo_valor);
            this.tabPage1.Controls.Add(this.lb_titulo_cpf);
            this.tabPage1.Controls.Add(this.lb_titulo_cadastro);
            this.tabPage1.Controls.Add(this.cb_natureza);
            this.tabPage1.Controls.Add(this.tb_cpf);
            this.tabPage1.Controls.Add(this.tb_valor);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lb_adicional
            // 
            this.lb_adicional.AutoSize = true;
            this.lb_adicional.Location = new System.Drawing.Point(454, 238);
            this.lb_adicional.Name = "lb_adicional";
            this.lb_adicional.Size = new System.Drawing.Size(0, 17);
            this.lb_adicional.TabIndex = 21;
            // 
            // lb_titulo_natureza
            // 
            this.lb_titulo_natureza.AutoSize = true;
            this.lb_titulo_natureza.Location = new System.Drawing.Point(217, 238);
            this.lb_titulo_natureza.Name = "lb_titulo_natureza";
            this.lb_titulo_natureza.Size = new System.Drawing.Size(166, 17);
            this.lb_titulo_natureza.TabIndex = 20;
            this.lb_titulo_natureza.Text = "Natureza do Pagamento:";
            // 
            // lb_titulo_valor
            // 
            this.lb_titulo_valor.AutoSize = true;
            this.lb_titulo_valor.Location = new System.Drawing.Point(217, 168);
            this.lb_titulo_valor.Name = "lb_titulo_valor";
            this.lb_titulo_valor.Size = new System.Drawing.Size(45, 17);
            this.lb_titulo_valor.TabIndex = 18;
            this.lb_titulo_valor.Text = "Valor:";
            this.lb_titulo_valor.Click += new System.EventHandler(this.lb_titulo_valor_Click);
            // 
            // lb_titulo_cpf
            // 
            this.lb_titulo_cpf.AutoSize = true;
            this.lb_titulo_cpf.Location = new System.Drawing.Point(217, 100);
            this.lb_titulo_cpf.Name = "lb_titulo_cpf";
            this.lb_titulo_cpf.Size = new System.Drawing.Size(38, 17);
            this.lb_titulo_cpf.TabIndex = 17;
            this.lb_titulo_cpf.Text = "CPF:";
            // 
            // lb_titulo_cadastro
            // 
            this.lb_titulo_cadastro.AutoSize = true;
            this.lb_titulo_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo_cadastro.Location = new System.Drawing.Point(200, 37);
            this.lb_titulo_cadastro.Name = "lb_titulo_cadastro";
            this.lb_titulo_cadastro.Size = new System.Drawing.Size(224, 25);
            this.lb_titulo_cadastro.TabIndex = 16;
            this.lb_titulo_cadastro.Text = "Cadastro de Pagamento";
            this.lb_titulo_cadastro.Click += new System.EventHandler(this.lb_titulo_cadastro_Click);
            // 
            // cb_natureza
            // 
            this.cb_natureza.FormattingEnabled = true;
            this.cb_natureza.Items.AddRange(new object[] {
            "Saúde",
            "Alimentação",
            "Outro"});
            this.cb_natureza.Location = new System.Drawing.Point(220, 258);
            this.cb_natureza.Name = "cb_natureza";
            this.cb_natureza.Size = new System.Drawing.Size(190, 24);
            this.cb_natureza.TabIndex = 15;
            this.cb_natureza.Text = "Escolha um";
            this.cb_natureza.SelectedIndexChanged += new System.EventHandler(this.cb_natureza_SelectedIndexChanged);
            // 
            // button_enviar
            // 
            this.button_enviar.Location = new System.Drawing.Point(233, 353);
            this.button_enviar.Name = "button_enviar";
            this.button_enviar.Size = new System.Drawing.Size(159, 23);
            this.button_enviar.TabIndex = 14;
            this.button_enviar.Text = "Enviar";
            this.button_enviar.UseVisualStyleBackColor = true;
            this.button_enviar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_enviar_MouseClick);
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(220, 120);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(190, 22);
            this.tb_cpf.TabIndex = 13;
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(220, 188);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(190, 22);
            this.tb_valor.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_titulo_extrato);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extrato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_titulo_extrato
            // 
            this.lb_titulo_extrato.AutoSize = true;
            this.lb_titulo_extrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo_extrato.Location = new System.Drawing.Point(22, 33);
            this.lb_titulo_extrato.Name = "lb_titulo_extrato";
            this.lb_titulo_extrato.Size = new System.Drawing.Size(73, 25);
            this.lb_titulo_extrato.TabIndex = 1;
            this.lb_titulo_extrato.Text = "Extrato";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Código,
            this.CPF,
            this.Natureza,
            this.Valor,
            this.Adicional});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(787, 352);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Código
            // 
            this.Código.Text = "Código";
            this.Código.Width = 104;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.Width = 145;
            // 
            // Natureza
            // 
            this.Natureza.Text = "Natureza da Compra";
            this.Natureza.Width = 163;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 128;
            // 
            // Adicional
            // 
            this.Adicional.Text = "Estabelecimento/Descrição";
            this.Adicional.Width = 222;
            // 
            // tb_adicional
            // 
            this.tb_adicional.Location = new System.Drawing.Point(439, 260);
            this.tb_adicional.Name = "tb_adicional";
            this.tb_adicional.Size = new System.Drawing.Size(237, 22);
            this.tb_adicional.TabIndex = 22;
            this.tb_adicional.Visible = false;
            // 
            // lb_aviso
            // 
            this.lb_aviso.AutoSize = true;
            this.lb_aviso.Location = new System.Drawing.Point(289, 369);
            this.lb_aviso.Name = "lb_aviso";
            this.lb_aviso.Size = new System.Drawing.Size(0, 17);
            this.lb_aviso.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_titulo_natureza;
        private System.Windows.Forms.Label lb_titulo_valor;
        private System.Windows.Forms.Label lb_titulo_cpf;
        private System.Windows.Forms.Label lb_titulo_cadastro;
        private System.Windows.Forms.ComboBox cb_natureza;
        private System.Windows.Forms.Button button_enviar;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_titulo_extrato;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Código;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Natureza;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.Label lb_adicional;
        private System.Windows.Forms.ColumnHeader Adicional;
        private System.Windows.Forms.TextBox tb_adicional;
        private System.Windows.Forms.Label lb_aviso;
    }
}

