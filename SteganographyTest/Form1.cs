using Axiom.Encryption;
using System.Drawing;

namespace SteganographyTest
{
    public partial class Form1 : Form
    {
        Steganograph graph;

        public Form1()
        {
            InitializeComponent();
        }



        private void saveImage_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save Location";
            saveFileDialog1.AddExtension = true;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                MainImage.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void HT_Click(object sender, EventArgs e)
        {
            MainImage.Image = graph.HideText(MainText.Text);
        }

        private void GT_Click(object sender, EventArgs e)
        {
            MainText.Text = graph.FindHiddenString();
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open Image";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                MainImage.Image = Image.FromFile(openFileDialog1.FileName);
                graph = new Steganograph(MainImage.Image);
                HT.Enabled = true;
                GT.Enabled = true;
                saveImage.Enabled = true;
            }
        }
    }
}