using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caPilha;

namespace wfaPilha
{
    public partial class formPilha : Form
    {

        Pilha[] pilha = new Pilha[4];

        public formPilha()
        {
            InitializeComponent();          

            for (int i = 0; pilha.Length > i; i++)
            {
                Pilha pilha1 = new Pilha();
                pilha[i] = pilha1;
            }
        }

        private void btPush_Click(object sender, EventArgs e)
        {
                       
            try
            {
                string valor = tbPush.Text;
                int tbPushint = int.Parse(tbPush.Text);
                bool flag = true;
                
                
                tbPush.Text = "";
                Console.WriteLine(pilha[0].len());

                for (int i = 0; pilha.Length > i; i++)
                {
                    if (pilha[i].indexOf(tbPushint) != -1)
                    {

                        flag = false;
                    }                    
                    
                }
                if (flag)
                {
                    int aux = 0;
                    for (int i = 0; pilha.Length > i; i++)
                    {
                             
                        if(pilha[i].len() < pilha[aux].len() && pilha[i].len() <= 3)
                        {
                            
                            aux = i;
                            
                        }
      
                    }
                    if(pilha[aux].len() < 3)
                    {
                        pilha[aux].push(int.Parse(valor));
                    }
                    else
                    {
                        throw new Exception();
                    }
                    
                    tbPilha.Text = pilha[0].print();
                    tbPilha2.Text = pilha[1].print();
                    tbPilha3.Text = pilha[2].print();
                    tbPilha4.Text = pilha[3].print();

                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Código invalido!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Impossível Empilhar!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }

        }
        private void btPop_Click(object sender, EventArgs e)
        {
            try
            {
                int tbPopint = int.Parse(tbPop.Text);
                //pilha.indexOf(tbPopint);
                bool flag = false;
                int aux = -1;
                for (int i = 0; pilha.Length > i; i++)
                {
                   
                    if (pilha[i].indexOf(tbPopint) != -1)
                    {
                        aux = i;
                    }
                    
                    
                }
                if(aux != -1)
                {
                    if (pilha[aux].peek() == tbPopint)
                    {
                        pilha[aux].pop();
                        tbPilha.Text = pilha[0].print();
                        tbPilha2.Text = pilha[1].print();
                        tbPilha3.Text = pilha[2].print();
                        tbPilha4.Text = pilha[3].print();
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                else if (pilha[0].isEmpty() && pilha[1].isEmpty() && pilha[2].isEmpty() && pilha[3].isEmpty())
                {
                    throw new Exception();
                }
                else
                {
                    throw new FormatException();
                }
               

            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Código invalido!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Impossível desempilhar!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btImprime_Click(object sender, EventArgs e)
        {
            tbPilha.Text = pilha[0].print();
        }

        private void tbPilha_TextChanged(object sender, EventArgs e)
        {

        }

        private void formPilha_Load(object sender, EventArgs e)
        {

        }

        private void lbPilha_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


    }
}
