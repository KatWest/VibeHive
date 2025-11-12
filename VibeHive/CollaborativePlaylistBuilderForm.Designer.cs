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
            textBox_songDuration = new TextBox();
            label13 = new Label();
            textBox_songGenre = new TextBox();
            label14 = new Label();
            textBox_songId_AddSong = new TextBox();
            label15 = new Label();
            textBox_songId_songVote = new TextBox();
            label19 = new Label();
            label21 = new Label();
            textBox_playlistId_songVote = new TextBox();
            button_UpVote = new Button();
            button_downVote = new Button();
            SuspendLayout();
            // 
            // listBox_Playlists
            // 
            listBox_Playlists.FormattingEnabled = true;
            listBox_Playlists.Location = new Point(504, 209);
            listBox_Playlists.Name = "listBox_Playlists";
            listBox_Playlists.Size = new Size(599, 184);
            listBox_Playlists.TabIndex = 4;
            // 
            // listBox_users
            // 
            listBox_users.FormattingEnabled = true;
            listBox_users.Location = new Point(504, 12);
            listBox_users.Name = "listBox_users";
            listBox_users.Size = new Size(599, 184);
            listBox_users.TabIndex = 5;
            // 
            // listBox_PlaylistSongs
            // 
            listBox_PlaylistSongs.FormattingEnabled = true;
            listBox_PlaylistSongs.Location = new Point(504, 409);
            listBox_PlaylistSongs.Name = "listBox_PlaylistSongs";
            listBox_PlaylistSongs.Size = new Size(599, 184);
            listBox_PlaylistSongs.TabIndex = 6;
            // 
            // button_createPlaylist
            // 
            button_createPlaylist.Location = new Point(46, 281);
            button_createPlaylist.Name = "button_createPlaylist";
            button_createPlaylist.Size = new Size(146, 29);
            button_createPlaylist.TabIndex = 7;
            button_createPlaylist.Text = "Create Playlist";
            button_createPlaylist.UseVisualStyleBackColor = true;
            button_createPlaylist.Click += button_createPlaylist_Click;
            // 
            // textBox_userId
            // 
            textBox_userId.Location = new Point(46, 115);
            textBox_userId.Name = "textBox_userId";
            textBox_userId.Size = new Size(125, 27);
            textBox_userId.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 92);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 9;
            label1.Text = "Creator UserId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 159);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 11;
            label2.Text = "Playlist Name";
            // 
            // textBox_playlistName
            // 
            textBox_playlistName.Location = new Point(46, 182);
            textBox_playlistName.Name = "textBox_playlistName";
            textBox_playlistName.Size = new Size(125, 27);
            textBox_playlistName.TabIndex = 10;
            // 
            // radioButton_true_isCollaborative
            // 
            radioButton_true_isCollaborative.AutoSize = true;
            radioButton_true_isCollaborative.Location = new Point(46, 249);
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
            label3.Location = new Point(46, 226);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 13;
            label3.Text = "Is this a collaborative playlist?";
            // 
            // radioButton_false_isCollaborative
            // 
            radioButton_false_isCollaborative.AutoSize = true;
            radioButton_false_isCollaborative.Location = new Point(120, 249);
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
            label5.Location = new Point(46, 463);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 19;
            label5.Text = "Collaborator UserId";
            // 
            // textBox_collabUserId
            // 
            textBox_collabUserId.Location = new Point(46, 486);
            textBox_collabUserId.Name = "textBox_collabUserId";
            textBox_collabUserId.Size = new Size(125, 27);
            textBox_collabUserId.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 396);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 17;
            label6.Text = "Creator UserId";
            // 
            // textBox_creatorId
            // 
            textBox_creatorId.Location = new Point(46, 419);
            textBox_creatorId.Name = "textBox_creatorId";
            textBox_creatorId.Size = new Size(125, 27);
            textBox_creatorId.TabIndex = 16;
            // 
            // button_AddCollaborator
            // 
            button_AddCollaborator.Location = new Point(46, 532);
            button_AddCollaborator.Name = "button_AddCollaborator";
            button_AddCollaborator.Size = new Size(146, 29);
            button_AddCollaborator.TabIndex = 15;
            button_AddCollaborator.Text = "Add Collaborator";
            button_AddCollaborator.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 52);
            label4.Name = "label4";
            label4.Size = new Size(217, 28);
            label4.TabIndex = 20;
            label4.Text = "Create A New Playlist";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 365);
            label7.Name = "label7";
            label7.Size = new Size(325, 28);
            label7.TabIndex = 21;
            label7.Text = "Add Collaborator To Your Playlist";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 608);
            label8.Name = "label8";
            label8.Size = new Size(204, 28);
            label8.TabIndex = 27;
            label8.Text = "Add Song to Playlist";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(212, 639);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 26;
            label9.Text = "Song Title";
            // 
            // textBox_songTitle
            // 
            textBox_songTitle.Location = new Point(212, 662);
            textBox_songTitle.Name = "textBox_songTitle";
            textBox_songTitle.Size = new Size(125, 27);
            textBox_songTitle.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 639);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 24;
            label10.Text = "Playlist Id";
            // 
            // textBox_playlistID_addSong
            // 
            textBox_playlistID_addSong.Location = new Point(46, 662);
            textBox_playlistID_addSong.Name = "textBox_playlistID_addSong";
            textBox_playlistID_addSong.Size = new Size(125, 27);
            textBox_playlistID_addSong.TabIndex = 23;
            // 
            // button_addSong
            // 
            button_addSong.Location = new Point(359, 781);
            button_addSong.Name = "button_addSong";
            button_addSong.Size = new Size(146, 29);
            button_addSong.TabIndex = 22;
            button_addSong.Text = "Add Song";
            button_addSong.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(212, 707);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 29;
            label11.Text = "Song Artist";
            // 
            // textBox_songArtist
            // 
            textBox_songArtist.Location = new Point(212, 730);
            textBox_songArtist.Name = "textBox_songArtist";
            textBox_songArtist.Size = new Size(125, 27);
            textBox_songArtist.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(380, 707);
            label12.Name = "label12";
            label12.Size = new Size(105, 20);
            label12.TabIndex = 33;
            label12.Text = "Song Duration";
            // 
            // textBox_songDuration
            // 
            textBox_songDuration.Location = new Point(380, 730);
            textBox_songDuration.Name = "textBox_songDuration";
            textBox_songDuration.Size = new Size(125, 27);
            textBox_songDuration.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(380, 639);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 31;
            label13.Text = "Song Genre";
            // 
            // textBox_songGenre
            // 
            textBox_songGenre.Location = new Point(380, 662);
            textBox_songGenre.Name = "textBox_songGenre";
            textBox_songGenre.Size = new Size(125, 27);
            textBox_songGenre.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(46, 707);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 35;
            label14.Text = "Song Id";
            // 
            // textBox_songId_AddSong
            // 
            textBox_songId_AddSong.Location = new Point(46, 730);
            textBox_songId_AddSong.Name = "textBox_songId_AddSong";
            textBox_songId_AddSong.Size = new Size(125, 27);
            textBox_songId_AddSong.TabIndex = 34;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(644, 707);
            label15.Name = "label15";
            label15.Size = new Size(60, 20);
            label15.TabIndex = 49;
            label15.Text = "Song Id";
            // 
            // textBox_songId_songVote
            // 
            textBox_songId_songVote.Location = new Point(644, 730);
            textBox_songId_songVote.Name = "textBox_songId_songVote";
            textBox_songId_songVote.Size = new Size(125, 27);
            textBox_songId_songVote.TabIndex = 48;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(644, 608);
            label19.Name = "label19";
            label19.Size = new Size(108, 28);
            label19.TabIndex = 41;
            label19.Text = "Song Vote";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(644, 639);
            label21.Name = "label21";
            label21.Size = new Size(72, 20);
            label21.TabIndex = 38;
            label21.Text = "Playlist Id";
            // 
            // textBox_playlistId_songVote
            // 
            textBox_playlistId_songVote.Location = new Point(644, 662);
            textBox_playlistId_songVote.Name = "textBox_playlistId_songVote";
            textBox_playlistId_songVote.Size = new Size(125, 27);
            textBox_playlistId_songVote.TabIndex = 37;
            // 
            // button_UpVote
            // 
            button_UpVote.Location = new Point(795, 672);
            button_UpVote.Name = "button_UpVote";
            button_UpVote.Size = new Size(146, 29);
            button_UpVote.TabIndex = 36;
            button_UpVote.Text = "Up Vote";
            button_UpVote.UseVisualStyleBackColor = true;
            // 
            // button_downVote
            // 
            button_downVote.Location = new Point(795, 707);
            button_downVote.Name = "button_downVote";
            button_downVote.Size = new Size(146, 29);
            button_downVote.TabIndex = 50;
            button_downVote.Text = "Down Vote";
            button_downVote.UseVisualStyleBackColor = true;
            // 
            // CollaborativePlaylistBuilderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 822);
            Controls.Add(button_downVote);
            Controls.Add(label15);
            Controls.Add(textBox_songId_songVote);
            Controls.Add(label19);
            Controls.Add(label21);
            Controls.Add(textBox_playlistId_songVote);
            Controls.Add(button_UpVote);
            Controls.Add(label14);
            Controls.Add(textBox_songId_AddSong);
            Controls.Add(label12);
            Controls.Add(textBox_songDuration);
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
        private TextBox textBox_songDuration;
        private Label label13;
        private TextBox textBox_songGenre;
        private Label label14;
        private TextBox textBox_songId_AddSong;
        private Label label15;
        private TextBox textBox_songId_songVote;
        private Label label19;
        private Label label21;
        private TextBox textBox_playlistId_songVote;
        private Button button_UpVote;
        private Button button_downVote;
    }
}