using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.IO;
using System.Speech.AudioFormat;
using System.Globalization;

namespace SpeechToText
{
    public class speechToText
    {
        public SpeechRecognitionEngine engine = new SpeechRecognitionEngine();

        public speechToText()
        {
            //Choices language = new Choices(File.ReadAllLines("english.txt"));

            //GrammarBuilder grammarBuilder = new GrammarBuilder();
            //CultureInfo cultureInfo = new CultureInfo("fr-FR");
            //grammarBuilder.Culture = cultureInfo;
            //grammarBuilder.Append(language);

            //Grammar grammar = new Grammar(grammarBuilder);

            engine.SetInputToDefaultAudioDevice();
            engine.LoadGrammar(new DictationGrammar());
            engine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(SpeechRecognized);
            engine.RecognizeAsync(RecognizeMode.Single);

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
