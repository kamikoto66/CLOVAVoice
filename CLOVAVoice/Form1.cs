using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;

namespace CLOVAVoice
{
    public partial class Form1 : Form
    {
        private List<List<string>> _TextDatas;

        private string _Speaker = string.Empty;
        private string _Text = string.Empty;
        private int _Volume = 0;
        private int _Speed = 0;
        private int _Pitch = 0;
        private int _Emotion = 0;
        private int _Emotion_strength;
        private string _Format = string.Empty;
        private int _Sampling_Rate= 0;
        private int _Alpha = 0;
        private int _End_Pitch = 0;
        private string _FolderName = string.Empty;
        private bool _Isinitialize = false;

        private string[] _NomalSpeaker = null;
        private string[] _EmotionSpeaker = { "nara", "varam", "vmikyung", "vdain", "vyuna" };
        private bool _IsEmotionCheck = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] emotion = { "중립", "슬픔", "기쁨", "분노" };
            string[] emotion_strength = { "약함", "보통", "강함" };
            string[] format = { "mp3", "wav" };
            string[] sampling = { "8000", "16000", "24000", "48000" };

            string[] english = { "clara", "matt", "danna", "djoey",  };

            string[] japan = { "shinji", "ntomoko", "nnaomi", "dnaomi_joyful", "dnaomi_formal", "driko", "deriko",
                               "nsayuri", "dhajime", "ddaiki", "dayumu", "dsayuri", "dtomoko", "dnaomi"};

            string[] speaker = { "nara", "nara_call", "nminyoung", "nyejin", "mijin", "jinho",
                "nminsang", "nsinu", "nhajun", "ndain", "njiyun", "nsujin", "njinho", "njihun",
                "njooahn",  "nseonghoon", "njihwan", "nsiyoon", "ngaram", "ngoeun", "neunyoung",
                "nsunkyung", "nyujin", "ntaejin", "nyoungil", "nseungpyo", "nwontak", "dara_ang",
                "nsunhee", "nminseo", "njiwon", "nbora", "njonghyun", "njoonyoung", "njaewook",
                "nes_c_hyeri", "nes_c_sohyun", "nes_c_mikyung", "nes_c_kihyo", "ntiffany", "napple",
                "njangj", "noyj", "neunseo", "nheera", "nyoungmi", "nnarae", "nyeji" ,"nyuna"
                ,"nkyunglee" ,"nminjeong" ,"nihyun" ,"nraewon" ,"nkyuwon" ,"nkitae" ,"neunwoo"
                ,"nkyungtae" ,"nwoosik" ,"vara" ,"vmikyung" ,"vdain" ,"vyuna" ,"vhyeri" ,"dara-danna"
                ,"dsinu-matt" ,"nsabina" ,"nmammon" ,"nmeow" ,"nwoof" ,"nreview" ,"nyounghwa"
                ,"nmovie" ,"nsangdo" ,"nshasha" ,"nian" ,"ndonghyun" ,"vian","vdonghyun"};

            _NomalSpeaker = new string[speaker.Length + japan.Length + english.Length];

            Array.Copy(speaker, 0, _NomalSpeaker, 0, speaker.Length);
            Array.Copy(japan, 0, _NomalSpeaker, speaker.Length, japan.Length);
            Array.Copy(english, 0, _NomalSpeaker, speaker.Length + japan.Length, english.Length);


            format_combobox.Items.AddRange(format);      
            sampling_rate_combobox.Items.AddRange(sampling);
            emotion_comboBox.Items.AddRange(emotion);
            emotion_strength_comboBox.Items.AddRange(emotion_strength);

            speaker_comboBox.Items.AddRange(speaker);
            speaker_comboBox.Items.AddRange(japan);
            speaker_comboBox.Items.AddRange(english);

            format_combobox.SelectedIndex = 0;
            sampling_rate_combobox.SelectedIndex = 2;
            emotion_comboBox.SelectedIndex = 0;
            emotion_strength_comboBox.SelectedIndex = 0;
            speaker_comboBox.SelectedIndex = 0;

