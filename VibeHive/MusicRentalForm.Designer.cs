namespace VibeHive
{
    partial class MusicRentalForm
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
            btn_AddMusicAlbum = new Button();
            btn_ListAllAlbums = new Button();
            btn_RentMusicAlbum = new Button();
            btn_ReturnMusicAlbum = new Button();
            btn_ViewActiveRentals = new Button();
            SuspendLayout();
            // 
            // btn_AddMusicAlbum
            // 
            btn_AddMusicAlbum.Location = new Point(588, 41);
            btn_AddMusicAlbum.Name = "btn_AddMusicAlbum";
            btn_AddMusicAlbum.Size = new Size(172, 39);
            btn_AddMusicAlbum.TabIndex = 0;
            btn_AddMusicAlbum.Text = "Add Music Album";
            btn_AddMusicAlbum.UseVisualStyleBackColor = true;
            // 
            // btn_ListAllAlbums
            // 
            btn_ListAllAlbums.Location = new Point(588, 101);
            btn_ListAllAlbums.Name = "btn_ListAllAlbums";
            btn_ListAllAlbums.Size = new Size(172, 40);
            btn_ListAllAlbums.TabIndex = 0;
            btn_ListAllAlbums.Text = "List All Music Albums";
            btn_ListAllAlbums.UseVisualStyleBackColor = true;
            // 
            // btn_RentMusicAlbum
            // 
            btn_RentMusicAlbum.Location = new Point(588, 171);
            btn_RentMusicAlbum.Name = "btn_RentMusicAlbum";
            btn_RentMusicAlbum.Size = new Size(172, 40);
            btn_RentMusicAlbum.TabIndex = 0;
            btn_RentMusicAlbum.Text = "Rent Music Album";
            btn_RentMusicAlbum.UseVisualStyleBackColor = true;
            // 
            // btn_ReturnMusicAlbum
            // 
            btn_ReturnMusicAlbum.Location = new Point(588, 231);
            btn_ReturnMusicAlbum.Name = "btn_ReturnMusicAlbum";
            btn_ReturnMusicAlbum.Size = new Size(172, 40);
            btn_ReturnMusicAlbum.TabIndex = 0;
            btn_ReturnMusicAlbum.Text = "Return Music Album";
            btn_ReturnMusicAlbum.UseVisualStyleBackColor = true;
            // 
            // btn_ViewActiveRentals
            // 
            btn_ViewActiveRentals.Location = new Point(588, 299);
            btn_ViewActiveRentals.Name = "btn_ViewActiveRentals";
            btn_ViewActiveRentals.Size = new Size(172, 40);
            btn_ViewActiveRentals.TabIndex = 0;
            btn_ViewActiveRentals.Text = "View Active Rentals";
            btn_ViewActiveRentals.UseVisualStyleBackColor = true;
            // 
            // MusicRentalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ViewActiveRentals);
            Controls.Add(btn_ReturnMusicAlbum);
            Controls.Add(btn_RentMusicAlbum);
            Controls.Add(btn_ListAllAlbums);
            Controls.Add(btn_AddMusicAlbum);
            Name = "MusicRentalForm";
            Text = "MusicRentalForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AddMusicAlbum;
        private Button btn_ListAllAlbums;
        private Button btn_RentMusicAlbum;
        private Button btn_ReturnMusicAlbum;
        private Button btn_ViewActiveRentals;
    }
}