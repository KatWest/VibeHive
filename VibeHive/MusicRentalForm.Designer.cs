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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabControl_Customers = new TabControl();
            tabPage_Customers = new TabPage();
            label10 = new Label();
            label9 = new Label();
            btn_GetAllCustomers = new Button();
            listBox_Customers = new ListBox();
            btn_AddCustomer = new Button();
            txb_CustomerEmail = new TextBox();
            txb_CustomerName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage_MusicLibrary = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            listBox_MusicAlbums = new ListBox();
            txb_AlbumYear = new TextBox();
            txb_AlbumGenre = new TextBox();
            txb_AlbumArtist = new TextBox();
            txb_AlbumTitle = new TextBox();
            tabPage_Rentals = new TabPage();
            label8 = new Label();
            txb_RentalIdToReturn = new TextBox();
            cmb_MusicAlbums = new ComboBox();
            cmb_Customers = new ComboBox();
            listBox_AllActiveRentals = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label11 = new Label();
            tabControl_Customers.SuspendLayout();
            tabPage_Customers.SuspendLayout();
            tabPage_MusicLibrary.SuspendLayout();
            tabPage_Rentals.SuspendLayout();
            SuspendLayout();
            // 
            // btn_AddMusicAlbum
            // 
            btn_AddMusicAlbum.Location = new Point(540, 70);
            btn_AddMusicAlbum.Name = "btn_AddMusicAlbum";
            btn_AddMusicAlbum.Size = new Size(161, 39);
            btn_AddMusicAlbum.TabIndex = 0;
            btn_AddMusicAlbum.Text = "Add Music Album";
            btn_AddMusicAlbum.UseVisualStyleBackColor = true;
            btn_AddMusicAlbum.Click += btn_AddMusicAlbum_Click;
            // 
            // btn_ListAllAlbums
            // 
            btn_ListAllAlbums.Location = new Point(281, 299);
            btn_ListAllAlbums.Name = "btn_ListAllAlbums";
            btn_ListAllAlbums.Size = new Size(161, 40);
            btn_ListAllAlbums.TabIndex = 0;
            btn_ListAllAlbums.Text = "List All Music Albums";
            btn_ListAllAlbums.UseVisualStyleBackColor = true;
            btn_ListAllAlbums.Click += btn_ListAllAlbums_Click;
            // 
            // btn_RentMusicAlbum
            // 
            btn_RentMusicAlbum.Location = new Point(514, 48);
            btn_RentMusicAlbum.Name = "btn_RentMusicAlbum";
            btn_RentMusicAlbum.Size = new Size(153, 28);
            btn_RentMusicAlbum.TabIndex = 0;
            btn_RentMusicAlbum.Text = "Rent Music Album";
            btn_RentMusicAlbum.UseVisualStyleBackColor = true;
            btn_RentMusicAlbum.Click += btn_RentMusicAlbum_Click;
            // 
            // btn_ReturnMusicAlbum
            // 
            btn_ReturnMusicAlbum.Location = new Point(516, 92);
            btn_ReturnMusicAlbum.Name = "btn_ReturnMusicAlbum";
            btn_ReturnMusicAlbum.Size = new Size(153, 28);
            btn_ReturnMusicAlbum.TabIndex = 0;
            btn_ReturnMusicAlbum.Text = "Return Music Album";
            btn_ReturnMusicAlbum.UseVisualStyleBackColor = true;
            btn_ReturnMusicAlbum.Click += btn_ReturnMusicAlbum_Click;
            // 
            // btn_ViewActiveRentals
            // 
            btn_ViewActiveRentals.Location = new Point(280, 291);
            btn_ViewActiveRentals.Name = "btn_ViewActiveRentals";
            btn_ViewActiveRentals.Size = new Size(177, 32);
            btn_ViewActiveRentals.TabIndex = 0;
            btn_ViewActiveRentals.Text = "View All Active Rentals";
            btn_ViewActiveRentals.UseVisualStyleBackColor = true;
            btn_ViewActiveRentals.Click += btn_ViewActiveRentals_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(686, 398);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tabControl_Customers
            // 
            tabControl_Customers.Controls.Add(tabPage_Customers);
            tabControl_Customers.Controls.Add(tabPage_MusicLibrary);
            tabControl_Customers.Controls.Add(tabPage_Rentals);
            tabControl_Customers.Location = new Point(39, 28);
            tabControl_Customers.Name = "tabControl_Customers";
            tabControl_Customers.SelectedIndex = 0;
            tabControl_Customers.Size = new Size(726, 378);
            tabControl_Customers.TabIndex = 3;
            // 
            // tabPage_Customers
            // 
            tabPage_Customers.Controls.Add(label10);
            tabPage_Customers.Controls.Add(label9);
            tabPage_Customers.Controls.Add(btn_GetAllCustomers);
            tabPage_Customers.Controls.Add(listBox_Customers);
            tabPage_Customers.Controls.Add(btn_AddCustomer);
            tabPage_Customers.Controls.Add(txb_CustomerEmail);
            tabPage_Customers.Controls.Add(txb_CustomerName);
            tabPage_Customers.Controls.Add(label2);
            tabPage_Customers.Controls.Add(label1);
            tabPage_Customers.Location = new Point(4, 29);
            tabPage_Customers.Name = "tabPage_Customers";
            tabPage_Customers.Padding = new Padding(3);
            tabPage_Customers.Size = new Size(718, 345);
            tabPage_Customers.TabIndex = 0;
            tabPage_Customers.Text = "1. View Customers";
            tabPage_Customers.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(292, 61);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 5;
            label10.Text = "Customer Email: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 61);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 5;
            label9.Text = "Customer Name: ";
            // 
            // btn_GetAllCustomers
            // 
            btn_GetAllCustomers.Location = new Point(278, 297);
            btn_GetAllCustomers.Name = "btn_GetAllCustomers";
            btn_GetAllCustomers.Size = new Size(158, 29);
            btn_GetAllCustomers.TabIndex = 4;
            btn_GetAllCustomers.Text = "Get All Customers";
            btn_GetAllCustomers.UseVisualStyleBackColor = true;
            btn_GetAllCustomers.Click += btn_GetAllCustomers_Click;
            // 
            // listBox_Customers
            // 
            listBox_Customers.FormattingEnabled = true;
            listBox_Customers.Location = new Point(6, 107);
            listBox_Customers.Name = "listBox_Customers";
            listBox_Customers.Size = new Size(697, 184);
            listBox_Customers.TabIndex = 3;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.Location = new Point(587, 53);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(116, 28);
            btn_AddCustomer.TabIndex = 2;
            btn_AddCustomer.Text = "Add Customer";
            btn_AddCustomer.UseVisualStyleBackColor = true;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // txb_CustomerEmail
            // 
            txb_CustomerEmail.Location = new Point(418, 54);
            txb_CustomerEmail.Name = "txb_CustomerEmail";
            txb_CustomerEmail.Size = new Size(153, 27);
            txb_CustomerEmail.TabIndex = 1;
            // 
            // txb_CustomerName
            // 
            txb_CustomerName.Location = new Point(133, 54);
            txb_CustomerName.Name = "txb_CustomerName";
            txb_CustomerName.Size = new Size(153, 27);
            txb_CustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 41);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(235, 20);
            label1.TabIndex = 0;
            label1.Text = "Step 1. Add Customer Information";
            // 
            // tabPage_MusicLibrary
            // 
            tabPage_MusicLibrary.Controls.Add(label7);
            tabPage_MusicLibrary.Controls.Add(label6);
            tabPage_MusicLibrary.Controls.Add(label5);
            tabPage_MusicLibrary.Controls.Add(label4);
            tabPage_MusicLibrary.Controls.Add(label3);
            tabPage_MusicLibrary.Controls.Add(listBox_MusicAlbums);
            tabPage_MusicLibrary.Controls.Add(txb_AlbumYear);
            tabPage_MusicLibrary.Controls.Add(txb_AlbumGenre);
            tabPage_MusicLibrary.Controls.Add(txb_AlbumArtist);
            tabPage_MusicLibrary.Controls.Add(txb_AlbumTitle);
            tabPage_MusicLibrary.Controls.Add(btn_AddMusicAlbum);
            tabPage_MusicLibrary.Controls.Add(btn_ListAllAlbums);
            tabPage_MusicLibrary.Location = new Point(4, 29);
            tabPage_MusicLibrary.Name = "tabPage_MusicLibrary";
            tabPage_MusicLibrary.Padding = new Padding(3);
            tabPage_MusicLibrary.Size = new Size(718, 345);
            tabPage_MusicLibrary.TabIndex = 1;
            tabPage_MusicLibrary.Text = "2. View Music Library";
            tabPage_MusicLibrary.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(443, 59);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 5;
            label7.Text = "Add Year: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(324, 59);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 5;
            label6.Text = "Add Genre: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 59);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 5;
            label5.Text = "Add Artist:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 59);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 5;
            label4.Text = "Add Album Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 18);
            label3.Name = "label3";
            label3.Size = new Size(258, 20);
            label3.TabIndex = 4;
            label3.Text = "Step 2: Add Music Album Information";
            // 
            // listBox_MusicAlbums
            // 
            listBox_MusicAlbums.FormattingEnabled = true;
            listBox_MusicAlbums.Location = new Point(19, 129);
            listBox_MusicAlbums.Name = "listBox_MusicAlbums";
            listBox_MusicAlbums.Size = new Size(682, 164);
            listBox_MusicAlbums.TabIndex = 3;
            // 
            // txb_AlbumYear
            // 
            txb_AlbumYear.Location = new Point(429, 82);
            txb_AlbumYear.Name = "txb_AlbumYear";
            txb_AlbumYear.Size = new Size(105, 27);
            txb_AlbumYear.TabIndex = 2;
            // 
            // txb_AlbumGenre
            // 
            txb_AlbumGenre.Location = new Point(312, 82);
            txb_AlbumGenre.Name = "txb_AlbumGenre";
            txb_AlbumGenre.Size = new Size(111, 27);
            txb_AlbumGenre.TabIndex = 2;
            // 
            // txb_AlbumArtist
            // 
            txb_AlbumArtist.Location = new Point(203, 82);
            txb_AlbumArtist.Name = "txb_AlbumArtist";
            txb_AlbumArtist.Size = new Size(103, 27);
            txb_AlbumArtist.TabIndex = 2;
            // 
            // txb_AlbumTitle
            // 
            txb_AlbumTitle.Location = new Point(19, 82);
            txb_AlbumTitle.Name = "txb_AlbumTitle";
            txb_AlbumTitle.Size = new Size(176, 27);
            txb_AlbumTitle.TabIndex = 2;
            // 
            // tabPage_Rentals
            // 
            tabPage_Rentals.Controls.Add(label11);
            tabPage_Rentals.Controls.Add(label8);
            tabPage_Rentals.Controls.Add(txb_RentalIdToReturn);
            tabPage_Rentals.Controls.Add(cmb_MusicAlbums);
            tabPage_Rentals.Controls.Add(cmb_Customers);
            tabPage_Rentals.Controls.Add(listBox_AllActiveRentals);
            tabPage_Rentals.Controls.Add(btn_RentMusicAlbum);
            tabPage_Rentals.Controls.Add(btn_ReturnMusicAlbum);
            tabPage_Rentals.Controls.Add(btn_ViewActiveRentals);
            tabPage_Rentals.Location = new Point(4, 29);
            tabPage_Rentals.Name = "tabPage_Rentals";
            tabPage_Rentals.Padding = new Padding(3);
            tabPage_Rentals.Size = new Size(718, 345);
            tabPage_Rentals.TabIndex = 2;
            tabPage_Rentals.Text = "3. View Rentals";
            tabPage_Rentals.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 96);
            label8.Name = "label8";
            label8.Size = new Size(292, 20);
            label8.TabIndex = 5;
            label8.Text = "Enter Rental ID to Return Music Album -->:";
            // 
            // txb_RentalIdToReturn
            // 
            txb_RentalIdToReturn.Location = new Point(346, 90);
            txb_RentalIdToReturn.Name = "txb_RentalIdToReturn";
            txb_RentalIdToReturn.Size = new Size(111, 27);
            txb_RentalIdToReturn.TabIndex = 4;
            // 
            // cmb_MusicAlbums
            // 
            cmb_MusicAlbums.FormattingEnabled = true;
            cmb_MusicAlbums.Location = new Point(231, 48);
            cmb_MusicAlbums.Name = "cmb_MusicAlbums";
            cmb_MusicAlbums.Size = new Size(226, 28);
            cmb_MusicAlbums.TabIndex = 3;
            cmb_MusicAlbums.Text = "Select Music Album Name";
            // 
            // cmb_Customers
            // 
            cmb_Customers.FormattingEnabled = true;
            cmb_Customers.Location = new Point(15, 49);
            cmb_Customers.Name = "cmb_Customers";
            cmb_Customers.Size = new Size(192, 28);
            cmb_Customers.TabIndex = 3;
            cmb_Customers.Text = "Select Customer Name";
            // 
            // listBox_AllActiveRentals
            // 
            listBox_AllActiveRentals.FormattingEnabled = true;
            listBox_AllActiveRentals.Location = new Point(15, 141);
            listBox_AllActiveRentals.Name = "listBox_AllActiveRentals";
            listBox_AllActiveRentals.Size = new Size(654, 144);
            listBox_AllActiveRentals.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 16);
            label11.Name = "label11";
            label11.Size = new Size(190, 20);
            label11.TabIndex = 6;
            label11.Text = "Step 3: Rent a Music Album";
            // 
            // MusicRentalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl_Customers);
            Controls.Add(flowLayoutPanel1);
            Name = "MusicRentalForm";
            Text = "MusicRentalForm";
            Load += MusicRentalForm_Load;
            tabControl_Customers.ResumeLayout(false);
            tabPage_Customers.ResumeLayout(false);
            tabPage_Customers.PerformLayout();
            tabPage_MusicLibrary.ResumeLayout(false);
            tabPage_MusicLibrary.PerformLayout();
            tabPage_Rentals.ResumeLayout(false);
            tabPage_Rentals.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AddMusicAlbum;
        private Button btn_ListAllAlbums;
        private Button btn_RentMusicAlbum;
        private Button btn_ReturnMusicAlbum;
        private Button btn_ViewActiveRentals;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabControl tabControl_Customers;
        private TabPage tabPage_Customers;
        private TabPage tabPage_MusicLibrary;
        private TabPage tabPage_Rentals;
        private TextBox txb_CustomerEmail;
        private TextBox txb_CustomerName;
        private Label label2;
        private Label label1;
        private Button btn_AddCustomer;
        private ListBox listBox_Customers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listBox_MusicAlbums;
        private TextBox txb_AlbumYear;
        private TextBox txb_AlbumGenre;
        private TextBox txb_AlbumArtist;
        private TextBox txb_AlbumTitle;
        private ListBox listBox_AllActiveRentals;
        private Button btn_GetAllCustomers;
        private ComboBox cmb_MusicAlbums;
        private ComboBox cmb_Customers;
        private TextBox txb_RentalIdToReturn;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label10;
        private Label label11;
    }
}