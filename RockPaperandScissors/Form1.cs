using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperandScissors
{

    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void rock_Click(object sender, EventArgs e)
        {
            bool myimage = true;
            if (myimage)
            {
                displayImage.Image = rock.Image;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resultImage_Click(object sender, EventArgs e)
        {

        }

        private void paper_Click(object sender, EventArgs e)
        {
            bool myimage = true;
            if (myimage)
            {
                displayImage.Image = paper.Image;
            }
        }

        private void scissors_click(object sender, EventArgs e)
        {
            bool myimage = true;
            if (myimage)
            {
                displayImage.Image = scissors.Image;
            }
        }

        private void displayImage_Click(object sender, EventArgs e)
        {


        }

        public void play_click(object sender, EventArgs e)
        {
            Random myPicture = new Random();
            int i = myPicture.Next(1, 4);

            if (displayImage.Image == null)
            {
                MessageBox.Show("Please select an Image", "Image Not Selected");
                return;
            }



            if (i == 1)
                resultImage.Image = rock.Image;
            else if (i == 2)
                resultImage.Image = paper.Image;
            else if (i == 3)
                resultImage.Image = scissors.Image;

            #region Draw Conditions

            //Setting Draw conditions 
            if (resultImage.Image == rock.Image && displayImage.Image == rock.Image)
            {
                MessageBox.Show("It's a Draw", "Draw!");
                myResult.Draw++;
                drawScore.Text = myResult.Draw.ToString();
                
            }

            else if (resultImage.Image == paper.Image && displayImage.Image == paper.Image)
            {
                MessageBox.Show("It's a Draw", "Draw!");
                myResult.Draw++;
                drawScore.Text = myResult.Draw.ToString();
            }
            else if (resultImage.Image == scissors.Image && displayImage.Image == scissors.Image)
            {
                MessageBox.Show("It's a Draw", "Draw!");
                myResult.Draw++;
                drawScore.Text = myResult.Draw.ToString();
            }

            #endregion

            #region Rock
            //Setting conditions for rock
            if (displayImage.Image == rock.Image && resultImage.Image == paper.Image)
            {
                MessageBox.Show("You Loose", "Sorry!");
                myResult.Lost++;
                label14.Text = myResult.Lost.ToString();
            }
            else if (displayImage.Image == rock.Image && resultImage.Image == scissors.Image)
            {
                MessageBox.Show("You Won", "Congrats!");
                myResult.Won++;
                label12.Text = myResult.Won.ToString();
            }
            #endregion


            #region Paper
            //Setting conditions for paper
            if (displayImage.Image == paper.Image && resultImage.Image == rock.Image)
            {
                MessageBox.Show("You Won", "Congrats!");
                myResult.Won++;
                label12.Text = myResult.Won.ToString();
            }
            else if (displayImage.Image == paper.Image && resultImage.Image == scissors.Image)
            {
                MessageBox.Show("You Loose", "Sorry!");
                myResult.Lost++;
                label14.Text = myResult.Lost.ToString();
            }


            #endregion


            #region scissors
            //Setting conditions for scissors
            if (displayImage.Image == scissors.Image && resultImage.Image == rock.Image)
            {
                MessageBox.Show("You Loose", "Sorry!");
                myResult.Lost++;
                label14.Text = myResult.Lost.ToString();
            }
            else if (displayImage.Image == scissors.Image && resultImage.Image == paper.Image)
            {
                MessageBox.Show("You Won", "Congrats!");
                myResult.Won++;
                label12.Text = myResult.Won.ToString();
            }


#endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }

        public class myResult
        {
            public static int Won { get; set; }
            public static int Lost { get; set; }
            public static int Draw { get; set; }
        }

        private void drawScore_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
 











