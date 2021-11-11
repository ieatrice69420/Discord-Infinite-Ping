namespace DiscordInfinitePing
{
    partial class discordInfinitePingWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(discordInfinitePingWindow));
            this.minDelayBetweenPingsInput = new System.Windows.Forms.TextBox();
            this.minDelayBetweenPingsLabel = new System.Windows.Forms.Label();
            this.maxDelayBetweenPingsLabel = new System.Windows.Forms.Label();
            this.maxDelayBetweenPingsInput = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minDelayBetweenPingsInput
            // 
            resources.ApplyResources(this.minDelayBetweenPingsInput, "minDelayBetweenPingsInput");
            this.minDelayBetweenPingsInput.Name = "minDelayBetweenPingsInput";
            this.minDelayBetweenPingsInput.TextChanged += new System.EventHandler(this.minDelayBetweenPingsInput_TextChanged);
            // 
            // minDelayBetweenPingsLabel
            // 
            resources.ApplyResources(this.minDelayBetweenPingsLabel, "minDelayBetweenPingsLabel");
            this.minDelayBetweenPingsLabel.Name = "minDelayBetweenPingsLabel";
            this.minDelayBetweenPingsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxDelayBetweenPingsLabel
            // 
            resources.ApplyResources(this.maxDelayBetweenPingsLabel, "maxDelayBetweenPingsLabel");
            this.maxDelayBetweenPingsLabel.Name = "maxDelayBetweenPingsLabel";
            this.maxDelayBetweenPingsLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // maxDelayBetweenPingsInput
            // 
            resources.ApplyResources(this.maxDelayBetweenPingsInput, "maxDelayBetweenPingsInput");
            this.maxDelayBetweenPingsInput.Name = "maxDelayBetweenPingsInput";
            this.maxDelayBetweenPingsInput.TextChanged += new System.EventHandler(this.maxDelayBetweenPingsInput_TextChanged);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Hide
            // 
            resources.ApplyResources(this.Hide, "Hide");
            this.Hide.Name = "Hide";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // discordInfinitePingWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.maxDelayBetweenPingsLabel);
            this.Controls.Add(this.maxDelayBetweenPingsInput);
            this.Controls.Add(this.minDelayBetweenPingsLabel);
            this.Controls.Add(this.minDelayBetweenPingsInput);
            this.Name = "discordInfinitePingWindow";
            this.Load += new System.EventHandler(this.DiscordInfinitePingWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minDelayBetweenPingsInput;
        private System.Windows.Forms.Label minDelayBetweenPingsLabel;
        private System.Windows.Forms.Label maxDelayBetweenPingsLabel;
        private System.Windows.Forms.TextBox maxDelayBetweenPingsInput;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button Hide;
    }
}

