
namespace CLOVAVoice
{
    partial class AppID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.API_KEY_ID = new System.Windows.Forms.Label();
            this.API_KEY = new System.Windows.Forms.Label();
            this.API_KEY_ID_textBox = new System.Windows.Forms.TextBox();
            this.API_KEY_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.API_KEY_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.API_KEY_ID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.API_KEY, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.API_KEY_ID_textBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // API_KEY_ID
            // 
            this.API_KEY_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.API_KEY_ID.AutoSize = true;
            this.API_KEY_ID.Location = new System.Drawing.Point(3, 19);
            this.API_KEY_ID.Name = "API_KEY_ID";
            this.API_KEY_ID.Size = new System.Drawing.Size(71, 12);
            this.API_KEY_ID.TabIndex = 0;
            this.API_KEY_ID.Text = "API_KEY_ID";
            // 
            // API_KEY
            // 
            this.API_KEY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.API_KEY.AutoSize = true;
            this.API_KEY.Location = new System.Drawing.Point(11, 69);
            this.API_KEY.Name = "API_KEY";
            this.API_KEY.Size = new System.Drawing.Size(54, 12);
            this.API_KEY.TabIndex = 1;
            this.API_KEY.Text = "API-KEY";
            // 
            // API_KEY_ID_textBox
            // 
            this.API_KEY_ID_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.API_KEY_ID_textBox.Location = new System.Drawing.Point(103, 14);
            this.API_KEY_ID_textBox.Name = "API_KEY_ID_textBox";
            this.API_KEY_ID_textBox.Size = new System.Drawing.Size(370, 21);
            this.API_KEY_ID_textBox.TabIndex = 2;
            this.API_KEY_ID_textBox.TextChanged += new System.EventHandler(this.API_KEY_ID_textBox_TextChanged);
            // 
            // API_KEY_textBox
            // 
            this.API_KEY_textBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.API_KEY_textBox.Location = new System.Drawing.Point(103, 64);
            this.API_KEY_textBox.Name = "API_KEY_textBox";
            this.API_KEY_textBox.Size = new System.Drawing.Size(370, 21);
            this.API_KEY_textBox.TabIndex = 3;
            this.API_KEY_textBox.TextChanged += new System.EventHandler(this.API_KEY_textBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConformButton_Click);
            // 
            // AppID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AppID";
            this.Text = "AppID";
            this.Load += new System.EventHandler(this.AppID_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label API_KEY_ID;
        private System.Windows.Forms.Label API_KEY;
        private System.Windows.Forms.TextBox API_KEY_textBox;
        private System.Windows.Forms.TextBox API_KEY_ID_textBox;
        private System.Windows.Forms.Button button1;
    }
}