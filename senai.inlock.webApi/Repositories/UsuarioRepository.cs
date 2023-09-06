using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interface;
using senai.inlock.webApi.Interfaces;
using System.Data.SqlClient;
using static senai.inlock.webApi.Interface.IUsuario;

namespace senai.inlock.webApi.Repositories
{
    public class UsuarioRepository : IUsuario
    {
        string StringConexao = "Data Source = NOTE07-S15; Initial Catalog = inlock_games; User id = sa; pwd = Senai@134; TrustServerCertificate = true";
        public UsuarioDomain Login(string _email, string _senha)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string stringLogin = "SELECT Email, Senha, Titulo FROM Usuario LEFT JOIN TiposUsuario ON TiposUsuario.IdTipoUsuario = Usuario.IdTipoUsuario WHERE Email = @emailBusca AND Senha = @senhaBusca";

                con.Open();

                using (SqlCommand cmd = new SqlCommand(stringLogin, con))
                {
                    cmd.Parameters.AddWithValue("@emailBusca", _email);
                    cmd.Parameters.AddWithValue("@senhaBusca", _email);

                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            Email = rdr["Email"].ToString(),
                            Senha = rdr["Senha"].ToString(),
                            IdTipoUsuario = new TiposUsuario()
                            {
                                Titulo = rdr["Titulo"].ToString()
                            }
                        };
                        return usuario;
                    }
                    return null;
                }
            }
        }
    }
}