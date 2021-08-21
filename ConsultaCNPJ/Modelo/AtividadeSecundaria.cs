using Newtonsoft.Json;

namespace ConsultaCNPJ.Modelo
{
    public class AtividadeSecundaria
    {
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        public override string ToString()
        {
            string resultado = "\n\r";

            resultado += Text + "\n\r";
            resultado += Code + "\n\r";

            return resultado;
        }
    }
}
