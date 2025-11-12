namespace VibeHive
{
    partial class Form1
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
            playlistBuilderBtn = new Button();
            musicRentalBtn = new Button();
            albumManageBtn = new Button();
            SuspendLayout();
            // 
            // playlistBuilderBtn
            // 
            playlistBuilderBtn.Location = new Point(160, 51);
            playlistBuilderBtn.Name = "playlistBuilderBtn";
            playlistBuilderBtn.Size = new Size(129, 85);
            playlistBuilderBtn.TabIndex = 2;
            playlistBuilderBtn.Text = "Playlist Builder (wip)";
            playlistBuilderBtn.UseVisualStyleBackColor = true;
            playlistBuilderBtn.Click += playlistBuilderBtn_Click;
            // 
            // musicRentalBtn
            // 
            musicRentalBtn.Location = new Point(295, 51);
            musicRentalBtn.Name = "musicRentalBtn";
            musicRentalBtn.Size = new Size(129, 85);
            musicRentalBtn.TabIndex = 3;
            musicRentalBtn.Text = "Music Rental";
            musicRentalBtn.UseVisualStyleBackColor = true;
            musicRentalBtn.Click += musicRentalBtn_Click;
            // 
            // albumManageBtn
            // 
            albumManageBtn.Location = new Point(25, 51);
            albumManageBtn.Name = "albumManageBtn";
            albumManageBtn.Size = new Size(129, 85);
            albumManageBtn.TabIndex = 1;
            albumManageBtn.Text = "Album Management";
            albumManageBtn.UseVisualStyleBackColor = true;
            albumManageBtn.Click += albumManageBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 196);
            Controls.Add(albumManageBtn);
            Controls.Add(musicRentalBtn);
            Controls.Add(playlistBuilderBtn);
            Name = "Form1";
            Text = "VibeHive";
            ResumeLayout(false);
        }

        #endregion

        private Button playlistBuilderBtn;
        private Button musicRentalBtn;
        private Button albumManageBtn;
    }
}
