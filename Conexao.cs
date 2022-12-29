using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV
{
    internal class Conexao
    {
        public string conexao = "SERVER=localhost; DATABASE=pdv; UID=root; PDW=; PORT=3306";

        public MySqlConnection conn = null;

        public void AbrirConexao()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Open();
                //MessageBox.Show("Conexão aberta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir conexão", ex.Message);
                throw;
            }
        }

        public void FecharConexao()
        {
            try
            {
                conn = new MySqlConnection(conexao);
                conn.Close();
                conn.Dispose(); //derruba alguma conexão aberta
                conn.ClearAllPoolsAsync(); //método de limpeza
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fechar conexão", ex.Message);
                throw;
            }
        }
    }
}
