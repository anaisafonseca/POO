
namespace final
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.atualizar = new System.Windows.Forms.Button();
            this.deletar = new System.Windows.Forms.Button();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cCadastrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cTelefone = new System.Windows.Forms.TextBox();
            this.cCEP = new System.Windows.Forms.TextBox();
            this.cUF = new System.Windows.Forms.TextBox();
            this.cCPF = new System.Windows.Forms.TextBox();
            this.cCidade = new System.Windows.Forms.TextBox();
            this.cBairro = new System.Windows.Forms.TextBox();
            this.cEndereco = new System.Windows.Forms.TextBox();
            this.cNome = new System.Windows.Forms.TextBox();
            this.cID = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vLancamento = new System.Windows.Forms.DateTimePicker();
            this.vCadastrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.vValor = new System.Windows.Forms.TextBox();
            this.vUso = new System.Windows.Forms.TextBox();
            this.vArtista = new System.Windows.Forms.TextBox();
            this.vEstado = new System.Windows.Forms.TextBox();
            this.vCategoria = new System.Windows.Forms.TextBox();
            this.vVinil = new System.Windows.Forms.TextBox();
            this.vID = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pCadastrar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.pPagamento = new System.Windows.Forms.TextBox();
            this.pIDv = new System.Windows.Forms.TextBox();
            this.pValor = new System.Windows.Forms.TextBox();
            this.pVendedor = new System.Windows.Forms.TextBox();
            this.pQtd = new System.Windows.Forms.TextBox();
            this.pIDc = new System.Windows.Forms.TextBox();
            this.pID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(272, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDados.Location = new System.Drawing.Point(6, 87);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 46;
            this.dgvDados.Size = new System.Drawing.Size(1077, 518);
            this.dgvDados.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 642);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.atualizar);
            this.tabPage1.Controls.Add(this.deletar);
            this.tabPage1.Controls.Add(this.selectBox);
            this.tabPage1.Controls.Add(this.dgvDados);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1089, 614);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Relação";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // atualizar
            // 
            this.atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.Location = new System.Drawing.Point(953, 30);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(107, 32);
            this.atualizar.TabIndex = 4;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // deletar
            // 
            this.deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar.Location = new System.Drawing.Point(809, 30);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(107, 32);
            this.deletar.TabIndex = 3;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = true;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // selectBox
            // 
            this.selectBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.selectBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.selectBox.FormattingEnabled = true;
            this.selectBox.Location = new System.Drawing.Point(29, 30);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(215, 28);
            this.selectBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.cCadastrar);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cTelefone);
            this.tabPage2.Controls.Add(this.cCEP);
            this.tabPage2.Controls.Add(this.cUF);
            this.tabPage2.Controls.Add(this.cCPF);
            this.tabPage2.Controls.Add(this.cCidade);
            this.tabPage2.Controls.Add(this.cBairro);
            this.tabPage2.Controls.Add(this.cEndereco);
            this.tabPage2.Controls.Add(this.cNome);
            this.tabPage2.Controls.Add(this.cID);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1089, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            // 
            // cCadastrar
            // 
            this.cCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.cCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cCadastrar.Location = new System.Drawing.Point(493, 373);
            this.cCadastrar.Name = "cCadastrar";
            this.cCadastrar.Size = new System.Drawing.Size(113, 40);
            this.cCadastrar.TabIndex = 2;
            this.cCadastrar.Text = "Cadastrar";
            this.cCadastrar.UseVisualStyleBackColor = false;
            this.cCadastrar.Click += new System.EventHandler(this.cCadastrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(547, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(547, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "UF";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(547, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "CEP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(82, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(547, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(82, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(82, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(82, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(82, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // cTelefone
            // 
            this.cTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTelefone.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cTelefone.Location = new System.Drawing.Point(652, 229);
            this.cTelefone.Name = "cTelefone";
            this.cTelefone.Size = new System.Drawing.Size(313, 26);
            this.cTelefone.TabIndex = 0;
            // 
            // cCEP
            // 
            this.cCEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCEP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cCEP.Location = new System.Drawing.Point(652, 62);
            this.cCEP.Name = "cCEP";
            this.cCEP.Size = new System.Drawing.Size(313, 26);
            this.cCEP.TabIndex = 0;
            // 
            // cUF
            // 
            this.cUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cUF.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cUF.Location = new System.Drawing.Point(652, 176);
            this.cUF.Name = "cUF";
            this.cUF.Size = new System.Drawing.Size(313, 26);
            this.cUF.TabIndex = 0;
            // 
            // cCPF
            // 
            this.cCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCPF.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cCPF.Location = new System.Drawing.Point(192, 171);
            this.cCPF.Name = "cCPF";
            this.cCPF.Size = new System.Drawing.Size(313, 26);
            this.cCPF.TabIndex = 0;
            // 
            // cCidade
            // 
            this.cCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCidade.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cCidade.Location = new System.Drawing.Point(652, 119);
            this.cCidade.Name = "cCidade";
            this.cCidade.Size = new System.Drawing.Size(313, 26);
            this.cCidade.TabIndex = 0;
            // 
            // cBairro
            // 
            this.cBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBairro.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cBairro.Location = new System.Drawing.Point(192, 288);
            this.cBairro.Name = "cBairro";
            this.cBairro.Size = new System.Drawing.Size(313, 26);
            this.cBairro.TabIndex = 0;
            // 
            // cEndereco
            // 
            this.cEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEndereco.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cEndereco.Location = new System.Drawing.Point(192, 231);
            this.cEndereco.Name = "cEndereco";
            this.cEndereco.Size = new System.Drawing.Size(313, 26);
            this.cEndereco.TabIndex = 0;
            // 
            // cNome
            // 
            this.cNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cNome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cNome.Location = new System.Drawing.Point(192, 118);
            this.cNome.Name = "cNome";
            this.cNome.Size = new System.Drawing.Size(313, 26);
            this.cNome.TabIndex = 0;
            // 
            // cID
            // 
            this.cID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cID.Location = new System.Drawing.Point(192, 62);
            this.cID.Name = "cID";
            this.cID.Size = new System.Drawing.Size(313, 26);
            this.cID.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.vLancamento);
            this.tabPage3.Controls.Add(this.vCadastrar);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.vValor);
            this.tabPage3.Controls.Add(this.vUso);
            this.tabPage3.Controls.Add(this.vArtista);
            this.tabPage3.Controls.Add(this.vEstado);
            this.tabPage3.Controls.Add(this.vCategoria);
            this.tabPage3.Controls.Add(this.vVinil);
            this.tabPage3.Controls.Add(this.vID);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(1089, 614);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vinis";
            // 
            // vLancamento
            // 
            this.vLancamento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.747663F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vLancamento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vLancamento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vLancamento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vLancamento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vLancamento.Location = new System.Drawing.Point(159, 227);
            this.vLancamento.Name = "vLancamento";
            this.vLancamento.Size = new System.Drawing.Size(350, 24);
            this.vLancamento.TabIndex = 22;
            // 
            // vCadastrar
            // 
            this.vCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vCadastrar.Location = new System.Drawing.Point(492, 335);
            this.vCadastrar.Name = "vCadastrar";
            this.vCadastrar.Size = new System.Drawing.Size(113, 40);
            this.vCadastrar.TabIndex = 21;
            this.vCadastrar.Text = "Cadastrar";
            this.vCadastrar.UseVisualStyleBackColor = true;
            this.vCadastrar.Click += new System.EventHandler(this.vCadastrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(552, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tempo de uso";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(552, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Valor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(552, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Categoria";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(552, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Artista";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 234);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Lançamento";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(42, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Vinil";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 65);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "ID";
            // 
            // vValor
            // 
            this.vValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vValor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vValor.Location = new System.Drawing.Point(682, 114);
            this.vValor.Name = "vValor";
            this.vValor.Size = new System.Drawing.Size(350, 26);
            this.vValor.TabIndex = 9;
            // 
            // vUso
            // 
            this.vUso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vUso.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vUso.Location = new System.Drawing.Point(682, 228);
            this.vUso.Name = "vUso";
            this.vUso.Size = new System.Drawing.Size(350, 26);
            this.vUso.TabIndex = 8;
            // 
            // vArtista
            // 
            this.vArtista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vArtista.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vArtista.Location = new System.Drawing.Point(159, 171);
            this.vArtista.Name = "vArtista";
            this.vArtista.Size = new System.Drawing.Size(350, 26);
            this.vArtista.TabIndex = 7;
            // 
            // vEstado
            // 
            this.vEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vEstado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vEstado.Location = new System.Drawing.Point(682, 172);
            this.vEstado.Name = "vEstado";
            this.vEstado.Size = new System.Drawing.Size(350, 26);
            this.vEstado.TabIndex = 6;
            // 
            // vCategoria
            // 
            this.vCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vCategoria.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vCategoria.Location = new System.Drawing.Point(682, 61);
            this.vCategoria.Name = "vCategoria";
            this.vCategoria.Size = new System.Drawing.Size(350, 26);
            this.vCategoria.TabIndex = 5;
            // 
            // vVinil
            // 
            this.vVinil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vVinil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vVinil.Location = new System.Drawing.Point(159, 118);
            this.vVinil.Name = "vVinil";
            this.vVinil.Size = new System.Drawing.Size(350, 26);
            this.vVinil.TabIndex = 11;
            // 
            // vID
            // 
            this.vID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.vID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.vID.Location = new System.Drawing.Point(159, 61);
            this.vID.Name = "vID";
            this.vID.Size = new System.Drawing.Size(350, 26);
            this.vID.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.pCadastrar);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.label22);
            this.tabPage4.Controls.Add(this.label23);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.label25);
            this.tabPage4.Controls.Add(this.pPagamento);
            this.tabPage4.Controls.Add(this.pIDv);
            this.tabPage4.Controls.Add(this.pValor);
            this.tabPage4.Controls.Add(this.pVendedor);
            this.tabPage4.Controls.Add(this.pQtd);
            this.tabPage4.Controls.Add(this.pIDc);
            this.tabPage4.Controls.Add(this.pID);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.76635F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage4.Size = new System.Drawing.Size(1089, 614);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pedidos";
            // 
            // pCadastrar
            // 
            this.pCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.09346F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pCadastrar.Location = new System.Drawing.Point(494, 339);
            this.pCadastrar.Name = "pCadastrar";
            this.pCadastrar.Size = new System.Drawing.Size(113, 40);
            this.pCadastrar.TabIndex = 38;
            this.pCadastrar.Text = "Cadastrar";
            this.pCadastrar.UseVisualStyleBackColor = true;
            this.pCadastrar.Click += new System.EventHandler(this.pCadastrar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Pagamento";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(115, 238);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "Quantidade";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(570, 123);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 20);
            this.label21.TabIndex = 33;
            this.label21.Text = "Vendedor";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(570, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 20);
            this.label22.TabIndex = 32;
            this.label22.Text = "Valor";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(115, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 20);
            this.label23.TabIndex = 31;
            this.label23.Text = "ID do vinil";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(115, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 20);
            this.label24.TabIndex = 37;
            this.label24.Text = "ID do cliente";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(115, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(100, 20);
            this.label25.TabIndex = 30;
            this.label25.Text = "ID do pedido";
            // 
            // pPagamento
            // 
            this.pPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pPagamento.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pPagamento.Location = new System.Drawing.Point(678, 176);
            this.pPagamento.Name = "pPagamento";
            this.pPagamento.Size = new System.Drawing.Size(279, 26);
            this.pPagamento.TabIndex = 27;
            // 
            // pIDv
            // 
            this.pIDv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pIDv.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pIDv.Location = new System.Drawing.Point(230, 178);
            this.pIDv.Name = "pIDv";
            this.pIDv.Size = new System.Drawing.Size(279, 26);
            this.pIDv.TabIndex = 26;
            // 
            // pValor
            // 
            this.pValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pValor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pValor.Location = new System.Drawing.Point(678, 62);
            this.pValor.Name = "pValor";
            this.pValor.Size = new System.Drawing.Size(279, 26);
            this.pValor.TabIndex = 26;
            // 
            // pVendedor
            // 
            this.pVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pVendedor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pVendedor.Location = new System.Drawing.Point(678, 120);
            this.pVendedor.Name = "pVendedor";
            this.pVendedor.Size = new System.Drawing.Size(279, 26);
            this.pVendedor.TabIndex = 25;
            // 
            // pQtd
            // 
            this.pQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pQtd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pQtd.Location = new System.Drawing.Point(230, 235);
            this.pQtd.Name = "pQtd";
            this.pQtd.Size = new System.Drawing.Size(279, 26);
            this.pQtd.TabIndex = 24;
            // 
            // pIDc
            // 
            this.pIDc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pIDc.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pIDc.Location = new System.Drawing.Point(230, 118);
            this.pIDc.Name = "pIDc";
            this.pIDc.Size = new System.Drawing.Size(279, 26);
            this.pIDc.TabIndex = 29;
            // 
            // pID
            // 
            this.pID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pID.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pID.Location = new System.Drawing.Point(230, 62);
            this.pID.Name = "pID";
            this.pID.Size = new System.Drawing.Size(279, 26);
            this.pID.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1125, 669);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.074766F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox cID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cTelefone;
        private System.Windows.Forms.TextBox cCEP;
        private System.Windows.Forms.TextBox cUF;
        private System.Windows.Forms.TextBox cCPF;
        private System.Windows.Forms.TextBox cCidade;
        private System.Windows.Forms.TextBox cBairro;
        private System.Windows.Forms.TextBox cEndereco;
        private System.Windows.Forms.TextBox cNome;
        private System.Windows.Forms.ComboBox selectBox;
        private System.Windows.Forms.Button cCadastrar;
        private System.Windows.Forms.Button vCadastrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox vValor;
        private System.Windows.Forms.TextBox vUso;
        private System.Windows.Forms.TextBox vArtista;
        private System.Windows.Forms.TextBox vEstado;
        private System.Windows.Forms.TextBox vCategoria;
        private System.Windows.Forms.TextBox vVinil;
        private System.Windows.Forms.TextBox vID;
        private System.Windows.Forms.DateTimePicker vLancamento;
        private System.Windows.Forms.Button pCadastrar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox pPagamento;
        private System.Windows.Forms.TextBox pIDv;
        private System.Windows.Forms.TextBox pValor;
        private System.Windows.Forms.TextBox pVendedor;
        private System.Windows.Forms.TextBox pQtd;
        private System.Windows.Forms.TextBox pIDc;
        private System.Windows.Forms.TextBox pID;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.Button atualizar;
    }
}

