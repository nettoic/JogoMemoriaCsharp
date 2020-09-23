using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class FrmCadastro : Form
    {
        List<Jogador> ListaJogadores;
        public FrmCadastro(List<Jogador> LJcad)
        {
            InitializeComponent();
            ListaJogadores = LJcad;
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Digite um nome.");
            else
            {
                Jogador J = new Jogador();
                J.Nome = textBox1.Text;
                ListaJogadores.Add(J);
                MessageBox.Show(textBox1.Text + " cadastrado com sucesso!");
                textBox1.Clear();
            }

            textBox1.Focus();
        }
    }
}

