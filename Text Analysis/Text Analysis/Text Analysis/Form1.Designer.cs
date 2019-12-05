namespace Text_Analysis
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countSizeOfVocabularyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLines = new System.Windows.Forms.TextBox();
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.textBoxVocabulary = new System.Windows.Forms.TextBox();
            this.listBoxWords = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRepetition = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countSizeOfVocabularyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 25);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // countSizeOfVocabularyToolStripMenuItem
            // 
            this.countSizeOfVocabularyToolStripMenuItem.Name = "countSizeOfVocabularyToolStripMenuItem";
            this.countSizeOfVocabularyToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.countSizeOfVocabularyToolStripMenuItem.Text = "Clear";
            this.countSizeOfVocabularyToolStripMenuItem.Click += new System.EventHandler(this.countSizeOfVocabularyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonImport.Location = new System.Drawing.Point(189, 32);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(194, 35);
            this.buttonImport.TabIndex = 1;
            this.buttonImport.Text = "Import File";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(38, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Lines:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(38, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Words:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(38, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Size of Vocabulary:";
            // 
            // textBoxLines
            // 
            this.textBoxLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLines.Location = new System.Drawing.Point(359, 309);
            this.textBoxLines.Name = "textBoxLines";
            this.textBoxLines.ReadOnly = true;
            this.textBoxLines.Size = new System.Drawing.Size(184, 26);
            this.textBoxLines.TabIndex = 6;
            // 
            // textBoxWords
            // 
            this.textBoxWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxWords.Location = new System.Drawing.Point(359, 339);
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.ReadOnly = true;
            this.textBoxWords.Size = new System.Drawing.Size(184, 26);
            this.textBoxWords.TabIndex = 7;
            // 
            // textBoxVocabulary
            // 
            this.textBoxVocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxVocabulary.Location = new System.Drawing.Point(359, 369);
            this.textBoxVocabulary.Name = "textBoxVocabulary";
            this.textBoxVocabulary.ReadOnly = true;
            this.textBoxVocabulary.Size = new System.Drawing.Size(184, 26);
            this.textBoxVocabulary.TabIndex = 8;
            // 
            // listBoxWords
            // 
            this.listBoxWords.FormattingEnabled = true;
            this.listBoxWords.Location = new System.Drawing.Point(584, 33);
            this.listBoxWords.Name = "listBoxWords";
            this.listBoxWords.Size = new System.Drawing.Size(290, 368);
            this.listBoxWords.TabIndex = 9;
            this.listBoxWords.SelectedIndexChanged += new System.EventHandler(this.listBoxWords_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(38, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of Times Selected Word Appears:";
            // 
            // textBoxRepetition
            // 
            this.textBoxRepetition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRepetition.Location = new System.Drawing.Point(418, 126);
            this.textBoxRepetition.Name = "textBoxRepetition";
            this.textBoxRepetition.ReadOnly = true;
            this.textBoxRepetition.Size = new System.Drawing.Size(125, 26);
            this.textBoxRepetition.TabIndex = 11;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 413);
            this.Controls.Add(this.textBoxRepetition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxWords);
            this.Controls.Add(this.textBoxVocabulary);
            this.Controls.Add(this.textBoxWords);
            this.Controls.Add(this.textBoxLines);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countSizeOfVocabularyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLines;
        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.TextBox textBoxVocabulary;
        private System.Windows.Forms.ListBox listBoxWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRepetition;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

