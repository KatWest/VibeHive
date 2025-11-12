namespace VibeHive
{
    partial class AlbumInventory
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
            inputPanel = new Panel();
            clearBtn = new Button();
            yearNud = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            genreTxb = new TextBox();
            artistTxb = new TextBox();
            titleTxb = new TextBox();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            dataPanel = new Panel();
            albumsDgv = new DataGridView();
            panel1 = new Panel();
            btnRefresh = new Button();
            label1 = new Label();
            inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearNud).BeginInit();
            dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)albumsDgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // inputPanel
            // 
            inputPanel.Controls.Add(clearBtn);
            inputPanel.Controls.Add(yearNud);
            inputPanel.Controls.Add(label5);
            inputPanel.Controls.Add(label4);
            inputPanel.Controls.Add(label3);
            inputPanel.Controls.Add(label2);
            inputPanel.Controls.Add(genreTxb);
            inputPanel.Controls.Add(artistTxb);
            inputPanel.Controls.Add(titleTxb);
            inputPanel.Controls.Add(deleteBtn);
            inputPanel.Controls.Add(updateBtn);
            inputPanel.Controls.Add(addBtn);
            inputPanel.Dock = DockStyle.Left;
            inputPanel.Location = new Point(0, 0);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(367, 581);
            inputPanel.TabIndex = 0;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(266, 41);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 23);
            clearBtn.TabIndex = 8;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // yearNud
            // 
            yearNud.Font = new Font("Segoe UI", 12F);
            yearNud.Location = new Point(137, 201);
            yearNud.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            yearNud.Name = "yearNud";
            yearNud.Size = new Size(204, 29);
            yearNud.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(38, 203);
            label5.Name = "label5";
            label5.Size = new Size(40, 21);
            label5.TabIndex = 4;
            label5.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(38, 166);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 4;
            label4.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(38, 119);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 4;
            label3.Text = "Artist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(38, 73);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 4;
            label2.Text = "Album Title";
            // 
            // genreTxb
            // 
            genreTxb.Font = new Font("Segoe UI", 12F);
            genreTxb.Location = new Point(137, 163);
            genreTxb.Name = "genreTxb";
            genreTxb.Size = new Size(204, 29);
            genreTxb.TabIndex = 3;
            // 
            // artistTxb
            // 
            artistTxb.Font = new Font("Segoe UI", 12F);
            artistTxb.Location = new Point(137, 116);
            artistTxb.Name = "artistTxb";
            artistTxb.Size = new Size(204, 29);
            artistTxb.TabIndex = 2;
            // 
            // titleTxb
            // 
            titleTxb.Font = new Font("Segoe UI", 12F);
            titleTxb.Location = new Point(137, 70);
            titleTxb.Name = "titleTxb";
            titleTxb.Size = new Size(204, 29);
            titleTxb.TabIndex = 1;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Segoe UI", 12F);
            deleteBtn.Location = new Point(252, 243);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(100, 34);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Remove";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Font = new Font("Segoe UI", 12F);
            updateBtn.Location = new Point(146, 243);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(100, 34);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Font = new Font("Segoe UI", 12F);
            addBtn.Location = new Point(38, 243);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(100, 34);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // dataPanel
            // 
            dataPanel.Controls.Add(albumsDgv);
            dataPanel.Controls.Add(panel1);
            dataPanel.Dock = DockStyle.Fill;
            dataPanel.Location = new Point(367, 0);
            dataPanel.Name = "dataPanel";
            dataPanel.Size = new Size(644, 581);
            dataPanel.TabIndex = 1;
            // 
            // albumsDgv
            // 
            albumsDgv.AllowUserToAddRows = false;
            albumsDgv.AllowUserToDeleteRows = false;
            albumsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            albumsDgv.Dock = DockStyle.Fill;
            albumsDgv.Location = new Point(0, 70);
            albumsDgv.Name = "albumsDgv";
            albumsDgv.ReadOnly = true;
            albumsDgv.Size = new Size(644, 511);
            albumsDgv.TabIndex = 0;
            albumsDgv.CellMouseDoubleClick += albumsDgv_CellMouseDoubleClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 70);
            panel1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(6, 47);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 51);
            label1.TabIndex = 0;
            label1.Text = "Albums";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AlbumInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 581);
            Controls.Add(dataPanel);
            Controls.Add(inputPanel);
            MinimumSize = new Size(1027, 620);
            Name = "AlbumInventory";
            Text = "VibeHive - Album Inventory";
            Load += AlbumInventory_Load;
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearNud).EndInit();
            dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)albumsDgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel inputPanel;
        private Panel dataPanel;
        private DataGridView albumsDgv;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox genreTxb;
        private TextBox artistTxb;
        private TextBox titleTxb;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private NumericUpDown yearNud;
        private Button btnRefresh;
        private Button clearBtn;
    }
}