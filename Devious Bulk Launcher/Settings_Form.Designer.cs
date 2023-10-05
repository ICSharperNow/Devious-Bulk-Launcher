namespace Devious_Bulk_Launcher
{
    partial class Settings_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings_Form));
            this.Textbox_Client_Executable_Directory = new System.Windows.Forms.TextBox();
            this.Label_Client_Executable_Directory_Title = new System.Windows.Forms.Label();
            this.Radio_Button_Dark_Theme = new System.Windows.Forms.RadioButton();
            this.Label_Theme_Title = new System.Windows.Forms.Label();
            this.Button_Set_Executable_Directory = new System.Windows.Forms.Button();
            this.Label_Sec_Between_Client_Launches = new System.Windows.Forms.Label();
            this.Number_Up_Down_Client_Launch_Seconds = new System.Windows.Forms.NumericUpDown();
            this.Label_Launch_Client_In_Debug_Mode = new System.Windows.Forms.Label();
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled = new System.Windows.Forms.RadioButton();
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled = new System.Windows.Forms.RadioButton();
            this.Panel_Theme = new System.Windows.Forms.Panel();
            this.Radio_Button_Light_Theme = new System.Windows.Forms.RadioButton();
            this.Panel_Launch_Client_In_Debug_Mode = new System.Windows.Forms.Panel();
            this.Panel_Hide_Console_Window_When_Launching = new System.Windows.Forms.Panel();
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled = new System.Windows.Forms.RadioButton();
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled = new System.Windows.Forms.RadioButton();
            this.Label_Hide_Console_Window_When_Launching = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Up_Down_Client_Launch_Seconds)).BeginInit();
            this.Panel_Theme.SuspendLayout();
            this.Panel_Launch_Client_In_Debug_Mode.SuspendLayout();
            this.Panel_Hide_Console_Window_When_Launching.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textbox_Client_Executable_Directory
            // 
            this.Textbox_Client_Executable_Directory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textbox_Client_Executable_Directory.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Client_Executable_Directory.Location = new System.Drawing.Point(252, 22);
            this.Textbox_Client_Executable_Directory.Name = "Textbox_Client_Executable_Directory";
            this.Textbox_Client_Executable_Directory.Size = new System.Drawing.Size(393, 23);
            this.Textbox_Client_Executable_Directory.TabIndex = 1;
            // 
            // Label_Client_Executable_Directory_Title
            // 
            this.Label_Client_Executable_Directory_Title.AutoSize = true;
            this.Label_Client_Executable_Directory_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Client_Executable_Directory_Title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Client_Executable_Directory_Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Client_Executable_Directory_Title.Location = new System.Drawing.Point(12, 22);
            this.Label_Client_Executable_Directory_Title.Name = "Label_Client_Executable_Directory_Title";
            this.Label_Client_Executable_Directory_Title.Size = new System.Drawing.Size(234, 19);
            this.Label_Client_Executable_Directory_Title.TabIndex = 2;
            this.Label_Client_Executable_Directory_Title.Text = "Client jar/exe directory:";
            // 
            // Radio_Button_Dark_Theme
            // 
            this.Radio_Button_Dark_Theme.AutoSize = true;
            this.Radio_Button_Dark_Theme.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Dark_Theme.Checked = true;
            this.Radio_Button_Dark_Theme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Dark_Theme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Dark_Theme.Location = new System.Drawing.Point(3, 3);
            this.Radio_Button_Dark_Theme.Name = "Radio_Button_Dark_Theme";
            this.Radio_Button_Dark_Theme.Size = new System.Drawing.Size(117, 23);
            this.Radio_Button_Dark_Theme.TabIndex = 3;
            this.Radio_Button_Dark_Theme.TabStop = true;
            this.Radio_Button_Dark_Theme.Text = "Dark Theme";
            this.Radio_Button_Dark_Theme.UseVisualStyleBackColor = false;
            // 
            // Label_Theme_Title
            // 
            this.Label_Theme_Title.AutoSize = true;
            this.Label_Theme_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Theme_Title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Theme_Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Theme_Title.Location = new System.Drawing.Point(12, 71);
            this.Label_Theme_Title.Name = "Label_Theme_Title";
            this.Label_Theme_Title.Size = new System.Drawing.Size(63, 19);
            this.Label_Theme_Title.TabIndex = 5;
            this.Label_Theme_Title.Text = "Theme:";
            // 
            // Button_Set_Executable_Directory
            // 
            this.Button_Set_Executable_Directory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Set_Executable_Directory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Set_Executable_Directory.Location = new System.Drawing.Point(651, 22);
            this.Button_Set_Executable_Directory.Name = "Button_Set_Executable_Directory";
            this.Button_Set_Executable_Directory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Set_Executable_Directory.Size = new System.Drawing.Size(45, 23);
            this.Button_Set_Executable_Directory.TabIndex = 7;
            this.Button_Set_Executable_Directory.Text = "...";
            this.Button_Set_Executable_Directory.UseVisualStyleBackColor = false;
            // 
            // Label_Sec_Between_Client_Launches
            // 
            this.Label_Sec_Between_Client_Launches.AutoSize = true;
            this.Label_Sec_Between_Client_Launches.BackColor = System.Drawing.Color.Transparent;
            this.Label_Sec_Between_Client_Launches.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sec_Between_Client_Launches.ForeColor = System.Drawing.Color.White;
            this.Label_Sec_Between_Client_Launches.Location = new System.Drawing.Point(12, 115);
            this.Label_Sec_Between_Client_Launches.Name = "Label_Sec_Between_Client_Launches";
            this.Label_Sec_Between_Client_Launches.Size = new System.Drawing.Size(261, 19);
            this.Label_Sec_Between_Client_Launches.TabIndex = 13;
            this.Label_Sec_Between_Client_Launches.Text = "Sec/between client launches:";
            // 
            // Number_Up_Down_Client_Launch_Seconds
            // 
            this.Number_Up_Down_Client_Launch_Seconds.BackColor = System.Drawing.Color.Black;
            this.Number_Up_Down_Client_Launch_Seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number_Up_Down_Client_Launch_Seconds.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Number_Up_Down_Client_Launch_Seconds.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Up_Down_Client_Launch_Seconds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Number_Up_Down_Client_Launch_Seconds.Location = new System.Drawing.Point(279, 113);
            this.Number_Up_Down_Client_Launch_Seconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Number_Up_Down_Client_Launch_Seconds.Name = "Number_Up_Down_Client_Launch_Seconds";
            this.Number_Up_Down_Client_Launch_Seconds.Size = new System.Drawing.Size(74, 26);
            this.Number_Up_Down_Client_Launch_Seconds.TabIndex = 12;
            this.Number_Up_Down_Client_Launch_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number_Up_Down_Client_Launch_Seconds.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // Label_Launch_Client_In_Debug_Mode
            // 
            this.Label_Launch_Client_In_Debug_Mode.AutoSize = true;
            this.Label_Launch_Client_In_Debug_Mode.BackColor = System.Drawing.Color.Transparent;
            this.Label_Launch_Client_In_Debug_Mode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Launch_Client_In_Debug_Mode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Launch_Client_In_Debug_Mode.Location = new System.Drawing.Point(12, 158);
            this.Label_Launch_Client_In_Debug_Mode.Name = "Label_Launch_Client_In_Debug_Mode";
            this.Label_Launch_Client_In_Debug_Mode.Size = new System.Drawing.Size(261, 19);
            this.Label_Launch_Client_In_Debug_Mode.TabIndex = 16;
            this.Label_Launch_Client_In_Debug_Mode.Text = "Launch client in debug mode:";
            // 
            // Radio_Button_Launch_Client_In_Debug_Mode_Enabled
            // 
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.AutoSize = true;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.Location = new System.Drawing.Point(108, 12);
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.Name = "Radio_Button_Launch_Client_In_Debug_Mode_Enabled";
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.Size = new System.Drawing.Size(90, 23);
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.TabIndex = 15;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.Text = "Enabled";
            this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled.UseVisualStyleBackColor = false;
            // 
            // Radio_Button_Launch_Client_In_Debug_Mode_Disabled
            // 
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.AutoSize = true;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Checked = true;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Location = new System.Drawing.Point(3, 12);
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Name = "Radio_Button_Launch_Client_In_Debug_Mode_Disabled";
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Size = new System.Drawing.Size(99, 23);
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.TabIndex = 14;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.TabStop = true;
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Text = "Disabled";
            this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled.UseVisualStyleBackColor = false;
            // 
            // Panel_Theme
            // 
            this.Panel_Theme.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Theme.Controls.Add(this.Radio_Button_Light_Theme);
            this.Panel_Theme.Controls.Add(this.Radio_Button_Dark_Theme);
            this.Panel_Theme.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Theme.Location = new System.Drawing.Point(81, 66);
            this.Panel_Theme.Name = "Panel_Theme";
            this.Panel_Theme.Size = new System.Drawing.Size(259, 29);
            this.Panel_Theme.TabIndex = 19;
            // 
            // Radio_Button_Light_Theme
            // 
            this.Radio_Button_Light_Theme.AutoSize = true;
            this.Radio_Button_Light_Theme.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Light_Theme.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Light_Theme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Light_Theme.Location = new System.Drawing.Point(126, 3);
            this.Radio_Button_Light_Theme.Name = "Radio_Button_Light_Theme";
            this.Radio_Button_Light_Theme.Size = new System.Drawing.Size(126, 23);
            this.Radio_Button_Light_Theme.TabIndex = 4;
            this.Radio_Button_Light_Theme.Text = "Light Theme";
            this.Radio_Button_Light_Theme.UseVisualStyleBackColor = false;
            // 
            // Panel_Launch_Client_In_Debug_Mode
            // 
            this.Panel_Launch_Client_In_Debug_Mode.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Launch_Client_In_Debug_Mode.Controls.Add(this.Radio_Button_Launch_Client_In_Debug_Mode_Enabled);
            this.Panel_Launch_Client_In_Debug_Mode.Controls.Add(this.Radio_Button_Launch_Client_In_Debug_Mode_Disabled);
            this.Panel_Launch_Client_In_Debug_Mode.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Launch_Client_In_Debug_Mode.Location = new System.Drawing.Point(279, 145);
            this.Panel_Launch_Client_In_Debug_Mode.Name = "Panel_Launch_Client_In_Debug_Mode";
            this.Panel_Launch_Client_In_Debug_Mode.Size = new System.Drawing.Size(233, 47);
            this.Panel_Launch_Client_In_Debug_Mode.TabIndex = 20;
            // 
            // Panel_Hide_Console_Window_When_Launching
            // 
            this.Panel_Hide_Console_Window_When_Launching.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Hide_Console_Window_When_Launching.Controls.Add(this.Radio_Button_Hide_Console_Window_When_Launching_Enabled);
            this.Panel_Hide_Console_Window_When_Launching.Controls.Add(this.Radio_Button_Hide_Console_Window_When_Launching_Disabled);
            this.Panel_Hide_Console_Window_When_Launching.ForeColor = System.Drawing.Color.Transparent;
            this.Panel_Hide_Console_Window_When_Launching.Location = new System.Drawing.Point(342, 198);
            this.Panel_Hide_Console_Window_When_Launching.Name = "Panel_Hide_Console_Window_When_Launching";
            this.Panel_Hide_Console_Window_When_Launching.Size = new System.Drawing.Size(207, 38);
            this.Panel_Hide_Console_Window_When_Launching.TabIndex = 22;
            // 
            // Radio_Button_Hide_Console_Window_When_Launching_Enabled
            // 
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.AutoSize = true;
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.Location = new System.Drawing.Point(108, 9);
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.Name = "Radio_Button_Hide_Console_Window_When_Launching_Enabled";
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.Size = new System.Drawing.Size(90, 23);
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.TabIndex = 15;
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.Text = "Enabled";
            this.Radio_Button_Hide_Console_Window_When_Launching_Enabled.UseVisualStyleBackColor = false;
            // 
            // Radio_Button_Hide_Console_Window_When_Launching_Disabled
            // 
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.AutoSize = true;
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.Checked = true;
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.Location = new System.Drawing.Point(3, 9);
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.Name = "Radio_Button_Hide_Console_Window_When_Launching_Disabled";
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.Size = new System.Drawing.Size(99, 23);
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.TabIndex = 14;
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.TabStop = true;
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.Text = "Disabled";
            this.Radio_Button_Hide_Console_Window_When_Launching_Disabled.UseVisualStyleBackColor = false;
            // 
            // Label_Hide_Console_Window_When_Launching
            // 
            this.Label_Hide_Console_Window_When_Launching.AutoSize = true;
            this.Label_Hide_Console_Window_When_Launching.BackColor = System.Drawing.Color.Transparent;
            this.Label_Hide_Console_Window_When_Launching.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Hide_Console_Window_When_Launching.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Hide_Console_Window_When_Launching.Location = new System.Drawing.Point(12, 207);
            this.Label_Hide_Console_Window_When_Launching.Name = "Label_Hide_Console_Window_When_Launching";
            this.Label_Hide_Console_Window_When_Launching.Size = new System.Drawing.Size(324, 19);
            this.Label_Hide_Console_Window_When_Launching.TabIndex = 21;
            this.Label_Hide_Console_Window_When_Launching.Text = "Hide console window when launching:";
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 263);
            this.Controls.Add(this.Panel_Hide_Console_Window_When_Launching);
            this.Controls.Add(this.Label_Hide_Console_Window_When_Launching);
            this.Controls.Add(this.Panel_Launch_Client_In_Debug_Mode);
            this.Controls.Add(this.Panel_Theme);
            this.Controls.Add(this.Label_Launch_Client_In_Debug_Mode);
            this.Controls.Add(this.Label_Sec_Between_Client_Launches);
            this.Controls.Add(this.Number_Up_Down_Client_Launch_Seconds);
            this.Controls.Add(this.Button_Set_Executable_Directory);
            this.Controls.Add(this.Label_Theme_Title);
            this.Controls.Add(this.Label_Client_Executable_Directory_Title);
            this.Controls.Add(this.Textbox_Client_Executable_Directory);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings_Form";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Number_Up_Down_Client_Launch_Seconds)).EndInit();
            this.Panel_Theme.ResumeLayout(false);
            this.Panel_Theme.PerformLayout();
            this.Panel_Launch_Client_In_Debug_Mode.ResumeLayout(false);
            this.Panel_Launch_Client_In_Debug_Mode.PerformLayout();
            this.Panel_Hide_Console_Window_When_Launching.ResumeLayout(false);
            this.Panel_Hide_Console_Window_When_Launching.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Textbox_Client_Executable_Directory;
        private System.Windows.Forms.Label Label_Client_Executable_Directory_Title;
        private System.Windows.Forms.RadioButton Radio_Button_Dark_Theme;
        private System.Windows.Forms.Label Label_Theme_Title;
        private System.Windows.Forms.Button Button_Set_Executable_Directory;
        private System.Windows.Forms.Label Label_Sec_Between_Client_Launches;
        private System.Windows.Forms.NumericUpDown Number_Up_Down_Client_Launch_Seconds;
        private System.Windows.Forms.Label Label_Launch_Client_In_Debug_Mode;
        private System.Windows.Forms.RadioButton Radio_Button_Launch_Client_In_Debug_Mode_Enabled;
        private System.Windows.Forms.RadioButton Radio_Button_Launch_Client_In_Debug_Mode_Disabled;
        private System.Windows.Forms.Panel Panel_Theme;
        private System.Windows.Forms.RadioButton Radio_Button_Light_Theme;
        private System.Windows.Forms.Panel Panel_Launch_Client_In_Debug_Mode;
        private System.Windows.Forms.Panel Panel_Hide_Console_Window_When_Launching;
        private System.Windows.Forms.RadioButton Radio_Button_Hide_Console_Window_When_Launching_Enabled;
        private System.Windows.Forms.RadioButton Radio_Button_Hide_Console_Window_When_Launching_Disabled;
        private System.Windows.Forms.Label Label_Hide_Console_Window_When_Launching;
    }
}