using System.DirectoryServices.ActiveDirectory;
using Timer = System.Windows.Forms.Timer;
namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Timer timer = new();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }
        private void baku_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackgroundImage=Properties.Resources.Baku;
                Timer timer = new();
                timer.Interval = 1000;
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void london_Click(object sender, EventArgs e)
        {

        }
        private void Timer_TickLondon(object? sender, EventArgs e)
        {
            Text=DateTime.Now.ToLongTimeString();
            
        }
        private void london_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BackgroundImage = Properties.Resources.Londonn;
                Timer timer = new();
                timer.Interval = 1000;
                timer.Tick += Timer_TickLondon;
                timer.Start();
            }

        }

    }
}