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
        private string _Format = string.Empty;
        private int _Sampling_Rate= 0;
        private string _FolderName = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] format = { "mp3", "wav"};
            string[] sampling = { "8000", "16000", "24000", "48000" };
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

            sampling_rate_combobox.Items.AddRange(sampling);
            sampling_rate_combobox.SelectedIndex = 2;

            format_combobox.Items.AddRange(format);
            format_combobox.SelectedIndex = 0;

            speaker_combo.Items.AddRange(speaker);
            speaker_combo.SelectedIndex = 0;

            convert_button.Enabled = false;

            TextList.Items.Clear();
        }

        #region MenuItemClick

        private void Open_MenuItem_Click(object sender, EventArgs e)
        {
            ReadExcel();
        }

        private void Clear_MenuItem_Click(object sender, EventArgs e)
        {
            convert_button.Enabled = false;

            TextList.Items.Clear();

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
            _Volume = volume_bar.Value;
        }

        private void speed_bar_Scroll(object sender, EventArgs e)
        {
            _Speed = speed_bar.Value;
        }

        private void pitch_bar_Scroll(object sender, EventArgs e)
        {
            _Pitch = pitch_bar.Value;
        }

        #endregion

        #region ComboBox

        private void format_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Format = format_combobox.SelectedItem as string;

            if (_Format.Equals("mp3"))
            {
                if(_Speaker.Equals("mijin"))
                {
                    sampling_rate_combobox.SelectedIndex = 1;
                }
                else
                {
                    sampling_rate_combobox.SelectedIndex = 2;
                }
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
            _Speaker = speaker_combo.SelectedItem as string;

            if(_Format.Equals("mp3"))
            {
                if(_Speaker.Equals("mijin"))
                {
                    sampling_rate_combobox.SelectedIndex = 1;
                }
                else
                {
                    sampling_rate_combobox.SelectedIndex = 2;
                }
            }
        }

        #endregion

        #region ButtonClick

        private void convert_button_Click(object sender, EventArgs e)
        {
            ClovaVoiceAPI.Params @params = new ClovaVoiceAPI.Params(_Speaker, _Volume, _Speed, _Pitch,
                _Format, _Sampling_Rate);

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

            TextList.Items.Clear();

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
                TextList.Items.AddRange(_TextDatas[i].ToArray());
            }
        }
    }
}
