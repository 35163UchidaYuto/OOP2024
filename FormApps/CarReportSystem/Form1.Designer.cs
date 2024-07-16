namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            cbAuthor = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbCarName = new ComboBox();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            tbReport = new TextBox();
            label6 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label7 = new Label();
            dgvCarReport = new DataGridView();
            ofdPicFileOpen = new OpenFileDialog();
            ssMessageArea = new StatusStrip();
            tslbMessage = new ToolStripStatusLabel();
            ofdReportFileOpen = new OpenFileDialog();
            sfdReportFileSave = new SaveFileDialog();
            btClear = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ヘルプhToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            cdColor = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            ssMessageArea.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(41, 51);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(101, 45);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(198, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(22, 103);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者";
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(101, 100);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(302, 33);
            cbAuthor.TabIndex = 2;
            cbAuthor.TextChanged += cbAuthor_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(28, 149);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 0;
            label3.Text = "メーカー";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(41, 202);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(24, 247);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(101, 199);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(302, 33);
            cbCarName.TabIndex = 2;
            cbCarName.TextChanged += cbCarName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(102, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 38);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Checked = true;
            rbOther.Location = new Point(307, 15);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(240, 15);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 0;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(180, 15);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 0;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(121, 15);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 0;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(66, 15);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 0;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(10, 15);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.BackColor = SystemColors.Window;
            tbReport.BorderStyle = BorderStyle.FixedSingle;
            tbReport.Location = new Point(101, 247);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(376, 93);
            tbReport.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(512, 58);
            label6.Name = "label6";
            label6.Size = new Size(50, 25);
            label6.TabIndex = 0;
            label6.Text = "画像";
            // 
            // btPicOpen
            // 
            btPicOpen.BackColor = SystemColors.Info;
            btPicOpen.FlatStyle = FlatStyle.Flat;
            btPicOpen.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btPicOpen.Location = new Point(587, 60);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(75, 23);
            btPicOpen.TabIndex = 5;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = false;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.BackColor = SystemColors.Info;
            btPicDelete.FlatStyle = FlatStyle.Flat;
            btPicDelete.Location = new Point(668, 60);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(75, 23);
            btPicDelete.TabIndex = 5;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = false;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = SystemColors.ActiveCaption;
            pbPicture.Location = new Point(512, 86);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(251, 206);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 6;
            pbPicture.TabStop = false;
            // 
            // btAddReport
            // 
            btAddReport.BackColor = SystemColors.Info;
            btAddReport.FlatStyle = FlatStyle.Flat;
            btAddReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddReport.Location = new Point(522, 303);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(65, 37);
            btAddReport.TabIndex = 5;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = false;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.BackColor = SystemColors.Info;
            btModifyReport.FlatStyle = FlatStyle.Flat;
            btModifyReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifyReport.Location = new Point(603, 303);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(72, 37);
            btModifyReport.TabIndex = 5;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = false;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.BackColor = Color.FromArgb(255, 192, 192);
            btDeleteReport.FlatStyle = FlatStyle.Flat;
            btDeleteReport.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteReport.Location = new Point(692, 303);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(71, 37);
            btDeleteReport.TabIndex = 5;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = false;
            btDeleteReport.Click += btDeleteReport_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(41, 358);
            label7.Name = "label7";
            label7.Size = new Size(50, 25);
            label7.TabIndex = 0;
            label7.Text = "一覧";
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.AllowUserToResizeRows = false;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(97, 358);
            dgvCarReport.MultiSelect = false;
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.RowHeadersVisible = false;
            dgvCarReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarReport.Size = new Size(666, 150);
            dgvCarReport.TabIndex = 7;
            dgvCarReport.Click += dgvCarReport_Click;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // ssMessageArea
            // 
            ssMessageArea.Items.AddRange(new ToolStripItem[] { tslbMessage });
            ssMessageArea.Location = new Point(0, 511);
            ssMessageArea.Name = "ssMessageArea";
            ssMessageArea.Size = new Size(780, 22);
            ssMessageArea.SizingGrip = false;
            ssMessageArea.TabIndex = 8;
            ssMessageArea.Text = "statusStrip1";
            // 
            // tslbMessage
            // 
            tslbMessage.Name = "tslbMessage";
            tslbMessage.Size = new Size(0, 17);
            // 
            // ofdReportFileOpen
            // 
            ofdReportFileOpen.FileName = "openFileDialog1";
            // 
            // btClear
            // 
            btClear.BackColor = SystemColors.HighlightText;
            btClear.FlatStyle = FlatStyle.Flat;
            btClear.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btClear.Location = new Point(435, 51);
            btClear.Name = "btClear";
            btClear.Size = new Size(71, 27);
            btClear.TabIndex = 9;
            btClear.Text = "項目クリア";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, ファイルFToolStripMenuItem, toolStripMenuItem2, ヘルプhToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(780, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, 色設定ToolStripMenuItem, 終了ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(119, 22);
            開くToolStripMenuItem.Text = "開く...";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(119, 22);
            保存ToolStripMenuItem.Text = "保存...";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(119, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(119, 22);
            終了ToolStripMenuItem.Text = "終了";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(12, 20);
            // 
            // ヘルプhToolStripMenuItem
            // 
            ヘルプhToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプhToolStripMenuItem.Name = "ヘルプhToolStripMenuItem";
            ヘルプhToolStripMenuItem.Size = new Size(65, 20);
            ヘルプhToolStripMenuItem.Text = "ヘルプ&(H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(180, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて";
            このアプリについてToolStripMenuItem.Click += このアプリについてToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 533);
            Controls.Add(btClear);
            Controls.Add(ssMessageArea);
            Controls.Add(menuStrip1);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(btPicDelete);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btAddReport);
            Controls.Add(btPicOpen);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ssMessageArea.ResumeLayout(false);
            ssMessageArea.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private ComboBox cbAuthor;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbCarName;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private TextBox tbReport;
        private Label label6;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label7;
        private DataGridView dgvCarReport;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip ssMessageArea;
        private ToolStripStatusLabel tslbMessage;
        private OpenFileDialog ofdReportFileOpen;
        private SaveFileDialog sfdReportFileSave;
        private Button btClear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ColorDialog cdColor;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem ヘルプhToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
    }
}
