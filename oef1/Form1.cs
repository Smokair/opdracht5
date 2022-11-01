namespace oef1
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smaillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.BackColor = Color.Red;

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Red;

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Green;

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.ForeColor = Color.Blue;

        }

        private void greenBgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.BackColor = Color.Green;

        }

        private void blueBgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputText.BackColor = Color.Blue;

        }

        private void smallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 8,
                    InputText.Font.Style, InputText.Font.Unit);
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 10,
                    InputText.Font.Style, InputText.Font.Unit);
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InputText.Font = Font = new Font(InputText.Font.Name, 12,
                    InputText.Font.Style, InputText.Font.Unit);
        }
    }
}