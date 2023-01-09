using Disparar_Avisos.Models;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Disparar_Avisos
{

    public partial class Form2_ConfiguraçõesAPI : Form
    {
        Credenciais Configuracoes = Credenciais.Instance;
        BancoDeDados ConfigSQL = BancoDeDados.Instance;
        Cripto Criptografa = new Cripto();

        public Form2_ConfiguraçõesAPI()
        {
            InitializeComponent();
            ConfigSQL.CarregaConfiguracoesSQL();
            CarregaConfigInterface();

        }
        
        private void CarregaConfigInterface()
        {
            try
            {
                string PasswordTemp = Criptografa.Decrypt(Configuracoes.Password, "123"); //senha exemplo
                string SenhaEmailTemp = Criptografa.Decrypt(Configuracoes.SenhaEmail, "123"); // Senha Exemplo
                string ClienteSecretTemp = Criptografa.Decrypt(Configuracoes.ClientSecret, "123"); // Senha Exemplo
                Txb_Password.Text = PasswordTemp;
                TxB_ClienteSecret.Text = ClienteSecretTemp;
                Txb_SenhaRemetente.Text = SenhaEmailTemp;
            }
            catch
            { 
                
            }
           

            TxtB_GrantType.Text = Configuracoes.GrantType;
            TxtB_UserName.Text = Configuracoes.UserName;
            TxB_ID.Text = Configuracoes.ClientID;
            TxB_HostAutentica.Text = Configuracoes.HostAutentica;
            TxB_Consulta.Text = Configuracoes.HostConsulta;
            TxB_Remetente.Text = Configuracoes.EmailRemetente;
            Configuracoes.Email_Destinatario.RemoveAll(s => s == "");

            CmbDestinatario.Items.AddRange(Configuracoes.Email_Destinatario.ToArray());
            TxB_HostEmail.Text = Configuracoes.HostEmail;
        }
        public void SalvaConfiguracoesLocal()
        {
            Configuracoes.GrantType = TxtB_GrantType.Text;
            Configuracoes.ClientID = TxB_ID.Text;
            Configuracoes.UserName = TxtB_UserName.Text;
            Configuracoes.HostAutentica = TxB_HostAutentica.Text;
            Configuracoes.HostConsulta = TxB_Consulta.Text;
            Configuracoes.EmailRemetente = TxB_Remetente.Text; 
            Configuracoes.HostEmail = TxB_HostEmail.Text;
            Configuracoes.SenhaEmail = Txb_SenhaRemetente.Text;
            Configuracoes.Password = Txb_Password.Text;
            Configuracoes.ClientSecret = TxB_ClienteSecret.Text;   
        }

   
        private void Btn_AdicionarEmail_Click(object sender, EventArgs e)
        {
           
            if (!CmbDestinatario.Items.Contains(CmbDestinatario.Text))
            {   
                Configuracoes.Email_Destinatario.Add(CmbDestinatario.Text);
                CmbDestinatario.Items.Add(CmbDestinatario.Text);

            }


        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvaConfiguracoesLocal();
            ConfigSQL.SalvaConfiguracoesSQL();
            
        }

        private void Btn_Remover_Click(object sender, EventArgs e)
        {
            try
            {
                string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Disparar Avisos.exe");
                Configuration config = ConfigurationManager.OpenExeConfiguration(configPath);
                object itemSelecionado = CmbDestinatario.SelectedItem;
                if (CmbDestinatario.Items.Count == 1) 
                {
                    MessageBox.Show($"Não é possível apagar o único email da lista. Adicione um outro antes de apagar este", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ConfigSQL.ApagaEmailSQL(itemSelecionado);
                    CmbDestinatario.Items.Remove(itemSelecionado);
                    Configuracoes.Email_Destinatario.Remove(itemSelecionado.ToString());
                    config.AppSettings.Settings.Remove(itemSelecionado.ToString());
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                    MessageBox.Show("Email apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao apagar o email {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        
    }
}

