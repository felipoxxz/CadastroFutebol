using System.Data.SqlClient;

namespace exercicio_times_e_jogadores_caio.DAO
{
   
        public static class ConexaoBD
        {
            public static SqlConnection GetConexao()
            {
                string strCon = "Data Source=LOCALHOST;Initial Catalog=AULADB;user id=sa; password=123456";
                SqlConnection conexao = new SqlConnection(strCon);
                conexao.Open();
                return conexao;
            }
        }
    
}
