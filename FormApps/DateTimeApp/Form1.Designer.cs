namespace DateTimeApp {
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
            btDateCount = new Button();
            tbDisp = new TextBox();
            nudDay = new NumericUpDown();
            dtDayBefore = new Button();
            btDayAfter = new Button();
            btage = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(52, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(168, 37);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 39);
            dtpDate.TabIndex = 1;
            // 
            // btDateCount
            // 
            btDateCount.Location = new Point(186, 104);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(103, 65);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(52, 195);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(293, 39);
            tbDisp.TabIndex = 3;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 22F);
            nudDay.Location = new Point(137, 265);
            nudDay.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 47);
            nudDay.TabIndex = 4;
            // 
            // dtDayBefore
            // 
            dtDayBefore.Font = new Font("Yu Gothic UI", 13F);
            dtDayBefore.Location = new Point(433, 87);
            dtDayBefore.Name = "dtDayBefore";
            dtDayBefore.Size = new Size(75, 44);
            dtDayBefore.TabIndex = 5;
            dtDayBefore.Text = "日前";
            dtDayBefore.UseVisualStyleBackColor = true;
            dtDayBefore.Click += btDayBefore_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Font = new Font("Yu Gothic UI", 13F);
            btDayAfter.Location = new Point(410, 183);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(75, 35);
            btDayAfter.TabIndex = 6;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += btDayAfter_Click_1;
            // 
            // btage
            // 
            btage.Font = new Font("Yu Gothic UI", 13F);
            btage.Location = new Point(555, 163);
            btage.Name = "btage";
            btage.Size = new Size(75, 35);
            btage.TabIndex = 7;
            btage.Text = "年齢";
            btage.UseVisualStyleBackColor = true;
            btage.Click += btage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 461);
            Controls.Add(btage);
            Controls.Add(btDayAfter);
            Controls.Add(dtDayBefore);
            Controls.Add(nudDay);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpDate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Button btDateCount;
        private TextBox tbDisp;
        private NumericUpDown nudDay;
        private Button dtDayBefore;
        private Button btDayAfter;
        private Button btage;
    }
}
