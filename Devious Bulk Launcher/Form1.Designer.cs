
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
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Account_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proxy_Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.World_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Launch = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Save_Config = new System.Windows.Forms.Button();
            this.Button_Uncheck_All = new System.Windows.Forms.Button();
            this.Label_Rows_Checked = new System.Windows.Forms.Label();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.Bottom_Group_Panel = new System.Windows.Forms.Panel();
            this.Bottom_Right_Panel = new System.Windows.Forms.Panel();
            this.Bottom_Left_Panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_View)).BeginInit();
            this.Bottom_Group_Panel.SuspendLayout();
            this.Bottom_Right_Panel.SuspendLayout();
            this.Bottom_Left_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_View
            // 
            this.Grid_View.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Grid_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_View.BackgroundColor = System.Drawing.Color.White;
            this.Grid_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Grid_View.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_View.DefaultCellStyle = dataGridViewCellStyle4;
            this.Grid_View.EnableHeadersVisualStyles = false;
            this.Grid_View.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Grid_View.Location = new System.Drawing.Point(0, 0);
            this.Grid_View.Name = "Grid_View";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_View.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Grid_View.RowHeadersVisible = false;
            this.Grid_View.RowHeadersWidth = 10;
            this.Grid_View.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Grid_View.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Grid_View.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_View.ShowCellToolTips = false;
            this.Grid_View.Size = new System.Drawing.Size(884, 361);
            this.Grid_View.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = false;
            this.Select.DefaultCellStyle = dataGridViewCellStyle3;
            this.Select.FillWeight = 253.8071F;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Width = 49;
            // 
            // Account_Username
            // 
            this.Account_Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Account_Username.FillWeight = 93.27411F;
            this.Account_Username.HeaderText = "Account Username";
            this.Account_Username.Name = "Account_Username";
            this.Account_Username.Width = 139;
            // 
            // Account_Password
            // 
            this.Account_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Account_Password.FillWeight = 93.27411F;
            this.Account_Password.HeaderText = "Account Password";
            this.Account_Password.Name = "Account_Password";
            this.Account_Password.Width = 137;
            // 
            // Proxy_IP
            // 
            this.Proxy_IP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Proxy_IP.FillWeight = 93.27411F;
            this.Proxy_IP.HeaderText = "Proxy IP";
            this.Proxy_IP.Name = "Proxy_IP";
            this.Proxy_IP.Width = 79;
            // 
            // Proxy_Port
            // 
            this.Proxy_Port.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Proxy_Port.FillWeight = 93.27411F;
            this.Proxy_Port.HeaderText = "Proxy Port";
            this.Proxy_Port.Name = "Proxy_Port";
            this.Proxy_Port.Width = 90;
            // 
            // Proxy_Username
            // 
            this.Proxy_Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Proxy_Username.FillWeight = 93.27411F;
            this.Proxy_Username.HeaderText = "Proxy Username";
            this.Proxy_Username.Name = "Proxy_Username";
            this.Proxy_Username.Width = 123;
            // 
            // Proxy_Password
            // 
            this.Proxy_Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Proxy_Password.FillWeight = 93.27411F;
            this.Proxy_Password.HeaderText = "Proxy Password";
            this.Proxy_Password.Name = "Proxy_Password";
            this.Proxy_Password.Width = 121;
            // 
            // World_No
            // 
            this.World_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.World_No.FillWeight = 93.27411F;
            this.World_No.HeaderText = "World #";
            this.World_No.Name = "World_No";
            this.World_No.Width = 77;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notes.FillWeight = 93.27411F;
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // Button_Add
            // 
            this.Button_Add.AutoSize = true;
            this.Button_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Add.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(80, 76);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(102, 42);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = false;
            // 
            // Button_Launch
            // 
            this.Button_Launch.AutoSize = true;
            this.Button_Launch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Launch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Launch.Location = new System.Drawing.Point(201, 76);
            this.Button_Launch.Name = "Button_Launch";
            this.Button_Launch.Size = new System.Drawing.Size(101, 42);
            this.Button_Launch.TabIndex = 3;
            this.Button_Launch.Text = "Launch";
            this.Button_Launch.UseVisualStyleBackColor = false;
            // 
            // Button_Remove
            // 
            this.Button_Remove.AutoSize = true;
            this.Button_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Button_Remove.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.Location = new System.Drawing.Point(319, 76);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(101, 42);
            this.Button_Remove.TabIndex = 4;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = false;
            // 
            // Button_Save_Config
            // 
            this.Button_Save_Config.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Save_Config.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Save_Config.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Save_Config.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Button_Save_Config.Location = new System.Drawing.Point(12, 76);
            this.Button_Save_Config.MaximumSize = new System.Drawing.Size(120, 42);
            this.Button_Save_Config.MinimumSize = new System.Drawing.Size(120, 42);
            this.Button_Save_Config.Name = "Button_Save_Config";
            this.Button_Save_Config.Size = new System.Drawing.Size(120, 42);
            this.Button_Save_Config.TabIndex = 5;
            this.Button_Save_Config.Text = "Save config";
            this.Button_Save_Config.UseVisualStyleBackColor = false;
            // 
            // Button_Uncheck_All
            // 
            this.Button_Uncheck_All.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Button_Uncheck_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Button_Uncheck_All.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Uncheck_All.Location = new System.Drawing.Point(147, 76);
            this.Button_Uncheck_All.MaximumSize = new System.Drawing.Size(133, 42);
            this.Button_Uncheck_All.MinimumSize = new System.Drawing.Size(133, 42);
            this.Button_Uncheck_All.Name = "Button_Uncheck_All";
            this.Button_Uncheck_All.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Uncheck_All.Size = new System.Drawing.Size(133, 42);
            this.Button_Uncheck_All.TabIndex = 6;
            this.Button_Uncheck_All.Text = "Uncheck All";
            this.Button_Uncheck_All.UseVisualStyleBackColor = false;
            // 
            // Label_Rows_Checked
            // 
            this.Label_Rows_Checked.BackColor = System.Drawing.Color.Transparent;
            this.Label_Rows_Checked.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rows_Checked.ForeColor = System.Drawing.Color.White;
            this.Label_Rows_Checked.Location = new System.Drawing.Point(9, 12);
            this.Label_Rows_Checked.Name = "Label_Rows_Checked";
            this.Label_Rows_Checked.Size = new System.Drawing.Size(195, 32);
            this.Label_Rows_Checked.TabIndex = 7;
            this.Label_Rows_Checked.Text = "Rows selected: 0";
            // 
            // Button_Settings
            // 
            this.Button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button_Settings.BackgroundImage = global::Devious_Bulk_Launcher.Properties.Resources.My_project;
            this.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Settings.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Settings.Location = new System.Drawing.Point(290, 76);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Button_Settings.Size = new System.Drawing.Size(44, 42);
            this.Button_Settings.TabIndex = 12;
            this.Button_Settings.UseVisualStyleBackColor = false;
            // 
            // Bottom_Group_Panel
            // 
            this.Bottom_Group_Panel.AutoSize = true;
            this.Bottom_Group_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bottom_Group_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Bottom_Group_Panel.Controls.Add(this.Bottom_Right_Panel);
            this.Bottom_Group_Panel.Controls.Add(this.Bottom_Left_Panel);
            this.Bottom_Group_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Group_Panel.Location = new System.Drawing.Point(0, 362);
            this.Bottom_Group_Panel.Name = "Bottom_Group_Panel";
            this.Bottom_Group_Panel.Size = new System.Drawing.Size(884, 142);
            this.Bottom_Group_Panel.TabIndex = 13;
            // 
            // Bottom_Right_Panel
            // 
            this.Bottom_Right_Panel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bottom_Right_Panel.Controls.Add(this.Button_Remove);
            this.Bottom_Right_Panel.Controls.Add(this.Button_Launch);
            this.Bottom_Right_Panel.Controls.Add(this.Button_Add);
            this.Bottom_Right_Panel.Location = new System.Drawing.Point(449, 0);
            this.Bottom_Right_Panel.Name = "Bottom_Right_Panel";
            this.Bottom_Right_Panel.Size = new System.Drawing.Size(432, 139);
            this.Bottom_Right_Panel.TabIndex = 14;
            // 
            // Bottom_Left_Panel
            // 
            this.Bottom_Left_Panel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Bottom_Left_Panel.Controls.Add(this.Button_Uncheck_All);
            this.Bottom_Left_Panel.Controls.Add(this.Button_Save_Config);
            this.Bottom_Left_Panel.Controls.Add(this.Label_Rows_Checked);
            this.Bottom_Left_Panel.Controls.Add(this.Button_Settings);
            this.Bottom_Left_Panel.Location = new System.Drawing.Point(0, 0);
            this.Bottom_Left_Panel.Name = "Bottom_Left_Panel";
            this.Bottom_Left_Panel.Size = new System.Drawing.Size(419, 139);
            this.Bottom_Left_Panel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(884, 504);
            this.Controls.Add(this.Bottom_Group_Panel);
            this.Controls.Add(this.Grid_View);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 522);
            this.Name = "Form1";
            this.Text = "Devious Bulk Launcher - ICSN";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_View)).EndInit();
            this.Bottom_Group_Panel.ResumeLayout(false);
            this.Bottom_Right_Panel.ResumeLayout(false);
            this.Bottom_Right_Panel.PerformLayout();
            this.Bottom_Left_Panel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel Bottom_Group_Panel;
        private System.Windows.Forms.Panel Bottom_Right_Panel;
        private System.Windows.Forms.Panel Bottom_Left_Panel;
    }
}

