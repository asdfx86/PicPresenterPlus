namespace PicPresenterPlus
{
    partial class NewMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb1_Back2OXP = new System.Windows.Forms.ToolStripButton();
            this.theCHIBOX = new System.Windows.Forms.ToolStripComboBox();
            this.tsb2_OpenPic = new System.Windows.Forms.ToolStripButton();
            this.tsb3_ClearView = new System.Windows.Forms.ToolStripButton();
            this.tsb_DSV = new System.Windows.Forms.ToolStripButton();
            this.tsb4_BgColor = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb1_Back2OXP,
            this.theCHIBOX,
            this.tsb2_OpenPic,
            this.tsb3_ClearView,
            this.tsb_DSV,
            this.tsb4_BgColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb1_Back2OXP
            // 
            this.tsb1_Back2OXP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb1_Back2OXP.Image = ((System.Drawing.Image)(resources.GetObject("tsb1_Back2OXP.Image")));
            this.tsb1_Back2OXP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb1_Back2OXP.Name = "tsb1_Back2OXP";
            this.tsb1_Back2OXP.Size = new System.Drawing.Size(154, 22);
            this.tsb1_Back2OXP.Text = "<-- Back To Old E&xperience";
            this.tsb1_Back2OXP.ToolTipText = "Back To the Old Experience";
            // 
            // theCHIBOX
            // 
            this.theCHIBOX.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.theCHIBOX.DropDownHeight = 200;
            this.theCHIBOX.DropDownWidth = 200;
            this.theCHIBOX.IntegralHeight = false;
            this.theCHIBOX.Name = "theCHIBOX";
            this.theCHIBOX.Size = new System.Drawing.Size(300, 25);
            this.theCHIBOX.Text = "CHI Box";
            this.theCHIBOX.ToolTipText = "Tell me what you wanna do...";
            // 
            // tsb2_OpenPic
            // 
            this.tsb2_OpenPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb2_OpenPic.Image = ((System.Drawing.Image)(resources.GetObject("tsb2_OpenPic.Image")));
            this.tsb2_OpenPic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb2_OpenPic.Name = "tsb2_OpenPic";
            this.tsb2_OpenPic.Size = new System.Drawing.Size(98, 22);
            this.tsb2_OpenPic.Text = "&Open a Picture...";
            this.tsb2_OpenPic.ToolTipText = "Opens a Picture File";
            // 
            // tsb3_ClearView
            // 
            this.tsb3_ClearView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb3_ClearView.Image = ((System.Drawing.Image)(resources.GetObject("tsb3_ClearView.Image")));
            this.tsb3_ClearView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb3_ClearView.Name = "tsb3_ClearView";
            this.tsb3_ClearView.Size = new System.Drawing.Size(76, 22);
            this.tsb3_ClearView.Text = "&Clear Screen";
            this.tsb3_ClearView.ToolTipText = "Clears the Screen";
            // 
            // tsb_DSV
            // 
            this.tsb_DSV.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_DSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_DSV.Image = ((System.Drawing.Image)(resources.GetObject("tsb_DSV.Image")));
            this.tsb_DSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DSV.Name = "tsb_DSV";
            this.tsb_DSV.Size = new System.Drawing.Size(98, 22);
            this.tsb_DSV.Text = "Program Output";
            this.tsb_DSV.ToolTipText = "Dual Screen Output View";
            // 
            // tsb4_BgColor
            // 
            this.tsb4_BgColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb4_BgColor.Image = ((System.Drawing.Image)(resources.GetObject("tsb4_BgColor.Image")));
            this.tsb4_BgColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb4_BgColor.Name = "tsb4_BgColor";
            this.tsb4_BgColor.Size = new System.Drawing.Size(135, 22);
            this.tsb4_BgColor.Text = "Set &Background Color...";
            this.tsb4_BgColor.ToolTipText = "Sets the Background Color";
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Experience Preview - PicPresenter+ 2023";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb1_Back2OXP;
        private System.Windows.Forms.ToolStripComboBox theCHIBOX;
        private System.Windows.Forms.ToolStripButton tsb2_OpenPic;
        private System.Windows.Forms.ToolStripButton tsb3_ClearView;
        private System.Windows.Forms.ToolStripButton tsb_DSV;
        private System.Windows.Forms.ToolStripButton tsb4_BgColor;
    }
}