namespace cs_srt
{
    partial class FormSrt
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
            this.label_srt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_srt
            // 
            this.label_srt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_srt.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_srt.ForeColor = System.Drawing.Color.White;
            this.label_srt.Location = new System.Drawing.Point(0, 0);
            this.label_srt.Name = "label_srt";
            this.label_srt.Size = new System.Drawing.Size(740, 69);
            this.label_srt.TabIndex = 0;
            this.label_srt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_srt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_srt_MouseDown);
            this.label_srt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label_srt_MouseMove);
            // 
            // FormSrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(740, 69);
            this.ControlBox = false;
            this.Controls.Add(this.label_srt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSrt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.SizeChanged += new System.EventHandler(this.FormSrt_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_srt;
    }
}