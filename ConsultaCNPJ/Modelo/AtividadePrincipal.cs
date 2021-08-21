using Newtonsoft.Json;

namespace ConsultaCNPJ.Modelo
{
    public class AtividadePrincipal
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        public override string ToString()
        {
            string resultado = "\n\r**********Atividade Principal**********\n\r";

            resultado += Text + "\n\r";
            resultado += Code + "\n\r";           

            return resultado;
        }
    }
}
