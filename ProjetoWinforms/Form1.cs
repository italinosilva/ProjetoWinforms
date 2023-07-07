using AtividadeBanco;

namespace ProjetoWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            UsuarioDB usuarioDB = new UsuarioDB();
            usuarioDB.Usuario = textBox1.Text;
            usuarioDB.Senha = textBox2.Text;

            var retorno = db.BuscarUsuario(usuarioDB.Usuario, usuarioDB.Senha);

            var nome = db.NomeUsuario(usuarioDB.Usuario, usuarioDB.Senha);

            string pessoa = " ";

            foreach (var item in nome)
            {
                pessoa = item.Nome;
            }

            if (!retorno)
                MessageBox.Show("Senha ou Usuário incorretos");

            if (retorno)
            {
                MessageBox.Show($"Olá {pessoa}!");

                textBox1.Clear();
                textBox2.Clear();

                TelaAluno telaAluno = new TelaAluno();
                telaAluno.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Redefina_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}