using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Devious_Bulk_Launcher
{
    public partial class Settings_Form : Form
    {
        //Declare variable
        private int Button_Launch_Client_In_Minimal_Mode_Click_Counter = 0;

        public Settings_Form()
        {           
            InitializeComponent();

            //Set launch window position
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(0, 0);

            //Set events
            Button_Set_Executable_Directory.Click += Button_Set_Executable_Directory_Click;
            Radio_Button_Dark_Theme.Click += Radio_Button_Dark_Theme_Click;
            Radio_Button_Light_Theme.Click += Radio_Button_Light_Theme_Click;
            Radio_Button_Launch_Client_In_Debug_Mode_Enabled.Click += Radio_Button_Launch_Client_In_Debug_Mode_Enabled_Click;
            Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Click += Radio_Button_Launch_Client_In_Debug_Mode_Disabled_Click;
            Radio_Button_Hide_Console_Window_When_Launching_Enabled.Click += Radio_Button_Hide_Console_Window_When_Launching_Enabled_Click;
            Radio_Button_Hide_Console_Window_When_Launching_Disabled.Click += Radio_Button_Hide_Console_Window_When_Launching_Disabled_Click;
            Button_Launch_Client_In_Minimal_Mode.Click += Button_Hidden_Click;
            Button_Launch_Client_In_Minimal_Mode.FlatAppearance.MouseOverBackColor = Button_Launch_Client_In_Minimal_Mode.BackColor;
            Button_Launch_Client_In_Minimal_Mode.BackColorChanged += (s, e) => { Button_Launch_Client_In_Minimal_Mode.FlatAppearance.MouseOverBackColor = Button_Launch_Client_In_Minimal_Mode.BackColor; };
            Button_Launch_Client_In_Minimal_Mode.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Number_Up_Down_Client_Launch_Seconds.ValueChanged += Number_Up_Down_Client_Launch_Seconds_ValueChanged;

            //Set client executable directory textbox
            Textbox_Client_Executable_Directory.Text = Form1.Client_Executable_Directory;
            Textbox_Client_Executable_Directory.SelectionStart = 0;
            Textbox_Client_Executable_Directory.SelectionLength = 0;
            Textbox_Client_Executable_Directory.ScrollToCaret();

            //Set theme radio button
            if (Form1.Theme == "Dark")
            {Radio_Button_Dark_Theme.Checked = true;}
            else if (Form1.Theme == "Light")
            {Radio_Button_Light_Theme.Checked = true;}

            //Set Launch Client in Debug Mode radio button
            if (Form1.Launch_Client_In_Debug_Mode == true)
            {Radio_Button_Launch_Client_In_Debug_Mode_Enabled.Checked = true;}
            else if (Form1.Launch_Client_In_Debug_Mode == false)
            {Radio_Button_Launch_Client_In_Debug_Mode_Disabled.Checked = true;}

            //Set Hide Console Window When Launching radio button
            if (Form1.Hide_Console_Window_When_Launching == true)
            {Radio_Button_Hide_Console_Window_When_Launching_Enabled.Checked = true;}
            else if (Form1.Hide_Console_Window_When_Launching == false)
            {Radio_Button_Hide_Console_Window_When_Launching_Disabled.Checked = true;}

            //Set sec between client launches input
            Number_Up_Down_Client_Launch_Seconds.Value = Convert.ToInt32(Form1.Client_Launch_Seconds);

            //Refresh UI
            this.Refresh();
        }

        private void Form_Closing(object sender, FormClosingEventArgs Form_Closing_Event_Args)
        {
            //Save settings
            Form1.Save_Settings();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            try
            {
                if (Form1.Theme == "Dark")
                {
                    base.OnPaintBackground(e);

                    LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.DarkRed, Color.DarkBlue, 90F);

                    e.Graphics.FillRectangle(brush, this.ClientRectangle);

                    Label_Client_Executable_Directory_Title.ForeColor = Color.WhiteSmoke;
                    Label_Theme_Title.ForeColor = Color.WhiteSmoke;
                    Radio_Button_Dark_Theme.ForeColor = Color.WhiteSmoke;
                    Radio_Button_Light_Theme.ForeColor = Color.WhiteSmoke;
                    Label_Sec_Between_Client_Launches.ForeColor = Color.WhiteSmoke;
                    Number_Up_Down_Client_Launch_Seconds.BackColor = Color.Black;
                    Number_Up_Down_Client_Launch_Seconds.ForeColor = Color.WhiteSmoke;
                    Label_Launch_Client_In_Debug_Mode.ForeColor = Color.WhiteSmoke;
                    Label_Hide_Console_Window_When_Launching.ForeColor = Color.WhiteSmoke;
                    Radio_Button_Launch_Client_In_Debug_Mode_Disabled.ForeColor = Color.WhiteSmoke;
                    Radio_Button_Launch_Client_In_Debug_Mode_Enabled.ForeColor = Color.WhiteSmoke;
                    Radio_Button_Hide_Console_Window_When_Launching_Disabled.ForeColor = Color.WhiteSmoke;
                    Radio_Button_Hide_Console_Window_When_Launching_Enabled.ForeColor = Color.WhiteSmoke;
                }
                else if (Form1.Theme == "Light")
                {
                    base.OnPaintBackground(e);

                    LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.LightSkyBlue, 90F);

                    e.Graphics.FillRectangle(brush, this.ClientRectangle);

                    Label_Client_Executable_Directory_Title.ForeColor = Color.Black;
                    Label_Theme_Title.ForeColor = Color.Black;
                    Radio_Button_Dark_Theme.ForeColor = Color.Black;
                    Radio_Button_Light_Theme.ForeColor= Color.Black;
                    Label_Sec_Between_Client_Launches.ForeColor = Color.Black;
                    Number_Up_Down_Client_Launch_Seconds.BackColor = Color.WhiteSmoke;
                    Number_Up_Down_Client_Launch_Seconds.ForeColor = Color.Black;
                    Label_Launch_Client_In_Debug_Mode.ForeColor = Color.Black;
                    Label_Hide_Console_Window_When_Launching.ForeColor = Color.Black;
                    Radio_Button_Launch_Client_In_Debug_Mode_Disabled.ForeColor = Color.Black;
                    Radio_Button_Launch_Client_In_Debug_Mode_Enabled.ForeColor = Color.Black;
                    Radio_Button_Hide_Console_Window_When_Launching_Disabled.ForeColor = Color.Black;
                    Radio_Button_Hide_Console_Window_When_Launching_Enabled.ForeColor = Color.Black;
                }
            }
            catch (Exception Exception){}
        }

        private void Radio_Button_Dark_Theme_Click(object sender, EventArgs e)
        {
            Form1.Theme = "Dark";
            Form1.Refresh_UI = true;
            this.Refresh();            
        }

        private void Radio_Button_Light_Theme_Click(object sender, EventArgs e)
        {
            Form1.Theme = "Light";
            Form1.Refresh_UI = true;
            this.Refresh();
        }

        public void Radio_Button_Launch_Client_In_Debug_Mode_Disabled_Click(object sender, EventArgs e)
        {
            Form1.Launch_Client_In_Debug_Mode = false;
        }

        public void Radio_Button_Launch_Client_In_Debug_Mode_Enabled_Click(object sender, EventArgs e)
        {
            Form1.Launch_Client_In_Debug_Mode = true;
        }

        public void Radio_Button_Hide_Console_Window_When_Launching_Enabled_Click(object sender, EventArgs e)
        {
            Form1.Hide_Console_Window_When_Launching = true;
        }

        public void Radio_Button_Hide_Console_Window_When_Launching_Disabled_Click(object sender, EventArgs e)
        {
            Form1.Hide_Console_Window_When_Launching = false;
        }

        private void Number_Up_Down_Client_Launch_Seconds_ValueChanged(object sender, EventArgs e)
        {
            Form1.Client_Launch_Seconds = Number_Up_Down_Client_Launch_Seconds.Value.ToString();
        }

        private void Button_Set_Executable_Directory_Click(object sender, EventArgs e)
        {
            //Declare variables
            OpenFileDialog Open_File_Dialog;
            DialogResult Dialog_Result;

            //Set initial values
            Open_File_Dialog = new OpenFileDialog();
            Open_File_Dialog.Filter = "Executable|*.jar;*.exe";
            
            //Get user input
            Dialog_Result = Open_File_Dialog.ShowDialog();

            //Handle directory
            if (Dialog_Result == DialogResult.OK)
            {
                //Return if file does not exist
                if (System.IO.File.Exists(Open_File_Dialog.FileName) == false)
                {MessageBox.Show("File does not exist!");return;}

                //Apply directory to textbox
                Textbox_Client_Executable_Directory.Text = Open_File_Dialog.FileName.Trim();

                //Set client executable directory
                Form1.Client_Executable_Directory = Open_File_Dialog.FileName.Trim();

                //Scroll to beginning of path
                Textbox_Client_Executable_Directory.SelectionStart = 0;
                Textbox_Client_Executable_Directory.SelectionLength = 0;
                Textbox_Client_Executable_Directory.ScrollToCaret();
            }

        }

        private void Button_Hidden_Click(object sender, EventArgs e)
        {
            //Increment counter
            Button_Launch_Client_In_Minimal_Mode_Click_Counter++;

            //Enable/Disable Minimal mode on the 5th click
            if (Button_Launch_Client_In_Minimal_Mode_Click_Counter >= 5)
            {
                //Reset
                Button_Launch_Client_In_Minimal_Mode_Click_Counter = 0;

                //Enable/Disable Launch Client In Minimal Mode
                if (Form1.Launch_Client_In_Minimal_Mode == true)
                {
                    //Disable
                    Form1.Launch_Client_In_Minimal_Mode = false;
                    
                    //Notify user
                    MessageBox.Show("Launch Client In Minimal Mode Disabled");
                }
                else if (Form1.Launch_Client_In_Minimal_Mode == false)
                {
                    //Enable
                    Form1.Launch_Client_In_Minimal_Mode = true;

                    //Notify user
                    MessageBox.Show("Launch Client In Minimal Mode Enabled");
                }
                
            }
        }

    }

}
