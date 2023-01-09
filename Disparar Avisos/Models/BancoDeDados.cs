using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disparar_Avisos.Models
{
    public class BancoDeDados
    {
        private static BancoDeDados instance;
        private BancoDeDados()
        {

        }
        public static BancoDeDados Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new BancoDeDados();
                }
                return instance;

            }
        }
        public string HostSQL { get; set; }
        public string BancoNomeSQL { get; set; }
        public string UserSQL { get; set; }
        public string PasswordSQL { get; set; }
        public void SalvaConfiguracoesSQL()
        {
            Credenciais Configuracoes = Credenciais.Instance;
            Cripto Criptografa = new Cripto();
            try
            {

                string connectionString = $"Data Source={HostSQL};Initial Catalog={BancoNomeSQL};User ID={UserSQL};Password={PasswordSQL}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {   // Limpa as configurações anteriores antes de salvar 
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("TRUNCATE TABLE Disparo", connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    // Verifica se a primeira linha da tabela "Disparo" já possui algum dado
                    string checkSql = "SELECT COUNT(*) FROM Disparo WHERE ID = 1";
                    SqlCommand checkCommand = new SqlCommand(checkSql, connection);
                    int count = (int)checkCommand.ExecuteScalar();
                    // Se a primeira linha já possui um dado, atualiza o dado existente
                    // Caso contrário, insere um novo dado
                    if (count > 0)
                    {
                        string updateSql = "UPDATE Disparo SET GrantType = @GrantType WHERE ID = 1";
                        SqlCommand updateCommand = new SqlCommand(updateSql, connection);
                        updateCommand.Parameters.AddWithValue("@GrantType", Configuracoes.GrantType);
                        updateCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection))
                        {
                            // Define o nome da tabela de destino
                            bulkCopy.DestinationTableName = "Disparo";
                            bulkCopy.ColumnMappings.Add("ID", "ID");
                            bulkCopy.ColumnMappings.Add("GrantType", "GrantType");
                            bulkCopy.ColumnMappings.Add("UserName", "UserName");
                            bulkCopy.ColumnMappings.Add("ClienteID", "ClienteID");
                            bulkCopy.ColumnMappings.Add("Password", "Password");
                            bulkCopy.ColumnMappings.Add("ClienteSecret", "ClienteSecret");
                            bulkCopy.ColumnMappings.Add("HostAutenticacao", "HostAutenticacao");
                            bulkCopy.ColumnMappings.Add("HostConsulta", "HostConsulta");
                            bulkCopy.ColumnMappings.Add("Remetente", "Remetente");
                            bulkCopy.ColumnMappings.Add("Destinatario", "Destinatario");
                            bulkCopy.ColumnMappings.Add("Senha", "Senha");
                            bulkCopy.ColumnMappings.Add("HostEmail", "HostEmail");

                            // Cria um DataTable com os dados a serem inseridos
                            DataTable dataTable = new DataTable();
                            dataTable.Columns.Add("ID", typeof(int));
                            dataTable.Columns.Add("GrantType", typeof(string));
                            dataTable.Columns.Add("UserName", typeof(string));
                            dataTable.Columns.Add("ClienteID", typeof(string));
                            dataTable.Columns.Add("Password", typeof(string));
                            dataTable.Columns.Add("ClienteSecret", typeof(string));
                            dataTable.Columns.Add("HostAutenticacao", typeof(string));
                            dataTable.Columns.Add("HostConsulta", typeof(string));
                            dataTable.Columns.Add("Remetente", typeof(string));
                            dataTable.Columns.Add("Destinatario", typeof(string));
                            dataTable.Columns.Add("Senha", typeof(string));
                            dataTable.Columns.Add("HostEmail", typeof(string));
                            dataTable.PrimaryKey = new DataColumn[] { dataTable.Columns["ID"] };
                            // Atualiza lista de Destinatarios antes do envio 
                            Form2_ConfiguraçõesAPI Form2 = new Form2_ConfiguraçõesAPI();
                            List<string> lista = Form2.CmbDestinatario.Items.OfType<string>().ToList();
                            Configuracoes.Email_Destinatario = lista;
                            // Criptografa os dados sensiveis antes de salvar no banco
                            string PasswordTemp = Criptografa.Encrypt(Configuracoes.Password, "123"); // SENHA EX
                            string SenhaEmailTemp = Criptografa.Encrypt(Configuracoes.SenhaEmail, "123"); // SENHA EX
                            string ClienteSecretTemp = Criptografa.Encrypt(Configuracoes.ClientSecret, "123"); // SENHA EX
                            //salvando os dados
                            dataTable.Rows.Add(1, Configuracoes.GrantType, Configuracoes.UserName, Configuracoes.ClientID, PasswordTemp,
                            ClienteSecretTemp, Configuracoes.HostAutentica, Configuracoes.HostConsulta,
                            Configuracoes.EmailRemetente, string.Join(",", Configuracoes.Email_Destinatario), SenhaEmailTemp, Configuracoes.HostEmail);

                            // Insere os dados no banco de dados
                            bulkCopy.WriteToServer(dataTable);
                        }
                    }
                }


                MessageBox.Show("Configurações salvadas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar as configurações {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CarregaConfiguracoesSQL()
        {
            Credenciais Configuracoes = Credenciais.Instance;
            string connectionString = $"Data Source={HostSQL};Initial Catalog={BancoNomeSQL};User ID={UserSQL};Password={PasswordSQL}";
            // string selectSql = "SELECT Host Email FROM Disparo Config WHERE Id = 1";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT GrantType, UserName, ClienteID, Password, ClienteSecret, HostAutenticacao, HostConsulta, Remetente, Destinatario, Senha, HostEmail FROM Disparo";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {   

                    Configuracoes.GrantType = reader.GetString(0);
                    Configuracoes.UserName = reader.GetString(1);
                    Configuracoes.ClientID = reader.GetString(2);
                    Configuracoes.Password = reader.GetString(3);
                    Configuracoes.ClientSecret = reader.GetString(4);
                    Configuracoes.HostAutentica = reader.GetString(5);
                    Configuracoes.HostConsulta = reader.GetString(6);
                    Configuracoes.EmailRemetente = reader.GetString(7);
                    Configuracoes.Email_Destinatario.Clear();
                    string destinatario = reader.GetString(8);
                    Configuracoes.Email_Destinatario.AddRange(destinatario.Split(','));
                    Configuracoes.SenhaEmail = reader.GetString(9);
                    Configuracoes.HostEmail = reader.GetString(10);
                }
                connection.Close();

            }

        }
        public void ApagaEmailSQL(object Email)
        {
            string connectionString = $"Data Source={HostSQL};Initial Catalog={BancoNomeSQL};User ID={UserSQL};Password={PasswordSQL}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = $"UPDATE {BancoNomeSQL} SET Destinatario = REPLACE(Destinatario, @pattern, '') WHERE id = @id";
                    command.Parameters.AddWithValue("@pattern", Email);
                    command.Parameters.AddWithValue("@id", 1);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
