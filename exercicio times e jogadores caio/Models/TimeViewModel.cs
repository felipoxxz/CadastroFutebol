using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Http;
using System;

namespace exercicio_times_e_jogadores_caio.Models
{
    public class TimeViewModel : PadraoViewModel
    {
        public string Nome;

        public string NomeDoEstadio;


        public IFormFile Imagem { get; set; }
        /// <summary>
        /// Imagem em bytes pronta para ser salva
        /// </summary>
        public byte[] LogotipoTime { get; set; }
        /// <summary>
        /// Imagem usada para ser enviada ao form no formato para ser exibida
        /// </summary>
        public string ImagemEmBase64
        {
            get
            {
                if (LogotipoTime != null)
                    return Convert.ToBase64String(LogotipoTime);
                else
                    return string.Empty;
            }
        }




    }


}
