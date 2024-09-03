namespace ProjectKeygen
{
    partial class WW3Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.softwareLabel = new System.Windows.Forms.LinkLabel();
            this.teamLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.serialText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // softwareLabel
            // 
            this.softwareLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.softwareLabel.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.softwareLabel.Location = new System.Drawing.Point(12, 9);
            this.softwareLabel.Name = "softwareLabel";
            this.softwareLabel.Size = new System.Drawing.Size(368, 23);
            this.softwareLabel.TabIndex = 1;
            this.softwareLabel.TabStop = true;
            this.softwareLabel.Text = "World War 3 Runner v2.0.24";
            this.softwareLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.softwareLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.softwareLabel_LinkClicked);
            // 
            // teamLabel
            // 
            this.teamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.teamLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teamLabel.Location = new System.Drawing.Point(12, 269);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(275, 22);
            this.teamLabel.TabIndex = 2;
            this.teamLabel.Text = "TEAM CHINGCHONG 2024";
            this.teamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teamLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aboutButton.Location = new System.Drawing.Point(293, 269);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(87, 22);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // serialText
            // 
            this.serialText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serialText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serialText.Location = new System.Drawing.Point(98, 171);
            this.serialText.Name = "serialText";
            this.serialText.Size = new System.Drawing.Size(198, 18);
            this.serialText.TabIndex = 4;
            this.serialText.Text = "1234-5678";
            this.serialText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.2F);
            this.label3.Location = new System.Drawing.Point(50, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Serial:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // generateButton
            // 
            this.generateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generateButton.Location = new System.Drawing.Point(141, 192);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(111, 37);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // WW3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 300);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serialText);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.softwareLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WW3Form";
            this.Text = "WW3";
            this.Load += new System.EventHandler(this.WW3Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel softwareLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label serialText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button generateButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

