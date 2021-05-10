using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Melt_The_Jelly_Game
{
    class Bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.CornflowerBlue;
            bullet.Size = new Size(12, 12 );
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();

            form.Controls.Add(bullet);

            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                bullet.Left -= speed;
            }

            if (direction == "right")
            {
                bullet.Left += speed;
            }

            if (direction == "up")
            {
                bullet.Top -= speed;
            }

            if (direction == "down")
            {
                bullet.Top += speed;
            }


            if (bullet.Left < 1 || bullet.Left > 1200 || bullet.Top < 1 || bullet.Top > 900)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
