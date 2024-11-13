using System.Data;
using System.Reflection.Emit;
using System;
using exercicio_times_e_jogadores_caio.DAO;
using exercicio_times_e_jogadores_caio.Models;
using System.Data.SqlClient;

namespace exercicio_times_e_jogadores_caio.DAO
{
    public class JogadorDAO : PadraoDAO<JogadorViewModel>
    {
         
        protected override SqlParameter[] CriaParametros(JogadorViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", model.Id);
            parametros[1] = new SqlParameter("nome", model.Nome);
            parametros[2] = new SqlParameter("timeId", model.TimeId);
            parametros[3] = new SqlParameter("posicao", model.Posicao);
            return parametros;
        }
        protected override JogadorViewModel MontaModel(DataRow registro)
        {
            JogadorViewModel j = new JogadorViewModel();
            j.Id = Convert.ToInt32(registro["id"]);
            j.Nome = registro["nome"].ToString();
            j.TimeId = Convert.ToInt32(registro["timeId"]);
            j.Posicao = Convert.ToInt32(registro["posicao"]);
            
            return j;
        }
        protected override void SetTabela()
        {
            Tabela = "jogadores";
        }
    }
}

