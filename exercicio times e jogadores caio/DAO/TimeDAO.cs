using exercicio_times_e_jogadores_caio.Models;
using System.Data.SqlClient;
using System.Data;
using System;

namespace exercicio_times_e_jogadores_caio.DAO
{
    public class TimeDAO : PadraoDAO<TimeViewModel>
    {
        protected override SqlParameter[] CriaParametros(TimeViewModel model)
        {
            object logotipo = model.LogotipoTime;
            if (logotipo == null)
                logotipo = DBNull.Value;

            SqlParameter[] parametros =
            {
                new SqlParameter("id", model.Id),
                new SqlParameter("nome", model.Nome),
                new SqlParameter("nome do estadio", model.NomeDoEstadio),
                new SqlParameter("logotipo", logotipo)
            };
            return parametros;
        }

        protected override TimeViewModel MontaModel(DataRow registro)
        {
            TimeViewModel t = new TimeViewModel()
            {
                Id = Convert.ToInt32(registro["id"]),
                Nome = registro["nome"].ToString(),
                NomeDoEstadio = registro["nome do estadio"].ToString()

            };
            if (registro["imagem"] != DBNull.Value)
                t.LogotipoTime = registro["logotipo"] as byte[];
            return t;
        }

        protected override void SetTabela()
        {
            Tabela = "TimeFutebol";
        }
    }
}
