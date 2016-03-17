using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            BX();
        }

        Jogo j;
        Ellipse[] bola = new Ellipse[9];
        TextBlock[] x = new TextBlock[9];
        public int one = 0;
        int two = 0;
        int pos = 0;

        public void listarComponentes()
        {
            //linhas
            j.L[0] = Linha1;
            j.L[1] = Linha2;
            j.L[2] = Linha3;
            j.L[3] = Linha4;
            j.L[4] = Linha5;
            j.L[5] = Linha6;
            j.L[6] = Linha7;
            j.L[7] = Linha8;
            //botõesJogo
            j.B[0] = btn1;
            j.B[1] = btn2;
            j.B[2] = btn3;
            j.B[3] = btn4;
            j.B[4] = btn5;
            j.B[5] = btn6;
            j.B[6] = btn7;
            j.B[7] = btn8;
            j.B[8] = btn9;
            //bolas
            j.Bola[0] = Bola1;
            j.Bola[1] = Bola2;
            j.Bola[2] = Bola3;
            j.Bola[3] = Bola4;
            j.Bola[4] = Bola5;
            j.Bola[5] = Bola6;
            j.Bola[6] = Bola7;
            j.Bola[7] = Bola8;
            j.Bola[8] = Bola9;
            //X
            j.X[0] = X1;
            j.X[1] = X2;
            j.X[2] = X3;
            j.X[3] = X4;
            j.X[4] = X5;
            j.X[5] = X6;
            j.X[6] = X7;
            j.X[7] = X8;
            j.X[8] = X9;

            j.G = ganhador;
            j.P = placar;
            j.Zera = ZerarJogo;
            j.Recomeca = RecomecarJogo;
            j.Comeca = comecar;

            j.NB = NomeBolaT;
            j.NX = NomeXT;

            j.Jogos = Jogo;
            j.LayoutRoot = LayoutRoot;
            j.OnePlayer = oneplayer;
            j.TwoPlayers = twoplayers;
            j.Fechar = Fechar;
        }

        bool VerificaPlayer()
        {
            if (one > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void BX()
        {
            bola[0] = Bola1;
            bola[1] = Bola2;
            bola[2] = Bola3;
            bola[3] = Bola4;
            bola[4] = Bola5;
            bola[5] = Bola6;
            bola[6] = Bola7;
            bola[7] = Bola8;
            bola[8] = Bola9;
            //X
            x[0] = X1;
            x[1] = X2;
            x[2] = X3;
            x[3] = X4;
            x[4] = X5;
            x[5] = X6;
            x[6] = X7;
            x[7] = X8;
            x[8] = X9;
        }


        private void comecar_Click(object sender, RoutedEventArgs e)
        {
            if (NomeBolaT.Text == string.Empty)
            {
                NomeBolaT.Focus();
            }
            else if (NomeXT.Text == string.Empty)
            {
                NomeXT.Focus();
            }
            else
            {
                NomeBolaT.IsEnabled = false;
                NomeXT.IsEnabled = false;
                comecar.IsEnabled = false;
                j.NomeBola = NomeBolaT.Text;
                j.NomeX = NomeXT.Text;
                j.HabilitaBotao();
            }

        }

        private void ZerarJogo_Click(object sender, RoutedEventArgs e)
        {
            j.Zerar();
        }

        private void RecomecarJogo_Click(object sender, RoutedEventArgs e)
        {
            j.Recomecar();
        }



        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            pos = 0;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            pos = 1;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            pos = 2;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            pos = 3;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            pos = 4;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            pos = 5;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            pos = 6;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            pos = 7;
            j.fazJogada(bola, x, sender, pos);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            pos = 8;
            j.fazJogada(bola, x, sender, pos);
        }




        private void twoplayers_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            two++;
            if (VerificaPlayer() == true)
            {
                j = new JogoOne();
            }
            else
            {
                j = new JogoTwo();
            }
            listarComponentes();
            j.EsconderEscolha();
            rectwo.Fill = new SolidColorBrush(Colors.Transparent);
            j.BloqueiaBotoes();
        }
        private void twoplayers_MouseEnter(object sender, MouseEventArgs e)
        {
            rectwo.Fill = new SolidColorBrush(Colors.Black);
        }

        private void twoplayers_MouseLeave(object sender, MouseEventArgs e)
        {
            rectwo.Fill = new SolidColorBrush(Colors.Transparent);
        }


        private void Fechar_MouseEnter(object sender, MouseEventArgs e)
        {
            recx.Fill = new SolidColorBrush(Colors.Red);
        }

        private void Fechar_MouseLeave(object sender, MouseEventArgs e)
        {
            recx.Fill = new SolidColorBrush(Colors.Transparent);
        }
        private void Fechar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            LayoutRoot.Visibility = Visibility.Collapsed;
            Fechar.Visibility = Visibility.Collapsed;
            recx.Fill = new SolidColorBrush(Colors.Transparent);
            j.Zerar();
            j.MostrarEscolha();
        }


        //botao oneplayer
        //private void oneplayer_MouseEnter(object sender, MouseEventArgs e)
        //{
        //    recone.Fill = new SolidColorBrush(Colors.Black);
        //}

        //private void oneplayer_MouseLeave(object sender, MouseEventArgs e)
        //{
        //    recone.Fill = new SolidColorBrush(Colors.Transparent);
        //}
        //private void oneplayer_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    one++;
        //    if (VerificaPlayer())
        //    {
        //        j = new JogoOne();
        //    }
        //    else
        //    {
        //        j = new JogoTwo();
        //    }
        //    listarComponentes();
        //    j.EsconderEscolha();
        //    recone.Fill = new SolidColorBrush(Colors.Transparent);
        //    j.BloqueiaBotoes();
        //}


    }
}


