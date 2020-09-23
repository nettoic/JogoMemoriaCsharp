using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        static List<Jogador> ListaJogadores = new List<Jogador>();

        FrmCadastro frmCadastro = new FrmCadastro(ListaJogadores);

        FrmRanking frmRanking = new FrmRanking(ListaJogadores);

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro.ShowDialog();
            Atualizar();
        }

        private void Atualizar()
        {
            comboBoxJogador.Items.Clear();
            ListaJogadores.ForEach(delegate (Jogador J1)
            {
                comboBoxJogador.Items.Add(J1.Nome);
            });

            if (comboBoxJogador.Items.Count > 0)
                comboBoxJogador.Enabled = true;
        }

        
        private void fácilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxJogador.SelectedItem == null)
                MessageBox.Show("Selecione um jogador!!!");
            else
            {
                FrmJogo Jogo = new FrmJogo(ListaJogadores[indice]);
                Jogo.ShowDialog();
            }
        }

        private void médioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxJogador.SelectedItem == null)
                MessageBox.Show("Selecione um jogador!!!");
            else
            {
                FrmJogoMedio frmJogoMedio = new FrmJogoMedio(ListaJogadores[indice]);
                frmJogoMedio.ShowDialog();
            }
        }

        private void difícilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBoxJogador.SelectedItem == null)
                MessageBox.Show("Selecione um jogador!!!");
            else
            {
                FrmJogoDificil frmJogoDificil = new FrmJogoDificil(ListaJogadores[indice]);
                frmJogoDificil.ShowDialog();
            }
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRanking.ShowDialog();
        }

        int indice;
        private void comboBoxJogador_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = comboBoxJogador.SelectedIndex;
        }

        private void MemoryGame_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

    }
}