using AtividadeBanco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWinforms
{
    public partial class AddAluno : Form
    {
        public AddAluno()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            Aluno aluno = new Aluno();
            aluno.Nome = textBox1.Text;
            aluno.Idade = int.Parse(textBox2.Text);
            aluno.Cpf = textBox3.Text;
            aluno.Curso = textBox4.Text;
            aluno.Telefone = textBox5.Text;

            UsuarioDB usuarioDB = new UsuarioDB();

            var retorno = db.CadastrarAluno(aluno.Nome, aluno.Cpf, aluno.Idade, aluno.Curso, aluno.Telefone);

            if (!retorno)
                MessageBox.Show("Erro ao cadastrar SepAluno(a) :(");

            if (retorno)
                MessageBox.Show($"SepAluno(a) cadastrado(a) com sucesso! :)");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void AddAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
