namespace PlayMarioWorld
{
    partial class Options
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
            this.StartButton = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.ProgressDisplay = new System.Windows.Forms.ProgressBar();
            this.ProgressText = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Log = new System.Windows.Forms.ListView();
            this.DescriptionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 332);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 51);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(12, 389);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(108, 51);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "End";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // ProgressDisplay
            // 
            this.ProgressDisplay.BackColor = System.Drawing.Color.Purple;
            this.ProgressDisplay.ForeColor = System.Drawing.Color.Purple;
            this.ProgressDisplay.Location = new System.Drawing.Point(12, 52);
            this.ProgressDisplay.Name = "ProgressDisplay";
            this.ProgressDisplay.Size = new System.Drawing.Size(451, 23);
            this.ProgressDisplay.TabIndex = 2;
            this.ProgressDisplay.Value = 1;
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.Location = new System.Drawing.Point(181, 97);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(129, 13);
            this.ProgressText.TabIndex = 3;
            this.ProgressText.Text = "Progress Untill Completion";
            this.ProgressText.UseMnemonic = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 420);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Log
            // 
            this.Log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DescriptionHeader});
            this.Log.HideSelection = false;
            this.Log.Location = new System.Drawing.Point(272, 164);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(200, 250);
            this.Log.TabIndex = 6;
            this.Log.UseCompatibleStateImageBehavior = false;
            this.Log.View = System.Windows.Forms.View.SmallIcon;
            this.Log.SelectedIndexChanged += new System.EventHandler(this.Log_SelectedIndexChanged);
            // 
            // DescriptionHeader
            // 
            this.DescriptionHeader.Text = "Victor :)";
            this.DescriptionHeader.Width = 200;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(337, 148);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(75, 13);
            this.logLabel.TabIndex = 7;
            this.logLabel.Text = "Command Log";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(112, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(254, 28);
            this.Title.TabIndex = 8;
            this.Title.Text = "Super Mario Bros. Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Victor Henney";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 196);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ProgressText);
            this.Controls.Add(this.ProgressDisplay);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.StartButton);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victor\'s Mario Bot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.ProgressBar ProgressDisplay;
        private System.Windows.Forms.Label ProgressText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView Log;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.ColumnHeader DescriptionHeader;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

