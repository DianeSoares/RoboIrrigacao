using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteBackend.Services;

namespace TesteBackend
{
    public partial class Tela_frm : Form
    {
        public Tela_frm()
        {
            InitializeComponent();
        }

        private void Tela_frm_Close(object sender, FormClosingEventArgs e)
        {
            const string message = "Tem certeza que quer fechar a aplicação?";
            const string caption = "Fechar Aplicação";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            } 

        }

        private void btnIrrigar_Click(object sender, EventArgs e)
        {
            var valido = true;
            if (cmbOrientacao.SelectedItem is null)
            {
                MessageBox.Show("Selecione uma orientação para continuar", "Atenção",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                valido = false;
            }

            if (dgvPosicoes.Rows.Count == 1)
            {
                MessageBox.Show("Adicionar canteiros que serão irrigados", "Atenção",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                valido = false;
            }

            if (valido)
            {
                try
                {
                    var posicaoInicialX = nudXPosicao.Value;
                    var posicaoInicialY = nudYPosicao.Value;
                    var orientacao = cmbOrientacao.SelectedItem.ToString();

                    var total = dgvPosicoes.Rows.Count - 1;
                    var listOfPosicoes = new List<List<string>>();

                    for (int i = 0; i < total; i++)
                    {
                        var listPosicao = new List<string>();
                        var xValue = dgvPosicoes.Rows[i].Cells["xPosicao"].Value.ToString();
                        var yValue = dgvPosicoes.Rows[i].Cells["yPosicao"].Value.ToString();
                        listPosicao.Add(xValue);
                        listPosicao.Add(yValue);

                        listOfPosicoes.Add(listPosicao);

                    }

                    IrrigaService irrigaService = new IrrigaService();
                    var resultado = irrigaService.calculaResultados(posicaoInicialX, posicaoInicialY, orientacao, listOfPosicoes);
                    lblResultIrrigacao.Text = resultado;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ocorreu um erro ao executar o robô",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddPosicao_Click(object sender, EventArgs e)
        {
            var xIrrigar = nudXIrrigar.Value;
            var yIrrigar = nudYIrrigar.Value;

            this.dgvPosicoes.Rows.Insert(0, xIrrigar, yIrrigar);

        }

    }
}
