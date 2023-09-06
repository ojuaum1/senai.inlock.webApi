using senai.inlock.webApi.Domains;

namespace senai.inlock.webApi.Interface
{
    public interface IJogo
    {
        void Cadastrar(JogoDomain NovoJogo);
        List<JogoDomain> ListarEstudio();
    }
}
