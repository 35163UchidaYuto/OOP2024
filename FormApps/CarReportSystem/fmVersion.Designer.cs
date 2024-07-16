namespace CarReportSystem {
    partial class fmVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btVersionOk = new Button();
            label1 = new Label();
            lbVersion = new Label();
            SuspendLayout();
            // 
            // btVersionOk
            // 
            btVersionOk.Location = new Point(267, 140);
            btVersionOk.Name = "btVersionOk";
            btVersionOk.Size = new Size(75, 23);
            btVersionOk.TabIndex = 0;
            btVersionOk.Text = "OK";
            btVersionOk.UseVisualStyleBackColor = true;
            btVersionOk.Click += btVersionOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 17.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 128);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 1;
            label1.Text = "CarReportSystem";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbVersion.Location = new Point(65, 80);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(49, 15);
            lbVersion.TabIndex = 1;
            lbVersion.Text = "Ver.0.0.1";
            // 
            // fmVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 238);
            Controls.Add(lbVersion);
            Controls.Add(label1);
            Controls.Add(btVersionOk);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "fmVersion";
            Text = "fmVersion";
            Load += fmVersion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVersionOk;
        private Label label1;
        private Label lbVersion;
    }
}