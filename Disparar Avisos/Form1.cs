using Hubsoft_Auth;
using System;
using System.Windows.Forms;
using TesteHC.Models;
using System.Linq;
using ComponentFactory.Krypton.Toolkit;
using Disparar_Avisos.Models;
using System.Xml.Serialization;
using System.IO;

namespace Disparar_Avisos
{
    public partial class Form1 : Form
    {
        readonly Credenciais Configuracoes = Credenciais.Instance;
        public Form1()
        {
            
            InitializeComponent();
            Btn1_Enviar.Enabled= false;
            // Crie uma coleção de strings para armazenar os itens da combobox
            

            if (Btn1_Enviar.Enabled == false )
            {

                Btn1_Enviar.Cursor.Equals( Cursors.No );
            }
        }

       
       
        private void Btn_OK_Click(object sender, EventArgs e)
        {
          
         
            Form2_ConfiguraçõesAPI Salvar = new Form2_ConfiguraçõesAPI();
            var textBoxes = groupBox1.Controls.OfType<KryptonTextBox>();
            var comboBoxes = groupBox1.Controls.OfType<KryptonComboBox>();
            if(textBoxes.Any(tb => tb.Text == "") || comboBoxes.Any(cb => cb.SelectedIndex == -1))
    {
                MessageBox.Show("Um ou mais campos estão vazios!", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                
                Hubsoft_A AutenticaHubsoft = new Hubsoft_A();
                string Resposta = AutenticaHubsoft.Autentica_Hubsoft();
                Consulta_Cliente_Codigo Consulta = new Consulta_Cliente_Codigo();
                int CodigoCliente = Convert.ToInt32(TxtB_Codigo.Text);
                string NomeCliente = Consulta.Consulta_Codigo(CodigoCliente,Resposta);
                Txb_NomeCliente.Text = NomeCliente;
                
                
                if (Txb_NomeCliente.Text != "Cliente não encontrado" || Txb_NomeCliente.Text != "")
                {
                    Btn1_Enviar.Enabled = true;

                }

            }
        }

        private void Btn1_Enviar_Click(object sender, EventArgs e)
        {
           
            string Atendente = Cmb_Atendente.SelectedItem.ToString(); 
            string TipoDisparo = CmB_Aviso.SelectedItem.ToString();
            string Tecnico = Cmb_Tecnico.SelectedItem.ToString();
            string Codigo = TxtB_Codigo.Text;
            string NomeCliente = Txb_NomeCliente.Text;
            EmailSender Enviar = new EmailSender();
            try
            {
               
               if (CmB_Aviso.SelectedItem.ToString() == "MIGRAÇÃO DE VELOCIDADE")
                {
                    Enviar.SendEmail(Configuracoes.EmailRemetente, Configuracoes.Email_Destinatario, $"{TipoDisparo} CONLUIDA CLIENTE {Codigo} {NomeCliente} ", $"MIGRAÇÃO REALIZADA DE MANEIRA INCORRETA, NÃO ABERTO SERVIÇO DE MIGRAÇÃO PELA {Tecnico}");
                    MessageBox.Show("E-Mail enviado com sucesso ao Financeiro. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Enviar.SendEmail(Configuracoes.EmailRemetente, Configuracoes.Email_Destinatario, $"{TipoDisparo} CONLUIDA CLIENTE {Codigo} {NomeCliente} ", $"{TipoDisparo} CONCLUIDA PELO TECNICO {Tecnico} JUNTO AO {Atendente} DO SUPORTE TÉCNICO");
                    MessageBox.Show("E-Mail enviado com sucesso ao Financeiro. ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao enviar o email ao Financeiro. {ex.Message}","Falha",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            Btn1_Enviar.Enabled = false;
            
        }

        private void Btn4_Config_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2_ConfiguraçõesAPI>().Count() == 1)
            {
                // Se estiver, mostra o formulário já aberto
                Application.OpenForms.OfType<Form2_ConfiguraçõesAPI>().First().Show();
            }
            else
            {
                // Se não estiver, cria um novo formulário
                Form2_ConfiguraçõesAPI form = new Form2_ConfiguraçõesAPI();
                form.Show();
            }        
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<Form3_Login>().Count() == 1)
            {
                // Se estiver, mostra o formulário já aberto
                Application.OpenForms.OfType<Form3_Login>().First().Show();
            }
            else
            {
                // Se não estiver, cria um novo formulário
                Form3_Login form = new Form3_Login();
                form.Show();
            }
        }
    }
}
