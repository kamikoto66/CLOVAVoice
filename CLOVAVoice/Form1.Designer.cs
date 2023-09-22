
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
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppID_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pitch_label = new System.Windows.Forms.Label();
            this.speed_label = new System.Windows.Forms.Label();
            this.volume_trackBar = new System.Windows.Forms.TrackBar();
            this.speed_trackBar = new System.Windows.Forms.TrackBar();
            this.pitch_trackBar = new System.Windows.Forms.TrackBar();
            this.volume_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sampling_rate_combobox = new System.Windows.Forms.ComboBox();
            this.format_label = new System.Windows.Forms.Label();
            this.sampling_rate_label = new System.Windows.Forms.Label();
            this.format_combobox = new System.Windows.Forms.ComboBox();
            this.convert_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.speaker = new System.Windows.Forms.Label();
            this.speaker_comboBox = new System.Windows.Forms.ComboBox();
            this.textList = new System.Windows.Forms.ListBox();
            this.emotion_label = new System.Windows.Forms.Label();
            this.emotion_strength_label = new System.Windows.Forms.Label();
            this.emotion_comboBox = new System.Windows.Forms.ComboBox();
            this.emotion_strength_comboBox = new System.Windows.Forms.ComboBox();
            this.alpha_label = new System.Windows.Forms.Label();
            this.end_pitch_label = new System.Windows.Forms.Label();
            this.alpha_trackBar = new System.Windows.Forms.TrackBar();
            this.end_pitch_trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Emotion_checkBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_trackBar)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pitch_trackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pitch_label, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.speed_label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.volume_trackBar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.speed_trackBar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pitch_trackBar, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.volume_label, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 41);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pitch_label
            // 
            this.pitch_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pitch_label.AutoSize = true;
            this.pitch_label.Location = new System.Drawing.Point(485, 14);
            this.pitch_label.Name = "pitch_label";
            this.pitch_label.Size = new System.Drawing.Size(29, 12);
            this.pitch_label.TabIndex = 5;
            this.pitch_label.Text = "피치";
            // 
            // speed_label
            // 
            this.speed_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speed_label.AutoSize = true;
            this.speed_label.Location = new System.Drawing.Point(244, 14);
            this.speed_label.Name = "speed_label";
            this.speed_label.Size = new System.Drawing.Size(29, 12);
            this.speed_label.TabIndex = 4;
            this.speed_label.Text = "속도";
            // 
            // volume_trackBar
            // 
            this.volume_trackBar.Location = new System.Drawing.Point(38, 3);
            this.volume_trackBar.Maximum = 5;
            this.volume_trackBar.Minimum = -5;
            this.volume_trackBar.Name = "volume_trackBar";
            this.volume_trackBar.Size = new System.Drawing.Size(200, 35);
            this.volume_trackBar.TabIndex = 0;
            this.volume_trackBar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // speed_trackBar
            // 
            this.speed_trackBar.Location = new System.Drawing.Point(279, 3);
            this.speed_trackBar.Maximum = 5;
            this.speed_trackBar.Minimum = -5;
            this.speed_trackBar.Name = "speed_trackBar";
            this.speed_trackBar.Size = new System.Drawing.Size(200, 35);
            this.speed_trackBar.TabIndex = 1;
            this.speed_trackBar.Scroll += new System.EventHandler(this.speed_bar_Scroll);
            // 
            // pitch_trackBar
            // 
            this.pitch_trackBar.Location = new System.Drawing.Point(520, 3);
            this.pitch_trackBar.Maximum = 5;
            this.pitch_trackBar.Minimum = -5;
            this.pitch_trackBar.Name = "pitch_trackBar";
            this.pitch_trackBar.Size = new System.Drawing.Size(200, 35);
            this.pitch_trackBar.TabIndex = 2;
            this.pitch_trackBar.Scroll += new System.EventHandler(this.pitch_bar_Scroll);
            // 
            // volume_label
            // 
            this.volume_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.volume_label.AutoSize = true;
            this.volume_label.Location = new System.Drawing.Point(3, 14);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(29, 12);
            this.volume_label.TabIndex = 3;
            this.volume_label.Text = "볼륨";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.end_pitch_trackBar, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.alpha_trackBar, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.alpha_label, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.format_label, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.emotion_label, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.format_combobox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.emotion_comboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.sampling_rate_combobox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.emotion_strength_comboBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.sampling_rate_label, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.emotion_strength_label, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.end_pitch_label, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 67);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(722, 206);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // sampling_rate_combobox
            // 
            this.sampling_rate_combobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sampling_rate_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampling_rate_combobox.FormattingEnabled = true;
            this.sampling_rate_combobox.Location = new System.Drawing.Point(534, 92);
            this.sampling_rate_combobox.Name = "sampling_rate_combobox";
            this.sampling_rate_combobox.Size = new System.Drawing.Size(121, 20);
            this.sampling_rate_combobox.TabIndex = 3;
            this.sampling_rate_combobox.SelectedIndexChanged += new System.EventHandler(this.sampling_rate_combobox_SelectedIndexChanged);
            // 
            // format_label
            // 
            this.format_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.format_label.AutoSize = true;
            this.format_label.Location = new System.Drawing.Point(34, 96);
            this.format_label.Name = "format_label";
            this.format_label.Size = new System.Drawing.Size(40, 12);
            this.format_label.TabIndex = 1;
            this.format_label.Text = "format";
            // 
            // sampling_rate_label
            // 
            this.sampling_rate_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sampling_rate_label.AutoSize = true;
            this.sampling_rate_label.Location = new System.Drawing.Point(372, 96);
            this.sampling_rate_label.Name = "sampling_rate_label";
            this.sampling_rate_label.Size = new System.Drawing.Size(84, 12);
            this.sampling_rate_label.TabIndex = 0;
            this.sampling_rate_label.Text = "sampling-rate";
            // 
            // format_combobox
            // 
            this.format_combobox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.format_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.format_combobox.FormattingEnabled = true;
            this.format_combobox.Location = new System.Drawing.Point(173, 92);
            this.format_combobox.Name = "format_combobox";
            this.format_combobox.Size = new System.Drawing.Size(121, 20);
            this.format_combobox.TabIndex = 2;
            this.format_combobox.SelectedIndexChanged += new System.EventHandler(this.format_combobox_SelectedIndexChanged);
            // 
            // convert_button
            // 
            this.convert_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.convert_button.Location = new System.Drawing.Point(300, 425);
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
            this.tableLayoutPanel3.Controls.Add(this.speaker_comboBox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(15, 279);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(722, 30);
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
            // speaker_comboBox
            // 
            this.speaker_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.speaker_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speaker_comboBox.FormattingEnabled = true;
            this.speaker_comboBox.Location = new System.Drawing.Point(481, 5);
            this.speaker_comboBox.Name = "speaker_comboBox";
            this.speaker_comboBox.Size = new System.Drawing.Size(121, 20);
            this.speaker_comboBox.TabIndex = 2;
            this.speaker_comboBox.SelectedIndexChanged += new System.EventHandler(this.speaker_combo_SelectedIndexChanged);
            // 
            // textList
            // 
            this.textList.FormattingEnabled = true;
            this.textList.ItemHeight = 12;
            this.textList.Location = new System.Drawing.Point(15, 315);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(722, 88);
            this.textList.TabIndex = 8;
            // 
            // emotion_label
            // 
            this.emotion_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emotion_label.AutoSize = true;
            this.emotion_label.Location = new System.Drawing.Point(29, 28);
            this.emotion_label.Name = "emotion_label";
            this.emotion_label.Size = new System.Drawing.Size(50, 12);
            this.emotion_label.TabIndex = 4;
            this.emotion_label.Text = "emotion";
            // 
            // emotion_strength_label
            // 
            this.emotion_strength_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emotion_strength_label.AutoSize = true;
            this.emotion_strength_label.BackColor = System.Drawing.SystemColors.Control;
            this.emotion_strength_label.Location = new System.Drawing.Point(363, 28);
            this.emotion_strength_label.Name = "emotion_strength_label";
            this.emotion_strength_label.Size = new System.Drawing.Size(101, 12);
            this.emotion_strength_label.TabIndex = 5;
            this.emotion_strength_label.Text = "emotion-strength";
            // 
            // emotion_comboBox
            // 
            this.emotion_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emotion_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emotion_comboBox.FormattingEnabled = true;
            this.emotion_comboBox.Location = new System.Drawing.Point(173, 24);
            this.emotion_comboBox.Name = "emotion_comboBox";
            this.emotion_comboBox.Size = new System.Drawing.Size(121, 20);
            this.emotion_comboBox.TabIndex = 6;
            this.emotion_comboBox.SelectedIndexChanged += new System.EventHandler(this.emotion_comboBox_SelectedIndexChanged);
            // 
            // emotion_strength_comboBox
            // 
            this.emotion_strength_comboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emotion_strength_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.emotion_strength_comboBox.FormattingEnabled = true;
            this.emotion_strength_comboBox.Location = new System.Drawing.Point(534, 24);
            this.emotion_strength_comboBox.Name = "emotion_strength_comboBox";
            this.emotion_strength_comboBox.Size = new System.Drawing.Size(121, 20);
            this.emotion_strength_comboBox.TabIndex = 7;
            this.emotion_strength_comboBox.SelectedIndexChanged += new System.EventHandler(this.emotion_strength_comboBox_SelectedIndexChanged);
            // 
            // alpha_label
            // 
            this.alpha_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alpha_label.AutoSize = true;
            this.alpha_label.Location = new System.Drawing.Point(36, 165);
            this.alpha_label.Name = "alpha_label";
            this.alpha_label.Size = new System.Drawing.Size(36, 12);
            this.alpha_label.TabIndex = 8;
            this.alpha_label.Text = "alpha";
            // 
            // end_pitch_label
            // 
            this.end_pitch_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.end_pitch_label.AutoSize = true;
            this.end_pitch_label.Location = new System.Drawing.Point(384, 165);
            this.end_pitch_label.Name = "end_pitch_label";
            this.end_pitch_label.Size = new System.Drawing.Size(59, 12);
            this.end_pitch_label.TabIndex = 9;
            this.end_pitch_label.Text = "end-pitch";
            // 
            // alpha_trackBar
            // 
            this.alpha_trackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alpha_trackBar.Location = new System.Drawing.Point(134, 148);
            this.alpha_trackBar.Maximum = 5;
            this.alpha_trackBar.Minimum = -5;
            this.alpha_trackBar.Name = "alpha_trackBar";
            this.alpha_trackBar.Size = new System.Drawing.Size(200, 45);
            this.alpha_trackBar.TabIndex = 12;
            this.alpha_trackBar.Scroll += new System.EventHandler(this.alpha_trackBar_Scroll);
            // 
            // end_pitch_trackBar
            // 
            this.end_pitch_trackBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.end_pitch_trackBar.Location = new System.Drawing.Point(495, 148);
            this.end_pitch_trackBar.Maximum = 5;
            this.end_pitch_trackBar.Minimum = -5;
            this.end_pitch_trackBar.Name = "end_pitch_trackBar";
            this.end_pitch_trackBar.Size = new System.Drawing.Size(200, 45);
            this.end_pitch_trackBar.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.convert_button);
            this.groupBox1.Controls.Add(this.textList);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(25, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Emotion_checkBox
            // 
            this.Emotion_checkBox.AutoSize = true;
            this.Emotion_checkBox.Location = new System.Drawing.Point(25, 27);
            this.Emotion_checkBox.Name = "Emotion_checkBox";
            this.Emotion_checkBox.Size = new System.Drawing.Size(104, 16);
            this.Emotion_checkBox.TabIndex = 4;
            this.Emotion_checkBox.Text = "EmotionActive";
            this.Emotion_checkBox.UseVisualStyleBackColor = true;
            this.Emotion_checkBox.CheckedChanged += new System.EventHandler(this.Emotion_checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Emotion_checkBox);
            this.Controls.Add(this.groupBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.volume_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speed_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitch_trackBar)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alpha_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end_pitch_trackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Open_MenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label pitch_label;
        private System.Windows.Forms.Label speed_label;
        private System.Windows.Forms.TrackBar volume_trackBar;
        private System.Windows.Forms.TrackBar speed_trackBar;
        private System.Windows.Forms.TrackBar pitch_trackBar;
        private System.Windows.Forms.Label volume_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox sampling_rate_combobox;
        private System.Windows.Forms.Label format_label;
        private System.Windows.Forms.Label sampling_rate_label;
        private System.Windows.Forms.ComboBox format_combobox;
        private System.Windows.Forms.Button convert_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label speaker;
        private System.Windows.Forms.ComboBox speaker_comboBox;
        private System.Windows.Forms.ListBox textList;
        private System.Windows.Forms.ToolStripMenuItem Clear_MenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AppID_ToolStripMenuItem;
        private System.Windows.Forms.Label emotion_label;
        private System.Windows.Forms.Label emotion_strength_label;
        private System.Windows.Forms.ComboBox emotion_strength_comboBox;
        private System.Windows.Forms.ComboBox emotion_comboBox;
        private System.Windows.Forms.Label alpha_label;
        private System.Windows.Forms.Label end_pitch_label;
        private System.Windows.Forms.TrackBar alpha_trackBar;
        private System.Windows.Forms.TrackBar end_pitch_trackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Emotion_checkBox;
    }
}

