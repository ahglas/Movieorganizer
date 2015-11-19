using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.MovieBox = new System.Windows.Forms.ListBox();
            this.ContextMenuListbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.identifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextSearchMovie = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextSearchTV = new System.Windows.Forms.ToolStripMenuItem();
            this.getInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoDir = new System.Windows.Forms.Button();
            this.findMovieButton = new System.Windows.Forms.Button();
            this.findSerieButton = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.workFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuListbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieBox
            // 
            this.MovieBox.BackColor = System.Drawing.Color.White;
            this.MovieBox.ContextMenuStrip = this.ContextMenuListbox;
            this.MovieBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MovieBox.Location = new System.Drawing.Point(0, 24);
            this.MovieBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.MovieBox.Name = "MovieBox";
            this.MovieBox.Size = new System.Drawing.Size(203, 343);
            this.MovieBox.TabIndex = 0;
            this.MovieBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MovieBox_MouseDoubleClick);
            this.MovieBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovieBox_MouseDown);
            // 
            // ContextMenuListbox
            // 
            this.ContextMenuListbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifyToolStripMenuItem,
            this.getInfoToolStripMenuItem});
            this.ContextMenuListbox.Name = "ContextMenuListbox";
            this.ContextMenuListbox.Size = new System.Drawing.Size(128, 48);
            // 
            // identifyToolStripMenuItem
            // 
            this.identifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextSearchMovie,
            this.ContextSearchTV});
            this.identifyToolStripMenuItem.Name = "identifyToolStripMenuItem";
            this.identifyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.identifyToolStripMenuItem.Text = "Identify";
            // 
            // ContextSearchMovie
            // 
            this.ContextSearchMovie.Name = "ContextSearchMovie";
            this.ContextSearchMovie.Size = new System.Drawing.Size(121, 22);
            this.ContextSearchMovie.Text = "Movie";
            this.ContextSearchMovie.Click += new System.EventHandler(this.movieToolStripMenuItem_Click);
            // 
            // ContextSearchTV
            // 
            this.ContextSearchTV.Name = "ContextSearchTV";
            this.ContextSearchTV.Size = new System.Drawing.Size(121, 22);
            this.ContextSearchTV.Text = "TV Series";
            this.ContextSearchTV.Click += new System.EventHandler(this.ContextSearchTV_Click);
            // 
            // getInfoToolStripMenuItem
            // 
            this.getInfoToolStripMenuItem.Name = "getInfoToolStripMenuItem";
            this.getInfoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.getInfoToolStripMenuItem.Text = "Show info";
            this.getInfoToolStripMenuItem.Click += new System.EventHandler(this.getInfoToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // mainFolderToolStripMenuItem
            // 
            this.mainFolderToolStripMenuItem.Name = "mainFolderToolStripMenuItem";
            this.mainFolderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.mainFolderToolStripMenuItem.Text = "Work Folder";
            this.mainFolderToolStripMenuItem.Click += new System.EventHandler(this.mainFolderToolStripMenuItem_Click);
            // 
            // imageSettingsToolStripMenuItem
            // 
            this.imageSettingsToolStripMenuItem.Name = "imageSettingsToolStripMenuItem";
            this.imageSettingsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.imageSettingsToolStripMenuItem.Text = "Image Settings";
            this.imageSettingsToolStripMenuItem.Click += new System.EventHandler(this.imageSettingsToolStripMenuItem_Click);
            // 
            // gotoDir
            // 
            this.gotoDir.Location = new System.Drawing.Point(209, 28);
            this.gotoDir.Name = "gotoDir";
            this.gotoDir.Size = new System.Drawing.Size(93, 23);
            this.gotoDir.TabIndex = 3;
            this.gotoDir.Text = "Open folder";
            this.gotoDir.UseVisualStyleBackColor = true;
            this.gotoDir.Click += new System.EventHandler(this.openDirButton_Click);
            // 
            // findMovieButton
            // 
            this.findMovieButton.Location = new System.Drawing.Point(209, 57);
            this.findMovieButton.Name = "findMovieButton";
            this.findMovieButton.Size = new System.Drawing.Size(93, 23);
            this.findMovieButton.TabIndex = 4;
            this.findMovieButton.Text = "Search Movie";
            this.findMovieButton.UseVisualStyleBackColor = true;
            this.findMovieButton.Click += new System.EventHandler(this.findMovieButton_Click);
            // 
            // findSerieButton
            // 
            this.findSerieButton.Location = new System.Drawing.Point(209, 86);
            this.findSerieButton.Name = "findSerieButton";
            this.findSerieButton.Size = new System.Drawing.Size(93, 23);
            this.findSerieButton.TabIndex = 5;
            this.findSerieButton.Text = "Search TvShow";
            this.findSerieButton.UseVisualStyleBackColor = true;
            this.findSerieButton.Click += new System.EventHandler(this.findSerieButton_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.Location = new System.Drawing.Point(564, 28);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(83, 88);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 6;
            this.profilePicture.TabStop = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Program";
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workFolderToolStripMenuItem,
            this.imageSettingsToolStripMenuItem1});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem2.Text = "Settings";
            // 
            // workFolderToolStripMenuItem
            // 
            this.workFolderToolStripMenuItem.Name = "workFolderToolStripMenuItem";
            this.workFolderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.workFolderToolStripMenuItem.Text = "Work folder";
            this.workFolderToolStripMenuItem.Click += new System.EventHandler(this.mainFolderToolStripMenuItem_Click);
            // 
            // imageSettingsToolStripMenuItem1
            // 
            this.imageSettingsToolStripMenuItem1.Name = "imageSettingsToolStripMenuItem1";
            this.imageSettingsToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.imageSettingsToolStripMenuItem1.Text = "Image settings";
            this.imageSettingsToolStripMenuItem1.Click += new System.EventHandler(this.imageSettingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(656, 367);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.findSerieButton);
            this.Controls.Add(this.findMovieButton);
            this.Controls.Add(this.gotoDir);
            this.Controls.Add(this.MovieBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Movie Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.onResize);
            this.ContextMenuListbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MovieBox;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainFolderToolStripMenuItem;
        private System.Windows.Forms.Button gotoDir;
        private System.Windows.Forms.Button findMovieButton;
        private System.Windows.Forms.Button findSerieButton;
        private System.Windows.Forms.ContextMenuStrip ContextMenuListbox;
        private System.Windows.Forms.ToolStripMenuItem identifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContextSearchMovie;
        private System.Windows.Forms.ToolStripMenuItem ContextSearchTV;
        private System.Windows.Forms.ToolStripMenuItem getInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSettingsToolStripMenuItem;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem workFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSettingsToolStripMenuItem1;
    }
}

