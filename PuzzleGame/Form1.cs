//Akash Singh
//RollNo:1805086
//Puzzel Game


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    { 
        //declaration of variable
        Point EmptyPoint;
        ArrayList images = new ArrayList();   //Array for image
        public Form1()
        {
            EmptyPoint.X = 180;             //for swaping 
            EmptyPoint.Y = 180;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)  //click event on Start Button
        {
            foreach (Button b in panel1.Controls)
                b.Enabled = true;
            
            Image orginal = Image.FromFile(@"C:\Users\dell\Downloads\img1.png");   //Image from Computer memory

            cropImageTomages(orginal, 270, 270);     //Crop the image according to Panel

            AddImagesToButtons(images);     //calling of method that is for Suffling and make an enter
        }

        private void AddImagesToButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };

            arr = suffle(arr);

            foreach (Button b in panel1.Controls)
            {
                if (i < arr.Length)
                {
                    b.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }

        private int[] suffle(int[] arr)       //Every time Image suffle randomly
        {
            Random rand = new Random();
            arr = arr.OrderBy(x => rand.Next()).ToArray();
            return arr;
        }

        //method that crop the selected image with equal size of panal
        private void cropImageTomages(Image orginal, int w, int h)  
        {
            Bitmap bmp = new Bitmap(w, h);

            Graphics graphic = Graphics.FromImage(bmp);

            graphic.DrawImage(orginal, 0, 0, w, h);

            graphic.Dispose();

            int movr = 0, movd = 0;

            for (int x = 0; x < 8; x++)          //looop for moving 
            {
                Bitmap piece = new Bitmap(90, 90);  //Split the image with equal size of a button i.e 90,90  

                for (int i = 0; i < 90; i++)
                    for (int j = 0; j < 90; j++)
                        piece.SetPixel(i, j,
                            bmp.GetPixel(i + movr, j + movd));

                images.Add(piece);

                movr += 90;

                if (movr == 270)
                {
                    movr = 0;
                    movd += 90;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)     //Move the image at empty side
        {
            MoveButton((Button)sender);
        }

        private void MoveButton(Button btn)
        {
            // condition for moving X axis or Y axis where the Empty place is.
            if (((btn.Location.X == EmptyPoint.X - 90 || btn.Location.X == EmptyPoint.X + 90) 
                && btn.Location.Y == EmptyPoint.Y)
                || (btn.Location.Y == EmptyPoint.Y - 90 || btn.Location.Y == EmptyPoint.Y + 90)
                && btn.Location.X == EmptyPoint.X)
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            if (EmptyPoint.X == 180 && EmptyPoint.Y == 180)
                CheckValid();
        }

        private void CheckValid()
        {
            int count = 0, index;
            foreach (Button btn in panel1.Controls)
            {
                index = (btn.Location.Y / 90) * 3 + btn.Location.X / 90;
                if (images[index] == btn.Image)
                    count++;
            }
            if (count == 8)
                MessageBox.Show("well done you win!");      //when you complete the game
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
// End the Game