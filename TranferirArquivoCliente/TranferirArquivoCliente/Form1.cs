using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranferirArquivoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTCliente.LabelMensagem = labelStatus;
        }

        private void txtArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Enviar Arquivo";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtArquivo.Text = dialog.FileName;
            }
        }

        private void btnEnviarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEnderecoIP.Text) || 
                string.IsNullOrEmpty(txtPortaHost.Value.ToString()) ||
                txtArquivo.Text == "Clique para selecionar um arquivo...")
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Dados inválidos";
                return;
            }

            string enderecoIP = txtEnderecoIP.Text;
            int porta = (int)txtPortaHost.Value;
            string nomeArquivo = txtArquivo.Text;

            FTCliente.EnderecoIP = enderecoIP;
            FTCliente.PortaHost = porta;

            try
            {
                Task.Factory.StartNew(() => {
                    FTCliente.EnviarArquivo(nomeArquivo);
                });
            }
            catch (Exception ex)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "Erro :\n" + ex.Message;
            }
        }
    }
}
