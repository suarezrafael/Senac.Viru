namespace Viru
{
    public partial class Form1 : Form
    {
        // variavel randomica
        // gerar numero aleatorios
        Random random = new Random();

        private void MoverMouse()
        {
            //pegar a largura e altura da tela
            int largura = Screen.PrimaryScreen.Bounds.Width;
            // pegar a largura e altura da tela
            int altura = Screen.PrimaryScreen.Bounds.Height;
            int posicaoX = random.Next(largura);
            int posicaoY = random.Next(altura);

            // altera a posicao do mouse com a nova coodenada
            Cursor.Position = new Point(posicaoX, posicaoY);
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < 1000; x++)
            {
                MoverMouse();
                Thread.Sleep(10);
            }
        }
    }
}
