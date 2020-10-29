namespace BookApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblReadAndCount = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnGetFileDirectory = new System.Windows.Forms.Button();
            this.rtbBookOutput = new System.Windows.Forms.RichTextBox();
            this.lblTopWords = new System.Windows.Forms.Label();
            this.lblTopWords2 = new System.Windows.Forms.Label();
            this.rtbLinesAndWordsInFile = new System.Windows.Forms.RichTextBox();
            this.rtbProcessTime = new System.Windows.Forms.RichTextBox();
            this.btnReadAndProcessFile = new System.Windows.Forms.Button();
            this.richTextBoxTopWords = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTopWords2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblReadAndCount
            // 
            this.lblReadAndCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReadAndCount.AutoSize = true;
            this.lblReadAndCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadAndCount.Location = new System.Drawing.Point(13, 13);
            this.lblReadAndCount.Name = "lblReadAndCount";
            this.lblReadAndCount.Size = new System.Drawing.Size(139, 15);
            this.lblReadAndCount.TabIndex = 0;
            this.lblReadAndCount.Text = "File To Read And Count:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFilePath.Location = new System.Drawing.Point(158, 12);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(335, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnGetFileDirectory
            // 
            this.btnGetFileDirectory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGetFileDirectory.Location = new System.Drawing.Point(499, 12);
            this.btnGetFileDirectory.Name = "btnGetFileDirectory";
            this.btnGetFileDirectory.Size = new System.Drawing.Size(29, 20);
            this.btnGetFileDirectory.TabIndex = 2;
            this.btnGetFileDirectory.Text = "..";
            this.btnGetFileDirectory.UseVisualStyleBackColor = true;
            this.btnGetFileDirectory.Click += new System.EventHandler(this.btnGetFileDirectory_Click);
            // 
            // rtbBookOutput
            // 
            this.rtbBookOutput.Location = new System.Drawing.Point(12, 131);
            this.rtbBookOutput.Name = "rtbBookOutput";
            this.rtbBookOutput.Size = new System.Drawing.Size(516, 348);
            this.rtbBookOutput.TabIndex = 3;
            this.rtbBookOutput.Text = "";
            // 
            // lblTopWords
            // 
            this.lblTopWords.AutoSize = true;
            this.lblTopWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopWords.Location = new System.Drawing.Point(577, 13);
            this.lblTopWords.Name = "lblTopWords";
            this.lblTopWords.Size = new System.Drawing.Size(87, 13);
            this.lblTopWords.TabIndex = 6;
            this.lblTopWords.Text = "Top 50 Words";
            // 
            // lblTopWords2
            // 
            this.lblTopWords2.AutoSize = true;
            this.lblTopWords2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopWords2.Location = new System.Drawing.Point(714, 13);
            this.lblTopWords2.Name = "lblTopWords2";
            this.lblTopWords2.Size = new System.Drawing.Size(179, 13);
            this.lblTopWords2.TabIndex = 7;
            this.lblTopWords2.Text = "Top 50 Words with Lenght > 6";
            // 
            // rtbLinesAndWordsInFile
            // 
            this.rtbLinesAndWordsInFile.Location = new System.Drawing.Point(12, 38);
            this.rtbLinesAndWordsInFile.Name = "rtbLinesAndWordsInFile";
            this.rtbLinesAndWordsInFile.Size = new System.Drawing.Size(170, 87);
            this.rtbLinesAndWordsInFile.TabIndex = 8;
            this.rtbLinesAndWordsInFile.Text = "";
            // 
            // rtbProcessTime
            // 
            this.rtbProcessTime.Location = new System.Drawing.Point(188, 38);
            this.rtbProcessTime.Name = "rtbProcessTime";
            this.rtbProcessTime.Size = new System.Drawing.Size(186, 87);
            this.rtbProcessTime.TabIndex = 9;
            this.rtbProcessTime.Text = "";
            // 
            // btnReadAndProcessFile
            // 
            this.btnReadAndProcessFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadAndProcessFile.Location = new System.Drawing.Point(381, 39);
            this.btnReadAndProcessFile.Name = "btnReadAndProcessFile";
            this.btnReadAndProcessFile.Size = new System.Drawing.Size(147, 86);
            this.btnReadAndProcessFile.TabIndex = 10;
            this.btnReadAndProcessFile.Text = "Read and Process File";
            this.btnReadAndProcessFile.UseVisualStyleBackColor = true;
            this.btnReadAndProcessFile.Click += new System.EventHandler(this.btnReadAndProcessFile_Click);
            // 
            // richTextBoxTopWords
            // 
            this.richTextBoxTopWords.Location = new System.Drawing.Point(541, 33);
            this.richTextBoxTopWords.Name = "richTextBoxTopWords";
            this.richTextBoxTopWords.Size = new System.Drawing.Size(170, 446);
            this.richTextBoxTopWords.TabIndex = 11;
            this.richTextBoxTopWords.Text = "";
            // 
            // richTextBoxTopWords2
            // 
            this.richTextBoxTopWords2.Location = new System.Drawing.Point(717, 33);
            this.richTextBoxTopWords2.Name = "richTextBoxTopWords2";
            this.richTextBoxTopWords2.Size = new System.Drawing.Size(176, 446);
            this.richTextBoxTopWords2.TabIndex = 12;
            this.richTextBoxTopWords2.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 491);
            this.Controls.Add(this.richTextBoxTopWords2);
            this.Controls.Add(this.richTextBoxTopWords);
            this.Controls.Add(this.btnReadAndProcessFile);
            this.Controls.Add(this.rtbProcessTime);
            this.Controls.Add(this.rtbLinesAndWordsInFile);
            this.Controls.Add(this.lblTopWords2);
            this.Controls.Add(this.lblTopWords);
            this.Controls.Add(this.rtbBookOutput);
            this.Controls.Add(this.btnGetFileDirectory);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblReadAndCount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(914, 530);
            this.MinimumSize = new System.Drawing.Size(914, 530);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReadAndCount;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Button btnGetFileDirectory;
        private System.Windows.Forms.RichTextBox rtbBookOutput;
        private System.Windows.Forms.Label lblTopWords;
        private System.Windows.Forms.Label lblTopWords2;
        private System.Windows.Forms.RichTextBox rtbLinesAndWordsInFile;
        private System.Windows.Forms.RichTextBox rtbProcessTime;
        private System.Windows.Forms.Button btnReadAndProcessFile;
        private System.Windows.Forms.RichTextBox richTextBoxTopWords;
        private System.Windows.Forms.RichTextBox richTextBoxTopWords2;
    }
}

