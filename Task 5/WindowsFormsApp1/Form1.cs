using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Color[] colors = { Color.FromArgb(155, 136, 242), Color.FromArgb(253, 171, 211), Color.FromArgb(211, 253, 171) };
        private int colorIndex = 0;
        public delegate void ButtonAction();
        private event ButtonAction TransparencyAction;
        private event ButtonAction BackgroundAction;
        private event ButtonAction HelloAction;
        private event ButtonAction MegaButtonActions;

        public Form1()
        {
            InitializeComponent();

            // Призначаємо делегати для кожної дії
            TransparencyAction += AddTransparency;
            BackgroundAction += ChangeBackground;
            HelloAction += ShowHelloWorld;

            UpdateMegaButtonActions();
        }

        private void btnTransparency_Click(object sender, EventArgs e)
        {

            TransparencyAction?.Invoke();

        }

        private void btnBackground_Click(object sender, EventArgs e)
        {

            BackgroundAction?.Invoke();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            HelloAction?.Invoke();
        }
        private void btnMega_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!", "Super mega button ", MessageBoxButtons.OK);
            MegaButtonActions?.Invoke();
        }



        private void checkBoxTransp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMegaButtonActions();
        }

        private void checkBoxBackgr_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMegaButtonActions();
        }

        private void checkBoxHello_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMegaButtonActions();
        }
        public void AddTransparency()
        {
            this.BackColor = Color.White;
            this.Opacity = (this.Opacity == 1.0) ? 0.5 : 1.0;
        }


        public void ChangeBackground()
        {
            this.BackColor = colors[colorIndex];

            colorIndex++;
            if (colorIndex >= colors.Length)
            {
                colorIndex = 0;
            }
        }
        public void ShowHelloWorld()
        {
            MessageBox.Show("Hello everyone!\t\nNice to meet you :)\t", "Hello world", MessageBoxButtons.OK);
        }

        private void UpdateMegaButtonActions()
        {
            MegaButtonActions = null;

            MegaButtonActions += checkBoxTransp.Checked ? TransparencyAction : null;
            MegaButtonActions += checkBoxBackgr.Checked ? BackgroundAction : null;
            MegaButtonActions += checkBoxHello.Checked ? HelloAction : null;
        }
    }
}
