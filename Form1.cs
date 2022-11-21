using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Timers;

namespace jetstudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Controls Events

        private void menubar_Paint(object sender, PaintEventArgs e)
        {
            Rectangle thisRect = (sender as UserControl).ClientRectangle;
            e.Graphics.FillRectangle(new LinearGradientBrush((sender as UserControl).ClientRectangle,
               Color.FromArgb(0, 0, 0), Color.FromArgb(10, 10, 10), LinearGradientMode.Vertical),
                (sender as UserControl).ClientRectangle);
            e.Graphics.Dispose();
        }

        private void menu1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(global::jetstudio.Properties.Resources.menu1_text, (sender as UserControl).Font,
                new SolidBrush((sender as UserControl).ForeColor), new PointF(
                    ((sender as UserControl).Width - global::jetstudio.Properties.Resources.menu1_text.Length * 10) / 2, 5));
            e.Graphics.Dispose();
        }

        private void menu1_MouseHover(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            (sender as UserControl).BackColor = Color.FromArgb(0, 102, 204);
            (sender as UserControl).ForeColor = Color.White;
            (sender as UserControl).Refresh();
        }

        private void menu1_MouseLeave(object sender, EventArgs e)
        {
            (sender as UserControl).BackColor = Color.Transparent;
            (sender as UserControl).ForeColor = Color.White;
            (sender as UserControl).Refresh();
        }

        private void menucontent1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle thisRect = (sender as UserControl).ClientRectangle;
            e.Graphics.FillRectangle(new LinearGradientBrush((sender as UserControl).ClientRectangle,
               Color.FromArgb(0, 0, 0), Color.FromArgb(10, 10, 10), LinearGradientMode.Vertical),
                (sender as UserControl).ClientRectangle);
            e.Graphics.Dispose();
        }
        private void menu1_Click(object sender, EventArgs e)
        {
          
                this.menucontent1.Visible = true;
        }

        private void menu1item1_Paint(object sender, PaintEventArgs e)
        {
            if ((sender as UserControl).Enabled)
            {
                e.Graphics.DrawString(global::jetstudio.Properties.Resources.menu1item1_text, SystemFonts.MenuFont, new SolidBrush((sender as UserControl).ForeColor),
                    new PointF(13, 2));
            }
            else
            {
                e.Graphics.DrawString(global::jetstudio.Properties.Resources.menu1item1_text, SystemFonts.MenuFont, Brushes.DarkGray,
                      new PointF(13, 2));
            }
            e.Graphics.Dispose();
        }


        private void menu1item1_MouseHover(object sender, EventArgs e)
        {
                (sender as UserControl).BackColor = Color.FromArgb(0, 102, 204);
        }

        private void menu1item1_MouseLeave(object sender, EventArgs e)
        {
            (sender as UserControl).BackColor = Color.Transparent;
        }

        private void musicbox_Paint(object sender, PaintEventArgs e)
        {
            Rectangle thisRect= (sender as UserControl).ClientRectangle;

            e.Graphics.FillRectangle(new LinearGradientBrush((sender as UserControl).ClientRectangle,
                Color.FromArgb(66, 66, 66), Color.FromArgb(26, 26, 26), LinearGradientMode.Vertical), 
                    (sender as UserControl).ClientRectangle);
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(66, 66, 66))), new Point(0, 0), new Point(779, 0));
            e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(66, 66, 66))), new Point(0, 129), new Point(779, 129));
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(25, Color.White)), new Rectangle(thisRect.Left + 1, thisRect.Top + 1,
                thisRect.Width - 1, thisRect.Height / 2-1));
            e.Graphics.Dispose();
        }

        private void mainbutton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new System.Drawing.Bitmap(this.buttonimage,
              new System.Drawing.Size(e.ClipRectangle.Width, e.ClipRectangle.Height)), new Point(0, 0));
            e.Graphics.Dispose();
        }

        private void mainbutton_MouseHover(object sender, EventArgs e)
        {
            Thread.Sleep(120);
            (sender as UserControl).Size = new Size(86, 86);
            (sender as UserControl).Refresh();
        }

        private void mainbutton_MouseLeave(object sender, EventArgs e)
        {
            (sender as UserControl).Size = new Size(80, 80);
            (sender as UserControl).Refresh();
        }

        private void closebutton_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("×", new Font("MS Sans Serif", 14.0f), new SolidBrush((sender as Control).ForeColor), new PointF(0, 0));
            e.Graphics.Dispose();
        }

        private void closebutton_MouseHover(object sender, EventArgs e)
        {
            Thread.Sleep(120);
            (sender as Control).ForeColor = Color.FromArgb(255, 128, 0);
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = Color.FromArgb(0, 102, 204);
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            ((sender as UserControl).Parent as Form).Dispose();
        }
        private void ctrl_p_Click(object sender, EventArgs e)
        {
            (sender as Control).Dispose();
        }
        private void menu1item1_Click(object sender, EventArgs e)
        {
            Form ctrl_p = new Form();
            ctrl_p.Size = new Size(400, 200);
            ctrl_p.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ctrl_p.StartPosition = FormStartPosition.CenterScreen;
            ctrl_p.BackColor = Color.FromArgb(0, 0, 0);
            ctrl_p.Visible = true;
            ctrl_p.Click += new EventHandler(ctrl_p_Click);
            Label lab1 = new Label();
            lab1.SetBounds(160, 20, 100, 20);
            lab1.ForeColor = Color.White;
            lab1.Font = new Font("Gill Sans", 12.0f, FontStyle.Regular);
            lab1.Text = "Mr. Pranav";
            Label lab2 = new Label();
            lab2.SetBounds(160, 40, 200, 20);
            lab2.ForeColor = Color.White;
            lab2.Font = new Font("Gill Sans", 7.0f, FontStyle.Regular);
            lab2.Text = "https://github.com/Pranav00747";

            PictureBox box = new PictureBox();
            box.Image = new Bitmap((Image)global::jetstudio.Properties.Resources.IMG_20210911_111356_405, new Size(90, 160));
            box.SetBounds(10, 10, 90, 160);
            box.BackColor = Color.Transparent;

            ctrl_p.Controls.Add(lab1);
            ctrl_p.Controls.Add(lab2);
            ctrl_p.Controls.Add(box);
            
        }

        private void mainbutton_Click(object sender, EventArgs e)
        {
            if (this.buttonstate != 1)
            {
                if (this.openfiledialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (this.buttonstate == 0)
                    {
                        this.buttonimage = global::jetstudio.Properties.Resources.stop;
                        this.mainbutton.Refresh();
                        this.buttonstate = 1;
                        playSound(this.openfiledialog.FileName);
                    }
                }
            }
            else
            {
                if (this.buttonstate == 1)
                {

                    this.wmediaplayer.controls.stop();
                    this.buttonimage = global::jetstudio.Properties.Resources.play;
                    this.buttonstate = 0;
                    this.mainbutton.Refresh();

                }
            }
        }


        #endregion
    }
}
