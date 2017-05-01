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
    public partial class FormSrt : Form
    {
        public FormSrt()
        {
            InitializeComponent();
        }


        // 窗体的屏幕坐标  
        Point formPoint;  
  
        // 鼠标光标的屏幕坐标  
        Point mousePoint;  




        //窗口大小改变后，自动调整字体
        private void FormSrt_SizeChanged(object sender, EventArgs e)
        {

        }

        private void label_srt_MouseDown(object sender, MouseEventArgs e)
        {
            // 获取窗体的屏幕坐标(x,y)  
            formPoint = this.Location;

            // 获取鼠标光标的位置（屏幕坐标）  
            mousePoint = Control.MousePosition; 
        }

        private void label_srt_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //获取鼠标移动时的屏幕坐标  
                Point mousePos = Control.MousePosition;

                //改变窗体位置  
                this.Location = new Point(formPoint.X + mousePos.X - mousePoint.X,
                                          formPoint.Y + mousePos.Y - mousePoint.Y);
            } 
        }  

    }
}
