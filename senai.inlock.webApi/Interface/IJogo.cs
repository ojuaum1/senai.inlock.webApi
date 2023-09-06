using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interface
{
    public interface IJogo
    {
        void Cadastrar(JogoDomain NovoJogo);
        List<JogoDomain> ListarEstudio();
        void AtualizarIdCorpo(JogoDomain jogo);

        void AtualizarIdUrl(int id, JogoDomain jogo);

        void Deletar(int Jogo);

        JogoDomain BuscarPorId(int id);
    }
}
