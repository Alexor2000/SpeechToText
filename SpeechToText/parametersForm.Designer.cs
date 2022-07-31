namespace SpeechToText
{
    partial class parametersForm
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
            this.startingButton = new System.Windows.Forms.Button();
            this.onAirTextbox = new System.Windows.Forms.TextBox();
            this.endingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingButton
            // 
            this.startingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.startingButton.Location = new System.Drawing.Point(12, 12);
            this.startingButton.Name = "startingButton";
            this.startingButton.Size = new System.Drawing.Size(127, 23);
            this.startingButton.TabIndex = 0;
            this.startingButton.Text = "Start";
            this.startingButton.UseVisualStyleBackColor = true;
            this.startingButton.Click += new System.EventHandler(this.startingButton_Click);
            // 
            // onAirTextbox
            // 
            this.onAirTextbox.Location = new System.Drawing.Point(12, 41);
            this.onAirTextbox.Name = "onAirTextbox";
            this.onAirTextbox.Size = new System.Drawing.Size(260, 20);
            this.onAirTextbox.TabIndex = 2;
            // 
            // endingButton
            // 
            this.endingButton.Location = new System.Drawing.Point(145, 12);
            this.endingButton.Name = "endingButton";
            this.endingButton.Size = new System.Drawing.Size(127, 23);
            this.endingButton.TabIndex = 3;
            this.endingButton.Text = "End";
            this.endingButton.UseVisualStyleBackColor = true;
            this.endingButton.Click += new System.EventHandler(this.endingButton_Click);
            // 
            // parametersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.endingButton);
            this.Controls.Add(this.onAirTextbox);
            this.Controls.Add(this.startingButton);
            this.Name = "parametersForm";
            this.Text = "Speech-To-Text";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.parametersForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startingButton;
        private System.Windows.Forms.TextBox onAirTextbox;
        private System.Windows.Forms.Button endingButton;
    }
}