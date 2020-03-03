using System.IO;
namespace fileWatcherApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.eventGrid = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.watchBTN = new System.Windows.Forms.Button();
            this.label_path = new System.Windows.Forms.Label();
            this.dirPath = new System.Windows.Forms.TextBox();
            this.stop = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // eventGrid
            // 
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.changeType,
            this.path});
            this.eventGrid.Location = new System.Drawing.Point(12, 64);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.RowTemplate.Height = 23;
            this.eventGrid.Size = new System.Drawing.Size(554, 267);
            this.eventGrid.TabIndex = 0;
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.Name = "time";
            // 
            // changeType
            // 
            this.changeType.HeaderText = "type";
            this.changeType.Name = "changeType";
            // 
            // path
            // 
            this.path.HeaderText = "path";
            this.path.Name = "path";
            this.path.Width = 310;
            // 
            // watchBTN
            // 
            this.watchBTN.Location = new System.Drawing.Point(407, 27);
            this.watchBTN.Name = "watchBTN";
            this.watchBTN.Size = new System.Drawing.Size(86, 23);
            this.watchBTN.TabIndex = 1;
            this.watchBTN.Text = "监控";
            this.watchBTN.UseVisualStyleBackColor = true;
            this.watchBTN.Click += new System.EventHandler(this.watchBTN_Click);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Location = new System.Drawing.Point(13, 37);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(29, 12);
            this.label_path.TabIndex = 2;
            this.label_path.Text = "路径";
            // 
            // dirPath
            // 
            this.dirPath.Location = new System.Drawing.Point(60, 29);
            this.dirPath.Name = "dirPath";
            this.dirPath.Size = new System.Drawing.Size(341, 21);
            this.dirPath.TabIndex = 3;
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(499, 27);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 4;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(12, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 5;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 351);
            this.Controls.Add(this.save);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.dirPath);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.watchBTN);
            this.Controls.Add(this.eventGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView eventGrid;
        private System.Windows.Forms.Button watchBTN;
        private System.Windows.Forms.Label label_path;
        private System.Windows.Forms.TextBox dirPath;

        FileSystemWatcher watcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button save;
    }
}

