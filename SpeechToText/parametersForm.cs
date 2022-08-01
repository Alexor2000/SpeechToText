using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
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
            endingButton.Enabled = false;
        }

        private void parametersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.subForm.Close();
        }

        private void startingButton_Click(object sender, EventArgs e)
        {
            endingButton.Enabled = true;
            startingButton.Enabled = false;
            //audioStreaming.Sound();
        }

        private void endingButton_Click(object sender, EventArgs e)
        {
            Program.speechToText.engine.RecognizeAsyncCancel();
            startingButton.Enabled = true;
            endingButton.Enabled = false;
            //audioStreaming.CaptureInstance.StopRecording();
        }
    }
}