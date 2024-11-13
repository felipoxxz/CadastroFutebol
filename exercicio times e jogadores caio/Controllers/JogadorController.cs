using exercicio_times_e_jogadores_caio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;
using exercicio_times_e_jogadores_caio.DAO;

namespace exercicio_times_e_jogadores_caio.Controllers
{
    public class JogadorController : PadraoController<JogadorViewModel>
    {
        public JogadorController()
        {
            DAO = new JogadorDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(JogadorViewModel jogador, string operacao)
        {
    


            if (string.IsNullOrEmpty(jogador.Nome))
                ModelState.AddModelError("Nome", "Preencha o nome.");

            if (jogador.TimeId <= 0)
                ModelState.AddModelError("CidadeId", "Informe o código da cidade.");
        }

        protected override void PreencheDadosParaView(string Operacao, JogadorViewModel model)
        {
            PreparaListaCidadesParaCombo();
        }

        private void PreparaListaCidadesParaCombo()
        {
            PosicaoDAO cidadeDao = new PosicaoDAO();
            var cidades = cidadeDao.Listagem();
            List<SelectListItem> listaCidades = new List<SelectListItem>();

            listaCidades.Add(new SelectListItem("Selecione uma cidade...", "0"));
            foreach (var cidade in cidades)
            {
                SelectListItem item = new SelectListItem(cidade.Nome, cidade.Id.ToString());
                listaCidades.Add(item);
            }
            ViewBag.Cidades = listaCidades;
        }
    }
}

