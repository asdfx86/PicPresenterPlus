using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicPresenterPlus
{
    public partial class Form1 : Form
    {
        Form2 frm = new Form2();

        public Form1()
        {
            InitializeComponent();
            // Lagay din kaya tayo ng ListView para drag and drop yung mga pics.
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            // Show the Open File dialog. If the user chooses OK, load the 
            // picture that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Load(openFileDialog1.FileName);
                frm.pictureBox1.Image = this.pictureBox1.Image;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
            if (pictureBox1.Image != null)
                pictureBox1.Image.Dispose(); // For Ram Optimization
            pictureBox1.Image = null;
            frm.pictureBox1.Image = null;
            
        }

        private void bgButton_Click(object sender, EventArgs e)
        {
            // Show the color picker dialog box. If the user chooses OK, change the 
            // PictureBox control's background to the color the user chose. 
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.BackColor = colorDialog1.Color;
                frm.pictureBox1.BackColor = this.pictureBox1.BackColor;
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // If the user selects the Stretch check box,  
            // change the PictureBox's SizeMode property to "Stretch". 
            // If the user clears the check box, change it to "Normal".
            // Choosing Stretch shows the entire image in the available space.          
            if (checkBox1.Checked)
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                frm.pictureBox1.SizeMode = this.pictureBox1.SizeMode;
            }
            else
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                frm.pictureBox1.SizeMode = this.pictureBox1.SizeMode;
            }
        }

        

        private void dsButton_Click(object sender, EventArgs e)
        {
            // Medyo buggy. Pag cinlose mo yung form2, tas pinindot
            // mo to, mag-eerror. (Cannot access disposed object
            // UPDATE: Okay na. frm.Visible, frm IsDisposed -> frm new Form2,
            // then yung frm.show and frm.close na yun. Ayos. Werpa.

            // Additional note: Then will I start to figure out how to show the image
            // from Form1's PictureBox1 to Form2's PictureBox. Then kapag naka stretch
            // yung pic sa form1, dapat nakastretch din dun sa form2.
            // UPDATE: I think I got it. Hahahahaha :)

            /* Next up:
             * - [Check] Borderless Full screen double clicking to on form 2 [done that.]
             * - Top Dual Screen button when already shown but covered by another window.
             * - Context menu (right click) on form2. Workaround: shown form1 on top of form2. */
             
            if (frm.Visible == false)
            {
                if (frm.IsDisposed == true)
                {
                    frm = new Form2();
                }
                frm.pictureBox1.BackColor = this.pictureBox1.BackColor;
                frm.pictureBox1.Image = this.pictureBox1.Image;
                frm.pictureBox1.SizeMode = this.pictureBox1.SizeMode;
                frm.Show();
            }
            // Experimental Code - saka na nga
            else
            {
                frm.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            // this.Hide(); <-- Maya maya saglit lang
        }
    }
}
