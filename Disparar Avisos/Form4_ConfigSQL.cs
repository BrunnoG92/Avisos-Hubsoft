using Disparar_Avisos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disparar_Avisos
{
    public partial class Form4_ConfigSQL : Form
    {
        BancoDeDados ConfiguracoesSQL = BancoDeDados.Instance;
        public Form4_ConfigSQL()
        {
            InitializeComponent();
            CarregaConfiSQL();
        }
        public  void CarregaConfiSQL() 
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Disparar Avisos.exe");
            Configuration config = ConfigurationManager.OpenExeConfiguration(configPath);

            if (config.AppSettings.Settings.AllKeys.Contains("HostSQL"))
            {
                TxtB_Host.Text = ConfigurationManager.AppSettings["HostSQL"];
                ConfiguracoesSQL.HostSQL = ConfigurationManager.AppSettings["HostSQL"];

            }
            if (config.AppSettings.Settings.AllKeys.Contains("NomeBancoSQL"))
            {
                Txb_Banco.Text = ConfigurationManager.AppSettings["NomeBancoSQL"];
                ConfiguracoesSQL.BancoNomeSQL = ConfigurationManager.AppSettings["NomeBancoSQL"];

            }

        }
        private void SalvaConfigSQL()
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Disparar Avisos.exe");
            Configuration config = ConfigurationManager.OpenExeConfiguration(configPath);
            ConfiguracoesSQL.HostSQL = TxtB_Host.Text;
            ConfiguracoesSQL.BancoNomeSQL = Txb_Banco.Text;
            if (!config.AppSettings.Settings.AllKeys.Contains("HostSQL"))
            {
                config.AppSettings.Settings.Add("HostSQL", ConfiguracoesSQL.HostSQL);
                MessageBox.Show("Configurações salva com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!config.AppSettings.Settings.AllKeys.Contains("NomeBancoSQL"))
            {
                config.AppSettings.Settings.Add("NomeBancoSQL", ConfiguracoesSQL.BancoNomeSQL);
                MessageBox.Show("Configurações salva com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                config.AppSettings.Settings["HostSQL"].Value = ConfiguracoesSQL.HostSQL;
                config.AppSettings.Settings["NomeBancoSQL"].Value = ConfiguracoesSQL.BancoNomeSQL;
                MessageBox.Show("Configurações atualizadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvaConfigSQL();
        }
    }
}
