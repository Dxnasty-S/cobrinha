using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cobrinha
{
    public partial class Form1 : Form
    {
        private List<Circulo> Cobrinha = new List<Circulo>();
        private Circulo Comida = new Circulo();
        public Form1()
        {
            InitializeComponent();
            new Configuracoes();
            cronometro.Interval = 1000 / Configuracoes.Velocidade;
            cronometro.Tick += AtualizarTela;
            cronometro.Start();

            IniciarJogo();
        }

        private void TeclaPressionada(object sender, KeyEventArgs e)
        {
            Entrada.MudarEstado(e.KeyCode, true);
        }

        private void TeclaLiberada(object sender, KeyEventArgs e)
        {
            Entrada.MudarEstado(e.KeyCode, false);
        }

        private void AtualizarGraficos(object sender, PaintEventArgs e)
        {
            Graphics TelaDePintura = e.Graphics;

            if (Configuracoes.FimDeJogo == false)
            {
                Brush CorDaCobra;

                for (int i = 0; i < Cobrinha.Count; i++)
                {
                    if (i == 0)
                    {
                        CorDaCobra = Brushes.Black;
                    }
                    else
                    {
                        CorDaCobra = Brushes.Green;
                    }

                    TelaDePintura.FillEllipse(CorDaCobra,
                        new Rectangle(
                           Cobrinha[i].X * Configuracoes.Largura,
                           Cobrinha[i].Y * Configuracoes.Altura,
                           Configuracoes.Largura, Configuracoes.Altura));

                    TelaDePintura.FillEllipse(CorDaCobra,
                        new Rectangle(
                            Comida.X * Configuracoes.Largura,
                            Comida.Y * Configuracoes.Altura,
                            Configuracoes.Largura, Configuracoes.Altura));
                }
            }
            else
            {
                String FimDeJogo = "Fim de jogo! \n" + "Pontuação final: " + Configuracoes.Pontos + "\n Pressione ENTER para recomeçar";
                labelFimDeJogo.Text = FimDeJogo;
                labelFimDeJogo.Location = new Point(pbCenario.Width / 2 - (labelFimDeJogo.Width / 2), pbCenario.Height / 2);
                labelFimDeJogo.Visible = true;
            }
        }

        private void IniciarJogo()
        {
            labelFimDeJogo.Visible = false;
            new Configuracoes();

            Cobrinha.Clear();
            Circulo cabeca = new Circulo {X = 10, Y = 15};
            Cobrinha.Add(cabeca);

            labelPontos.Text = Configuracoes.Pontos.ToString();
            GerarComida();
        }

        private void GerarComida()
        {
            int maxX = pbCenario.Size.Width / Configuracoes.Largura;
            int maxY = pbCenario.Size.Height / Configuracoes.Altura;
            Random aleatorio = new Random();
            Comida = new Circulo { X = aleatorio.Next(0, maxX), Y = aleatorio.Next(0, maxY) };
        }

        private void AtualizarTela(object sender, EventArgs e)
        {
            if(Configuracoes.FimDeJogo == true)
            {
                if (Entrada.PressionarTecla(Keys.Enter))
                {
                    IniciarJogo();
                }
            }
            else
            {
                if (Entrada.PressionarTecla(Keys.Right) && Configuracoes.direcao != Direcoes.Esquerda)
                {
                    Configuracoes.direcao = Direcoes.Direita;
                }
                else if (Entrada.PressionarTecla(Keys.Left) && Configuracoes.direcao != Direcoes.Direita)
                {
                    Configuracoes.direcao = Direcoes.Esquerda;
                }
                else if (Entrada.PressionarTecla(Keys.Up) && Configuracoes.direcao != Direcoes.Baixo)
                {
                    Configuracoes.direcao = Direcoes.Cima;
                }
                else if (Entrada.PressionarTecla(Keys.Down) && Configuracoes.direcao != Direcoes.Cima)
                {
                    Configuracoes.direcao = Direcoes.Baixo;
                }
                MoverCobrinha();
            }
            pbCenario.Invalidate();
        }

        private void MoverCobrinha()
        {
            for (int i = Cobrinha.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Configuracoes.direcao)
                    {
                        case Direcoes.Esquerda:
                            Cobrinha[i].X--;
                            break;
                        case Direcoes.Direita:
                            Cobrinha[i].X++;
                            break;
                        case Direcoes.Cima:
                            Cobrinha[i].Y--;
                            break;
                        case Direcoes.Baixo:
                            Cobrinha[i].Y++;
                            break;
                        default:
                            break;
                    }

                    int maxX = pbCenario.Size.Width / Configuracoes.Largura;
                    int maxY = pbCenario.Size.Height / Configuracoes.Altura;

                    if (Cobrinha[i].X < 0 || Cobrinha[i].Y < 0 || Cobrinha[i].X > maxX || Cobrinha[i].Y > maxY)
                    {
                        Morrer();
                    }

                    for (int j = 1; j < Cobrinha.Count; j++)
                    {
                        if(Cobrinha[i].X == Cobrinha[j].X && Cobrinha[i].Y == Cobrinha[j].Y)
                        {
                            Morrer();
                        }
                    }

                    if (Cobrinha[0].X == Comida.X && Cobrinha[0].Y == Comida.Y)
                    {
                        Comer();
                    }
                }
                else
                {
                    Cobrinha[i].X = Cobrinha[i - 1].X;
                    Cobrinha[i].Y = Cobrinha[i - 1].Y;
                }
            }
        }

        private void Morrer()
        {
            Configuracoes.FimDeJogo = true;
        }

        private void Comer()
        {
            Circulo Corpo = new Circulo();
            Corpo.X = Cobrinha[Cobrinha.Count - 1].X;
            Corpo.Y = Cobrinha[Cobrinha.Count - 1].Y;

            Cobrinha.Add(Corpo);
            Configuracoes.Pontos++;
            labelPontos.Text = Configuracoes.Pontos.ToString();
            GerarComida();
        }
    }
}
