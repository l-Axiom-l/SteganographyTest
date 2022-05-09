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
            Image img = Bitmap.FromFile(@"C:\Users\momox\Pictures\approved-by-rubber-stamp-picture-id121995689.jpg");
            graph = new Steganograph(img);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            graph.HideText("hi, im Moritz").Save(@"C:\Programmieren\Test\Test.bmp");
        }
    }
}