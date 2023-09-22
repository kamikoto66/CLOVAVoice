using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Win32;

namespace CLOVAVoice
{
    public class ClovaVoiceAPI
    {
        public class ErrorCode
        {
            [JsonProperty("details")]
            public string _Details;

            [JsonProperty("errorCode")]
            public string _ErrorCode;

            [JsonProperty("message")]
            public string _Message;
        }

        public class Params
        {
            private string _Speaker;
            private int _Volume;
            private int _Speed;
            private int _Pitch;
            private string _Format;
            private int _Sampling_Rate;

            public string format { get { return _Format; } }

            public Params(string speaker, int volume, int speed, int pitch, string format, int sampling_rate)
            {
                this._Speaker = speaker;
                this._Volume = volume;
                this._Speed = speed;
                this._Pitch = pitch;
                this._Format = format;
                this._Sampling_Rate = sampling_rate;
            }

            public byte[] GetByte(string text)
            {
                string Params = string.Empty;

                if (_Format.Equals("mp3"))
                {
                    Params = string.Format("speaker={0}&text={1}&volume={2}&speed={3}&pitch={4}&format={5}",
                        _Speaker, text, _Volume, _Speed, _Pitch, _Format);
                }
                else
                {
                    Params = string.Format("speaker={0}&text={1}&volume={2}&speed={3}&pitch={4}&format={5}&sampling-rate={6}",
                        _Speaker, text, _Volume, _Speed, _Pitch, _Format, _Sampling_Rate);
                }

                byte[] output = Encoding.UTF8.GetBytes(Params);

                return output;
            }
        }

        private string _Url = "https://naveropenapi.apigw.ntruss.com/tts-premium/v1/tts";
        private string App_Key_ID = "";
        private string API_Key = "";

        private List<string> _Texts;
        private Params _Params;
        private string _Folder;
        private string _BasePath;

        public ClovaVoiceAPI(List<string> texts, string folder, Params @params)
        {
            _Texts = texts;
            _Params = @params;
            _Folder = folder;

            RegistryKey CLOVAVoiceSimG;

            CLOVAVoiceSimG = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("CLOVAVoiceSimG");

            App_Key_ID = CLOVAVoiceSimG.GetValue("API_KEY_ID") as string;
            API_Key = CLOVAVoiceSimG.GetValue("API_KEY") as string;
        }

        private void DirectoryExistCheck()
        {
            string CurrentDirectory = Environment.CurrentDirectory;
            _BasePath = Path.Combine(CurrentDirectory, "OutPut");

            if (!File.Exists(_BasePath))
            {
                Directory.CreateDirectory(_BasePath);
            }
        }

        public void Run()
        {
            DirectoryExistCheck();

            string path = Path.Combine(_BasePath, _Folder);

            if (Directory.Exists(path).Equals(false))
                Directory.CreateDirectory(path);

            try
            {
                for (int i = 0; i < _Texts.Count; i++)
                {
                    string filename = string.Format("{0:D2}.{1}", i, _Params.format);

                    RequestAPI(_Texts[i], Path.Combine(path, filename));
                }

                MessageBox.Show("완료", "End", MessageBoxButtons.OK);
            }
            catch(WebException e)
            {
                WebResponse Response = e.Response;

                using (Stream stream = Response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string data = reader.ReadToEnd();
                    ErrorCode errorcode = JsonConvert.DeserializeObject<ErrorCode>(data);

                    MessageBox.Show(string.Format("ErrorCode:{0}\nMessage:{1}", errorcode._ErrorCode, errorcode._Message), "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void RequestAPI(string text, string filepath)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_Url);
            request.Headers.Add("X-NCP-APIGW-API-KEY-ID", App_Key_ID);
            request.Headers.Add("X-NCP-APIGW-API-KEY", API_Key);
            request.Method = "POST";

            byte[] byteDataParams = _Params.GetByte(text);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteDataParams.Length;
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            Console.WriteLine("status=" + status);

            using (Stream output = File.OpenWrite(filepath))
            using (Stream input = response.GetResponseStream())
            {
                input.CopyTo(output);
            }
        }
    }
}
