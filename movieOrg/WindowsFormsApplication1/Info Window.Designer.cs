namespace WindowsFormsApplication1
{
    partial class Info_Window
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
            this.poster_path = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStory = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGenres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxProducers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.poster_path)).BeginInit();
            this.SuspendLayout();
            // 
            // poster_path
            // 
            this.poster_path.Location = new System.Drawing.Point(12, 12);
            this.poster_path.Name = "poster_path";
            this.poster_path.Size = new System.Drawing.Size(185, 278);
            this.poster_path.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poster_path.TabIndex = 0;
            this.poster_path.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(543, 338);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(330, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // textBoxStory
            // 
            this.textBoxStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxStory.Location = new System.Drawing.Point(334, 112);
            this.textBoxStory.Multiline = true;
            this.textBoxStory.Name = "textBoxStory";
            this.textBoxStory.ReadOnly = true;
            this.textBoxStory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxStory.Size = new System.Drawing.Size(380, 90);
            this.textBoxStory.TabIndex = 8;
            this.textBoxStory.Text = "description";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTitle.Location = new System.Drawing.Point(413, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(34, 20);
            this.labelTitle.TabIndex = 9;
            this.labelTitle.Text = "title";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelYear.Location = new System.Drawing.Point(413, 55);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(39, 20);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "year";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGenres
            // 
            this.textBoxGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxGenres.Location = new System.Drawing.Point(417, 233);
            this.textBoxGenres.Multiline = true;
            this.textBoxGenres.Name = "textBoxGenres";
            this.textBoxGenres.ReadOnly = true;
            this.textBoxGenres.Size = new System.Drawing.Size(251, 38);
            this.textBoxGenres.TabIndex = 12;
            this.textBoxGenres.Text = "Genres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(330, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Genres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(330, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Producers";
            // 
            // textBoxProducers
            // 
            this.textBoxProducers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProducers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxProducers.Location = new System.Drawing.Point(418, 274);
            this.textBoxProducers.Multiline = true;
            this.textBoxProducers.Name = "textBoxProducers";
            this.textBoxProducers.ReadOnly = true;
            this.textBoxProducers.Size = new System.Drawing.Size(380, 42);
            this.textBoxProducers.TabIndex = 15;
            this.textBoxProducers.Text = "Producers";
            // 
            // Info_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 387);
            this.Controls.Add(this.textBoxProducers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGenres);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxStory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poster_path);
            this.Name = "Info_Window";
            this.Text = "Info_Window";
            this.Load += new System.EventHandler(this.Info_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poster_path)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poster_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStory;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxGenres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxProducers;
    }
}