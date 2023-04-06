using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Data.SqlClient;
using Disparar_Avisos.Models;

namespace Disparar_Avisos
{
    public partial class Form3_Login : Form
    {
        BancoDeDados ConfigSQL = BancoDeDados.Instance;
        bool LoginSucesso;
       
        public Form3_Login()
        {   
            InitializeComponent();
            BordasArredondadas.SetBorderlessStyle(this);
            DraggableWindow draggable = new DraggableWindow(this);

            Form4_ConfigSQL ConfiguSQL = new Form4_ConfigSQL();
            kryptonLabel2.Font = new Font("Arial", 250, FontStyle.Bold);
            // Obtém o tamanho da PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;

            // Cria um GraphicsPath para desenhar a região da PictureBox
            GraphicsPath path = new GraphicsPath();

            // Adiciona um círculo ao GraphicsPath
            path.AddEllipse(0, 0, width, height);

            // Define a região da PictureBox como o círculo criado
            pictureBox1.Region = new Region(path);
        }


        private void Btn4_ConfigSQL_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form4_ConfigSQL>().Count() == 1)
            {
                // Se estiver, mostra o formulário já aberto
                Application.OpenForms.OfType<Form4_ConfigSQL>().First().Show();
            }
            else
            {
                // Se não estiver, cria um novo formulário
                Form4_ConfigSQL form = new Form4_ConfigSQL();
                form.Show();
            }
        }
        private void Login()
        {
            
          string connectionString = $"Data Source={ConfigSQL.HostSQL};Initial Catalog={ConfigSQL.BancoNomeSQL};User ID={TxtB_UserSQL.Text};Password={TxB_PasswordSQL.Text}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    ConfigSQL.PasswordSQL = TxB_PasswordSQL.Text;
                    ConfigSQL.UserSQL = TxtB_UserSQL.Text;
                    LoginSucesso = true;
                    

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    LoginSucesso = false;
                }
            }
         
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Btn_Login.Enabled = false;
            if (!BackgroundWorker1.IsBusy)
                BackgroundWorker1.RunWorkerAsync();
            else
                BackgroundWorker1.CancelAsync();
        }


        private void BackgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Login();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Btn_Login.Enabled = true;
            if (LoginSucesso == true)
            {
             
                if (Application.OpenForms.OfType<Form1>().Count() == 1)
                {
                    // Se estiver, mostra o formulário já aberto
                    
                    ActiveForm.Hide();
                    Application.OpenForms.OfType<Form1>().First().Show();
                }
                else
                {
                    // Se não estiver, cria um novo formulário
                    Form1 form = new Form1();
                    ActiveForm.Hide(); ;
                    form.Show();
                }
            }
            else
            {
                MessageBox.Show("Login não autorizado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
