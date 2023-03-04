using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                case 1:
                    lblResposta.Text = "O mês 1 é equivalente a Janeiro";
                break;

                case 2:
                    lblResposta.Text = "O mês 2 é equivalente a Fevereiro";
                break;

                case 3:
                    lblResposta.Text = "O mês 3 é equivalente a Março";
                break;

                case 4:
                    lblResposta.Text = "O mês 4 é equivalente a Abril";
                break;

                case 5:
                    lblResposta.Text = "O mês 5 é equivalente a Maio";
                break;

                case 6:
                    lblResposta.Text = "O mês 6 é equivalente a Junho";
                break;

                case 7:
                    lblResposta.Text = "O mês 7 é equivalente a Julho";
                break;

                case 8:
                    lblResposta.Text = "O mês 8 é equivalente a Agosto";
                break;

                case 9:
                    lblResposta.Text = "O mês 9 é equivalente a Setembro";
                break;

                case 10:
                    lblResposta.Text = "O mês 10 é equivalente a Outubro";
                break;

                case 11:
                    lblResposta.Text = "O mês 11 é equivalente a Novembro";
                break;

                case 12:
                    lblResposta.Text = "O mês 12 é equivalente a Dezembro";
                break;

                    
            }
        }
    }
}
