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
    public partial class parametersForm : Form
    {
        public parametersForm()
        {
            InitializeComponent();
        }

        private void parametersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.subForm.Close();
        }
    }
}
