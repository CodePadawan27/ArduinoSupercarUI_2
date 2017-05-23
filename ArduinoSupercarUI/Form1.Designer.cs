namespace ArduinoSupercarUI
{
    partial class arduinoUI
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
            this.UI_otsikko = new System.Windows.Forms.Label();
            this.UI_up = new System.Windows.Forms.Button();
            this.UI_down = new System.Windows.Forms.Button();
            this.UI_right = new System.Windows.Forms.Button();
            this.UI_left = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tiedostoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UI_button_start = new System.Windows.Forms.Button();
            this.UI_button_stop = new System.Windows.Forms.Button();
            this.UI_button_picture = new System.Windows.Forms.Button();
            this.UI_combobox_valikko = new System.Windows.Forms.ComboBox();
            this.UI_tallennusRuutu = new System.Windows.Forms.SaveFileDialog();
            this.UI_lights_ON = new System.Windows.Forms.Button();
            this.UI_lights_OFF = new System.Windows.Forms.Button();
            this.UI_control_group = new System.Windows.Forms.GroupBox();
            this.UI_lights_group = new System.Windows.Forms.GroupBox();
            this.UI_webcam_group = new System.Windows.Forms.GroupBox();
            this.UI_connection_ip = new System.Windows.Forms.TextBox();
            this.UI_button_connect = new System.Windows.Forms.Button();
            this.UI_connection_port = new System.Windows.Forms.TextBox();
            this.UI_group_connection = new System.Windows.Forms.GroupBox();
            this.UI_logo = new System.Windows.Forms.PictureBox();
            this.UI_webcam = new System.Windows.Forms.PictureBox();
            this.UI_break = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.UI_control_group.SuspendLayout();
            this.UI_lights_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UI_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_webcam)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_otsikko
            // 
            this.UI_otsikko.AutoSize = true;
            this.UI_otsikko.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_otsikko.Location = new System.Drawing.Point(48, 28);
            this.UI_otsikko.Name = "UI_otsikko";
            this.UI_otsikko.Size = new System.Drawing.Size(272, 45);
            this.UI_otsikko.TabIndex = 0;
            this.UI_otsikko.Text = "Arduino SuperCar";
            // 
            // UI_up
            // 
            this.UI_up.Location = new System.Drawing.Point(92, 19);
            this.UI_up.Name = "UI_up";
            this.UI_up.Size = new System.Drawing.Size(75, 23);
            this.UI_up.TabIndex = 1;
            this.UI_up.Text = "UP";
            this.UI_up.UseVisualStyleBackColor = true;
            this.UI_up.Click += new System.EventHandler(this.UI_up_Click);
            // 
            // UI_down
            // 
            this.UI_down.Location = new System.Drawing.Point(92, 48);
            this.UI_down.Name = "UI_down";
            this.UI_down.Size = new System.Drawing.Size(75, 23);
            this.UI_down.TabIndex = 1;
            this.UI_down.Text = "DOWN";
            this.UI_down.UseVisualStyleBackColor = true;
            // 
            // UI_right
            // 
            this.UI_right.Location = new System.Drawing.Point(173, 33);
            this.UI_right.Name = "UI_right";
            this.UI_right.Size = new System.Drawing.Size(75, 23);
            this.UI_right.TabIndex = 1;
            this.UI_right.Text = "RIGHT";
            this.UI_right.UseVisualStyleBackColor = true;
            // 
            // UI_left
            // 
            this.UI_left.Location = new System.Drawing.Point(11, 33);
            this.UI_left.Name = "UI_left";
            this.UI_left.Size = new System.Drawing.Size(75, 23);
            this.UI_left.TabIndex = 1;
            this.UI_left.Text = "LEFT";
            this.UI_left.UseVisualStyleBackColor = true;
            this.UI_left.Click += new System.EventHandler(this.UI_left_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiedostoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            this.tiedostoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suljeToolStripMenuItem});
            this.tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            this.tiedostoToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.tiedostoToolStripMenuItem.Text = "File";
            // 
            // suljeToolStripMenuItem
            // 
            this.suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            this.suljeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.suljeToolStripMenuItem.Text = "Close";
            this.suljeToolStripMenuItem.Click += new System.EventHandler(this.suljeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.aboutToolStripMenuItem.Text = "Information";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // UI_button_start
            // 
            this.UI_button_start.Location = new System.Drawing.Point(465, 384);
            this.UI_button_start.Name = "UI_button_start";
            this.UI_button_start.Size = new System.Drawing.Size(75, 23);
            this.UI_button_start.TabIndex = 4;
            this.UI_button_start.Text = "Start";
            this.UI_button_start.UseVisualStyleBackColor = true;
            this.UI_button_start.Click += new System.EventHandler(this.UI_button_start_Click);
            // 
            // UI_button_stop
            // 
            this.UI_button_stop.Location = new System.Drawing.Point(778, 384);
            this.UI_button_stop.Name = "UI_button_stop";
            this.UI_button_stop.Size = new System.Drawing.Size(75, 23);
            this.UI_button_stop.TabIndex = 4;
            this.UI_button_stop.Text = "Stop";
            this.UI_button_stop.UseVisualStyleBackColor = true;
            this.UI_button_stop.Click += new System.EventHandler(this.UI_button_stop_Click);
            // 
            // UI_button_picture
            // 
            this.UI_button_picture.Location = new System.Drawing.Point(613, 384);
            this.UI_button_picture.Name = "UI_button_picture";
            this.UI_button_picture.Size = new System.Drawing.Size(92, 23);
            this.UI_button_picture.TabIndex = 4;
            this.UI_button_picture.Text = "Take a Picture";
            this.UI_button_picture.UseVisualStyleBackColor = true;
            this.UI_button_picture.Click += new System.EventHandler(this.UI_button_picture_Click);
            // 
            // UI_combobox_valikko
            // 
            this.UI_combobox_valikko.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_combobox_valikko.FormattingEnabled = true;
            this.UI_combobox_valikko.Location = new System.Drawing.Point(465, 342);
            this.UI_combobox_valikko.Name = "UI_combobox_valikko";
            this.UI_combobox_valikko.Size = new System.Drawing.Size(389, 21);
            this.UI_combobox_valikko.TabIndex = 5;
            this.UI_combobox_valikko.SelectedIndexChanged += new System.EventHandler(this.UI_combobox_valikko_SelectedIndexChanged);
            // 
            // UI_tallennusRuutu
            // 
            this.UI_tallennusRuutu.Filter = "jpg Image|*.jpg";
            // 
            // UI_lights_ON
            // 
            this.UI_lights_ON.Location = new System.Drawing.Point(6, 19);
            this.UI_lights_ON.Name = "UI_lights_ON";
            this.UI_lights_ON.Size = new System.Drawing.Size(75, 23);
            this.UI_lights_ON.TabIndex = 1;
            this.UI_lights_ON.Text = "ON";
            this.UI_lights_ON.UseVisualStyleBackColor = true;
            // 
            // UI_lights_OFF
            // 
            this.UI_lights_OFF.Location = new System.Drawing.Point(6, 53);
            this.UI_lights_OFF.Name = "UI_lights_OFF";
            this.UI_lights_OFF.Size = new System.Drawing.Size(75, 23);
            this.UI_lights_OFF.TabIndex = 1;
            this.UI_lights_OFF.Text = "OFF";
            this.UI_lights_OFF.UseVisualStyleBackColor = true;
            // 
            // UI_control_group
            // 
            this.UI_control_group.Controls.Add(this.UI_up);
            this.UI_control_group.Controls.Add(this.UI_break);
            this.UI_control_group.Controls.Add(this.UI_down);
            this.UI_control_group.Controls.Add(this.UI_right);
            this.UI_control_group.Controls.Add(this.UI_left);
            this.UI_control_group.Location = new System.Drawing.Point(39, 307);
            this.UI_control_group.Name = "UI_control_group";
            this.UI_control_group.Size = new System.Drawing.Size(264, 109);
            this.UI_control_group.TabIndex = 6;
            this.UI_control_group.TabStop = false;
            this.UI_control_group.Text = "Control";
            // 
            // UI_lights_group
            // 
            this.UI_lights_group.Controls.Add(this.UI_lights_ON);
            this.UI_lights_group.Controls.Add(this.UI_lights_OFF);
            this.UI_lights_group.Location = new System.Drawing.Point(321, 307);
            this.UI_lights_group.Name = "UI_lights_group";
            this.UI_lights_group.Size = new System.Drawing.Size(116, 83);
            this.UI_lights_group.TabIndex = 7;
            this.UI_lights_group.TabStop = false;
            this.UI_lights_group.Text = "Lights";
            // 
            // UI_webcam_group
            // 
            this.UI_webcam_group.Location = new System.Drawing.Point(453, 47);
            this.UI_webcam_group.Name = "UI_webcam_group";
            this.UI_webcam_group.Size = new System.Drawing.Size(415, 369);
            this.UI_webcam_group.TabIndex = 9;
            this.UI_webcam_group.TabStop = false;
            this.UI_webcam_group.Text = "Camera";
            // 
            // UI_connection_ip
            // 
            this.UI_connection_ip.Location = new System.Drawing.Point(50, 256);
            this.UI_connection_ip.Name = "UI_connection_ip";
            this.UI_connection_ip.Size = new System.Drawing.Size(75, 20);
            this.UI_connection_ip.TabIndex = 10;
            this.UI_connection_ip.Text = "192.168.1.1";
            this.UI_connection_ip.TextChanged += new System.EventHandler(this.UI_connection_ip_TextChanged);
            // 
            // UI_button_connect
            // 
            this.UI_button_connect.Location = new System.Drawing.Point(228, 254);
            this.UI_button_connect.Name = "UI_button_connect";
            this.UI_button_connect.Size = new System.Drawing.Size(75, 23);
            this.UI_button_connect.TabIndex = 1;
            this.UI_button_connect.Text = "Connect";
            this.UI_button_connect.UseVisualStyleBackColor = true;
            this.UI_button_connect.Click += new System.EventHandler(this.UI_button_connect_Click);
            // 
            // UI_connection_port
            // 
            this.UI_connection_port.Location = new System.Drawing.Point(162, 256);
            this.UI_connection_port.Name = "UI_connection_port";
            this.UI_connection_port.Size = new System.Drawing.Size(44, 20);
            this.UI_connection_port.TabIndex = 10;
            this.UI_connection_port.Text = "1000";
            // 
            // UI_group_connection
            // 
            this.UI_group_connection.Location = new System.Drawing.Point(39, 241);
            this.UI_group_connection.Name = "UI_group_connection";
            this.UI_group_connection.Size = new System.Drawing.Size(270, 47);
            this.UI_group_connection.TabIndex = 11;
            this.UI_group_connection.TabStop = false;
            this.UI_group_connection.Text = "Connection";
            // 
            // UI_logo
            // 
            this.UI_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_logo.Image = global::ArduinoSupercarUI.Properties.Resources.flat_800x800_075_f;
            this.UI_logo.Location = new System.Drawing.Point(78, 76);
            this.UI_logo.Name = "UI_logo";
            this.UI_logo.Size = new System.Drawing.Size(202, 134);
            this.UI_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UI_logo.TabIndex = 8;
            this.UI_logo.TabStop = false;
            // 
            // UI_webcam
            // 
            this.UI_webcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_webcam.Image = global::ArduinoSupercarUI.Properties.Resources.presstartlivefeed;
            this.UI_webcam.Location = new System.Drawing.Point(465, 60);
            this.UI_webcam.Name = "UI_webcam";
            this.UI_webcam.Size = new System.Drawing.Size(389, 253);
            this.UI_webcam.TabIndex = 3;
            this.UI_webcam.TabStop = false;
            this.UI_webcam.Click += new System.EventHandler(this.UI_webcam_Click);
            // 
            // UI_break
            // 
            this.UI_break.Location = new System.Drawing.Point(92, 77);
            this.UI_break.Name = "UI_break";
            this.UI_break.Size = new System.Drawing.Size(75, 23);
            this.UI_break.TabIndex = 1;
            this.UI_break.Text = "BREAK";
            this.UI_break.UseVisualStyleBackColor = true;
            // 
            // arduinoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 426);
            this.Controls.Add(this.UI_button_connect);
            this.Controls.Add(this.UI_connection_port);
            this.Controls.Add(this.UI_connection_ip);
            this.Controls.Add(this.UI_logo);
            this.Controls.Add(this.UI_lights_group);
            this.Controls.Add(this.UI_control_group);
            this.Controls.Add(this.UI_combobox_valikko);
            this.Controls.Add(this.UI_button_picture);
            this.Controls.Add(this.UI_button_stop);
            this.Controls.Add(this.UI_button_start);
            this.Controls.Add(this.UI_webcam);
            this.Controls.Add(this.UI_otsikko);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.UI_webcam_group);
            this.Controls.Add(this.UI_group_connection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "arduinoUI";
            this.Text = "Arduino SuperCar";
            this.Load += new System.EventHandler(this.arduinoUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.UI_control_group.ResumeLayout(false);
            this.UI_lights_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UI_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_webcam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UI_otsikko;
        private System.Windows.Forms.Button UI_up;
        private System.Windows.Forms.Button UI_down;
        private System.Windows.Forms.Button UI_right;
        private System.Windows.Forms.Button UI_left;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tiedostoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suljeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.PictureBox UI_webcam;
        private System.Windows.Forms.Button UI_button_start;
        private System.Windows.Forms.Button UI_button_stop;
        private System.Windows.Forms.Button UI_button_picture;
        private System.Windows.Forms.ComboBox UI_combobox_valikko;
        private System.Windows.Forms.SaveFileDialog UI_tallennusRuutu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button UI_lights_ON;
        private System.Windows.Forms.Button UI_lights_OFF;
        private System.Windows.Forms.GroupBox UI_control_group;
        private System.Windows.Forms.GroupBox UI_lights_group;
        private System.Windows.Forms.PictureBox UI_logo;
        private System.Windows.Forms.GroupBox UI_webcam_group;
        private System.Windows.Forms.TextBox UI_connection_ip;
        private System.Windows.Forms.Button UI_button_connect;
        private System.Windows.Forms.TextBox UI_connection_port;
        private System.Windows.Forms.GroupBox UI_group_connection;
        private System.Windows.Forms.Button UI_break;
    }
}

