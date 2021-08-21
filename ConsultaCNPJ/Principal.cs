using ConsultaCNPJ.Modelo;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ConsultaCNPJ
{
    public partial class Principal : Form
    {
        #region Construtor

        public Principal()
        {
            InitializeComponent();
            mskCNPJ.Text = "42.940.528/0001-90";
        }

        #endregion

        #region Eventos

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string cnpj = mskCNPJ.Text.Replace(".", "").Replace(",", "").Replace("/", "").Replace("-", "");

            if (!string.IsNullOrEmpty(cnpj) && cnpj.Trim().Length > 0)
            {                
                string url = "https://www.receitaws.com.br/v1/cnpj/" + cnpj;

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var response = client.GetAsync(url).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            var result = response.Content.ReadAsStringAsync().Result;

                            Empresa empresa = JsonConvert.DeserializeObject<Empresa>(result);
                            this.ExibirConsulta(empresa);
                        }
                    }
                }
                catch (Exception ex)
                {
                    richTextBox1.Text = string.Empty;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                richTextBox1.Text = string.Empty;
            }
        }

        #endregion

        #region Metodos

        private void ExibirConsulta(Empresa empresa)
        {
            richTextBox1.Text = empresa.ToString();
            richTextBox1.Text += empresa.Atividade_principal.ToString();

            if (empresa.Atividade_secundaria.Count > 0)
            {
                richTextBox1.Text += "\n\r**********Atividades Secundárias**********\n\r";

                foreach (AtividadeSecundaria item in empresa.Atividade_secundaria)
                {
                    richTextBox1.Text += item.ToString();
                }
            }
            if (empresa.Qsa.Count > 0)
            {
                richTextBox1.Text += "\n\r**********Quadro Societário**********\n\r";

                foreach (QuadroSocietario item in empresa.Qsa)
                {
                    richTextBox1.Text += item.ToString();
                }
            }
        }

        #endregion
    }
}
