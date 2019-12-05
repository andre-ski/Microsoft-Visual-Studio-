namespace SushiGo_
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
            this.listBoxPlayer1 = new System.Windows.Forms.ListBox();
            this.buttonDeal = new System.Windows.Forms.Button();
            this.listBoxPlayer2 = new System.Windows.Forms.ListBox();
            this.listBoxPlayArea1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxPlayArea2 = new System.Windows.Forms.ListBox();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.textBoxPlayer2Points = new System.Windows.Forms.TextBox();
            this.buttonPlayPlayer2 = new System.Windows.Forms.Button();
            this.textBoxPlayerPoints = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxPlayer1
            // 
            this.listBoxPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayer1.FormattingEnabled = true;
            this.listBoxPlayer1.Location = new System.Drawing.Point(3, 34);
            this.listBoxPlayer1.Name = "listBoxPlayer1";
            this.listBoxPlayer1.Size = new System.Drawing.Size(287, 394);
            this.listBoxPlayer1.TabIndex = 0;
            this.listBoxPlayer1.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayer1_SelectedIndexChanged);
            // 
            // buttonDeal
            // 
            this.buttonDeal.Location = new System.Drawing.Point(296, 437);
            this.buttonDeal.Name = "buttonDeal";
            this.buttonDeal.Size = new System.Drawing.Size(169, 35);
            this.buttonDeal.TabIndex = 2;
            this.buttonDeal.Text = "Deal! / New Round";
            this.buttonDeal.UseVisualStyleBackColor = true;
            this.buttonDeal.Click += new System.EventHandler(this.buttonDeal_Click);
            // 
            // listBoxPlayer2
            // 
            this.listBoxPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayer2.FormattingEnabled = true;
            this.listBoxPlayer2.Location = new System.Drawing.Point(1013, 34);
            this.listBoxPlayer2.Name = "listBoxPlayer2";
            this.listBoxPlayer2.Size = new System.Drawing.Size(282, 394);
            this.listBoxPlayer2.TabIndex = 3;
            this.listBoxPlayer2.SelectedIndexChanged += new System.EventHandler(this.listBoxPlayer2_SelectedIndexChanged);
            // 
            // listBoxPlayArea1
            // 
            this.listBoxPlayArea1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayArea1.FormattingEnabled = true;
            this.listBoxPlayArea1.Location = new System.Drawing.Point(296, 34);
            this.listBoxPlayArea1.Name = "listBoxPlayArea1";
            this.listBoxPlayArea1.Size = new System.Drawing.Size(296, 394);
            this.listBoxPlayArea1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1227, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player1 ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Player Area";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1310, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearBoardToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearBoardToolStripMenuItem
            // 
            this.clearBoardToolStripMenuItem.Name = "clearBoardToolStripMenuItem";
            this.clearBoardToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.clearBoardToolStripMenuItem.Text = "Clear Board";
            this.clearBoardToolStripMenuItem.Click += new System.EventHandler(this.clearBoardToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // listBoxPlayArea2
            // 
            this.listBoxPlayArea2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlayArea2.FormattingEnabled = true;
            this.listBoxPlayArea2.Location = new System.Drawing.Point(723, 34);
            this.listBoxPlayArea2.Name = "listBoxPlayArea2";
            this.listBoxPlayArea2.Size = new System.Drawing.Size(284, 394);
            this.listBoxPlayArea2.TabIndex = 10;
            // 
            // buttonSwap
            // 
            this.buttonSwap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSwap.Location = new System.Drawing.Point(606, 437);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(103, 35);
            this.buttonSwap.TabIndex = 11;
            this.buttonSwap.Text = "Swap!";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(3, 437);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(158, 35);
            this.buttonPlay.TabIndex = 14;
            this.buttonPlay.Text = "Play Selected Card";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.26821F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.680285F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.38011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.94211F));
            this.tableLayoutPanel1.Controls.Add(this.buttonFinish, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSwap, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPlayer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPlayArea1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPlayer2, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPlayArea2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlay, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPlayer2Points, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlayPlayer2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeal, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPlayerPoints, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.512605F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.40337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.08403F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 484);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Location = new System.Drawing.Point(838, 437);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(169, 35);
            this.buttonFinish.TabIndex = 16;
            this.buttonFinish.Text = "Finish Game";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // textBoxPlayer2Points
            // 
            this.textBoxPlayer2Points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPlayer2Points.Location = new System.Drawing.Point(907, 3);
            this.textBoxPlayer2Points.Name = "textBoxPlayer2Points";
            this.textBoxPlayer2Points.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayer2Points.TabIndex = 18;
            this.textBoxPlayer2Points.Text = "Player2 Points";
            // 
            // buttonPlayPlayer2
            // 
            this.buttonPlayPlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlayPlayer2.Location = new System.Drawing.Point(1137, 437);
            this.buttonPlayPlayer2.Name = "buttonPlayPlayer2";
            this.buttonPlayPlayer2.Size = new System.Drawing.Size(158, 35);
            this.buttonPlayPlayer2.TabIndex = 20;
            this.buttonPlayPlayer2.Text = "Play Selected Card";
            this.buttonPlayPlayer2.UseVisualStyleBackColor = true;
            this.buttonPlayPlayer2.Click += new System.EventHandler(this.buttonPlayPlayer2_Click);
            // 
            // textBoxPlayerPoints
            // 
            this.textBoxPlayerPoints.Location = new System.Drawing.Point(296, 3);
            this.textBoxPlayerPoints.Name = "textBoxPlayerPoints";
            this.textBoxPlayerPoints.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlayerPoints.TabIndex = 21;
            this.textBoxPlayerPoints.Text = "Player1 Points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 523);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayer1;
        private System.Windows.Forms.Button buttonDeal;
        private System.Windows.Forms.ListBox listBoxPlayer2;
        private System.Windows.Forms.ListBox listBoxPlayArea1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxPlayArea2;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPlayer2Points;
        private System.Windows.Forms.Button buttonPlayPlayer2;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.TextBox textBoxPlayerPoints;
        private System.Windows.Forms.ToolStripMenuItem clearBoardToolStripMenuItem;
    }
}

