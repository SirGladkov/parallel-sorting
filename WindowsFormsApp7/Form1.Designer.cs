namespace ParallelSortingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lstOriginal = new System.Windows.Forms.ListBox();
            this.lstBubble = new System.Windows.Forms.ListBox();
            this.lstQuick = new System.Windows.Forms.ListBox();
            this.lstMerge = new System.Windows.Forms.ListBox();
            this.lblBubbleStatus = new System.Windows.Forms.Label();
            this.lblQuickStatus = new System.Windows.Forms.Label();
            this.lblMergeStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
           
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 15);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(97, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Размер массива:";
          
            this.txtSize.Location = new System.Drawing.Point(120, 12);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 1;
            this.txtSize.Text = "100";
          
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(12, 45);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(86, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Мин. значение:";
            
            this.txtMin.Location = new System.Drawing.Point(120, 42);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(100, 20);
            this.txtMin.TabIndex = 3;
            this.txtMin.Text = "1";
            
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(12, 75);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(90, 13);
            this.lblMax.TabIndex = 4;
            this.lblMax.Text = "Макс. значение:";
            
            this.txtMax.Location = new System.Drawing.Point(120, 72);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(100, 20);
            this.txtMax.TabIndex = 5;
            this.txtMax.Text = "1000";
            
            this.btnStart.Location = new System.Drawing.Point(12, 105);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(208, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Запустить сортировки";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
           
            this.lstOriginal.FormattingEnabled = true;
            this.lstOriginal.HorizontalScrollbar = true;
            this.lstOriginal.Location = new System.Drawing.Point(12, 140);
            this.lstOriginal.Name = "lstOriginal";
            this.lstOriginal.Size = new System.Drawing.Size(120, 147);
            this.lstOriginal.TabIndex = 7;
            
            this.lstBubble.FormattingEnabled = true;
            this.lstBubble.HorizontalScrollbar = true;
            this.lstBubble.Location = new System.Drawing.Point(150, 140);
            this.lstBubble.Name = "lstBubble";
            this.lstBubble.Size = new System.Drawing.Size(120, 147);
            this.lstBubble.TabIndex = 8;
            
            this.lstQuick.FormattingEnabled = true;
            this.lstQuick.HorizontalScrollbar = true;
            this.lstQuick.Location = new System.Drawing.Point(290, 140);
            this.lstQuick.Name = "lstQuick";
            this.lstQuick.Size = new System.Drawing.Size(120, 147);
            this.lstQuick.TabIndex = 9;
          
            this.lstMerge.FormattingEnabled = true;
            this.lstMerge.HorizontalScrollbar = true;
            this.lstMerge.Location = new System.Drawing.Point(430, 140);
            this.lstMerge.Name = "lstMerge";
            this.lstMerge.Size = new System.Drawing.Size(120, 147);
            this.lstMerge.TabIndex = 10;
           
            this.lblBubbleStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBubbleStatus.Location = new System.Drawing.Point(150, 300);
            this.lblBubbleStatus.Name = "lblBubbleStatus";
            this.lblBubbleStatus.Size = new System.Drawing.Size(120, 60);
            this.lblBubbleStatus.TabIndex = 11;
            this.lblBubbleStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
           
            this.lblQuickStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuickStatus.Location = new System.Drawing.Point(290, 300);
            this.lblQuickStatus.Name = "lblQuickStatus";
            this.lblQuickStatus.Size = new System.Drawing.Size(120, 60);
            this.lblQuickStatus.TabIndex = 12;
            this.lblQuickStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
          
            this.lblMergeStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMergeStatus.Location = new System.Drawing.Point(430, 300);
            this.lblMergeStatus.Name = "lblMergeStatus";
            this.lblMergeStatus.Size = new System.Drawing.Size(120, 60);
            this.lblMergeStatus.TabIndex = 13;
            this.lblMergeStatus.TextAlign = System.Drawing.ContentAlignment.TopLeft;
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 380);
            this.Controls.Add(this.lblMergeStatus);
            this.Controls.Add(this.lblQuickStatus);
            this.Controls.Add(this.lblBubbleStatus);
            this.Controls.Add(this.lstMerge);
            this.Controls.Add(this.lstQuick);
            this.Controls.Add(this.lstBubble);
            this.Controls.Add(this.lstOriginal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Name = "Form1";
            this.Text = "Параллельные сортировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstOriginal;
        private System.Windows.Forms.ListBox lstBubble;
        private System.Windows.Forms.ListBox lstQuick;
        private System.Windows.Forms.ListBox lstMerge;
        private System.Windows.Forms.Label lblBubbleStatus;
        private System.Windows.Forms.Label lblQuickStatus;
        private System.Windows.Forms.Label lblMergeStatus;
    }
}

