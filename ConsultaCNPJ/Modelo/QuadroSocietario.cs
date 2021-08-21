using Newtonsoft.Json;

namespace ConsultaCNPJ.Modelo
{
    public class QuadroSocietario
    {
        [JsonProperty(PropertyName = "qual")]
        public string Qual { get; set; }

        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }

        public override string ToString()
        {
            string resultado = "\n\r";

            resultado += Qual + "\n\r";
            resultado += Nome + "\n\r";

            return resultado;
        }
    }
}
