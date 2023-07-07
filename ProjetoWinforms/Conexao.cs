using ProjetoWinforms;
using System.Data.SqlClient;

namespace AtividadeBanco
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=JovemProgramador;MultipleActiveResultSets=true;Data Source=DESKTOP-8C9MJD7\\SQLEXPRESS");

        public void Conectar()
        {
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }

        public bool BuscarUsuario(string usuario, string senha)
        {
            string sql = $"select Usuario from UsuarioSenha where Usuario = '{usuario}' and Senha = '{senha}'";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return false;

        }

        public List<UsuarioDB> NomeUsuario(string usuario, string senha)
        {
            string sql = $"select Nome from UsuarioSenha where Usuario = '{usuario}' and Senha = '{senha}'";
            SqlCommand ordem = new SqlCommand (sql, conn);
            List<UsuarioDB> nome = new List<UsuarioDB>();

            using (var reader = ordem.ExecuteReader())
            {
                while (reader.Read())
                {
                    var nomeDb = reader.GetString(reader.GetOrdinal("Nome"));
                    nome.Add(new UsuarioDB()
                    {
                        Nome = nomeDb,
                    });
                 }
                return nome;
            }
        }

        //Realizar a busca dos alunos no Banco de Dados//
        public List<Aluno> BuscarAlunos()
        {
            string sql = "select Id, Nome, Idade, Cpf, Curso, Telefone from Aluno";
            SqlCommand comando = new SqlCommand(sql, conn);
            List<Aluno> turma = new List<Aluno>();

            using (var reader = comando.ExecuteReader())
            { //cria um leitor do ADO.Net//
                while (reader.Read())
                { //vai lendo cada item do resultado do select//
                  //retorna sob demanda cada item encontrado//
                    var nomeDb = reader.GetString(reader.GetOrdinal("Nome"));
                    var idadeDb = reader.GetInt32(reader.GetOrdinal("Idade"));
                    var cpfDb = reader.GetString(reader.GetOrdinal("Cpf"));
                    var cursoDb = reader.GetString(reader.GetOrdinal("Curso"));
                    var telefoneDb = reader.GetString(reader.GetOrdinal("Telefone"));
                    var idDB = reader.GetInt32(reader.GetOrdinal("Id"));

                    turma.Add(new Aluno()
                    {
                        Nome = nomeDb,
                        Idade = idadeDb,
                        Cpf = cpfDb,
                        Curso = cursoDb,
                        Telefone = telefoneDb,
                        Id = idDB
                    });

                }
                return turma;
            }
        }
        public bool CadastrarAluno(string nome, string cpf, int idade, string curso, string telefone)
       {
            string sql = $"insert into Aluno(Nome, Cpf, Idade, Curso, Telefone) values('{nome}', '{cpf}', {idade}, '{curso}', '{telefone}')";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return true;
        }

    }

}

