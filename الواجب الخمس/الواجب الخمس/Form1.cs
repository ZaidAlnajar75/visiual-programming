using System.Windows.Forms;

namespace الواجب_الخمس
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            rtextEditor.SelectionFont = fontDialog1.Font;
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rtextEditor.SelectionColor = colorDialog1.Color;
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtextEditor.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtextEditor.Paste();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtextEditor.Copy();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            openFileDialog1.ShowDialog();
        }
    }
}