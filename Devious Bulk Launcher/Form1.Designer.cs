
namespace Devious_Bulk_Launcher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Grid_View = new System.Windows.Forms.DataGridView();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Launch = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Save_Config = new System.Windows.Forms.Button();
            this.Button_Uncheck_All = new System.Windows.Forms.Button();
            this.Label_Rows_Checked = new System.Windows.Forms.Label();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Account_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.World_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_View
            // 
            this.Grid_View.AllowUserToResizeColumns = false;
            this.Grid_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Grid_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_View.BackgroundColor = System.Drawing.Color.Black;
            this.Grid_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.Account_Username,
            this.Account_Password,
            this.Proxy_IP,
            this.Proxy_Port,
            this.Proxy_Username,
            this.Proxy_Password,
            this.World_No,
            this.Notes});
            this.Grid_View.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_View.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_View.EnableHeadersVisualStyles = false;
            this.Grid_View.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grid_View.Location = new System.Drawing.Point(21, 14);
            this.Grid_View.Name = "Grid_View";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Grid_View.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_View.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.Grid_View.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_View.ShowCellToolTips = false;
            this.Grid_View.Size = new System.Drawing.Size(1415, 464);
            this.Grid_View.TabIndex = 0;
            // 
            // Button_Add
            // 
            this.Button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Add.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(958, 567);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(140, 47);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            // 
            // Button_Launch
            // 
            this.Button_Launch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Launch.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Launch.Location = new System.Drawing.Point(1137, 567);
            this.Button_Launch.Name = "Button_Launch";
            this.Button_Launch.Size = new System.Drawing.Size(130, 47);
            this.Button_Launch.TabIndex = 3;
            this.Button_Launch.Text = "Launch";
            this.Button_Launch.UseVisualStyleBackColor = false;
            // 
            // Button_Remove
            // 
            this.Button_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Remove.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.Location = new System.Drawing.Point(1307, 568);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(128, 46);
            this.Button_Remove.TabIndex = 4;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = false;
            // 
            // Button_Save_Config
            // 
            this.Button_Save_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Save_Config.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save_Config.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Save_Config.Location = new System.Drawing.Point(21, 568);
            this.Button_Save_Config.Name = "Button_Save_Config";
            this.Button_Save_Config.Size = new System.Drawing.Size(148, 47);
            this.Button_Save_Config.TabIndex = 5;
            this.Button_Save_Config.Text = "Save config";
            this.Button_Save_Config.UseVisualStyleBackColor = false;
            // 
            // Button_Uncheck_All
            // 
            this.Button_Uncheck_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Uncheck_All.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Uncheck_All.Location = new System.Drawing.Point(203, 568);
            this.Button_Uncheck_All.Name = "Button_Uncheck_All";
            this.Button_Uncheck_All.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Uncheck_All.Size = new System.Drawing.Size(148, 47);
            this.Button_Uncheck_All.TabIndex = 6;
            this.Button_Uncheck_All.Text = "Uncheck All";
            this.Button_Uncheck_All.UseVisualStyleBackColor = false;
            // 
            // Label_Rows_Checked
            // 
            this.Label_Rows_Checked.AutoSize = true;
            this.Label_Rows_Checked.BackColor = System.Drawing.Color.Transparent;
            this.Label_Rows_Checked.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rows_Checked.ForeColor = System.Drawing.Color.White;
            this.Label_Rows_Checked.Location = new System.Drawing.Point(17, 493);
            this.Label_Rows_Checked.Name = "Label_Rows_Checked";
            this.Label_Rows_Checked.Size = new System.Drawing.Size(202, 24);
            this.Label_Rows_Checked.TabIndex = 7;
            this.Label_Rows_Checked.Text = "Rows selected: 0";
            // 
            // Button_Settings
            // 
            this.Button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Settings.BackgroundImage = global::Devious_Bulk_Launcher.Properties.Resources.My_project;
            this.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Settings.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Settings.Location = new System.Drawing.Point(382, 568);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Settings.Size = new System.Drawing.Size(55, 47);
            this.Button_Settings.TabIndex = 12;
            this.Button_Settings.UseVisualStyleBackColor = false;
            // 
            // Select
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.Select.DefaultCellStyle = dataGridViewCellStyle3;
            this.Select.FillWeight = 200F;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 75;
            // 
            // Account_Username
            // 
            this.Account_Username.HeaderText = "Account Username";
            this.Account_Username.Name = "Account_Username";
            this.Account_Username.Width = 175;
            // 
            // Account_Password
            // 
            this.Account_Password.HeaderText = "Account Password";
            this.Account_Password.Name = "Account_Password";
            this.Account_Password.Width = 170;
            // 
            // Proxy_IP
            // 
            this.Proxy_IP.HeaderText = "Proxy IP";
            this.Proxy_IP.Name = "Proxy_IP";
            this.Proxy_IP.Width = 125;
            // 
            // Proxy_Port
            // 
            this.Proxy_Port.HeaderText = "Proxy Port";
            this.Proxy_Port.Name = "Proxy_Port";
            // 
            // Proxy_Username
            // 
            this.Proxy_Username.HeaderText = "Proxy Username";
            this.Proxy_Username.Name = "Proxy_Username";
            this.Proxy_Username.Width = 150;
            // 
            // Proxy_Password
            // 
            this.Proxy_Password.HeaderText = "Proxy Password";
            this.Proxy_Password.Name = "Proxy_Password";
            this.Proxy_Password.Width = 150;
            // 
            // World_No
            // 
            this.World_No.HeaderText = "World #";
            this.World_No.Name = "World_No";
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Width = 330;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1448, 645);
            this.Controls.Add(this.Button_Settings);
            this.Controls.Add(this.Label_Rows_Checked);
            this.Controls.Add(this.Button_Uncheck_All);
            this.Controls.Add(this.Button_Save_Config);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.Button_Launch);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Grid_View);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Devious Bulk Launcher - ICSN";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_View;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Launch;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_Save_Config;
        private System.Windows.Forms.Button Button_Uncheck_All;
        private System.Windows.Forms.Label Label_Rows_Checked;
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy_IP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy_Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proxy_Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn World_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}

