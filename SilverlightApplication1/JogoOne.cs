using System;
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
    public class JogoOne:Jogo
    {
        public override void fazJogada(Ellipse[] bola, TextBlock[] x, object sender, int pos)
        {
            if (Vez % 2 == 0)
            {
                if (I % 2 == 0)
                {
                    bola[pos].Visibility = Visibility.Visible;
                }
                if(I % 2 != 0)
                {
                    x[Posicao()].Visibility = Visibility.Visible;
                }
            }
            else
            {
                if (I % 2 == 0)
                {
                    x[Posicao()].Visibility = Visibility.Visible;
                }
                else
                {
                    bola[pos].Visibility = Visibility.Visible;
                }
            }
            ((Button)sender).IsEnabled = false;
            I++;
            verificaVelha();
        }

        private int Posicao()
        {
            return 0;
        }
    }
}
