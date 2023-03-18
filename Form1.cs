namespace Control_Inventario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labRecCont_Click(object sender, EventArgs e)
        {
            FormRecCont frm = new FormRecCont();
            frm.Show();
            this.Hide();

        }
    }
}