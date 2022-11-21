namespace jetstudio
{
    partial class Form1
    {
        private System.Drawing.Point point = System.Drawing.Point.Empty;
        private System.Drawing.Image buttonimage = null;
        private int buttonstate = 0;
        private System.Windows.Forms.UserControl closebutton = null;
        private System.Windows.Forms.UserControl menubar = null, menu1 = null;
        private System.Windows.Forms.UserControl musicbackcontrol= null;
        private System.Windows.Forms.UserControl menucontent1 = null;
        private System.Windows.Forms.UserControl menu1item1 = null;
        private System.Windows.Forms.Label copyright = null;

        private System.Windows.Forms.UserControl musicbox = null, mainbutton = null;

        private WMPLib.WindowsMediaPlayer wmediaplayer = null;
        private System.Windows.Forms.OpenFileDialog openfiledialog = null;
        
        protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e)
        {
            if (this.menucontent1.Visible)
            {
                this.menucontent1.Visible = false;
            }
            base.OnMouseClick(e);
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (e.X > 0 && e.X < this.Width && e.Y > 0 && e.Y < 32)
                {
                    this.Location = new System.Drawing.Point(this.Left + e.X - point.X,
                        this.Top + e.Y - point.Y);
                }
            }
            base.OnMouseMove(e);
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.X > 0 && e.X < this.Width && e.Y > 0 && e.Y < 32)
            {
                point = new System.Drawing.Point(e.X, e.Y);
                this.Cursor = System.Windows.Forms.Cursors.SizeAll;
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            if (e.X > 0 && e.X < this.Width && e.Y > 0 && e.Y < 32)
            {
                point = System.Drawing.Point.Empty;
                this.Cursor = System.Windows.Forms.Cursors.Default;
            }
            base.OnMouseUp(e);
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(0, 0,
                this.Width, 40), System.Drawing.Color.FromArgb(66, 66, 66), System.Drawing.Color.FromArgb(26, 26, 26),
                System.Drawing.Drawing2D.LinearGradientMode.Vertical), new System.Drawing.Rectangle(0, 0, this.Width, 40));

            e.Graphics.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(0, 40,
                  10, this.Height-32), System.Drawing.Color.FromArgb(66, 66, 66), System.Drawing.Color.FromArgb(26, 26, 26),
                System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal), new System.Drawing.Rectangle(0, 40, 10, this.Height-40));


            e.Graphics.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(this.Width-10, 40,
                  this.Width-10+10, this.Height - 40), System.Drawing.Color.FromArgb(66, 66, 66), System.Drawing.Color.FromArgb(26, 26, 26),
                System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal), new System.Drawing.Rectangle(this.Width - 10, 40,
                  this.Width - 10 + 10, this.Height - 40));

            e.Graphics.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(10, this.Height-10,
                this.Width / 2, this.Height - 10 + 10), System.Drawing.Color.FromArgb(66, 66, 66), System.Drawing.Color.FromArgb(26, 26, 26),
              System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal), new System.Drawing.Rectangle(10, this.Height-10,
                this.Width/2, this.Height - 10+10));


            e.Graphics.FillRectangle(new System.Drawing.Drawing2D.LinearGradientBrush(new System.Drawing.Rectangle(this.Width / 2, this.Height - 10,
                this.Width / 2-20, this.Height - 10 + 10), System.Drawing.Color.FromArgb(66, 66, 66), System.Drawing.Color.FromArgb(26, 26, 26),
              System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal), new System.Drawing.Rectangle(this.Width / 2, this.Height - 10,
                this.Width / 2-9, this.Height - 10 + 10));

            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(40, System.Drawing.Color.White)),
                new System.Drawing.Rectangle(1, 1, this.Width - 2, 19));

            e.Graphics.DrawLine(new System.Drawing.Pen(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(80, 80, 80))),
                new System.Drawing.Point(10, 40), new System.Drawing.Point(this.Width - 10, 40));

            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(28, 28, 28)), 
                new System.Drawing.Rectangle(10, 40, this.Width - 20,
                this.Height - 50));

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.DrawString(global::jetstudio.Properties.Resources.title_text, new System.Drawing.Font("Gill Sans MS", 12.0f,
                 System.Drawing.FontStyle.Regular), new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(230, System.Drawing.Color.FromArgb(255, 255, 255))),
                 new System.Drawing.PointF(280, 10));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;

            e.Graphics.DrawImage(new System.Drawing.Bitmap(global::jetstudio.Properties.Resources.jetstudio, new System.Drawing.Size(22, 22)),
                new System.Drawing.Point(10, 10));
            e.Graphics.Dispose();

            base.OnPaint(e);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
          this.Size = new System.Drawing.Size(799, 599);
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.BackColor = System.Drawing.Color.Black;
          this.Cursor = System.Windows.Forms.Cursors.Default;
          this.ShowIcon = false;
          this.menubar = new System.Windows.Forms.UserControl();
          this.menubar.Location = new System.Drawing.Point(10, 40);
          this.menubar.Size = new System.Drawing.Size(779, 20);
          this.menubar.Paint += new System.Windows.Forms.PaintEventHandler(this.menubar_Paint);

          this.menu1 = new System.Windows.Forms.UserControl();
          this.menu1.Location = new System.Drawing.Point(0, 0);
          this.menu1.Size = new System.Drawing.Size(50, 20);
          this.menu1.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
          this.menu1.ForeColor = System.Drawing.Color.White;
          this.menu1.Font = System.Drawing.SystemFonts.MenuFont;
          this.menu1.Paint += new System.Windows.Forms.PaintEventHandler(this.menu1_Paint);
          this.menu1.MouseHover += new System.EventHandler(this.menu1_MouseHover);
          this.menu1.MouseLeave += new System.EventHandler(this.menu1_MouseLeave);
          this.menu1.Click += new System.EventHandler(this.menu1_Click);
          this.menu1.Cursor = System.Windows.Forms.Cursors.Hand;

          this.musicbackcontrol = new System.Windows.Forms.UserControl();
          this.musicbackcontrol.Size = new System.Drawing.Size(128, 128);
          this.musicbackcontrol.Location = new System.Drawing.Point((this.Width-this.musicbackcontrol.Width)/2,
                (this.Height-this.musicbackcontrol.Height)/2);
          this.musicbackcontrol.BackColor = System.Drawing.Color.Transparent;
          this.musicbackcontrol.BackgroundImage = global::jetstudio.Properties.Resources.playerback;

          this.menucontent1 = new System.Windows.Forms.UserControl();
          this.menucontent1.Location = new System.Drawing.Point(15, 63);
          this.menucontent1.Size = new System.Drawing.Size(160, 20);
          this.menucontent1.Paint += new System.Windows.Forms.PaintEventHandler(this.menucontent1_Paint);
          this.menucontent1.Visible = false;


          this.menu1item1 = new System.Windows.Forms.UserControl();
          this.menu1item1.Location = new System.Drawing.Point(0, 0);
          this.menu1item1.Size = new System.Drawing.Size(160, 20);
          this.menu1item1.BackColor = System.Drawing.Color.Transparent;
          this.menu1item1.Cursor = System.Windows.Forms.Cursors.Hand;
          this.menu1item1.ForeColor = System.Drawing.Color.White;
          this.menu1item1.Paint += new System.Windows.Forms.PaintEventHandler(this.menu1item1_Paint);
          this.menu1item1.MouseHover += new System.EventHandler(this.menu1item1_MouseHover);
          this.menu1item1.MouseLeave += new System.EventHandler(this.menu1item1_MouseLeave);
           this.menu1item1.Click += new System.EventHandler(this.menu1item1_Click);

        
         
          this.menucontent1.Controls.Add(this.menu1item1);
   

          this.musicbox = new System.Windows.Forms.UserControl();
          this.musicbox.Location = new System.Drawing.Point(10, 449);
          this.musicbox.Size = new System.Drawing.Size(779, 130);
          this.musicbox.BackColor = System.Drawing.Color.Black;
          this.musicbox.Paint += new System.Windows.Forms.PaintEventHandler(this.musicbox_Paint);

          this.mainbutton = new System.Windows.Forms.UserControl();
          this.mainbutton.Size = new System.Drawing.Size(80, 80);
          this.mainbutton.Location = new System.Drawing.Point((this.musicbox.Width - this.mainbutton.Width) / 2-28,
              10);
          this.mainbutton.BackColor = System.Drawing.Color.Transparent;
          this.mainbutton.Paint += new System.Windows.Forms.PaintEventHandler(this.mainbutton_Paint);
          this.mainbutton.MouseHover += new System.EventHandler(this.mainbutton_MouseHover);
          this.mainbutton.MouseLeave += new System.EventHandler(this.mainbutton_MouseLeave);
          this.mainbutton.Cursor = System.Windows.Forms.Cursors.Hand;
          this.mainbutton.Click += new System.EventHandler(this.mainbutton_Click);
          this.buttonimage = global::jetstudio.Properties.Resources.play;


          this.closebutton = new System.Windows.Forms.UserControl();
          this.closebutton.Size = new System.Drawing.Size(28, 28);
          this.closebutton.Location = new System.Drawing.Point(this.Width - 40, 4);
          this.closebutton.BackColor = System.Drawing.Color.Transparent;
          this.closebutton.ForeColor = System.Drawing.Color.FromArgb(0, 102, 204);
          this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
          this.closebutton.MouseHover += new System.EventHandler(this.closebutton_MouseHover);
          this.closebutton.MouseLeave += new System.EventHandler(this.closebutton_MouseLeave);
          this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
          this.closebutton.Paint += new System.Windows.Forms.PaintEventHandler(closebutton_Paint);

          this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
          this.openfiledialog.Title = global::jetstudio.Properties.Resources.open_file_dlg_title;
          this.openfiledialog.Filter = global::jetstudio.Properties.Resources.open_file_dlg_filter;

          this.copyright = new System.Windows.Forms.Label();
          this.copyright.BackColor = System.Drawing.Color.Transparent;
          this.copyright.ForeColor = System.Drawing.Color.White;
          this.copyright.Cursor = System.Windows.Forms.Cursors.Hand;
          this.copyright.Text = "Copyright © of @Pranav";
          this.copyright.Font = new System.Drawing.Font("Gill Sans", 7.0f, System.Drawing.FontStyle.Regular);
          this.copyright.SetBounds(310, 105, 400, 20);
          this.copyright.MouseHover +=new System.EventHandler(copyright_MouseHover);
          this.copyright.MouseLeave += new System.EventHandler(copyright_MouseLeave);
          this.copyright.Click +=new System.EventHandler(copyright_Click);
          this.menubar.Controls.Add(this.menu1);

          this.Controls.Add(this.closebutton);
          this.Controls.Add(this.menubar);
          this.Controls.Add(this.musicbackcontrol);
          this.Controls.Add(this.menucontent1);
  
          this.Controls.Add(this.musicbox);
          this.musicbox.Controls.Add(this.mainbutton);
          this.musicbox.Controls.Add(this.copyright);
        }

        private void playSound(string filename)
        {
            this.wmediaplayer = new WMPLib.WindowsMediaPlayer();
            this.wmediaplayer.URL = filename;
            this.wmediaplayer.settings.volume = 100;
            this.wmediaplayer.controls.play();
           
        }

        private void copyright_MouseHover(object sender, System.EventArgs e)
        {
            (sender as System.Windows.Forms.Control).Font = new System.Drawing.Font("MS Sans Serif", 7.0f, System.Drawing.FontStyle.Bold);
            
        }
        private void copyright_MouseLeave(object sender, System.EventArgs e)
        {
            (sender as System.Windows.Forms.Control).Font = new System.Drawing.Font("MS Sans Serif", 7.0f, System.Drawing.FontStyle.Regular);
        }
        private void copyright_Click(object sender, System.EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/Pranav00747");
            }
            finally
            {
            }
        }

        #endregion
    }
}

