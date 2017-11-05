using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepMoM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kickOmm(string ommPath)
        {
            //ProcessStartInfoオブジェクトを作成する
            System.Diagnostics.ProcessStartInfo psi =
                new System.Diagnostics.ProcessStartInfo();
            //起動するファイルのパスを指定する
            psi.FileName = ".\\omm.exe";
            //コマンドライン引数を指定する
            psi.Arguments = ommPath;

            //アプリケーションを起動する
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            p.WaitForExit();
        }


        private void copyGeneratedFiles(string ommPath, string targetDir, string variable)
        {
            string tmp;
            System.IO.StreamReader sr;
            System.IO.StreamWriter sw;
            {
                sr = new System.IO.StreamReader(ommPath);
                sw = new System.IO.StreamWriter(targetDir + "\\source " + variable + ".omm");
                while ((tmp = sr.ReadLine()) != null)
                {
                    sw.WriteLine(tmp);
                }
                sr.Close();
                sw.Close();
            }

            if (System.IO.File.Exists("current.log"))
            {
                sr = new System.IO.StreamReader("current.log");
                sw = new System.IO.StreamWriter(targetDir + "\\current " + variable + ".log");
                while ((tmp = sr.ReadLine()) != null)
                {
                    sw.WriteLine(tmp);
                }
                sr.Close();
                sw.Close();
            }
            if (System.IO.File.Exists("element.log")) {
                sr = new System.IO.StreamReader("element.log");
                sw = new System.IO.StreamWriter(targetDir + "\\element " + variable + ".log");
                while ((tmp = sr.ReadLine()) != null)
                {
                    sw.WriteLine(tmp);
                }
                sr.Close();
                sw.Close();
            }
            if (System.IO.File.Exists("ev2d.htm"))
            {
                sr = new System.IO.StreamReader("ev2d.htm");
                sw = new System.IO.StreamWriter(targetDir + "\\ev2d " + variable + ".htm");
                while ((tmp = sr.ReadLine()) != null)
                {
                    sw.WriteLine(tmp);
                }
                sr.Close();
                sw.Close();
            }
            if (System.IO.File.Exists("geom3d.htm"))
            {
                sr = new System.IO.StreamReader("geom3d.htm");
                sw = new System.IO.StreamWriter(targetDir + "\\geom3d " + variable + ".htm");
                while ((tmp = sr.ReadLine()) != null)
                {
                    sw.WriteLine(tmp);
                }
                sr.Close();
                sw.Close();
            }
            if (System.IO.File.Exists("omm.log"))
            {
                sr = new System.IO.StreamReader("omm.log");
                sw = new System.IO.StreamWriter(targetDir + "\\omm " + variable + ".log");
                while ((tmp = sr.ReadLine()) != null)
                {
                    sw.WriteLine(tmp);
                }
                sr.Close();
                sw.Close();
            }
        }

        private void evalInternal(int i, float value1, string targetDir)
        {
            string ommPath = System.IO.Path.GetTempFileName();
            System.IO.StreamReader sr = new System.IO.StreamReader(sourcePath.Text);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ommPath);
            string line;
            string statement;
            Match mo;
            while ((line = sr.ReadLine()) != null)
            {
                line = String.Format(line, value1);
                while (true)
                {
                    mo = Regex.Match(line, "\"[^\"]*\"");
                    if (mo.Success)
                    {
                        statement = line.Substring(mo.Index, mo.Length);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        //line = line.Replace(mo.Value, statement.Substring(1, statement.Length - 2));
                        //statusArea.Text = statusArea.Text + "\r\n" + statement;
                        string result = (dt.Compute(statement.Substring(1, statement.Length - 2), "")).ToString();
                        line = line.Replace(mo.Value, result.ToString());
                        //statusArea.Text = statusArea.Text + "\r\n" + line;
                    }
                    else
                    {
                        break;
                    }
                }
                sw.WriteLine(line);
            }
            sr.Close();
            sw.Close();
            kickOmm(ommPath);
            copyGeneratedFiles(ommPath, targetDir, " " + i.ToString() + " " + value1.ToString("e4"));
        }


    private void eval2(float startValue, float stopValue, float stepValue)
        {
            if (System.IO.File.Exists(sourcePath.Text))
            {
                string targetDir = System.IO.Path.GetDirectoryName(sourcePath.Text) + "\\" + System.IO.Path.GetFileNameWithoutExtension(sourcePath.Text)+" "+System.DateTime.Now.ToString("yyyymmdd-HHmmss");
                System.IO.Directory.CreateDirectory(targetDir);
                float value1 = startValue;
                if (stepValue > 0.0)
                {
                    for (int i = 0; (value1 = startValue + stepValue * i) <= stopValue + 0.1 * stepValue; i++)
                    {
                        evalInternal(i, value1, targetDir);
                    }
                } else if (stepValue < 0.0)
                {
                    for (int i = 0; (value1 = startValue + stepValue * i) >= stopValue + 0.1 * stepValue; i++)
                    {
                        evalInternal(i, value1, targetDir);
                    }
                }
            }
            else
            {
                statusArea.Text = statusArea.Text + "\r\nErr: File not found.";
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            //eval2(0.024f, 0.026f, 0.001f);
            float v0from, v0to, v0step;
            v0from = float.Parse(variable0From.Text);
            v0to = float.Parse(variable0to.Text);
            v0step = float.Parse(variable0step.Text);
            if (v0step != 0.0)
            {
                eval2(v0from, v0to, v0step);
            }
            statusArea.Text = statusArea.Text + "\r\nDone.";
        }

        private void selectSrcButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "StepMoMファイル(*.smm)|*.smm|OpenMoMファイル(*.omm)|*.omm|すべてのファイル(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourcePath.Text = (openFileDialog1.FileName);
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            double d;
            if (!double.TryParse(((TextBox)sender).Text, out d))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
