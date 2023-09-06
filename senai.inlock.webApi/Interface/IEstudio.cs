using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interface
{
    public interface IEstudio
    {
        void Cadastrar(EstudioDomain NovoEstudio);
        List<EstudioDomain> ListarEstudio();

   
        void Deletar(int IdEstudio);
    }
}
