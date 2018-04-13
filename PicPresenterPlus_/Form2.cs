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
                targetForm.Text = "PicPresenter Full Screen View";
            }

            public void LeaveFullScreenMode(Form targetForm)
            {
                targetForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                targetForm.WindowState = FormWindowState.Normal;
                targetForm.Text = "PicPresenter Dual Screen View";
            }

            
        }

        bool FullScreenMode;

        public Form2()
        {
            /* Done: 
             *  - Borderless fullscreen double clicking on form 2
             *  - (Context menu) Right click, show Form1 on top. 
             */
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

        // Achievent Unlocked.! Yay~
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (MouseButtons)
            {
                case MouseButtons.Right:
                    Application.OpenForms["Form1"].BringToFront();
                    break;
            }
        }
    }
}
