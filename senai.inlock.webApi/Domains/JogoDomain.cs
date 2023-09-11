using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace senai.inlock.webApi.Domains
{
    public class JogoDomain
    {
        public int IdJogo {get; set;}
        
        [Required(ErrorMessage = "o nome do jogo e obrigatorio")]

        public int IdEstudio { get; set;}
        public string Nome { get; set;}

        public string Descricao { get; set;}

        public DateTime DataLancamento { get; set;}

        [Required(ErrorMessage = "o valor e obrigatorio")]
        public double Valor { get; set; }

        public EstudioDomain Estudio { get; set;}
    }
}
