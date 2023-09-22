
namespace CLOVAVoice
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Open_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Clear_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pitch = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.Label();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.speed_bar = new System.Windows.Forms.TrackBar();
            this.pitch_bar = new System.Windows.Forms.TrackBar();
            this.volume = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sampling_rate_combobox = new System.Windows.Forms.ComboBox();
            this.format = new System.Windows.Forms.Label();
            this.sampling_rate = new System.Windows.Forms.Label();
            this.format_combobox = new System.Windows.Forms.ComboBox();
            this.convert_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.speaker = new System.Windows.Forms.Label();
            this.speaker_combo = new System.Windows.Forms.ComboBox();
            this.TextList = new System.Windows.Forms.ListBox();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppID_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_bar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_MenuItem,
            this.Clear_MenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // Open_MenuItem
            // 
            this.Open_MenuItem.Name = "Open_MenuItem";
            this.Open_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Open_MenuItem.Text = "열기";
            this.Open_MenuItem.Click += new System.EventHandler(this.Open_MenuItem_Click);
            // 
            // Clear_MenuItem
            // 
            this.Clear_MenuItem.Name = "Clear_MenuItem";
            this.Clear_MenuItem.Size = new System.Drawing.Size(180, 22);
            this.Clear_MenuItem.Text = "초기화";
            this.Clear_MenuItem.Click += new System.EventHandler(this.Clear_MenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pitch, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.speed, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.volume_bar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.speed_bar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pitch_bar, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.volume, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pitch
            // 
            this.pitch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pitch.AutoSize = true;
            this.pitch.Location = new System.Drawing.Point(485, 14);
            this.pitch.Name = "pitch";
            this.pitch.Size = new System.Drawing.Size(29, 12);
            this.pitch.TabIndex = 5;
            this.pitch.Text = "피치";
            // 
            // speed
            // 
            this.speed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(244, 14);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(29, 12);
            this.speed.TabIndex = 4;
            this.speed.Text = "속도";
            // 
            // volume_bar
            // 
            this.volume_bar.Location = new System.Drawing.Point(38, 3);
            this.volume_bar.Maximum = 5;
            this.volume_bar.Minimum = -5;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Size = new System.Drawing.Size(200, 35);
            this.volume_bar.TabIndex = 0;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // speed_bar
            // 
            this.speed_bar.Location = new System.Drawing.Point(279, 3);
            this.speed_bar.Maximum = 5;
            this.speed_bar.Minimum = -5;
            this.speed_bar.Name = "speed_bar";
            this.speed_bar.Size = new System.Drawing.Size(200, 35);
            this.speed_bar.TabIndex = 1;
            this.speed_bar.Scroll += new System.EventHandler(this.speed_bar_Scroll);
            // 
            // pitch_bar
            // 
            this.pitch_bar.Location = new System.Drawing.Point(520, 3);
            this.pitch_bar.Maximum = 5;
            this.pitch_bar.Minimum = -5;
            this.pitch_bar.Name = "pitch_bar";
            this.pitch_bar.Size = new System.Drawing.Size(200, 35);
            this.pitch_bar.TabIndex = 2;
            this.pitch_bar.Scroll += new System.EventHandler(this.pitch_bar_Scroll);
            // 
            // volume
            // 
            this.volume.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(3, 14);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(29, 12);
            this.volume.TabIndex = 3;
            this.volume.Text = "볼륨";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.sampling_rate_combobox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.format, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sampling_rate, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.format_combobox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(32, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(722, 50);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // sampling_rate_combobox
            // 
            this.sampling_rate_combobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sampling_rate_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampling_rate_combobox.FormattingEnabled = true;
            this.sampling_rate_combobox.Location = new System.Drawing.Point(534, 15);
            this.sampling_rate_combobox.Name = "sampling_rate_combobox";
            this.sampling_rate_combobox.Size = new System.Drawing.Size(121, 20);
            this.sampling_rate_combobox.TabIndex = 3;
            this.sampling_rate_combobox.SelectedIndexChanged += new System.EventHandler(this.sampling_rate_combobox_SelectedIndexChanged);
            // 
            // format
            // 
            this.format.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.format.AutoSize = true;
            this.format.Location = new System.Drawing.Point(34, 19);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(40, 12);
            this.format.TabIndex = 1;
            this.format.Text = "format";
            // 
            // sampling_rate
            // 
            this.sampling_rate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sampling_rate.AutoSize = true;
            this.sampling_rate.Location = new System.Drawing.Point(372, 19);
            this.sampling_rate.Name = "sampling_rate";
            this.sampling_rate.Size = new System.Drawing.Size(84, 12);
            this.sampling_rate.TabIndex = 0;
            this.sampling_rate.Text = "sampling-rate";
            // 
            // format_combobox
            // 
            this.format_combobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.format_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.format_combobox.FormattingEnabled = true;
            this.format_combobox.Location = new System.Drawing.Point(173, 15);
            this.format_combobox.Name = "format_combobox";
            this.format_combobox.Size = new System.Drawing.Size(121, 20);
            this.format_combobox.TabIndex = 2;
            this.format_combobox.SelectedIndexChanged += new System.EventHandler(this.format_combobox_SelectedIndexChanged);
            // 
            // convert_button
            // 
            this.convert_button.Location = new System.Drawing.Point(311, 526);
            this.convert_button.Name = "convert_button";
            this.convert_button.Size = new System.Drawing.Size(150, 23);
            this.convert_button.TabIndex = 6;
            this.convert_button.Text = "Convert";
            this.convert_button.UseVisualStyleBackColor = true;
            this.convert_button.Click += new System.EventHandler(this.convert_button_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.speaker, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.speaker_combo, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(32, 127);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(720, 30);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // speaker
            // 
            this.speaker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speaker.AutoSize = true;
            this.speaker.Location = new System.Drawing.Point(155, 9);
            this.speaker.Name = "speaker";
            this.speaker.Size = new System.Drawing.Size(50, 12);
            this.speaker.TabIndex = 1;
            this.speaker.Text = "speaker";
            // 
            // speaker_combo
            // 
            this.speaker_combo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speaker_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speaker_combo.FormattingEnabled = true;
            this.speaker_combo.Location = new System.Drawing.Point(479, 5);
            this.speaker_combo.Name = "speaker_combo";
            this.speaker_combo.Size = new System.Drawing.Size(121, 20);
            this.speaker_combo.TabIndex = 2;
            this.speaker_combo.SelectedIndexChanged += new System.EventHandler(this.speaker_combo_SelectedIndexChanged);
            // 
            // TextList
            // 
            this.TextList.FormattingEnabled = true;
            this.TextList.ItemHeight = 12;
            this.TextList.Location = new System.Drawing.Point(32, 163);
            this.TextList.Name = "TextList";
            this.TextList.Size = new System.Drawing.Size(722, 328);
            this.TextList.TabIndex = 8;
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppID_ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // AppID_ToolStripMenuItem
            // 
            this.AppID_ToolStripMenuItem.Name = "AppID_ToolStripMenuItem";
            this.AppID_ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AppID_ToolStripMenuItem.Text = "앱아이디등록";
            this.AppID_ToolStripMenuItem.Click += new System.EventHandler(this.AppID_ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TextList);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.convert_button);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_bar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_MenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label pitch;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.TrackBar speed_bar;
        private System.Windows.Forms.TrackBar pitch_bar;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox sampling_rate_combobox;
        private System.Windows.Forms.Label format;
        private System.Windows.Forms.Label sampling_rate;
        private System.Windows.Forms.ComboBox format_combobox;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label speaker;
        private System.Windows.Forms.ComboBox speaker_combo;
        private System.Windows.Forms.ListBox TextList;
        private System.Windows.Forms.ToolStripMenuItem Clear_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppID_ToolStripMenuItem;
    }
}

