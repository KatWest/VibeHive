namespace VibeHive
{
    partial class CollaborativePlaylistBuilderForm
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
            listBox_Playlists = new ListBox();
            listBox_users = new ListBox();
            listBox_PlaylistSongs = new ListBox();
            button_createPlaylist = new Button();
            textBox_userId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox_playlistName = new TextBox();
            radioButton_true_isCollaborative = new RadioButton();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            radioButton_false_isCollaborative = new RadioButton();
            label5 = new Label();
            textBox_collabUserId = new TextBox();
            label6 = new Label();
            textBox_creatorId = new TextBox();
            button_AddCollaborator = new Button();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox_songTitle = new TextBox();
            label10 = new Label();
            textBox_playlistID_addSong = new TextBox();
            button_addSong = new Button();
            label11 = new Label();
            textBox_songArtist = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textBox_songGenre = new TextBox();
            label15 = new Label();
            textBox_songId_songVote = new TextBox();
            label19 = new Label();
            label21 = new Label();
            textBox_playlistId_songVote = new TextBox();
            button_Vote = new Button();
            radioButton_downVote = new RadioButton();
            label16 = new Label();
            radioButton_Up = new RadioButton();
            label17 = new Label();
            label18 = new Label();
            label20 = new Label();
            label22 = new Label();
            textBox_playlistId_addCollab = new TextBox();
            label23 = new Label();
            label24 = new Label();
            numericUpDown_songMinutes = new NumericUpDown();
            numericUpDown_songSeconds = new NumericUpDown();
            label_songUpdateStatus = new Label();
            label25 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_songMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_songSeconds).BeginInit();
            SuspendLayout();
            // 
            // listBox_Playlists
            // 
            listBox_Playlists.FormattingEnabled = true;
            listBox_Playlists.Location = new Point(301, 68);
            listBox_Playlists.Name = "listBox_Playlists";
            listBox_Playlists.Size = new Size(599, 204);
            listBox_Playlists.TabIndex = 4;
            listBox_Playlists.SelectedIndexChanged += listBox_Playlists_SelectedIndexChanged;
            // 
            // listBox_users
            // 
            listBox_users.FormattingEnabled = true;
            listBox_users.Location = new Point(11, 68);
            listBox_users.Name = "listBox_users";
            listBox_users.Size = new Size(272, 204);
            listBox_users.TabIndex = 5;
            listBox_users.SelectedIndexChanged += listBox_users_SelectedIndexChanged;
            // 
            // listBox_PlaylistSongs
            // 
            listBox_PlaylistSongs.FormattingEnabled = true;
            listBox_PlaylistSongs.Location = new Point(936, 68);
            listBox_PlaylistSongs.Name = "listBox_PlaylistSongs";
            listBox_PlaylistSongs.Size = new Size(646, 204);
            listBox_PlaylistSongs.TabIndex = 6;
            listBox_PlaylistSongs.SelectedIndexChanged += listBox_PlaylistSongs_SelectedIndexChanged;
            // 
            // button_createPlaylist
            // 
            button_createPlaylist.Location = new Point(296, 544);
            button_createPlaylist.Name = "button_createPlaylist";
            button_createPlaylist.Size = new Size(146, 29);
            button_createPlaylist.TabIndex = 7;
            button_createPlaylist.Text = "Create Playlist";
            button_createPlaylist.UseVisualStyleBackColor = true;
            button_createPlaylist.Click += button_createPlaylist_Click;
            // 
            // textBox_userId
            // 
            textBox_userId.Location = new Point(296, 378);
            textBox_userId.Name = "textBox_userId";
            textBox_userId.Size = new Size(125, 27);
            textBox_userId.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(296, 355);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 9;
            label1.Text = "Creator UserId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 422);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 11;
            label2.Text = "Playlist Name";
            // 
            // textBox_playlistName
            // 
            textBox_playlistName.Location = new Point(296, 445);
            textBox_playlistName.Name = "textBox_playlistName";
            textBox_playlistName.Size = new Size(125, 27);
            textBox_playlistName.TabIndex = 10;
            // 
            // radioButton_true_isCollaborative
            // 
            radioButton_true_isCollaborative.AutoSize = true;
            radioButton_true_isCollaborative.Location = new Point(296, 512);
            radioButton_true_isCollaborative.Name = "radioButton_true_isCollaborative";
            radioButton_true_isCollaborative.Size = new Size(51, 24);
            radioButton_true_isCollaborative.TabIndex = 12;
            radioButton_true_isCollaborative.TabStop = true;
            radioButton_true_isCollaborative.Text = "Yes";
            radioButton_true_isCollaborative.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 489);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 13;
            label3.Text = "Is this a collaborative playlist?";
            // 
            // radioButton_false_isCollaborative
            // 
            radioButton_false_isCollaborative.AutoSize = true;
            radioButton_false_isCollaborative.Location = new Point(370, 512);
            radioButton_false_isCollaborative.Name = "radioButton_false_isCollaborative";
            radioButton_false_isCollaborative.Size = new Size(50, 24);
            radioButton_false_isCollaborative.TabIndex = 14;
            radioButton_false_isCollaborative.TabStop = true;
            radioButton_false_isCollaborative.Text = "No";
            radioButton_false_isCollaborative.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(575, 413);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 19;
            label5.Text = "Collaborator UserId";
            // 
            // textBox_collabUserId
            // 
            textBox_collabUserId.Location = new Point(575, 436);
            textBox_collabUserId.Name = "textBox_collabUserId";
            textBox_collabUserId.Size = new Size(125, 27);
            textBox_collabUserId.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(575, 346);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 17;
            label6.Text = "Creator UserId";
            // 
            // textBox_creatorId
            // 
            textBox_creatorId.Location = new Point(575, 369);
            textBox_creatorId.Name = "textBox_creatorId";
            textBox_creatorId.Size = new Size(125, 27);
            textBox_creatorId.TabIndex = 16;
            // 
            // button_AddCollaborator
            // 
            button_AddCollaborator.Location = new Point(568, 544);
            button_AddCollaborator.Name = "button_AddCollaborator";
            button_AddCollaborator.Size = new Size(146, 29);
            button_AddCollaborator.TabIndex = 15;
            button_AddCollaborator.Text = "Add Collaborator";
            button_AddCollaborator.UseVisualStyleBackColor = true;
            button_AddCollaborator.Click += button_AddCollaborator_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(296, 315);
            label4.Name = "label4";
            label4.Size = new Size(217, 28);
            label4.TabIndex = 20;
            label4.Text = "Create A New Playlist";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(575, 315);
            label7.Name = "label7";
            label7.Size = new Size(325, 28);
            label7.TabIndex = 21;
            label7.Text = "Add Collaborator To Your Playlist";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(983, 316);
            label8.Name = "label8";
            label8.Size = new Size(204, 28);
            label8.TabIndex = 27;
            label8.Text = "Add Song to Playlist";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1125, 347);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 26;
            label9.Text = "Song Title";
            // 
            // textBox_songTitle
            // 
            textBox_songTitle.Location = new Point(1125, 370);
            textBox_songTitle.Name = "textBox_songTitle";
            textBox_songTitle.Size = new Size(125, 27);
            textBox_songTitle.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(983, 347);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 24;
            label10.Text = "Playlist Id";
            // 
            // textBox_playlistID_addSong
            // 
            textBox_playlistID_addSong.Location = new Point(983, 370);
            textBox_playlistID_addSong.Name = "textBox_playlistID_addSong";
            textBox_playlistID_addSong.Size = new Size(125, 27);
            textBox_playlistID_addSong.TabIndex = 23;
            // 
            // button_addSong
            // 
            button_addSong.Location = new Point(1104, 553);
            button_addSong.Name = "button_addSong";
            button_addSong.Size = new Size(146, 29);
            button_addSong.TabIndex = 22;
            button_addSong.Text = "Add Song";
            button_addSong.UseVisualStyleBackColor = true;
            button_addSong.Click += button_addSong_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1125, 414);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 29;
            label11.Text = "Song Artist";
            // 
            // textBox_songArtist
            // 
            textBox_songArtist.Location = new Point(1125, 437);
            textBox_songArtist.Name = "textBox_songArtist";
            textBox_songArtist.Size = new Size(125, 27);
            textBox_songArtist.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(978, 500);
            label12.Name = "label12";
            label12.Size = new Size(112, 20);
            label12.TabIndex = 33;
            label12.Text = "Song Duration: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(983, 415);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 31;
            label13.Text = "Song Genre";
            // 
            // textBox_songGenre
            // 
            textBox_songGenre.Location = new Point(983, 438);
            textBox_songGenre.Name = "textBox_songGenre";
            textBox_songGenre.Size = new Size(125, 27);
            textBox_songGenre.TabIndex = 30;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1402, 414);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 49;
            label15.Text = "Song Id";
            // 
            // textBox_songId_songVote
            // 
            textBox_songId_songVote.Location = new Point(1402, 437);
            textBox_songId_songVote.Name = "textBox_songId_songVote";
            textBox_songId_songVote.Size = new Size(125, 27);
            textBox_songId_songVote.TabIndex = 48;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(1402, 315);
            label19.Name = "label19";
            label19.Size = new Size(108, 28);
            label19.TabIndex = 41;
            label19.Text = "Song Vote";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1402, 346);
            label21.Name = "label21";
            label21.Size = new Size(72, 20);
            label21.TabIndex = 38;
            label21.Text = "Playlist Id";
            // 
            // textBox_playlistId_songVote
            // 
            textBox_playlistId_songVote.Location = new Point(1402, 369);
            textBox_playlistId_songVote.Name = "textBox_playlistId_songVote";
            textBox_playlistId_songVote.Size = new Size(125, 27);
            textBox_playlistId_songVote.TabIndex = 37;
            // 
            // button_Vote
            // 
            button_Vote.Location = new Point(1402, 553);
            button_Vote.Name = "button_Vote";
            button_Vote.Size = new Size(146, 29);
            button_Vote.TabIndex = 50;
            button_Vote.Text = "Vote";
            button_Vote.UseVisualStyleBackColor = true;
            button_Vote.Click += button_Vote_Click;
            // 
            // radioButton_downVote
            // 
            radioButton_downVote.AutoSize = true;
            radioButton_downVote.Location = new Point(1491, 498);
            radioButton_downVote.Name = "radioButton_downVote";
            radioButton_downVote.Size = new Size(99, 24);
            radioButton_downVote.TabIndex = 53;
            radioButton_downVote.TabStop = true;
            radioButton_downVote.Text = "DownVote";
            radioButton_downVote.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1402, 475);
            label16.Name = "label16";
            label16.Size = new Size(39, 20);
            label16.TabIndex = 52;
            label16.Text = "Vote";
            // 
            // radioButton_Up
            // 
            radioButton_Up.AutoSize = true;
            radioButton_Up.Location = new Point(1402, 498);
            radioButton_Up.Name = "radioButton_Up";
            radioButton_Up.Size = new Size(83, 24);
            radioButton_Up.TabIndex = 51;
            radioButton_Up.TabStop = true;
            radioButton_Up.Text = "Up Vote";
            radioButton_Up.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(6, 25);
            label17.Name = "label17";
            label17.Size = new Size(63, 28);
            label17.TabIndex = 55;
            label17.Text = "Users";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(296, 25);
            label18.Name = "label18";
            label18.Size = new Size(90, 28);
            label18.TabIndex = 56;
            label18.Text = "Playlists";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(931, 25);
            label20.Name = "label20";
            label20.Size = new Size(143, 28);
            label20.TabIndex = 57;
            label20.Text = "Playlist Songs";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(575, 475);
            label22.Name = "label22";
            label22.Size = new Size(72, 20);
            label22.TabIndex = 59;
            label22.Text = "Playlist Id";
            // 
            // textBox_playlistId_addCollab
            // 
            textBox_playlistId_addCollab.Location = new Point(575, 498);
            textBox_playlistId_addCollab.Name = "textBox_playlistId_addCollab";
            textBox_playlistId_addCollab.Size = new Size(125, 27);
            textBox_playlistId_addCollab.TabIndex = 58;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1087, 476);
            label23.Name = "label23";
            label23.Size = new Size(61, 20);
            label23.TabIndex = 61;
            label23.Text = "Minutes";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(1174, 476);
            label24.Name = "label24";
            label24.Size = new Size(64, 20);
            label24.TabIndex = 62;
            label24.Text = "Seconds";
            // 
            // numericUpDown_songMinutes
            // 
            numericUpDown_songMinutes.Location = new Point(1089, 500);
            numericUpDown_songMinutes.Name = "numericUpDown_songMinutes";
            numericUpDown_songMinutes.Size = new Size(74, 27);
            numericUpDown_songMinutes.TabIndex = 63;
            // 
            // numericUpDown_songSeconds
            // 
            numericUpDown_songSeconds.Location = new Point(1174, 500);
            numericUpDown_songSeconds.Name = "numericUpDown_songSeconds";
            numericUpDown_songSeconds.Size = new Size(74, 27);
            numericUpDown_songSeconds.TabIndex = 64;
            // 
            // label_songUpdateStatus
            // 
            label_songUpdateStatus.AutoSize = true;
            label_songUpdateStatus.Location = new Point(1344, 45);
            label_songUpdateStatus.Name = "label_songUpdateStatus";
            label_songUpdateStatus.Size = new Size(238, 20);
            label_songUpdateStatus.TabIndex = 65;
            label_songUpdateStatus.Text = "Select a playlist with songs to view";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(601, 286);
            label25.Name = "label25";
            label25.Size = new Size(360, 20);
            label25.TabIndex = 66;
            label25.Text = "Select the corresponding line in each box to fill in Ids";
            // 
            // CollaborativePlaylistBuilderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1605, 610);
            Controls.Add(label25);
            Controls.Add(label_songUpdateStatus);
            Controls.Add(numericUpDown_songSeconds);
            Controls.Add(numericUpDown_songMinutes);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(textBox_playlistId_addCollab);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(radioButton_downVote);
            Controls.Add(label16);
            Controls.Add(radioButton_Up);
            Controls.Add(button_Vote);
            Controls.Add(label15);
            Controls.Add(textBox_songId_songVote);
            Controls.Add(label19);
            Controls.Add(label21);
            Controls.Add(textBox_playlistId_songVote);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(textBox_songGenre);
            Controls.Add(label11);
            Controls.Add(textBox_songArtist);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(textBox_songTitle);
            Controls.Add(label10);
            Controls.Add(textBox_playlistID_addSong);
            Controls.Add(button_addSong);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(textBox_collabUserId);
            Controls.Add(label6);
            Controls.Add(textBox_creatorId);
            Controls.Add(button_AddCollaborator);
            Controls.Add(radioButton_false_isCollaborative);
            Controls.Add(label3);
            Controls.Add(radioButton_true_isCollaborative);
            Controls.Add(label2);
            Controls.Add(textBox_playlistName);
            Controls.Add(label1);
            Controls.Add(textBox_userId);
            Controls.Add(button_createPlaylist);
            Controls.Add(listBox_PlaylistSongs);
            Controls.Add(listBox_users);
            Controls.Add(listBox_Playlists);
            Name = "CollaborativePlaylistBuilderForm";
            Text = "CollaborativePlaylistBuilder";
            Load += CollaborativePlaylistBuilder_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown_songMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_songSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_Playlists;
        private ListBox listBox_users;
        private ListBox listBox_PlaylistSongs;
        private Button button_createPlaylist;
        private TextBox textBox_userId;
        private Label label1;
        private Label label2;
        private TextBox textBox_playlistName;
        private RadioButton radioButton_true_isCollaborative;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioButton_false_isCollaborative;
        private Label label5;
        private TextBox textBox_collabUserId;
        private Label label6;
        private TextBox textBox_creatorId;
        private Button button_AddCollaborator;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox_songTitle;
        private Label label10;
        private TextBox textBox_playlistID_addSong;
        private Button button_addSong;
        private Label label11;
        private TextBox textBox_songArtist;
        private Label label12;
        private Label label13;
        private TextBox textBox_songGenre;
        private Label label15;
        private TextBox textBox_songId_songVote;
        private Label label19;
        private Label label21;
        private TextBox textBox_playlistId_songVote;
        private Button button_UpVote;
        private Button button_Vote;
        private RadioButton radioButton_downVote;
        private Label label16;
        private RadioButton radioButton_Up;
        private Label label17;
        private Label label18;
        private Label label20;
        private Label label22;
        private TextBox textBox_playlistId_addCollab;
        private Label label23;
        private Label label24;
        private NumericUpDown numericUpDown_songMinutes;
        private NumericUpDown numericUpDown_songSeconds;
        private Label label_songUpdateStatus;
        private Label label25;
    }
}