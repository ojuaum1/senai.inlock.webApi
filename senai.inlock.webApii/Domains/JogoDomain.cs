using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class JogoDomain
    {
        public int IdJogo {get; set;}
        
        [Required(ErrorMessage = "o nome do jogo e obrigatorio")]
        public string Nome { get; set;}

        public string Descricao { get; set;}

        public int DataLancamento { get; set;}

        [Required(ErrorMessage = "o valor e obrigatorio")]
        public string Valor { get;}
    }
}
