namespace VibeHive
{
    partial class CollaborativePlaylistBuilder
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
            // CollaborativePlaylistBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 605);
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
            Name = "CollaborativePlaylistBuilder";
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
    }
}