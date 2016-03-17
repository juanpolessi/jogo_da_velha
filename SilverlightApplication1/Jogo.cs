using System;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public abstract class Jogo
    {
        private int pBola, pX;
        private string nomeBola, nomeX;
        Grid jogos, layoutRoot, oneplayer, twoplayers, fechar;
        Ellipse[] bola = new Ellipse[9];
        Rectangle[] l = new Rectangle[8];
        TextBlock[] x = new TextBlock[9];
        TextBlock p, g;
        TextBox nB, nX;
        Button[] b = new Button[9];
        Button zera, recomeca, comeca;
        private int i = 0;
        private int vez = 0;

        public Grid Jogos
        {
            get { return jogos; }
            set { jogos = value; }
        }
        public Grid LayoutRoot
        {
            get { return layoutRoot; }
            set { layoutRoot = value; }
        }
        public Grid OnePlayer
        {
            get { return oneplayer; }
            set { oneplayer = value; }
        }
        public Grid TwoPlayers
        {
            get { return twoplayers; }
            set { twoplayers = value; }
        }
        public Grid Fechar
        {
            get { return fechar; }
            set { fechar = value; }
        }
        public Ellipse[] Bola
        {
            get { return bola; }
            set { bola = value; }
        }
        public Rectangle[] L
        {
            get { return l; }
            set { l = value; }
        }
        public TextBlock[] X
        {
            get { return x; }
            set { x = value; }
        }
        public TextBlock P
        {
            get { return p; }
            set { p = value; }
        }
        public TextBlock G
        {
            get { return g; }
            set { g = value; }
        }
        public Button[] B
        {
            get { return b; }
            set { b = value; }
        }
        public Button Zera
        {
            get { return zera; }
            set { zera = value; }
        }
        public Button Recomeca
        {
            get { return recomeca; }
            set { recomeca = value; }
        }
        public Button Comeca
        {
            get { return comeca; }
            set { comeca = value; }
        }
        public TextBox NB
        {
            get { return nB; }
            set { nB = value; }
        }
        public TextBox NX
        {
            get { return nX; }
            set { nX = value; }
        }
        public int I
        {
            get { return i; }
            set { i = value; }
        }
        public int Vez
        {
            get { return vez; }
            set { vez = value; }
        }
        public string NomeBola
        {
            get { return nomeBola; }
            set { nomeBola = value; }
        }
        public string NomeX
        {
            get { return nomeX; }
            set { nomeX = value; }
        }
        public int PBola
        {
            get { return pBola; }
            set { pBola = value; }
        }
        public int PX
        {
            get { return pX; }
            set { pX = value; }
        }


        public virtual void fazJogada(Ellipse[] bola, TextBlock[] x, object sender, int pos)
        {
        }

        public void verificaVelha()
        {
            #region bola

            if (bola[0].Visibility == Visibility.Visible && bola[1].Visibility == Visibility.Visible && bola[2].Visibility == Visibility.Visible)
            {
                l[0].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }
            else if (bola[3].Visibility == Visibility.Visible && bola[4].Visibility == Visibility.Visible && bola[5].Visibility == Visibility.Visible)
            {
                l[1].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }
            else if (bola[6].Visibility == Visibility.Visible && bola[7].Visibility == Visibility.Visible && bola[8].Visibility == Visibility.Visible)
            {
                l[2].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }
            else if (bola[0].Visibility == Visibility.Visible && bola[3].Visibility == Visibility.Visible && bola[6].Visibility == Visibility.Visible)
            {
                l[3].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }
            else if (bola[1].Visibility == Visibility.Visible && bola[4].Visibility == Visibility.Visible && bola[7].Visibility == Visibility.Visible)
            {
                l[4].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }
            else if (bola[2].Visibility == Visibility.Visible && bola[5].Visibility == Visibility.Visible && bola[8].Visibility == Visibility.Visible)
            {
                l[5].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }
            else if (bola[0].Visibility == Visibility.Visible && bola[4].Visibility == Visibility.Visible && bola[8].Visibility == Visibility.Visible)
            {
                l[6].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }
            else if (bola[2].Visibility == Visibility.Visible && bola[4].Visibility == Visibility.Visible && bola[6].Visibility == Visibility.Visible)
            {
                l[7].Visibility = Visibility.Visible;
                g.Text = nomeBola + " Ganhou!!";
                pBola++;
                travarGrid();
            }

            #endregion

            #region X
            else if (x[0].Visibility == Visibility.Visible && x[1].Visibility == Visibility.Visible && x[2].Visibility == Visibility.Visible)
            {
                l[0].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            else if (x[3].Visibility == Visibility.Visible && x[4].Visibility == Visibility.Visible && x[5].Visibility == Visibility.Visible)
            {
                l[1].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            else if (x[6].Visibility == Visibility.Visible && x[7].Visibility == Visibility.Visible && x[8].Visibility == Visibility.Visible)
            {
                l[2].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            else if (x[0].Visibility == Visibility.Visible && x[3].Visibility == Visibility.Visible && x[6].Visibility == Visibility.Visible)
            {
                l[3].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            else if (x[1].Visibility == Visibility.Visible && x[4].Visibility == Visibility.Visible && x[7].Visibility == Visibility.Visible)
            {
                l[4].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            else if (x[2].Visibility == Visibility.Visible && x[5].Visibility == Visibility.Visible && x[8].Visibility == Visibility.Visible)
            {
                l[5].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            else if (x[0].Visibility == Visibility.Visible && x[4].Visibility == Visibility.Visible && x[8].Visibility == Visibility.Visible)
            {
                l[6].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            else if (x[2].Visibility == Visibility.Visible && x[4].Visibility == Visibility.Visible && x[6].Visibility == Visibility.Visible)
            {
                l[7].Visibility = Visibility.Visible;
                g.Text = nomeX + " Ganhou!!";
                pX++;
                travarGrid();
            }
            #endregion

            #region Velha
            else if (i == 9 && verificaLinhas() == true)
            {
                g.Text = "Deu velha!";
                travarGrid();
            }
            #endregion
        }

        public void travarGrid()
        {
            foreach (Button btn in b)
            {
                btn.IsEnabled = false;
            }

            recomeca.Visibility = Visibility.Visible;
            zera.Visibility = Visibility.Visible;
            p.Text = nomeBola + " " + pBola + " X " + pX + " " + nomeX;
        }

        public void Zerar()
        {
            nB.IsEnabled = true;
            nX.IsEnabled = true;
            comeca.IsEnabled = true;
            recomeca.Visibility = Visibility.Collapsed;
            zera.Visibility = Visibility.Collapsed;
            nB.Text = "";
            nX.Text = "";
            g.Text = "";
            p.Text = "";
            pX = 0;
            pBola = 0;
            i = 0;
            vez = 0;

            foreach (Ellipse eli in bola)
            {
                eli.Visibility = Visibility.Collapsed;
            }

            foreach (TextBlock tex in x)
            {
                tex.Visibility = Visibility.Collapsed;
            }

            foreach (Rectangle rec in l)
            {
                rec.Visibility = Visibility.Collapsed;
            }

            BloqueiaBotoes();
        }

        public void Recomecar()
        {
            vez++;
            g.Text = "";
            i = 0;
            recomeca.Visibility = Visibility.Collapsed;
            zera.Visibility = Visibility.Collapsed;

            foreach (Ellipse eli in bola)
            {
                eli.Visibility = Visibility.Collapsed;
            }

            foreach (TextBlock tex in x)
            {
                tex.Visibility = Visibility.Collapsed;
            }

            foreach (Rectangle rec in l)
            {
                rec.Visibility = Visibility.Collapsed;
            }
            HabilitaBotao();
        }

        public void HabilitaBotao()
        {
            foreach (Button btn in b)
            {
                btn.IsEnabled = true;
            }
        }

        public void BloqueiaBotoes()
        {
            foreach (Button btn in b)
            {
                btn.IsEnabled = false;
            }
        }

        public bool verificaLinhas()
        {
            if (l[0].Visibility == Visibility.Collapsed && l[1].Visibility == Visibility.Collapsed && l[2].Visibility == Visibility.Collapsed &&
            l[3].Visibility == Visibility.Collapsed && l[4].Visibility == Visibility.Collapsed && l[5].Visibility == Visibility.Collapsed &&
            l[6].Visibility == Visibility.Collapsed && l[7].Visibility == Visibility.Collapsed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void EsconderEscolha()
        {
            oneplayer.Visibility = Visibility.Collapsed;
            twoplayers.Visibility = Visibility.Collapsed;
            layoutRoot.Visibility = Visibility.Visible;
            Fechar.Visibility = Visibility.Visible;
        }

        public void MostrarEscolha()
        {
            oneplayer.Visibility = Visibility.Visible;
            twoplayers.Visibility = Visibility.Visible;
        }


    }

}

