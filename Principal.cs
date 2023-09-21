
using ReaLTaiizor.Forms;
namespace projeto4
{
    public partial class Principal : MaterialForm
    {
        public static bool isOpenAluno = false;
        public static bool isOpenProfessor = false;
        public static bool isOpenCurso = false;
        public static bool isOpenRelatorioAluno = false;
        public static bool isOpenRelatorioProfessor = false;
        public static bool isOpenRelatorioCurso = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cadastroDeAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOpenAluno)
            {
                FormAluno formAluno = new FormAluno();
                formAluno.MdiParent = this;
                isOpenAluno= true;
                formAluno.Show();
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOpenProfessor)
            {
                FormProfessor formProfessor = new FormProfessor();
                formProfessor.MdiParent = this;
                isOpenProfessor = true;
                formProfessor.Show();
            }
        }

        private void cadastroCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOpenCurso)
            {
                FormCurso formCurso = new FormCurso();
                formCurso.MdiParent = this;
                isOpenCurso = true;
                formCurso.Show();
            }
        }

        
        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isOpenRelatorioAluno)
            {
                var formRelAluno = new FormRelatorioAluno();
                formRelAluno.MdiParent = this;
                isOpenRelatorioAluno = true;
                formRelAluno.Show();
            }
        }
    }
}