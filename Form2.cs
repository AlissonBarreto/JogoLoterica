using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboLoto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var rRandom = new Random();
            int iQuantidade = decimal.ToInt32(numNumero.Value);
            int iValorMinimo = decimal.ToInt32(numMin.Value);
            int iValorMaximo = decimal.ToInt32(numMax.Value);
            int iQuantidadeJogos = decimal.ToInt32(numJogos.Value);
            int iDezena;
            bool bExist;
            int[] sNumerosGerados = new int[iQuantidade];
            int iQuantidadeGerada = 0;

            string sJogo = "";
            rtbJogos.Text = "";

            for (int x = 0; x < iQuantidadeJogos; x++)
            {
                sJogo = "";
                iQuantidadeGerada = 0;

                while (iQuantidadeGerada < iQuantidade)
                {
                    iDezena = rRandom.Next(iValorMinimo, iValorMaximo);
                    bExist = false;

                    for (int i = 0; i < sNumerosGerados.Count(); i++)
                    {
                        if (sNumerosGerados[i] == iDezena)
                        {
                            bExist = true;
                            break;
                        }
                    }

                    if (!bExist)
                    {
                        sNumerosGerados[iQuantidadeGerada] = iDezena;
                        iQuantidadeGerada++;
                    }
                }

                Array.Sort(sNumerosGerados);

                for (int i = 0; i < sNumerosGerados.Count(); i++)
                {
                    sJogo += sNumerosGerados[i].ToString() + " ";
                }

                rtbJogos.Text += sJogo + Environment.NewLine;
            }
        }
    }
}
