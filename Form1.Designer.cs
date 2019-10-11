namespace Slide_Show
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.slidePic1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btNext = new System.Windows.Forms.Button();
            this.btPrevius = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btSlideShow = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.slidePic1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 68);
            this.panel1.TabIndex = 0;
            // 
            // slidePic1
            // 
            this.slidePic1.Image = ((System.Drawing.Image)(resources.GetObject("slidePic1.Image")));
            this.slidePic1.Location = new System.Drawing.Point(0, 0);
            this.slidePic1.Name = "slidePic1";
            this.slidePic1.Size = new System.Drawing.Size(103, 68);
            this.slidePic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slidePic1.TabIndex = 0;
            this.slidePic1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btSlideShow);
            this.panel2.Controls.Add(this.btNext);
            this.panel2.Controls.Add(this.btPrevius);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 57);
            this.panel2.TabIndex = 1;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(452, 20);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(75, 23);
            this.btNext.TabIndex = 2;
            this.btNext.Text = ">>";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btPrevius
            // 
            this.btPrevius.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btPrevius.Location = new System.Drawing.Point(255, 20);
            this.btPrevius.Name = "btPrevius";
            this.btPrevius.Size = new System.Drawing.Size(75, 23);
            this.btPrevius.TabIndex = 1;
            this.btPrevius.Text = "<<";
            this.btPrevius.UseVisualStyleBackColor = true;
            this.btPrevius.Click += new System.EventHandler(this.btPrevius_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.slidePic);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 385);
            this.panel3.TabIndex = 1;
            // 
            // slidePic
            // 
            this.slidePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slidePic.Image = ((System.Drawing.Image)(resources.GetObject("slidePic.Image")));
            this.slidePic.Location = new System.Drawing.Point(0, 0);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(796, 385);
            this.slidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.slidePic.TabIndex = 0;
            this.slidePic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btSlideShow
            // 
            this.btSlideShow.Location = new System.Drawing.Point(352, 20);
            this.btSlideShow.Name = "btSlideShow";
            this.btSlideShow.Size = new System.Drawing.Size(75, 23);
            this.btSlideShow.TabIndex = 3;
            this.btSlideShow.Text = "||";
            this.btSlideShow.UseVisualStyleBackColor = true;
            this.btSlideShow.Click += new System.EventHandler(this.btSlideShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(796, 510);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Picture slideshow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox slidePic1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btPrevius;
        private System.Windows.Forms.Button btSlideShow;
    }
}

