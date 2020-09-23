using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class FrmJogoDificil : Form
    {
        Jogador jogodificil;
        public FrmJogoDificil(Jogador LJjogo)
        {
            InitializeComponent();
            CriarJogo();
            jogodificil = LJjogo;
        }

        Random random = new Random();

        List<string> icons = new List<string>()
            {
                "!", "!", "Y", "Y", "j", "j", "J", "J","n","n",
                "b", "b", "v", "v", "V", "V", "t", "t","h","h",
                ",",",","k","k","L","L","ç","ç","p","p"
            };

        private void CriarJogo()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {

                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    iconLabel.ForeColor = iconLabel.BackColor;
                    int randomIcone = random.Next(icons.Count);
                    iconLabel.Text = icons[randomIcone];
                    icons.RemoveAt(randomIcone);
                }
            }
        }


        Label clique1 = null;
        Label clique2 = null;
             private void label_click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;
            if (clique2 != null)
                return;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;

                if (clique1 == null)
                {
                    clique1 = clickedLabel;
                    clique1.ForeColor = Color.Black;
                    return;
                }

                clique2 = clickedLabel;
                clique2.ForeColor = Color.Black;

                ChecarVencedor();

                if (clique1.Text == clique2.Text)
                {
                    clique1 = null;
                    clique2 = null;
                    return;
                }
                timer1.Start();
            }
        }

        int Segundos;
        private void ChecarVencedor()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Parabéns!!! Você terminou!");
            timer2.Stop();
            jogodificil.Fim = true;
            jogodificil.Tempo = Segundos;
            jogodificil.Nivel = "Difícil";
            Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            clique1.ForeColor = clique1.BackColor;
            clique2.ForeColor = clique2.BackColor;

            clique1 = null;
            clique2 = null;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Segundos++;
        }
    }
}