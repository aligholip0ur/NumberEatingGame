namespace snakelikegame
{
    public partial class Form1 : Form
    {
        int arrorw = 0;
        int k = 1,gam=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.P)
            {
                timer1.Enabled = false;
            }
            if (e.KeyCode == Keys.S)
            {
                timer1.Enabled = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                timer1.Enabled = true;
                arrorw = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                timer1.Enabled = true;
                arrorw = 1;
            }
            if (e.KeyCode == Keys.Left)
            {
                timer1.Enabled = true;
                arrorw = 2;
            }
            if (e.KeyCode == Keys.Right)
            {
                timer1.Enabled = true;
                arrorw = 3;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (arrorw == 0)
            {
                label2.Top -=gam ;
               
            }
            else if (arrorw == 1)
            {
                label2.Top +=gam ;
            }
            else if (arrorw == 2)
            {
                label2.Left -=gam ;
            }
            else if (arrorw == 3)
            {
                label2.Left +=gam ;

            }
            if (label2.Top >= this.Height)
            {
                label2.Location = new Point(label2.Location.X, 0);
            }
           else if (label2.Top+label2.Height<0)
            {
                label2.Location = new Point(label2.Location.X, this.Height);

            }
            else if (label2.Left+label2.Width < 0)
            {
                label2.Location = new Point(this.Width,label2.Location.Y);

            }
            else if (label2.Left >= this.Width)
            {
                label2.Location = new Point(0, label2.Location.Y);

            }

            Random rnd = new Random();
            int w = rnd.Next(0, this.Width-label1.Width);
            int h = rnd.Next(0, this.Height - label1.Height);

            if (label1.Bounds.IntersectsWith(label2.Bounds))
            {
                k++;
                label1.Location = new Point(w, h);
                label1.Text = ""+k;
                if (timer1.Interval>2)
                {
                    timer1.Interval -= 1;
                }
                gam += 1;
            }
            
        }
    }

}
            
