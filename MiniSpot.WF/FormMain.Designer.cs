namespace MiniSpot.WF
{
    partial class FormMain
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelPlayer = new System.Windows.Forms.Panel();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.trackBarPlayback = new System.Windows.Forms.TrackBar();
            this.labelNameSong = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonNextTrack = new System.Windows.Forms.Button();
            this.buttonPreviousTrack = new System.Windows.Forms.Button();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPlayLists = new System.Windows.Forms.Panel();
            this.buttonPlayList2 = new System.Windows.Forms.Button();
            this.buttonPlayList1 = new System.Windows.Forms.Button();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.buttonAddPlayList = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelPlayLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlay.Location = new System.Drawing.Point(385, 13);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(30, 30);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = ">";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPlayer
            // 
            this.panelPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayer.Controls.Add(this.trackBarVolume);
            this.panelPlayer.Controls.Add(this.trackBarPlayback);
            this.panelPlayer.Controls.Add(this.labelNameSong);
            this.panelPlayer.Controls.Add(this.labelArtist);
            this.panelPlayer.Controls.Add(this.pictureBox1);
            this.panelPlayer.Controls.Add(this.buttonNextTrack);
            this.panelPlayer.Controls.Add(this.buttonPreviousTrack);
            this.panelPlayer.Controls.Add(this.buttonPlay);
            this.panelPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayer.Location = new System.Drawing.Point(0, 367);
            this.panelPlayer.Name = "panelPlayer";
            this.panelPlayer.Size = new System.Drawing.Size(800, 83);
            this.panelPlayer.TabIndex = 1;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.AutoSize = false;
            this.trackBarVolume.Location = new System.Drawing.Point(683, 16);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(104, 25);
            this.trackBarVolume.TabIndex = 4;
            this.trackBarVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBarPlayback
            // 
            this.trackBarPlayback.AutoSize = false;
            this.trackBarPlayback.Location = new System.Drawing.Point(208, 49);
            this.trackBarPlayback.Name = "trackBarPlayback";
            this.trackBarPlayback.Size = new System.Drawing.Size(438, 29);
            this.trackBarPlayback.TabIndex = 3;
            this.trackBarPlayback.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // labelNameSong
            // 
            this.labelNameSong.AutoSize = true;
            this.labelNameSong.Location = new System.Drawing.Point(76, 28);
            this.labelNameSong.Name = "labelNameSong";
            this.labelNameSong.Size = new System.Drawing.Size(39, 15);
            this.labelNameSong.TabIndex = 2;
            this.labelNameSong.Text = "Name";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.Location = new System.Drawing.Point(76, 43);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(35, 15);
            this.labelArtist.TabIndex = 2;
            this.labelArtist.Text = "Artist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonNextTrack
            // 
            this.buttonNextTrack.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNextTrack.Location = new System.Drawing.Point(421, 17);
            this.buttonNextTrack.Name = "buttonNextTrack";
            this.buttonNextTrack.Size = new System.Drawing.Size(25, 25);
            this.buttonNextTrack.TabIndex = 0;
            this.buttonNextTrack.Text = ">I";
            this.buttonNextTrack.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousTrack
            // 
            this.buttonPreviousTrack.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPreviousTrack.Location = new System.Drawing.Point(354, 16);
            this.buttonPreviousTrack.Name = "buttonPreviousTrack";
            this.buttonPreviousTrack.Size = new System.Drawing.Size(25, 25);
            this.buttonPreviousTrack.TabIndex = 0;
            this.buttonPreviousTrack.Text = "I<";
            this.buttonPreviousTrack.UseVisualStyleBackColor = true;
            // 
            // TitleBar
            // 
            this.TitleBar.Controls.Add(this.buttonOptions);
            this.TitleBar.Controls.Add(this.buttonClose);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(800, 20);
            this.TitleBar.TabIndex = 2;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOptions.FlatAppearance.BorderSize = 0;
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOptions.Location = new System.Drawing.Point(0, 0);
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(50, 20);
            this.buttonOptions.TabIndex = 1;
            this.buttonOptions.Text = "* * *";
            this.buttonOptions.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonOptions.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(760, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 20);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelPlayLists);
            this.panelMenu.Controls.Add(this.panelSeparator);
            this.panelMenu.Controls.Add(this.buttonAddPlayList);
            this.panelMenu.Controls.Add(this.buttonUser);
            this.panelMenu.Controls.Add(this.buttonSearch);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 20);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 347);
            this.panelMenu.TabIndex = 3;
            // 
            // panelPlayLists
            // 
            this.panelPlayLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlayLists.Controls.Add(this.buttonPlayList2);
            this.panelPlayLists.Controls.Add(this.buttonPlayList1);
            this.panelPlayLists.Location = new System.Drawing.Point(0, 157);
            this.panelPlayLists.Name = "panelPlayLists";
            this.panelPlayLists.Size = new System.Drawing.Size(180, 190);
            this.panelPlayLists.TabIndex = 3;
            // 
            // buttonPlayList2
            // 
            this.buttonPlayList2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayList2.FlatAppearance.BorderSize = 0;
            this.buttonPlayList2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayList2.Location = new System.Drawing.Point(0, 30);
            this.buttonPlayList2.Name = "buttonPlayList2";
            this.buttonPlayList2.Size = new System.Drawing.Size(180, 30);
            this.buttonPlayList2.TabIndex = 0;
            this.buttonPlayList2.Text = "Плейлист 2";
            this.buttonPlayList2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayList2.UseVisualStyleBackColor = true;
            // 
            // buttonPlayList1
            // 
            this.buttonPlayList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlayList1.FlatAppearance.BorderSize = 0;
            this.buttonPlayList1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayList1.Location = new System.Drawing.Point(0, 0);
            this.buttonPlayList1.Name = "buttonPlayList1";
            this.buttonPlayList1.Size = new System.Drawing.Size(180, 30);
            this.buttonPlayList1.TabIndex = 0;
            this.buttonPlayList1.Text = "Плейлист 1";
            this.buttonPlayList1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayList1.UseVisualStyleBackColor = true;
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.DimGray;
            this.panelSeparator.Location = new System.Drawing.Point(10, 150);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(160, 1);
            this.panelSeparator.TabIndex = 1;
            // 
            // buttonAddPlayList
            // 
            this.buttonAddPlayList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddPlayList.FlatAppearance.BorderSize = 0;
            this.buttonAddPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddPlayList.Location = new System.Drawing.Point(0, 120);
            this.buttonAddPlayList.Name = "buttonAddPlayList";
            this.buttonAddPlayList.Size = new System.Drawing.Size(180, 23);
            this.buttonAddPlayList.TabIndex = 2;
            this.buttonAddPlayList.Text = "[+] Добавить плейлист";
            this.buttonAddPlayList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddPlayList.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Location = new System.Drawing.Point(0, 80);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(180, 40);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "Медиатека";
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(0, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(180, 40);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Location = new System.Drawing.Point(0, 0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(180, 40);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Главная";
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 20);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(620, 347);
            this.panelMain.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.panelPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPlayer.ResumeLayout(false);
            this.panelPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlayback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TitleBar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelPlayLists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonPlay;
        private Panel panelPlayer;
        private Panel TitleBar;
        private Button buttonClose;
        private Panel panelMenu;
        private Panel panelMain;
        private Button buttonHome;
        private Panel panelSeparator;
        private Button buttonUser;
        private Button buttonSearch;
        private Button buttonOptions;
        private Panel panelPlayLists;
        private Button buttonPlayList2;
        private Button buttonPlayList1;
        private Button buttonAddPlayList;
        private PictureBox pictureBox1;
        private Label labelArtist;
        private Label labelNameSong;
        private TrackBar trackBarVolume;
        private TrackBar trackBarPlayback;
        private Button buttonNextTrack;
        private Button buttonPreviousTrack;
    }
}