            textList.Items.Clear();
            convert_button.Enabled = false;
            emotion_comboBox.Enabled = false;
            emotion_strength_comboBox.Enabled = false;
        }

        #region MenuItemClick

        private void Open_MenuItem_Click(object sender, EventArgs e)
        {
            ReadExcel();
        }

        private void Clear_MenuItem_Click(object sender, EventArgs e)
        {
            convert_button.Enabled = false;

            textList.Items.Clear();

            _TextDatas.Clear();
        }

        private void AppID_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppID appID = new AppID();
            appID.Show();
        }

        #endregion

        #region Scroll

        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            _Volume = volume_trackBar.Value;
        }

        private void speed_bar_Scroll(object sender, EventArgs e)
        {
            _Speed = speed_trackBar.Value;
        }

        private void pitch_bar_Scroll(object sender, EventArgs e)
        {
            _Pitch = pitch_trackBar.Value;
        }

        private void alpha_trackBar_Scroll(object sender, EventArgs e)
        {
            _Alpha = alpha_trackBar.Value;
        }

        private void end_pitch_trackBar_Scroll(object sender, EventArgs e)
        {
            _End_Pitch = end_pitch_trackBar.Value;
        }

        #endregion

        #region ComboBox

        private void format_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Format = format_combobox.SelectedItem as string;

            if (_Format.Equals("mp3"))
            {
                sampling_rate_combobox.Enabled = false;
            }
            else
            {
                sampling_rate_combobox.Enabled = true;
            }
        }

        private void sampling_rate_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Sampling_Rate = int.Parse(sampling_rate_combobox.SelectedItem as string);
        }

        private void speaker_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Speaker = speaker_comboBox.SelectedItem as string;
        }

        private void emotion_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Emotion = emotion_comboBox.SelectedIndex;
        }

        private void emotion_strength_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Emotion_strength = emotion_strength_comboBox.SelectedIndex;
        }

        #endregion

        #region ButtonClick

        private void convert_button_Click(object sender, EventArgs e)
        {
            ClovaVoiceAPI.Params @params = new ClovaVoiceAPI.Params(_Speaker, _Volume, _Speed, _Pitch, _Emotion, _Emotion_strength, _Format, _Sampling_Rate, _Alpha, _End_Pitch);

            @params.isemotion = _IsEmotionCheck;

            for (int i = 0; i < _TextDatas.Count; i++)
            {
                ClovaVoiceAPI api = new ClovaVoiceAPI(_TextDatas[i], string.Format("{0}_{1}", _FolderName, _Speaker), @params);
                api.Run();
            }
        }

        #endregion

        private void ReadExcel()
        {
            FileDialogOpen open = new FileDialogOpen();
            string filepath = string.Empty;
            string filename = string.Empty;

            open.GetFilePath(ref filepath, ref filename);

            _FolderName = filename;

            if (_TextDatas == null)
                _TextDatas = new List<List<string>>();
            else
                _TextDatas.Clear();

            textList.Items.Clear();

            if (!filepath.Equals(string.Empty))
            {
                try
                {
                    using (Stream stream = File.Open(filepath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var reader = ExcelReaderFactory.CreateOpenXmlReader(stream))
                    {
                        var Result = reader.AsDataSet();

                        for (int i = 0; i < Result.Tables.Count; i++)
                        {
                            List<string> Texts = new List<string>();
                            
                            //Texts.Add(Result.Tables[i].TableName);

                            for (int j = 0; j < Result.Tables[i].Rows.Count; j++)
                            {
                                string text = Result.Tables[i].Rows[j][0].ToString();

                                if (!text.Equals(string.Empty))
                                {
                                    Texts.Add(text.Trim());
                                }
                            }

                            _TextDatas.Add(Texts);
                        }
                    }

                    convert_button.Enabled = true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK);
                }
            }

            for (int i = 0; i < _TextDatas.Count; i++)
            {
                textList.Items.AddRange(_TextDatas[i].ToArray());
            }
        }

        #region

        private void Emotion_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            _IsEmotionCheck = Emotion_checkBox.Checked;

            if(_IsEmotionCheck.Equals(true))
            {
                speaker_comboBox.Items.Clear();
                speaker_comboBox.Items.AddRange(_EmotionSpeaker);
            }
            else
            {
                speaker_comboBox.Items.Clear();
                speaker_comboBox.Items.AddRange(_NomalSpeaker);
            }

            emotion_comboBox.Enabled = Emotion_checkBox.Checked;
            emotion_strength_comboBox.Enabled = Emotion_checkBox.Checked;

            speaker_comboBox.SelectedIndex = 0;
        }

        #endregion
    }
}