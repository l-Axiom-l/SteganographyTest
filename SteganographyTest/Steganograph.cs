using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Numerics;

namespace Axiom.Encryption
{
    class Steganograph
    {
        Image SourceImage;
        Image FinalImage;
        Bitmap map;

        List<Vector2> Coordinates;

        public Steganograph(Image image)
        {
            SourceImage = image;
            map = new Bitmap(image);
            Start();
        }

        public Steganograph(Bitmap bitmap)
        {
            map = bitmap;
            SourceImage = bitmap;
            Start();
        }

        void Start()
        {
            Coordinates = GetCoordinates(SourceImage);
        }

        public Image HideText(string Text)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(Text);
            int[] temp = BinaryConverter(bytes);

            for (int i = 0; i < temp.Length; i++)
            {
                Vector2 vector = Coordinates[i];
                Color color = map.GetPixel((int)vector.X, (int)vector.Y);
                int[] colorBytes = BinaryConverter(color.G);
                colorBytes[6] = temp[i];
                byte test = BinaryConverter(colorBytes);
                color = Color.FromArgb(color.R, test, color.B);
                map.SetPixel((int)vector.X, (int)vector.Y, color);
            }
            return map;
        }

        public void HideImage(Image ImageToHide)
        {

        }

        public void SaveImage(string Path)
        {

        }

        public Image GetImage()
        {
            return FinalImage;
        }

        //public Image FindHiddenImage()
        //{
        //    Image temp;

        //    return temp;
        //}

        //public string FindHiddenString()
        //{
        //    string temp;

        //    return temp;
        //}

        List<Vector2> GetCoordinates(Image image)
        {
            List<Vector2> temp = new List<Vector2>();

            for (int w = 0; w < image.Width; w++)
                for (int h = 0; h < image.Height; h++)
                {
                    temp.Add(new Vector2(w, h));
                }
            return temp;
        }

        int[] BinaryConverter(byte[] array)
        {
            List<int> result = new List<int>();
            foreach (byte b in array)
            {
                char[] temp = Convert.ToString(b, 2).PadLeft(1, '0').ToCharArray();
                Array.ForEach(temp, x => result.Add(Convert.ToInt32(x) - 48));
            }
            return result.ToArray();
        }

        int[] BinaryConverter(byte b)
        {
            List<int> result = new List<int>();
            char[] temp = Convert.ToString(b, 2).PadLeft(1, '0').ToCharArray();
            Array.ForEach(temp, x => result.Add(Convert.ToInt32(x) - 48));
            return result.ToArray();
        }

        byte BinaryConverter(int[] array)
        {
            string temp = "";
            foreach (int i in array)
                temp += i.ToString();

            return Convert.ToByte(temp, 2);
        }
    }
}
