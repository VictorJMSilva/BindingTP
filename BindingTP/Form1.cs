using BLL;

namespace BindingTP
{
    public partial class Model : Form
    {

        public Repositorio Repositorio { get; set; } = new Repositorio();
        public Model()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsListaTel.DataSource = Repositorio;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente _nomes = new Cliente();
            _nomes.Nome = "Cliente exemplo";

            _nomes.Nome = "Digite seu nome";
            _nomes.Endereco = "Digite seu endereço";
            _nomes.Telefone = "xxxx-xxxx";

            Repositorio.Incluir(_nomes);
            bsListaTel.ResetBindings(false);
        }

        private void bsListaTel_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}