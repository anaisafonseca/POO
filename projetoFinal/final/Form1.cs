using Npgsql;
using System;
using System.Globalization;
using System.Data;
using System.Windows.Forms;

namespace final
{
    public partial class Form1 : Form
    {
        private static string host = "localhost";
        private static string user = "postgres";
        private static string dbName = "projetoFinal";
        private static string port = "5432";
        private static string password = "262472";
        NpgsqlConnection conn = null;

        string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    host,
                    user,
                    dbName,
                    port,
                    password);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            selectBox.Items.Add("Clientes");
            selectBox.Items.Add("Vinis");
            selectBox.Items.Add("Pedidos");
        }

        private DataTable Execute(string commandSQL)
        {
            DataTable dt = new DataTable();
            try
            {
                using (conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    using (NpgsqlDataAdapter cmd = new NpgsqlDataAdapter(commandSQL, conn))
                    {
                        cmd.Fill(dt);
                        dgvDados.DataSource = null;
                        dgvDados.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        private void Select()
        {
            var type = selectBox.SelectedItem;
            if (type == null)
            {
               MessageBox.Show("Selecione uma tabela para visualizar!");
            }
            else if (type.ToString() == "Clientes")
            {
                Execute("SELECT * FROM loja.tb_clientes ORDER BY id_cliente");
            }
            else if (type.ToString() == "Vinis")
            {
                Execute("SELECT * FROM loja.tb_vinis ORDER BY id_vinil");
            }
            else if (type.ToString() == "Pedidos")
            {
                Execute("SELECT * FROM loja.tb_pedidos ORDER BY id_pedido");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string cliente = "INSERT INTO loja.tb_clientes VALUES(" +
                    cID.Text + ",'" + cNome.Text + "','" + cCPF.Text + "','" + cEndereco.Text + "','" + cBairro.Text + "','" +
                    cCEP.Text + "','" + cCidade.Text + "','" + cUF.Text + "','" + cTelefone.Text + "');";
                Execute(cliente);

                cID.Text = "";
                cNome.Text = ""; 
                cCPF.Text = ""; 
                cEndereco.Text = ""; 
                cBairro.Text = "";
                cCEP.Text = ""; 
                cCidade.Text = ""; 
                cUF.Text = ""; 
                cTelefone.Text = "";
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void vCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string vinil = "INSERT INTO loja.tb_vinis VALUES(" +
                    vID.Text + ",'" + vVinil.Text + "','" + vArtista.Text + "','" + vLancamento.Value.ToShortDateString() + "','" +
                    vCategoria.Text + "'," + vValor.Text + ",'" + vEstado.Text + "','" + vUso.Text + "');";
                Execute(vinil);

                vID.Text = "";
                vVinil.Text = "";
                vArtista.Text = "";
                vCategoria.Text = "";
                vValor.Text = "";
                vEstado.Text = "";
                vUso.Text = "";
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string pedido = "INSERT INTO loja.tb_pedidos VALUES(" +
                    pID.Text + "," + pIDc.Text + "," + pValor.Text + "," + pIDv.Text + "," + pQtd.Text + ",'" +
                    pVendedor.Text + "','" + DateTime.Now.ToShortDateString() + "','" + pPagamento.Text + "');";
                Execute(pedido);

                pValor.Text = "";
                pIDv.Text = "";
                pQtd.Text = "";
                MessageBox.Show("Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            try
            {
                string deletar = "DELETE FROM ";
                string type = selectBox.SelectedItem.ToString();
                if (type == "Clientes")
                {
                    deletar += "loja.tb_clientes WHERE id_cliente=";
                }
                else if (type == "Vinis")
                {
                    deletar += "loja.tb_vinis WHERE id_vinil=";
                }
                else if (type == "Pedidos")
                {
                    deletar += "loja.tb_pedidos WHERE id_pedido=";
                }
                deletar += dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[0].Value;
                Execute(deletar);
                Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string atualizar = "UPDATE ";
                CultureInfo culture = new CultureInfo("en-US");
                string type = selectBox.SelectedItem.ToString();
                if (type == "Clientes")
                {
                    atualizar += "loja.tb_clientes SET nome='" +
                    dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[1].Value +
                    "',cpf=" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[2].Value +
                    ",endereco='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[3].Value +
                    "',bairro='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[4].Value +
                    "',cep=" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[5].Value +
                    ",cidade='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[6].Value +
                    "',uf='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[7].Value +
                    "',telefone=" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[8].Value +
                    "WHERE id_cliente=";
                }
                else if (type == "Vinis")
                {
                    atualizar += "loja.tb_vinis SET vinil='" +
                    dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[1].Value +
                    "',artista='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[2].Value +
                    "',lancamento='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[3].Value +
                    "',categoria='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[4].Value +
                    "',valor=" + Convert.ToString(Convert.ToDouble(dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[5].Value), culture) +
                    ",estado='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[6].Value +
                    "',tp_uso='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[7].Value +
                    "' WHERE id_vinil=";
                }
                else if (type == "Pedidos")
                {
                    atualizar += "loja.tb_pedidos SET id_cliente=" +
                    dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[1].Value +
                    ",valor=" + Convert.ToString(Convert.ToDouble(dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[2].Value), culture) +
                    ",id_vinil=" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[3].Value +
                    ",qtd=" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[4].Value +
                    ",vendedor='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[5].Value +
                    "',datavenda='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[6].Value +
                    "',pagamento='" + dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[7].Value +
                    "' WHERE id_pedido=";
                }
                atualizar += dgvDados.Rows[dgvDados.SelectedCells[0].RowIndex].Cells[0].Value;
                Execute(atualizar);
                Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
