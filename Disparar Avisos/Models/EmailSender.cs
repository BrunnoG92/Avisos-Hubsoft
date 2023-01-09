using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using Disparar_Avisos.Models;

public class EmailSender
{
    public void SendEmail(string from, List<string> to, string subject, string body)
    {
        Credenciais Configuracoes = Credenciais.Instance;
        Cripto Cripotografia= new Cripto();
        // Cria um objeto MailMessage com as informações do email
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress(from);


        foreach (string destinatario in to)
        {
            mail.To.Add(destinatario);
        }


        mail.Subject = subject;
        mail.Body = body;

        // Cria um objeto SmtpClient para enviar o email
        SmtpClient client = new SmtpClient();
        client.Host = Configuracoes.HostEmail;
        client.Port = 587;
        client.UseDefaultCredentials = false;
        client.Credentials = new NetworkCredential(from, Cripotografia.Decrypt(Configuracoes.SenhaEmail,"123"));// Senha Ex
        client.EnableSsl = true;

        // Envia o email
        client.Send(mail);
    }
}