using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteBackend.Services
{
    class IrrigaService
    {

        public String calculaResultados(Decimal posicaoInicialX, 
            Decimal posicaoInicialY, string orientacao, List<List<string>> posicoes)
        {
            int xInicial = decimal.ToInt32(posicaoInicialX);
            int yInicial = decimal.ToInt32(posicaoInicialY);

            var movimentos = "";
            foreach (List<string> lista in posicoes)
            {

                var hortaX = Int32.Parse(lista.ElementAt(0));
                var hortaY = Int32.Parse(lista.ElementAt(1));

                Tuple<string, string> resultado = CalculaMovimentos(orientacao, xInicial, yInicial, hortaX, hortaY);           
                movimentos += resultado.Item1;

                // Muda os parametros para a proxima iteração
                // O proximo movimento deve considerar o ultimo movimento executado
                xInicial = hortaX;
                yInicial = hortaY;
                orientacao = resultado.Item2;

            }

            

            return movimentos;
        }

        public Tuple<string, string> CalculaMovimentos(string orientacao, int posicaoInicialX, int posicaoInicialY, int hortaX, int hortaY)
        {
            var movimentosIrrigacao = "";

            if (posicaoInicialX == hortaX && posicaoInicialY == hortaY)
            {

                movimentosIrrigacao += "I";

                return Tuple.Create(movimentosIrrigacao, orientacao);
            }

            // Determina a direção dos movimentos
            switch (orientacao)
            {
                case "Norte":
                    if (posicaoInicialX < hortaX)
                    {
                        orientacao = "Leste";
                        movimentosIrrigacao += "D";
                    }
                    else
                    {
                        orientacao = "Oeste";
                        movimentosIrrigacao += "E";
                    }
                    break;
                case "Sul":
                    if (posicaoInicialX < hortaX)
                    {
                        orientacao = "Leste";
                        movimentosIrrigacao += "E";
                    }
                    else
                    {
                        orientacao = "Oeste";
                        movimentosIrrigacao += "D";
                    }
                    break;
                case "Leste":
                    if (posicaoInicialX > hortaX)
                    {
                        orientacao = "Oeste";
                        movimentosIrrigacao = movimentosIrrigacao + "D" + "D";
                    }
                    break;
                case "Oeste":
                    if (posicaoInicialX < hortaX)
                    {
                        orientacao = "Leste";
                        movimentosIrrigacao = movimentosIrrigacao + "D" + "D";
                    }
                    break;
            }

            // Realiza os movimentos Leste/Oeste
            switch (orientacao)
            {
                case "Leste":
                    while (posicaoInicialX != hortaX)
                    {
                        posicaoInicialX++;
                        movimentosIrrigacao += "M";
                    }
                    if (posicaoInicialY < hortaY)
                    {
                        orientacao = "Norte";
                        movimentosIrrigacao += "E";
                    }
                    else
                    {
                        orientacao = "Sul";
                        movimentosIrrigacao += "D";
                    }
                    break;
                case "Oeste":
                    while (posicaoInicialX != hortaX)
                    {
                        posicaoInicialX--;
                        movimentosIrrigacao += "M";
                    }
                    if (posicaoInicialY < hortaY)
                    {
                        orientacao = "Norte";
                        movimentosIrrigacao += "D";
                    }
                    else
                    {
                        orientacao = "Sul";
                        movimentosIrrigacao += "E";
                    }
                    break;
            }

            // Realiza os movimentos Norte/Sul
            switch (orientacao)
            {
                case "Norte":
                    while (posicaoInicialY != hortaY)
                    {
                        posicaoInicialY++;
                        movimentosIrrigacao += "M";
                    }
                    movimentosIrrigacao += "I";
                    break;
                case "Sul":
                    while (posicaoInicialY != hortaY)
                    {
                        posicaoInicialY--;
                        movimentosIrrigacao += "M";
                    }
                    movimentosIrrigacao += "I";
                    break;

            }

            return Tuple.Create(movimentosIrrigacao, orientacao);

        }
           
    }
}
