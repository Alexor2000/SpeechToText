using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.IO;
using System.Speech.AudioFormat;

namespace SpeechToText
{
    public class speechToText
    {
        public SpeechRecognitionEngine engine = new SpeechRecognitionEngine();

        public speechToText()
        {
            //GrammarBuilder builder = new GrammarBuilder();
            //builder.Culture = new System.Globalization.CultureInfo("en-GB");
            //builder.Append(new Choices(File.ReadAllLines("english.txt")));
            engine.SetInputToDefaultAudioDevice();
            engine.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines("english.txt")))));
            engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognized);
            engine.RecognizeAsync(RecognizeMode.Multiple);
            Console.WriteLine("Ready");
        }

        private void SpeechRecognized(object sender, SpeechRecognizedEventArgs eventArgs)
        {
            string speech = eventArgs.Result.Text;
            Console.WriteLine(speech);
            //Program.subForm.UpdateLabelText(speech);
            Program.subForm.lab(speech);
            
        }
    }
}
