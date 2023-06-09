﻿namespace Devious_Bulk_Launcher
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
            this.Radio_Button_Light_Theme = new System.Windows.Forms.RadioButton();
            this.Label_Theme_Title = new System.Windows.Forms.Label();
            this.Button_Set_Executable_Directory = new System.Windows.Forms.Button();
            this.Label_Sec_Between_Client_Launches = new System.Windows.Forms.Label();
            this.Number_Up_Down_Client_Launch_Seconds = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Number_Up_Down_Client_Launch_Seconds)).BeginInit();
            this.SuspendLayout();
            // 
            // Textbox_Client_Executable_Directory
            // 
            this.Textbox_Client_Executable_Directory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textbox_Client_Executable_Directory.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox_Client_Executable_Directory.Location = new System.Drawing.Point(307, 40);
            this.Textbox_Client_Executable_Directory.Name = "Textbox_Client_Executable_Directory";
            this.Textbox_Client_Executable_Directory.Size = new System.Drawing.Size(588, 23);
            this.Textbox_Client_Executable_Directory.TabIndex = 1;
            // 
            // Label_Client_Executable_Directory_Title
            // 
            this.Label_Client_Executable_Directory_Title.AutoSize = true;
            this.Label_Client_Executable_Directory_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Client_Executable_Directory_Title.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.Label_Client_Executable_Directory_Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Client_Executable_Directory_Title.Location = new System.Drawing.Point(44, 41);
            this.Label_Client_Executable_Directory_Title.Name = "Label_Client_Executable_Directory_Title";
            this.Label_Client_Executable_Directory_Title.Size = new System.Drawing.Size(260, 22);
            this.Label_Client_Executable_Directory_Title.TabIndex = 2;
            this.Label_Client_Executable_Directory_Title.Text = "Client jar/exe directory:";
            // 
            // Radio_Button_Dark_Theme
            // 
            this.Radio_Button_Dark_Theme.AutoSize = true;
            this.Radio_Button_Dark_Theme.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Dark_Theme.Checked = true;
            this.Radio_Button_Dark_Theme.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Dark_Theme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Dark_Theme.Location = new System.Drawing.Point(130, 105);
            this.Radio_Button_Dark_Theme.Name = "Radio_Button_Dark_Theme";
            this.Radio_Button_Dark_Theme.Size = new System.Drawing.Size(128, 26);
            this.Radio_Button_Dark_Theme.TabIndex = 3;
            this.Radio_Button_Dark_Theme.TabStop = true;
            this.Radio_Button_Dark_Theme.Text = "Dark Theme";
            this.Radio_Button_Dark_Theme.UseVisualStyleBackColor = false;
            // 
            // Radio_Button_Light_Theme
            // 
            this.Radio_Button_Light_Theme.AutoSize = true;
            this.Radio_Button_Light_Theme.BackColor = System.Drawing.Color.Transparent;
            this.Radio_Button_Light_Theme.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radio_Button_Light_Theme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Radio_Button_Light_Theme.Location = new System.Drawing.Point(293, 105);
            this.Radio_Button_Light_Theme.Name = "Radio_Button_Light_Theme";
            this.Radio_Button_Light_Theme.Size = new System.Drawing.Size(138, 26);
            this.Radio_Button_Light_Theme.TabIndex = 4;
            this.Radio_Button_Light_Theme.Text = "Light Theme";
            this.Radio_Button_Light_Theme.UseVisualStyleBackColor = false;
            // 
            // Label_Theme_Title
            // 
            this.Label_Theme_Title.AutoSize = true;
            this.Label_Theme_Title.BackColor = System.Drawing.Color.Transparent;
            this.Label_Theme_Title.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Theme_Title.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Label_Theme_Title.Location = new System.Drawing.Point(44, 107);
            this.Label_Theme_Title.Name = "Label_Theme_Title";
            this.Label_Theme_Title.Size = new System.Drawing.Size(70, 22);
            this.Label_Theme_Title.TabIndex = 5;
            this.Label_Theme_Title.Text = "Theme:";
            // 
            // Button_Set_Executable_Directory
            // 
            this.Button_Set_Executable_Directory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Set_Executable_Directory.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Set_Executable_Directory.Location = new System.Drawing.Point(901, 40);
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
            this.Label_Sec_Between_Client_Launches.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Sec_Between_Client_Launches.ForeColor = System.Drawing.Color.White;
            this.Label_Sec_Between_Client_Launches.Location = new System.Drawing.Point(44, 162);
            this.Label_Sec_Between_Client_Launches.Name = "Label_Sec_Between_Client_Launches";
            this.Label_Sec_Between_Client_Launches.Size = new System.Drawing.Size(290, 22);
            this.Label_Sec_Between_Client_Launches.TabIndex = 13;
            this.Label_Sec_Between_Client_Launches.Text = "Sec/between client launches:";
            // 
            // Number_Up_Down_Client_Launch_Seconds
            // 
            this.Number_Up_Down_Client_Launch_Seconds.BackColor = System.Drawing.Color.Black;
            this.Number_Up_Down_Client_Launch_Seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Number_Up_Down_Client_Launch_Seconds.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Number_Up_Down_Client_Launch_Seconds.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_Up_Down_Client_Launch_Seconds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Number_Up_Down_Client_Launch_Seconds.Location = new System.Drawing.Point(340, 158);
            this.Number_Up_Down_Client_Launch_Seconds.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Number_Up_Down_Client_Launch_Seconds.Name = "Number_Up_Down_Client_Launch_Seconds";
            this.Number_Up_Down_Client_Launch_Seconds.Size = new System.Drawing.Size(74, 32);
            this.Number_Up_Down_Client_Launch_Seconds.TabIndex = 12;
            this.Number_Up_Down_Client_Launch_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Number_Up_Down_Client_Launch_Seconds.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(987, 239);
            this.Controls.Add(this.Label_Sec_Between_Client_Launches);
            this.Controls.Add(this.Number_Up_Down_Client_Launch_Seconds);
            this.Controls.Add(this.Button_Set_Executable_Directory);
            this.Controls.Add(this.Label_Theme_Title);
            this.Controls.Add(this.Radio_Button_Light_Theme);
            this.Controls.Add(this.Radio_Button_Dark_Theme);
            this.Controls.Add(this.Label_Client_Executable_Directory_Title);
            this.Controls.Add(this.Textbox_Client_Executable_Directory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings_Form";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.Number_Up_Down_Client_Launch_Seconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Textbox_Client_Executable_Directory;
        private System.Windows.Forms.Label Label_Client_Executable_Directory_Title;
        private System.Windows.Forms.RadioButton Radio_Button_Dark_Theme;
        private System.Windows.Forms.RadioButton Radio_Button_Light_Theme;
        private System.Windows.Forms.Label Label_Theme_Title;
        private System.Windows.Forms.Button Button_Set_Executable_Directory;
        private System.Windows.Forms.Label Label_Sec_Between_Client_Launches;
        private System.Windows.Forms.NumericUpDown Number_Up_Down_Client_Launch_Seconds;
    }
}