using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechToText
{
    public partial class subtitlesForm : Form
    {
        bool erase = false;
        public CustomLabel textLabel = new CustomLabel();

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

            Controls.Add(textLabel);
            textLabel.Font = new Font("Microsoft Arial", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLabel.BackColor = Color.Transparent;
            textLabel.ForeColor = Color.White;
            textLabel.Text = "Waiting ...";
            textLabel.AutoSize = true;
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

        public void lab(string put)
        {
            textLabel.Text += put;
        }
    }

    public class CustomLabel : Label
    {
        public CustomLabel()
        {
            OutlineForeColor = Color.Black;
            OutlineWidth = 6;
        }
        public Color OutlineForeColor { get; set; }
        public float OutlineWidth { get; set; }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            using (GraphicsPath gp = new GraphicsPath())
            using (Pen outline = new Pen(OutlineForeColor, OutlineWidth)
            { LineJoin = LineJoin.Round })
            using (StringFormat sf = new StringFormat())
            using (Brush foreBrush = new SolidBrush(ForeColor))
            {
                gp.AddString(Text, Font.FontFamily, (int)Font.Style,
                    Font.Size, ClientRectangle, sf);
                e.Graphics.ScaleTransform(1f, 1f);
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                e.Graphics.DrawPath(outline, gp);
                e.Graphics.FillPath(foreBrush, gp);
            }
        }
    }
}
