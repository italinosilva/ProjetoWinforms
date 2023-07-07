using AtividadeBanco;

namespace ProjetoWinforms
{
    public partial class TelaAluno : Form
    {
        public TelaAluno()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaAluno_Load(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            var turma = db.BuscarAlunos();

            //Forma 1 de se fazer
            dataGridView1.DataSource = turma;

            //Forma 2 de se fazer
            //foreach (var aluno in turma)
            // {
            // dataGridView1.Rows.Add(
            //aluno.Nome,
            // aluno.Idade,
            //aluno.Cpf,
            //aluno.Curso,
            //aluno.Telefone);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAluno addAluno = new AddAluno();
            addAluno.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    //}
}
