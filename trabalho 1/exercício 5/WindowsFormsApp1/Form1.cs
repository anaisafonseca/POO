using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int i = 0;
        public int p = 0;
        Aluno[] vetoraluno = new Aluno[100];
        Matérias[] vetormatérias = new Matérias[100];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoaluno_Click(object sender, EventArgs e)
        {
            try {
                string nome = Campo_Nome.Text;
                string matricula = Campo_Matricula.Text;
                Console.WriteLine(i);
                Aluno aluno1 = new Aluno(nome, matricula);
                vetoraluno[i] = aluno1;
                Campo_Nome.Text = "";
                Campo_Matricula.Text = "";
                for (int j = 0; j <= i; j++)
                {
                    vetoraluno[j].Print();
                }
                listaaluno.Items.Insert(i, nome);
                listarelatorio.Items.Insert(i, nome);
                i = i + 1;
                }
            catch
            {
                MessageBox.Show("error");
            }
            }

        private void Aluno_Click(object sender, EventArgs e)
        {

        }

        private void Campo_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] lista = listamateria.CheckedItems.OfType<string>().ToArray();
                Console.WriteLine(lista);
                for (int j = 0; j < lista.Length; j++)
                {
                    Console.WriteLine(lista[j]);
                }
                int indexaluno = listaaluno.SelectedIndex;
                Matérias materia1 = new Matérias(lista, vetoraluno[indexaluno]);
                vetormatérias[p] = materia1;
                p += 1;
                listaaluno.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        private void listaaluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabelamateria_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void listarelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                string nomealuno = listarelatorio.SelectedItem.ToString();
                string frase = "";
                for (int j = 0; j < p; j++)
                {
                    if (vetormatérias[j].Getaluno() == nomealuno)
                    {
                        for (int x = 0; x < vetormatérias[j].Getmateria().Length; x++)
                        {
                            frase += vetormatérias[j].Getmateria()[x].ToString() + ",";
                        }
                    }
                }
                materiarelatorio.Text = frase;
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        
    }
}
