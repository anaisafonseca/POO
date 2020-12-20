using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Pagamentos
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void lb_titulo_cadastro_Click(object sender, EventArgs e)
        {

        }

        private void lb_titulo_valor_Click(object sender, EventArgs e)
        {

        }

        int codigo = 0;

        private void button_enviar_MouseClick(object sender, MouseEventArgs e)
        {

            string CPF = tb_cpf.Text, Adicional = tb_adicional.Text;
            double Valor = Convert.ToDouble(tb_valor.Text);


            if (cb_natureza.Text == "Saúde")
            {
                Pagamento_saude pagamento = new Pagamento_saude(CPF, codigo, Valor, Adicional);
                ListViewItem item = new ListViewItem(pagamento.get_codigo());
                item.SubItems.Add(pagamento.get_CPF());
                item.SubItems.Add(cb_natureza.Text);
                item.SubItems.Add(pagamento.get_valor());
                item.SubItems.Add(pagamento.get_estabelcimento());
                listView1.Items.AddRange(new ListViewItem[] { item });
            }
            else if (cb_natureza.Text == "Alimentação")
            {
                Pagamento_alimentaçao pagamento = new Pagamento_alimentaçao(CPF, codigo, Valor, Adicional);
                ListViewItem item = new ListViewItem(pagamento.get_codigo());
                item.SubItems.Add(pagamento.get_CPF());
                item.SubItems.Add(cb_natureza.Text);
                item.SubItems.Add(pagamento.get_valor());
                item.SubItems.Add(pagamento.get_descrição());
                listView1.Items.AddRange(new ListViewItem[] { item });
            }

            else
            {
                Pagamento pagamento = new Pagamento(CPF, codigo, Valor);
                ListViewItem item = new ListViewItem(pagamento.get_codigo());
                item.SubItems.Add(pagamento.get_CPF());
                item.SubItems.Add(cb_natureza.Text);
                item.SubItems.Add(pagamento.get_valor());
                listView1.Items.AddRange(new ListViewItem[] { item });
            }

            codigo++;

            if (codigo == 6)
            {
                button_enviar.Visible = false;
                lb_aviso.Text = "Número máximo de pagamentos faturados!";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_natureza_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_natureza.Text == "Saúde")
            {
                tb_adicional.Visible = true;
                tb_adicional.Text = "";
                lb_adicional.Text = "Adicione o Estabelecimento";
            }
            else if (cb_natureza.Text == "Alimentação")
            {
                tb_adicional.Visible = true;
                tb_adicional.Text = "";
                lb_adicional.Text = "Adicione uma Descrição";
            }
            else
            {
                tb_adicional.Visible = false;
                tb_adicional.Text = "";
                lb_adicional.Text = "";
            }
            

            
        }

        
    }
}
