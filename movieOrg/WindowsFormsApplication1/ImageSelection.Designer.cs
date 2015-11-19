namespace WindowsFormsApplication1
{
    partial class ImageSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.profileFileName = new System.Windows.Forms.TextBox();
            this.openProfilePicker = new System.Windows.Forms.Button();
            this.profilePicture = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundFileName = new System.Windows.Forms.TextBox();
            this.openBackgroundPicker = new System.Windows.Forms.Button();
            this.backgroundPicker = new System.Windows.Forms.OpenFileDialog();
            this.appleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avatar";
            // 
            // profileFileName
            // 
            this.profileFileName.Location = new System.Drawing.Point(16, 32);
            this.profileFileName.Name = "profileFileName";
            this.profileFileName.Size = new System.Drawing.Size(236, 20);
            this.profileFileName.TabIndex = 1;
            this.profileFileName.TextChanged += new System.EventHandler(this.profileFileName_TextChanged);
            // 
            // openProfilePicker
            // 
            this.openProfilePicker.Location = new System.Drawing.Point(16, 58);
            this.openProfilePicker.Name = "openProfilePicker";
            this.openProfilePicker.Size = new System.Drawing.Size(111, 20);
            this.openProfilePicker.TabIndex = 2;
            this.openProfilePicker.Text = "Open and Select";
            this.openProfilePicker.UseVisualStyleBackColor = true;
            this.openProfilePicker.Click += new System.EventHandler(this.openProfilePicker_Click);
            // 
            // profilePicture
            // 
            this.profilePicture.FileName = "profilePicture";
            this.profilePicture.Title = "Select profile picture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Background Image";
            // 
            // backgroundFileName
            // 
            this.backgroundFileName.Location = new System.Drawing.Point(16, 176);
            this.backgroundFileName.Name = "backgroundFileName";
            this.backgroundFileName.Size = new System.Drawing.Size(236, 20);
            this.backgroundFileName.TabIndex = 4;
            this.backgroundFileName.TextChanged += new System.EventHandler(this.backgroundFileName_TextChanged);
            // 
            // openBackgroundPicker
            // 
            this.openBackgroundPicker.Location = new System.Drawing.Point(16, 202);
            this.openBackgroundPicker.Name = "openBackgroundPicker";
            this.openBackgroundPicker.Size = new System.Drawing.Size(111, 20);
            this.openBackgroundPicker.TabIndex = 2;
            this.openBackgroundPicker.Text = "Open and Select";
            this.openBackgroundPicker.UseVisualStyleBackColor = true;
            this.openBackgroundPicker.Click += new System.EventHandler(this.openBackgroundPicker_Click);
            // 
            // backgroundPicker
            // 
            this.backgroundPicker.FileName = "backgroundPicture";
            this.backgroundPicker.Title = "Select Background Picture";
            // 
            // appleButton
            // 
            this.appleButton.Location = new System.Drawing.Point(270, 255);
            this.appleButton.Name = "appleButton";
            this.appleButton.Size = new System.Drawing.Size(75, 23);
            this.appleButton.TabIndex = 5;
            this.appleButton.Text = "Apply";
            this.appleButton.UseVisualStyleBackColor = true;
            this.appleButton.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ImageSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 290);
            this.Controls.Add(this.appleButton);
            this.Controls.Add(this.openBackgroundPicker);
            this.Controls.Add(this.backgroundFileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openProfilePicker);
            this.Controls.Add(this.profileFileName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImageSelection";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profileFileName;
        private System.Windows.Forms.Button openProfilePicker;
        private System.Windows.Forms.OpenFileDialog profilePicture;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox backgroundFileName;
        private System.Windows.Forms.Button openBackgroundPicker;
        private System.Windows.Forms.OpenFileDialog backgroundPicker;
        private System.Windows.Forms.Button appleButton;
    }
}