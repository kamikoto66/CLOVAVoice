using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CLOVAVoice
{
    public partial class AppID : Form
    {
        private string _Api_Key_Id;
        private string _Api_Key;

        public AppID()
        {
            InitializeComponent();
        }

        private void AppID_Load(object sender, EventArgs e)
        {

        }

        private void API_KEY_ID_textBox_TextChanged(object sender, EventArgs e)
        {
            _Api_Key_Id = API_KEY_ID_textBox.Text;
        }

        private void API_KEY_textBox_TextChanged(object sender, EventArgs e)
        {
            _Api_Key = API_KEY_textBox.Text;
        }

        private void ConformButton_Click(object sender, EventArgs e)
        {
            RegistryKey CLOVAVoiceSimG;

            CLOVAVoiceSimG = Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("CLOVAVoiceSimG");

            CLOVAVoiceSimG.SetValue("API_KEY_ID", _Api_Key_Id);
            CLOVAVoiceSimG.SetValue("API_KEY", _Api_Key);

            Close();
        }
    }
}
