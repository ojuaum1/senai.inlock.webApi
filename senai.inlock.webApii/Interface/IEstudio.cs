using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interface
{
    public interface IEstudio
    {
        void Cadastrar(EstudioDomain NovoEstudio);
        List<EstudioDomain> ListarEstudio();

        void AtualizarIdCorpo(EstudioDomain estudio);

        void AtualizarIdUrl(int id, EstudioDomain estudio);

        void Deletar(int IdEstudio);

        EstudioDomain BuscarPorId(int id);
    }
}
