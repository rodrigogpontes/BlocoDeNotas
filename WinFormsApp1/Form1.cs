using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear(); // Limpa o conteúdo do RichTextBox
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog abrirDialogo = new OpenFileDialog())
            {
                abrirDialogo.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
                if (abrirDialogo.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(abrirDialogo.FileName);
                }
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Clipboard.GetText();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void aRIAL12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial", 12);

        }

        private void bOLD12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Bold", 12);
        }

        private void nEGRITO14ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Negrito", 14);

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            //this.StripStat = new StatusStrip();

        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
