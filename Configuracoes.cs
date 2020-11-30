using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cobrinha
{
    public enum Direcoes
    {
        Esquerda,
        Direita,
        Cima,
        Baixo
    }
    class Configuracoes
    {
        public static int Largura { get; set; }
        public static int Altura { get; set; }
        public static int Velocidade { get; set; }
        public static int Pontos { get; set; }
        public static bool FimDeJogo { get; set; }
        public static Direcoes direcao { get; set; }

        public Configuracoes()
        {
            Largura = 16;
            Altura = 16;
            Velocidade = 20;
            Pontos = 0;
            FimDeJogo = false;
            direcao = Direcoes.Baixo;
        }
    }
}
