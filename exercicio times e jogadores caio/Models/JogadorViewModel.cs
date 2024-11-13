using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace exercicio_times_e_jogadores_caio.Models
{
    public class JogadorViewModel : PadraoViewModel
    {
        public string Nome;
        public int Posicao;
        public int TimeId;
    }
}
