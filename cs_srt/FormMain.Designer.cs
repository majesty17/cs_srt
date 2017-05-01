namespace cs_srt
{
    partial class FormMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_front = new System.Windows.Forms.CheckBox();
            this.checkBox_srt = new System.Windows.Forms.CheckBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_cap = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_cap);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.checkBox_srt);
            this.groupBox1.Controls.Add(this.checkBox_front);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本配置";
            // 
            // checkBox_front
            // 
            this.checkBox_front.AutoSize = true;
            this.checkBox_front.Checked = true;
            this.checkBox_front.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_front.Location = new System.Drawing.Point(6, 20);
            this.checkBox_front.Name = "checkBox_front";
            this.checkBox_front.Size = new System.Drawing.Size(72, 16);
            this.checkBox_front.TabIndex = 0;
            this.checkBox_front.Text = "窗口最前";
            this.checkBox_front.UseVisualStyleBackColor = true;
            this.checkBox_front.CheckedChanged += new System.EventHandler(this.checkBox_front_CheckedChanged);
            // 
            // checkBox_srt
            // 
            this.checkBox_srt.AutoSize = true;
            this.checkBox_srt.Location = new System.Drawing.Point(6, 42);
            this.checkBox_srt.Name = "checkBox_srt";
            this.checkBox_srt.Size = new System.Drawing.Size(72, 16);
            this.checkBox_srt.TabIndex = 1;
            this.checkBox_srt.Text = "开启字幕";
            this.checkBox_srt.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(13, 273);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "显示";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(94, 273);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 2;
            this.button_stop.Text = "关闭";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_search);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(164, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 236);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "字幕设置";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 21);
            this.textBox1.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(251, 19);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "搜索";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(6, 85);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(134, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_cap
            // 
            this.label_cap.AutoSize = true;
            this.label_cap.Location = new System.Drawing.Point(6, 70);
            this.label_cap.Name = "label_cap";
            this.label_cap.Size = new System.Drawing.Size(71, 12);
            this.label_cap.TabIndex = 3;
            this.label_cap.Text = "透明度:100%";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 308);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_front;
        private System.Windows.Forms.CheckBox checkBox_srt;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_cap;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

