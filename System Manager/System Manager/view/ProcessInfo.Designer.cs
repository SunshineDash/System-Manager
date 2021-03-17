namespace System_Manager
{
    partial class Process_Info
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Timer timer__Refresh;
            this.panel__TitleBar = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox__Icon = new System.Windows.Forms.PictureBox();
            this.button__Minimize = new System.Windows.Forms.Button();
            this.button__Maximize = new System.Windows.Forms.Button();
            this.button__Close = new System.Windows.Forms.Button();
            this.dataGridView__Process = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreadPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timer__Refresh = new System.Windows.Forms.Timer(this.components);
            this.panel__TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__Process)).BeginInit();
            this.SuspendLayout();
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
            this.panel__TitleBar.Size = new System.Drawing.Size(487, 40);
            this.panel__TitleBar.TabIndex = 2;
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
            this.labelName.Size = new System.Drawing.Size(59, 17);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Process";
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
            this.button__Minimize.Location = new System.Drawing.Point(307, 4);
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
            this.button__Maximize.Location = new System.Drawing.Point(367, 4);
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
            this.button__Close.Location = new System.Drawing.Point(427, 4);
            this.button__Close.Name = "button__Close";
            this.button__Close.Size = new System.Drawing.Size(60, 30);
            this.button__Close.TabIndex = 0;
            this.button__Close.UseVisualStyleBackColor = true;
            this.button__Close.Click += new System.EventHandler(this.button__Close_Click);
            // 
            // dataGridView__Process
            // 
            this.dataGridView__Process.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.dataGridView__Process.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView__Process.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView__Process.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView__Process.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView__Process.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView__Process.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ThreadId,
            this.ThreadPriority});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView__Process.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView__Process.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView__Process.EnableHeadersVisualStyles = false;
            this.dataGridView__Process.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dataGridView__Process.Location = new System.Drawing.Point(0, 40);
            this.dataGridView__Process.Name = "dataGridView__Process";
            this.dataGridView__Process.ReadOnly = true;
            this.dataGridView__Process.RowHeadersVisible = false;
            this.dataGridView__Process.RowHeadersWidth = 30;
            this.dataGridView__Process.RowTemplate.Height = 24;
            this.dataGridView__Process.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView__Process.Size = new System.Drawing.Size(487, 290);
            this.dataGridView__Process.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // ThreadId
            // 
            this.ThreadId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThreadId.HeaderText = "ID";
            this.ThreadId.MinimumWidth = 6;
            this.ThreadId.Name = "ThreadId";
            this.ThreadId.ReadOnly = true;
            // 
            // ThreadPriority
            // 
            this.ThreadPriority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThreadPriority.HeaderText = "Priority";
            this.ThreadPriority.MinimumWidth = 6;
            this.ThreadPriority.Name = "ThreadPriority";
            this.ThreadPriority.ReadOnly = true;
            // 
            // timer__Refresh
            // 
            timer__Refresh.Enabled = true;
            timer__Refresh.Interval = 10;
            timer__Refresh.Tick += new System.EventHandler(this.timer__Refresh_Tick);
            // 
            // Process_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 330);
            this.Controls.Add(this.dataGridView__Process);
            this.Controls.Add(this.panel__TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(487, 330);
            this.MinimumSize = new System.Drawing.Size(487, 330);
            this.Name = "Process_Info";
            this.Text = "Process Info";
            this.Load += new System.EventHandler(this.Process_Info_Load);
            this.panel__TitleBar.ResumeLayout(false);
            this.panel__TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox__Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView__Process)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel__TitleBar;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox__Icon;
        private System.Windows.Forms.Button button__Minimize;
        private System.Windows.Forms.Button button__Maximize;
        private System.Windows.Forms.Button button__Close;
        private System.Windows.Forms.DataGridView dataGridView__Process;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThreadPriority;
    }
}