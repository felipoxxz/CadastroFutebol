using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Reflection.Emit;
using exercicio_times_e_jogadores_caio.Models;

namespace exercicio_times_e_jogadores_caio.DAO
{
    public class PosicaoDAO : PadraoDAO<PosicaoViewModel>
    {
      
            protected override SqlParameter[] CriaParametros(PosicaoViewModel model)
            {
              
                SqlParameter[] parametros =
                {
                new SqlParameter("id", model.Id),
                new SqlParameter("nome", model.Nome),
                
            };
                return parametros;
            }

            protected override PosicaoViewModel MontaModel(DataRow registro)
            {
               PosicaoViewModel p = new PosicaoViewModel()
                {
                    Id = Convert.ToInt32(registro["id"]),
                    Nome = registro["nome"].ToString()

                };

                return p;
            }

            protected override void SetTabela()
            {
                Tabela = "posicoes";
            }
        }
    }
