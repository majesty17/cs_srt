using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs_srt
{
    public partial class FormMain : Form
    {

        private FormSrt formSrt = null;
        private SrtTools srtTools = null;


        public FormMain()
        {
            InitializeComponent();

            formSrt = new FormSrt();
            if (checkBox_front.Checked == true) {
                formSrt.TopMost = true;
            }
            formSrt.Visible = false;

            srtTools = new SrtTools("");
        }










        //start
        private void button_start_Click(object sender, EventArgs e){

            //显示窗口
            formSrt.Visible = true;
            //屏蔽按钮，最小化

        }
        //stop
        private void button_stop_Click(object sender, EventArgs e){
            formSrt.Visible = false;
            MessageBox.Show(srtTools.getContent());
        }
        //是否前置
        private void checkBox_front_CheckedChanged(object sender, EventArgs e) {
            if (checkBox_front.Checked == true){
                formSrt.TopMost = true;
            }
            else {
                formSrt.TopMost = false;
            }
        }
        //透明度
        private void trackBar1_Scroll(object sender, EventArgs e){
            formSrt.Opacity = (double)trackBar1.Value / 100.0;
            label_cap.Text = "透明度:" + trackBar1.Value;
        }
    }
}
