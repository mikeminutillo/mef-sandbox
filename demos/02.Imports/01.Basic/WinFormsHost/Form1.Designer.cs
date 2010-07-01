namespace WinFormsHost
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
            this.CommandTextbox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GoButton = new System.Windows.Forms.Button();
            this.FeedbackTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommandTextbox
            // 
            this.CommandTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandTextbox.Location = new System.Drawing.Point(0, 2);
            this.CommandTextbox.Name = "CommandTextbox";
            this.CommandTextbox.Size = new System.Drawing.Size(211, 20);
            this.CommandTextbox.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FeedbackTextbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GoButton);
            this.splitContainer1.Panel2.Controls.Add(this.CommandTextbox);
            this.splitContainer1.Size = new System.Drawing.Size(292, 266);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 2;
            // 
            // GoButton
            // 
            this.GoButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.GoButton.Location = new System.Drawing.Point(217, 0);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 25);
            this.GoButton.TabIndex = 1;
            this.GoButton.TabStop = false;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // FeedbackTextbox
            // 
            this.FeedbackTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedbackTextbox.Location = new System.Drawing.Point(0, 0);
            this.FeedbackTextbox.Multiline = true;
            this.FeedbackTextbox.Name = "FeedbackTextbox";
            this.FeedbackTextbox.ReadOnly = true;
            this.FeedbackTextbox.Size = new System.Drawing.Size(292, 237);
            this.FeedbackTextbox.TabIndex = 0;
            this.FeedbackTextbox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.GoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "MEF Rules";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CommandTextbox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox FeedbackTextbox;
        private System.Windows.Forms.Button GoButton;
    }
}

