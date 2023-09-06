using senai.inlock.webApi.Domains;
using senai.inlock.webApi.Interface;
using System.Data.SqlClient;

namespace senai.inlock.webApi.Repositories
{
    public class EstudioRepository : IEstudio
    {
        private string StringConexao = "Data Source = note03-s15; Initial Catalog = inlock_games; User Id = sa; pwd = Senai@134; TrustServerCertificate = true";

        public void Cadastrar(EstudioDomain NovoEstudio)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string stringPost = "INSERT INTO (Nome) VALUES(@Nome)";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(stringPost, con))
                {
                    cmd.Parameters.AddWithValue("@Nome", NovoEstudio.Nome);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Deletar(int IdEstudio)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string stringDelete = "DELETE FROM Estudio WHERE IdEstudio = @IdEstudio";
                con.Open();
                using (SqlCommand cmd = new SqlCommand(stringDelete, con))
                {
                    cmd.Parameters.AddWithValue("@IdEstudio", IdEstudio);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<EstudioDomain> ListarEstudio()
        {
            List<EstudioDomain> listaFilme = new List<EstudioDomain>();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string stringQuery = "SELECT IdEstudio,Nome.Estudio ";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(stringQuery, con))
                {
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        EstudioDomain estudio = new EstudioDomain()
                        {
                            IdEstudio = Convert.ToInt32(rdr["IdEstudio"]),

                            Nome = rdr["Nome"].ToString(),


                        };

                        listaFilme.Add(estudio);
                    }
                }
            }
            return ListarEstudio();
        }

    }
}
