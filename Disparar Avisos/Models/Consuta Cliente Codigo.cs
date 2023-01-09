using System;
using RestSharp;
using Newtonsoft.Json;
using Disparar_Avisos.Models;
using System.Windows.Forms;

namespace TesteHC.Models
{
    public class Consulta_Cliente_Codigo
    {
        public string Codigo { get; set; }

        public string  Consulta_Codigo(int num1, string Bearer)
        {
            Credenciais Configuracoes = Credenciais.Instance;
            string URLConsulta = $"{Configuracoes.HostConsulta}?busca=codigo_cliente&termo_busca={num1}&ultima_conexao&ultima_conexao=sim";
            var client = new RestClient(URLConsulta);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader($"Authorization", "Bearer " + Bearer);
            request.AddHeader("Cookie", "Cookie_1=value");
            IRestResponse response = client.Execute(request);
            var Resposta = response.Content;
            // Deserializa o objeto JSON em um JObject
            try
            {
                dynamic jsonObject = JsonConvert.DeserializeObject(Resposta);
                if (jsonObject.clientes.Count > 0)
                {
                    string cliente = jsonObject.clientes[0].nome_razaosocial;
                    return cliente;
                }
                else
                {
                    return "Cliente não encontrado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Cliente não encontrado";
               
            }
           
           
            
        }


    }
}

