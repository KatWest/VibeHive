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
            button1 = new Button();
            button2 = new Button();
            albumManageBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(46, 53);
            button1.Name = "button1";
            button1.Size = new Size(129, 85);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(181, 53);
            button2.Name = "button2";
            button2.Size = new Size(129, 85);
            button2.TabIndex = 2;
            button2.Text = "button1";
            button2.UseVisualStyleBackColor = true;
            // 
            // albumManageBtn
            // 
            albumManageBtn.Location = new Point(316, 53);
            albumManageBtn.Name = "albumManageBtn";
            albumManageBtn.Size = new Size(129, 85);
            albumManageBtn.TabIndex = 3;
            albumManageBtn.Text = "Album Management";
            albumManageBtn.UseVisualStyleBackColor = true;
            albumManageBtn.Click += albumManageBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(albumManageBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "VibeHive";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button albumManageBtn;
    }
}
