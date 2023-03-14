namespace herencia_a_partir_de_un_modelo_de_clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            animal perro = new Perro();
            label1.Text = perro.HacerSonido();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            animal gato = new gato();
            label1.Text =  gato.HacerSonido();
           
        }
    }
}