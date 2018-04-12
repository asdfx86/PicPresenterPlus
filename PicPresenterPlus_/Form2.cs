using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PicPresenterPlus
{
    public partial class Form2 : Form
    {
        // We're gonna move this somewhere else para pati yung PictureBox1 sa Form1 mag double click full screen. So, yeah.
        partial class FullScreen
        {
            public void EnterFullScreenMode(Form targetForm)
            {
                targetForm.WindowState = FormWindowState.Normal;
                targetForm.FormBorderStyle = FormBorderStyle.None;
                targetForm.WindowState = FormWindowState.Maximized;
            }

            public void LeaveFullScreenMode(Form targetForm)
            {
                targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                targetForm.WindowState = FormWindowState.Normal;
            }

            
        }

        bool FullScreenMode;

        public Form2()
        {
            // Next up: Borderless double clicking on form 2, and context menu (right click).
            InitializeComponent();
        }

        
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {  
            FullScreen fullScreen = new FullScreen();

            if (FullScreenMode != true)  // FullScreenMode is an enum
            {
                fullScreen.EnterFullScreenMode(this);
                FullScreenMode = true;
            }
            else
            {
                fullScreen.LeaveFullScreenMode(this);
                FullScreenMode = false;
            }
        }

        // Buggy...
        /*
        private void pictureBox1_DoubleClick(object sender, EventArgs e) // {} Balik natin to mamaya. Yung Form2.Designer.cs , ayusin din.
        {
            bool fullScreen=false;
            if (fullScreen != true)
            {
                fullScreen = true;
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                fullScreen = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
            }
        }
        */
    }
}
