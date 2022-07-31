using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VisioForge.Libs.NAudio.Wave;

namespace SpeechToText
{
    public class audioStreaming
    {
        private WaveFileWriter RecordedAudioWriter = null;
        public WasapiLoopbackCapture CaptureInstance = null;
        private speechToText toText = null;

        public audioStreaming()
        {

        }

        public void Sound()
        {
            string outputStream = "streaming.wav";

            CaptureInstance = new WasapiLoopbackCapture();

            // Redefine the audio writer instance with the given configuration
            RecordedAudioWriter = new WaveFileWriter(outputStream, CaptureInstance.WaveFormat);

            // When the capturer receives audio, start writing the buffer into the mentioned file
            CaptureInstance.DataAvailable += (s, a) =>
            {
                RecordedAudioWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };

            // When the Capturer Stops
            CaptureInstance.RecordingStopped += (s, a) =>
            {
                RecordedAudioWriter.Dispose();
                RecordedAudioWriter = null;
                CaptureInstance.Dispose();
            };

            // Start recording !
            CaptureInstance.StartRecording();
        }
    }
}
