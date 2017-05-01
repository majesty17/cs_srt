using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cs_srt
{
    class SrtTools
    {
        private DateTime start_time;



        public SrtTools(string filename) {

            start_time = DateTime.Now;
        }



        //获取当前字幕
        public string getContent() {
            DateTime now = DateTime.Now;
            TimeSpan ts = now - start_time;
            
            return ts.ToString();
        }
    }
}
