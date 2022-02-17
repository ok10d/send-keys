namespace SendKeys
{
    partial class FormSendKeys
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.checkBox_trimSpaces = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(21, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(311, 129);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // button
            // 
            this.button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button.Location = new System.Drawing.Point(355, 35);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100, 69);
            this.button.TabIndex = 1;
            this.button.Text = "Send";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // checkBox_trimSpaces
            // 
            this.checkBox_trimSpaces.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_trimSpaces.AutoSize = true;
            this.checkBox_trimSpaces.Location = new System.Drawing.Point(355, 122);
            this.checkBox_trimSpaces.Name = "checkBox_trimSpaces";
            this.checkBox_trimSpaces.Size = new System.Drawing.Size(88, 19);
            this.checkBox_trimSpaces.TabIndex = 2;
            this.checkBox_trimSpaces.Text = "Trim Spaces";
            this.checkBox_trimSpaces.UseVisualStyleBackColor = true;
            // 
            // FormSendKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(493, 167);
            this.Controls.Add(this.checkBox_trimSpaces);
            this.Controls.Add(this.button);
            this.Controls.Add(this.richTextBox);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "FormSendKeys";
            this.Text = "SendKeys";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox;
        private Button button;
        private CheckBox checkBox_trimSpaces;
    }
}