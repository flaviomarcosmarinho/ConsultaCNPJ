using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ConsultaCNPJ.Modelo
{
    [Serializable]
    public class Empresa
    {
        private List<AtividadePrincipal> atividade_principal = new List<AtividadePrincipal>();

        [JsonProperty(PropertyName = "atividade_principal")]
        public List<AtividadePrincipal> Atividade_principal { get => atividade_principal; set => atividade_principal = value; }

        [JsonProperty(PropertyName = "data_situacao")]
        public string Data_situacao { get; set; }

        [JsonProperty(PropertyName = "complemento")]
        public string Complemento { get; set; }

        [JsonProperty(PropertyName = "tipo")]
        public string Tipo { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        [JsonProperty(PropertyName = "uf")]
        public string Uf { get; set; }

        [JsonProperty(PropertyName = "telefone")]
        public string Telefone { get; set; }

        private List<AtividadeSecundaria> atividade_secundaria = new List<AtividadeSecundaria>();

        [JsonProperty(PropertyName = "atividades_secundarias")]
        public List<AtividadeSecundaria> Atividade_secundaria { get => atividade_secundaria; set => atividade_secundaria = value; }

        private List<QuadroSocietario> qsa = new List<QuadroSocietario>();

        [JsonProperty(PropertyName = "qsa")]
        public List<QuadroSocietario> Qsa { get => qsa; set => qsa = value; }


        [JsonProperty(PropertyName = "situacao")]
        public string Situacao { get; set; }

        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }

        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty(PropertyName = "numero")]
        public string Numero { get; set; }

        [JsonProperty(PropertyName = "cep")]
        public string Cep { get; set; }

        [JsonProperty(PropertyName = "municipio")]
        public string Municipio { get; set; }

        [JsonProperty(PropertyName = "porte")]
        public string Porte { get; set; }

        [JsonProperty(PropertyName = "abertura")]
        public string Abertura { get; set; }

        [JsonProperty(PropertyName = "natureza_juridica")]
        public string Natureza_juridica { get; set; }

        [JsonProperty(PropertyName = "fantasia")]
        public string Fantasia { get; set; }

        [JsonProperty(PropertyName = "cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty(PropertyName = "ultima_atualizacao")]
        public string Ultima_atualizacao { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
      
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "efr")]
        public string Efr { get; set; }

        [JsonProperty(PropertyName = "motivo_situacao")]
        public string Motivo_situacao { get; set; }

        [JsonProperty(PropertyName = "situacao_especial")]
        public string Situacao_especial { get; set; }

        [JsonProperty(PropertyName = "data_situacao_especial")]
        public string Data_situacao_especial { get; set; }

        [JsonProperty(PropertyName = "capital_social")]
        public string Capital_social { get; set; }
 

        public override string ToString()
        {
            string resultado = "\n\r";

            resultado += Data_situacao + "\n\r";
            resultado += Nome.Trim() + "\n\r";
            resultado += Uf.Trim() + "\n\r";
            resultado += Telefone.Trim() + "\n\r";
            resultado += Situacao.Trim() + "\n\r";
            resultado += Bairro.Trim() + "\n\r";
            resultado += Logradouro.Trim() + "\n\r";
            resultado += Numero.Trim() + "\n\r";
            resultado += Cep.Trim() + "\n\r";
            resultado += Municipio.Trim() + "\n\r";
            resultado += Abertura + "\n\r";
            resultado += Natureza_juridica.Trim() + "\n\r";
            resultado += Fantasia.Trim() + "\n\r";
            resultado += Porte.Trim() + "\n\r";
            resultado += Cnpj.Trim() + "\n\r";
            resultado += Ultima_atualizacao + "\n\r";
            resultado += Status.Trim() + "\n\r";
            resultado += Tipo.Trim() + "\n\r";
            resultado += Complemento.Trim() + "\n\r";
            resultado += Email.Trim() + "\n\r";
            resultado += Efr.Trim() + "\n\r";
            resultado += Motivo_situacao.Trim() + "\n\r";
            resultado += Situacao_especial.Trim() + "\n\r";
            resultado += Data_situacao_especial + "\n\r";
            resultado += Capital_social.Trim() + "\n\r";

            return resultado;
        }
    }
}
