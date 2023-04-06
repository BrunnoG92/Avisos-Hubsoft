using Disparar_Avisos.Models;
using RestSharp;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows;
using TesteHC;

namespace Hubsoft_Auth
{
    public class Hubsoft_A
    {
        public string Autentica_Hubsoft()
        {   
            Credenciais Configuracoes = Credenciais.Instance;
            Cripto Criptografa = new Cripto();
            var client = new RestClient(Configuracoes.HostAutentica);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cookie", "Cookie_1=value");
            string grantType = Configuracoes.GrantType;
            string clientId = Configuracoes.ClientID;
            string clientSecret = Criptografa.Decrypt(Configuracoes.ClientSecret,"123"); //SENHA EX
            string username = Configuracoes.UserName;
            string password = Criptografa.Decrypt(Configuracoes.Password,"123"); //SENHA EX

            var body = $@"{{
            ""grant_type"":""{grantType}"",
            ""client_id"":""{clientId}"",
            ""client_secret"":""{clientSecret}"",
            ""username"":""{username}"",
            ""password"":""{password}""
            }}";


            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            var Resposta = response.Content;


            var options = new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            };
            var Token = JsonSerializer.Deserialize<Token_Acess>(Resposta, options);
            var Token_Acesso = Token.access_token;
            return Token_Acesso;
        }
    }

}
