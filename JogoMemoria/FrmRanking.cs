using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class FrmRanking : Form
    {
        List<Jogador> LJrank;
        public FrmRanking(List<Jogador> LJjogadores)
        {
            InitializeComponent();
            LJrank = LJjogadores;
        }

        private void FrmRanking_Load(object sender, EventArgs e)
        {
            string resultado = null;
            listBox1.Items.Clear();
            LJrank.ForEach(delegate (Jogador J)
            {
                if (J.Fim)
                {
                    resultado = J.Tempo + " segundos" + "\t" + J.Nivel + "\t\t" + J.Nome;
                    listBox1.Items.Add(resultado);
                }
            });                     
        }
    }
}
