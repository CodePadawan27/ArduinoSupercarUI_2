namespace ArduinoSupercarUI
{
    partial class Popout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popout));
            this.popout_webcam = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.popout_webcam)).BeginInit();
            this.SuspendLayout();
            // 
            // popout_webcam
            // 
            this.popout_webcam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.popout_webcam.Location = new System.Drawing.Point(0, 0);
            this.popout_webcam.Margin = new System.Windows.Forms.Padding(0);
            this.popout_webcam.Name = "popout_webcam";
            this.popout_webcam.Size = new System.Drawing.Size(986, 683);
            this.popout_webcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.popout_webcam.TabIndex = 0;
            this.popout_webcam.TabStop = false;
            // 
            // Popout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 681);
            this.Controls.Add(this.popout_webcam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popout";
            this.Text = "Popout";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popout_webcam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox popout_webcam;
    }
}