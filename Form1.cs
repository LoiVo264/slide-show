using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int imageNumber1 = 1;
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if( imageNumber== 11)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void LoadNextImageMin()
        {
            if (imageNumber1 == 11)
            {
                imageNumber1 = 1;
            }
            slidePic1.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber1);
            imageNumber1++;
        }

        private void btPrevius_Click(object sender, EventArgs e)
        {
            if (imageNumber == 0)
            {
                imageNumber = 10;
            }
            slidePic.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber--;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (imageNumber == 11)
            {
                imageNumber = 1;

                }
            slidePic.ImageLocation = string.Format(@"images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void btSlideShow_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImageMin();
            LoadNextImage();
        }

        
    }
}
