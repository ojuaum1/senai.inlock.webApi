using System.ComponentModel.DataAnnotations;

namespace senai.inlock.webApi.Domains
{
    public class EstudioDomain
    {
        public int IdEstudio { get; set; }

        [Required(ErrorMessage = "o nome do estudio e obrigatorio")]
        public string Nome { get; set; }
    }
}
