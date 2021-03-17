namespace System_Manager
{
    partial class Manager
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
            System.Windows.Forms.Timer timer__Refresh;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel__TitleBar = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox__Icon = new System.Windows.Forms.PictureBox();
            this.button__Minimize = new System.Windows.Forms.Button();
            this.button__Maximize = new System.Windows.Forms.Button();
            this.button__Close = new System.Windows.Forms.Button();
            this.dataGridView__Manager = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Threads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer__Refresh = new System.Windows.Forms.Timer(this.components);
            this.panel__TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // timer__Refresh
            // 
            timer__Refresh.Enabled = true;
            timer__Refresh.Interval = 10;
            timer__Refresh.Tick += new System.EventHandler(this.timer__Refresh_Tick);
            // 
            // panel__TitleBar
            // 
            this.panel__TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel__TitleBar.Controls.Add(this.labelName);
            this.panel__TitleBar.Controls.Add(this.pictureBox__Icon);
            this.panel__TitleBar.Controls.Add(this.button__Minimize);
            this.panel__TitleBar.Controls.Add(this.button__Maximize);
            this.panel__TitleBar.Controls.Add(this.button__Close);
            this.panel__TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel__TitleBar.Location = new System.Drawing.Point(0, 0);
            this.panel__TitleBar.Name = "panel__TitleBar";
            this.panel__TitleBar.Size = new System.Drawing.Size(828, 40);
            this.panel__TitleBar.TabIndex = 1;
            this.panel__TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel__TitleBar_MouseDown);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(46, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(114, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "System Manager";
            // 
            // pictureBox__Icon
            // 
            this.pictureBox__Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox__Icon.InitialImage = null;
            this.pictureBox__Icon.Location = new System.Drawing.Point(0, 0);
            this.pictureBox__Icon.Name = "pictureBox__Icon";
            this.pictureBox__Icon.Size = new System.Drawing.Size(40, 40);
            this.pictureBox__Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox__Icon.TabIndex = 3;
            this.pictureBox__Icon.TabStop = false;
            // 
            // button__Minimize
            // 
            this.button__Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button__Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button__Minimize.FlatAppearance.BorderSize = 0;
            this.button__Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__Minimize.Location = new System.Drawing.Point(648, 4);
            this.button__Minimize.Name = "button__Minimize";
            this.button__Minimize.Size = new System.Drawing.Size(60, 30);
            this.button__Minimize.TabIndex = 2;
            this.button__Minimize.UseVisualStyleBackColor = true;
            this.button__Minimize.Click += new System.EventHandler(this.button__Minimize_Click);
            // 
            // button__Maximize
            // 
            this.button__Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button__Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button__Maximize.FlatAppearance.BorderSize = 0;
            this.button__Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__Maximize.Location = new System.Drawing.Point(708, 4);
            this.button__Maximize.Name = "button__Maximize";
            this.button__Maximize.Size = new System.Drawing.Size(60, 30);
            this.button__Maximize.TabIndex = 1;
            this.button__Maximize.UseVisualStyleBackColor = true;
            this.button__Maximize.Click += new System.EventHandler(this.button__Maximize_Click);
            // 
            // button__Close
            // 
            this.button__Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button__Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button__Close.FlatAppearance.BorderSize = 0;
            this.button__Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button__Close.Location = new System.Drawing.Point(768, 4);
            this.button__Close.Name = "button__Close";
            this.button__Close.Size = new System.Drawing.Size(60, 30);
            this.button__Close.TabIndex = 0;
            this.button__Close.UseVisualStyleBackColor = true;
            this.button__Close.Click += new System.EventHandler(this.button__Close_Click);
            // 
            // dataGridView__Manager
            // 
            this.dataGridView__Manager.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dataGridView__Manager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView__Manager.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView__Manager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView__Manager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView__Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView__Manager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Name,
            this.Id,
            this.User,
            this.Memory,
            this.Priority,
            this.Threads});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView__Manager.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView__Manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView__Manager.EnableHeadersVisualStyles = false;
            this.dataGridView__Manager.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dataGridView__Manager.Location = new System.Drawing.Point(0, 40);
            this.dataGridView__Manager.Name = "dataGridView__Manager";
            this.dataGridView__Manager.ReadOnly = true;
            this.dataGridView__Manager.RowHeadersVisible = false;
            this.dataGridView__Manager.RowHeadersWidth = 35;
            this.dataGridView__Manager.RowTemplate.Height = 24;
            this.dataGridView__Manager.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView__Manager.Size = new System.Drawing.Size(828, 458);
            this.dataGridView__Manager.TabIndex = 3;
            this.dataGridView__Manager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView__Manager_CellClick);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Memory
            // 
            this.Memory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Memory.HeaderText = "Memory";
            this.Memory.MinimumWidth = 6;
            this.Memory.Name = "Memory";
            this.Memory.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // Threads
            // 
            this.Threads.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Threads.HeaderText = "Threads";
            this.Threads.MinimumWidth = 6;
            this.Threads.Name = "Threads";
            this.Threads.ReadOnly = true;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 498);
            this.Controls.Add(this.dataGridView__Manager);
            this.Controls.Add(this.panel__TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(828, 498);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Manager_Load);
            this.panel__TitleBar.ResumeLayout(false);
            this.panel__TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__Manager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel__TitleBar;
        private System.Windows.Forms.Button button__Minimize;
        private System.Windows.Forms.Button button__Maximize;
        private System.Windows.Forms.Button button__Close;
        private System.Windows.Forms.PictureBox pictureBox__Icon;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView dataGridView__Manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Threads;
    }
}

