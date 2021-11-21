using System;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lucas
{
    static class ConexaoSQL
    {
        public static MySqlConnection cn;
        public static string strConexao;
        public static int id;
        public static bool admin;


        public static bool StatusConexao()
        {

            if (cn != null && cn.State == ConnectionState.Open)
                return true;
            else
                return false;

        }

        public static void ResetConexao()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
                cn.Open();
            }

        }

        public static bool Conecta(string Servidor = null, string Base = null, string User = null, string Senha = null)
        {
            if (cn is null)
            {
                cn = new MySqlConnection();

            }

            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }


            if (cn.State == ConnectionState.Closed)
            {
                cn.Close();
                    strConexao = @"Server=" + Servidor + "; Database=" + Base + "; UID=" + User + "; Password=" + Senha + ";";

                cn.ConnectionString = strConexao;
                try
                {
                    cn.Open();
                    return true;
                }

                catch (Exception ex)
                {
                    if (ex is MySqlException)
                    {
                        // Handle more specific SqlException exception here.  
                        MySqlException errSql = (MySqlException)ex;

                        string MessageBoxTitle = "Erro de Conexão";
                        string MessageBoxContent = "";

                        switch (errSql.Number)
                        {
                            case 53:
                                MessageBoxContent = "Servidor Não Localizado";
                                break;
                            case 18456:
                                MessageBoxContent = "Usuário ou Senha Inválido";
                                break;
                            default:

                                MessageBoxContent = "Erro não identificado: " + errSql.Message;
                                break;

                        }
                        DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.OK);
                    }
                    else
                    {
                        // Handle generic ones here.  
                        MessageBox.Show(ex.Message, "Erro não Identificado");
                    }
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public static void SQLCommand(string Query)
        {
            MySqlCommand cmd = new MySqlCommand(Query, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.CommandTimeout = 0;
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SQLCommandLogin(string pnome, string psenha)
        {
            MySqlCommand comando = new MySqlCommand("SELECT id, admin FROM Usuario WHERE nome=@nome AND senha=@senha", cn);
            comando.Parameters.AddWithValue("@nome", pnome);
            comando.Parameters.AddWithValue("@senha", psenha);

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            
            try
            {
                da.Fill(dt);
                id = Convert.ToInt32(dt.Rows[0]["id"]);
                admin = Convert.ToBoolean(dt.Rows[0]["admin"]);
            }

            catch (Exception e)
            {
                if(e is IndexOutOfRangeException)
                {
                    MessageBox.Show("Usuário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static bool SQLCommandCadastroProduto(string prfid, string pnome, decimal pvalor, int pquantidade)
        {
            MySqlCommand comando = new MySqlCommand("CALL InsereProduto(@rfid, @nome, @valor, @quantidade)", cn);
            comando.Parameters.AddWithValue("@rfid", prfid);
            comando.Parameters.AddWithValue("@nome", pnome);
            comando.Parameters.AddWithValue("@valor", pvalor);
            comando.Parameters.AddWithValue("@quantidade", pquantidade);

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            try
            {
                comando.ExecuteNonQuery();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable SQLCommandConsultaEstoque()
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Produto", cn);

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable SQLCommandConsultaEstoque(string prfid)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM Produto WHERE RFID=@rfid", cn);
            comando.Parameters.AddWithValue("@rfid", prfid);

            MySqlDataAdapter da = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static string HashValue(string value)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(value));

            StringBuilder hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }
    }
}
