using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechToText
{
    internal static class Program
    {
        public static subtitlesForm subForm;
        public static parametersForm paramForm;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            subForm = new subtitlesForm();
            paramForm = new parametersForm();
            Application.Run(new MultiFormContext(subForm, paramForm));
        }
    }
}
