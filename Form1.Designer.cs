
namespace xmlOldViewer
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c_searchCheck = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.b_export = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.t_locationInput = new System.Windows.Forms.TextBox();
            this.c_location1 = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.L_mainFromNameLabel = new System.Windows.Forms.Label();
            this.l_exitLabel = new System.Windows.Forms.Label();
            this.l_windowMinimize = new System.Windows.Forms.Label();
            this.l_names = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_changeName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.forPrint1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c_searchCheck);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.b_export);
            this.groupBox1.Controls.Add(this.b_search);
            this.groupBox1.Controls.Add(this.t_locationInput);
            this.groupBox1.Controls.Add(this.c_location1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(376, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // c_searchCheck
            // 
            this.c_searchCheck.AutoSize = true;
            this.c_searchCheck.Location = new System.Drawing.Point(317, 32);
            this.c_searchCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_searchCheck.Name = "c_searchCheck";
            this.c_searchCheck.Size = new System.Drawing.Size(45, 22);
            this.c_searchCheck.TabIndex = 9;
            this.c_searchCheck.Text = "X";
            this.c_searchCheck.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 414);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 8;
            this.button2.Text = "모든데이터";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // b_export
            // 
            this.b_export.Location = new System.Drawing.Point(224, 414);
            this.b_export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_export.Name = "b_export";
            this.b_export.Size = new System.Drawing.Size(139, 34);
            this.b_export.TabIndex = 7;
            this.b_export.Text = "내보내기 (xml)";
            this.b_export.UseVisualStyleBackColor = true;
            this.b_export.Click += new System.EventHandler(this.b_export_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(9, 414);
            this.b_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(80, 34);
            this.b_search.TabIndex = 4;
            this.b_search.Text = "검색";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // t_locationInput
            // 
            this.t_locationInput.Location = new System.Drawing.Point(190, 28);
            this.t_locationInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_locationInput.Name = "t_locationInput";
            this.t_locationInput.Size = new System.Drawing.Size(117, 28);
            this.t_locationInput.TabIndex = 3;
            this.t_locationInput.Text = "추가 검색";
            this.t_locationInput.Click += new System.EventHandler(this.t_locationInput_Click);
            // 
            // c_location1
            // 
            this.c_location1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_location1.FormattingEnabled = true;
            this.c_location1.Items.AddRange(new object[] {
            "가평군",
            "고양시",
            "과천시",
            "광명시",
            "광주시",
            "구리시",
            "군포시",
            "김포시",
            "남양주시",
            "동두천시",
            "부천시",
            "성남시",
            "수원시",
            "시흥시",
            "안산시",
            "안성시",
            "안양시",
            "양주시",
            "양평군",
            "여주시",
            "오산시",
            "용인시",
            "의왕시",
            "의정부시",
            "이천시",
            "파주시",
            "평택시",
            "포천시",
            "하남시",
            "화성시"});
            this.c_location1.Location = new System.Drawing.Point(9, 30);
            this.c_location1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_location1.Name = "c_location1";
            this.c_location1.Size = new System.Drawing.Size(171, 26);
            this.c_location1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(9, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 336);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1429, 56);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // L_mainFromNameLabel
            // 
            this.L_mainFromNameLabel.AutoSize = true;
            this.L_mainFromNameLabel.BackColor = System.Drawing.Color.DimGray;
            this.L_mainFromNameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.L_mainFromNameLabel.Location = new System.Drawing.Point(14, 14);
            this.L_mainFromNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_mainFromNameLabel.Name = "L_mainFromNameLabel";
            this.L_mainFromNameLabel.Size = new System.Drawing.Size(62, 18);
            this.L_mainFromNameLabel.TabIndex = 2;
            this.L_mainFromNameLabel.Text = "급식소";
            // 
            // l_exitLabel
            // 
            this.l_exitLabel.AutoSize = true;
            this.l_exitLabel.BackColor = System.Drawing.Color.DimGray;
            this.l_exitLabel.ForeColor = System.Drawing.Color.Transparent;
            this.l_exitLabel.Location = new System.Drawing.Point(1361, 14);
            this.l_exitLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_exitLabel.Name = "l_exitLabel";
            this.l_exitLabel.Size = new System.Drawing.Size(19, 18);
            this.l_exitLabel.TabIndex = 3;
            this.l_exitLabel.Text = "X";
            this.l_exitLabel.Click += new System.EventHandler(this.l_exitLabel_Click);
            // 
            // l_windowMinimize
            // 
            this.l_windowMinimize.AutoSize = true;
            this.l_windowMinimize.BackColor = System.Drawing.Color.DimGray;
            this.l_windowMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.l_windowMinimize.Location = new System.Drawing.Point(1337, 14);
            this.l_windowMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_windowMinimize.Name = "l_windowMinimize";
            this.l_windowMinimize.Size = new System.Drawing.Size(17, 18);
            this.l_windowMinimize.TabIndex = 4;
            this.l_windowMinimize.Text = "_";
            this.l_windowMinimize.Click += new System.EventHandler(this.l_windowMinimize_Click);
            // 
            // l_names
            // 
            this.l_names.FormattingEnabled = true;
            this.l_names.ItemHeight = 18;
            this.l_names.Location = new System.Drawing.Point(9, 30);
            this.l_names.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.l_names.Name = "l_names";
            this.l_names.Size = new System.Drawing.Size(230, 418);
            this.l_names.TabIndex = 5;
            this.l_names.SelectedIndexChanged += new System.EventHandler(this.l_names_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.l_changeName);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Controls.Add(this.forPrint1);
            this.groupBox2.Controls.Add(this.l_names);
            this.groupBox2.Location = new System.Drawing.Point(401, 48);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(979, 459);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 198);
            this.label1.TabIndex = 10;
            this.label1.Text = "메모용.\r\n표시할 값들은\r\nforPrintClass안에 있는 합쳐진 이름\r\nInstitution\r\nNumber\r\nLocation\r\ntarget\r\n" +
    "Time\r\nDatoftheweek\r\n\r\ndb스크린샷은 깃에 같이 업로드 되어있다\r\n";
            // 
            // l_changeName
            // 
            this.l_changeName.AutoSize = true;
            this.l_changeName.Location = new System.Drawing.Point(316, 34);
            this.l_changeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_changeName.Name = "l_changeName";
            this.l_changeName.Size = new System.Drawing.Size(44, 18);
            this.l_changeName.TabIndex = 9;
            this.l_changeName.Text = "이름";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(551, 30);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(29, 30);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(419, 418);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // forPrint1
            // 
            this.forPrint1.AutoSize = true;
            this.forPrint1.Location = new System.Drawing.Point(249, 34);
            this.forPrint1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forPrint1.Name = "forPrint1";
            this.forPrint1.Size = new System.Drawing.Size(62, 18);
            this.forPrint1.TabIndex = 6;
            this.forPrint1.Text = "이름 : ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.l_windowMinimize);
            this.Controls.Add(this.l_exitLabel);
            this.Controls.Add(this.L_mainFromNameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label L_mainFromNameLabel;
        private System.Windows.Forms.Label l_exitLabel;
        private System.Windows.Forms.Label l_windowMinimize;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.TextBox t_locationInput;
        private System.Windows.Forms.ComboBox c_location1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox l_names;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label forPrint1;
        private System.Windows.Forms.Button b_export;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label l_changeName;
        private System.Windows.Forms.CheckBox c_searchCheck;
        private System.Windows.Forms.Label label1;
    }
}

