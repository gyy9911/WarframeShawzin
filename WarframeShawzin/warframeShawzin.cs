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
        public int meterDef;//几分音符为一拍
        Data data = new Data();
        string scale;
        private void RunButton_Click(object sender, EventArgs e)
        {
            
            inputStr = inputBox.Text;
            
            outputBox.Text = "";
           
            meterDef = Convert.ToInt32(meterDefBox.SelectedItem);
            if(meterDef<1)
            {
                MessageBox.Show("请选择几分音符为1拍");
                return;
            }
            int scaleIndex= getScale();//从下拉框中读取音阶
            if(scaleIndex < 0)
            { 
                MessageBox.Show("请选择音阶！");
                return;
            }
            float span = 4 / (float)meterDef;//每拍有多少秒
            float time = 0;//音符出现的时间，逐渐累加

            outputBox.Text += (scaleBox.SelectedIndex + 1).ToString();

            string[] lines = inputStr.Split(new char[2] { '\n', ' ' });
            foreach (string eachLine in lines)
            {
                for (int i = 0; i < eachLine.Length; i++)
                {
                    char note = eachLine[i];
                    if (note == '0')
                    {
                        time += span;
                        continue;
                    }                  
                    float noteTime = time;
                    string NoteCode= calcuNoteCode(note);
                    string TimeCode= calcuTimeCode(noteTime);
                    if(NoteCode[0]=='4')//如果出错
                    {
                        outputBox.Text = "";
                        MessageBox.Show(scaleBox.SelectedItem.ToString()+"中不包含音符"+ NoteCode[3]);                       
                        return;
                    }
                    outputBox.Text += NoteCode + TimeCode;
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
            int index;
            try
            {
                index= scale.IndexOf(note);
                char code = data.noteCode[index];
                return code.ToString();
            }
            catch
            {
                return "404"+note;//没查到对应音符
            }
        }
        private int getScale()
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
                        scale = data.六式音阶;
                        break;
                    }
                case 3:
                    {
                        scale = data.半音;
                        break;
                    }
                case 4:
                    {
                        scale = data.大调;
                        break;
                    }
                case 5:
                    {
                        scale = data.小调;
                        break;
                    }
                case 6:
                    {
                        scale = data.平调子;
                        break;
                    }
                case 7:
                    {
                        scale = data.弗里几亚调式;
                        break;
                    }
                default:
                    {
                        return -1;
                    }
            }
            return scaleBox.SelectedIndex;
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.Show();
        }
    }
}
