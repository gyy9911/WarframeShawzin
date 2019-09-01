using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarframeShawzin
{
    public partial class warframeShawzin : Form
    {
        public warframeShawzin()
        {
            InitializeComponent();
        }
        public string inputStr;
        public string outputStr;
        public int meterPerBar;//每小节几拍
        public int meterDef;//几分音符为一拍
        Data data = new Data();
        string scale;
        private void RunButton_Click(object sender, EventArgs e)
        {
            
            inputStr = inputBox.Text;
            meterPerBar = Convert.ToInt32(meterPerBarBox.SelectedItem);
            meterDef = Convert.ToInt32(meterDefBox.SelectedItem);

            ouputBox.Text = "";
            float span = 4 / (float)meterDef;//每拍有多少秒
            float time = 0;//音符出现的时间，逐渐累加
            getScale();//从下拉框中读取音阶

            ouputBox.Text += (scaleBox.SelectedIndex + 1).ToString();
            string[] lines = inputStr.Split('\n');
            foreach (string eachLine in lines)
            {
                for (int i = 0; i < meterPerBar; i++)
                {
                    char note = eachLine[i];
                    if (note == '0')
                    {
                        time += span;
                        continue;
                    }                  
                    float noteTime = time;
                    ouputBox.Text += calcuNoteCode(note) + calcuTimeCode(noteTime);
                    time += span;
                }
            }

             //ouputBox.Text = span.ToString();
        }
        private string calcuTimeCode(float time)
        {
            int section = (int)time / 4;//该音符位于第几节（一节=4秒）
            int position = (int)((time - 4 * section) / 0.0625);
            char sectionCode = data.timeCode[section];
            char positionCode= data.timeCode[position];
            return sectionCode.ToString() + positionCode.ToString();
        }
        private string calcuNoteCode(char note)
        {
            int i = scale.IndexOf(note);
            char code = data.noteCode[i];
            return code.ToString();
        }
        private void getScale()
        {
            switch(scaleBox.SelectedIndex)
            {
                case 0:
                    {
                        scale = data.五声大调;
                        break;
                    }
                case 1:
                    {
                        scale = data.五声小调;
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                case 7:
                    {
                        break;
                    }
            }

        }
    }
}
