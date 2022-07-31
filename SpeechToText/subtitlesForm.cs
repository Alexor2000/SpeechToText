using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechToText
{
    public partial class subtitlesForm : Form
    {
        bool erase = false;

        public subtitlesForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.FromArgb(1, 1, 1);
            TransparencyKey = Color.FromArgb(1, 1, 1);

            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;

            Size = new Size(1000, 200);
            
            CenterToScreen();
            Location = new Point(Location.X, Location.Y + Screen.PrimaryScreen.WorkingArea.Height / 2 - 200);

            textLabel.BackColor = Color.Transparent;

            UpdateLabelLocation();
        }

        private void UpdateLabelLocation()
        {
            textLabel.Location = new Point(Size.Width/2 - textLabel.Size.Width/2, Size.Height / 2 - textLabel.Size.Height / 2);
        }

        public void UpdateLabelText(string textToPut)
        {
            UpdateLabelLocation();
            if (erase)
            {
                erase = false;
                textLabel.Text = textToPut;
            }
            else
            {
                Text += textToPut;
            }

            if (textToPut.Contains('.'))
            {
                erase = true;
            }
        }
    }
}
