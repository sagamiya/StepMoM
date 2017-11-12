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
            string[] files = System.Environment.GetCommandLineArgs();
            if (files.Length > 1)
            {
                sourcePath.Text = files[1];
            }
        }

        private void kickOmm(string ommPath)
        {
            //ProcessStartInfoオブジェクトを作成する
            System.Diagnostics.ProcessStartInfo psi =
                new System.Diagnostics.ProcessStartInfo();

            //起動するファイルのパスを指定する
            psi.FileName = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\omm.exe";
            //コマンドライン引数を指定する
            psi.Arguments = ommPath;

            //アプリケーションを起動する
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
            p.WaitForExit();
        }

        private void cleanLogFiles()
        {
            System.IO.File.Delete("current.log");
            System.IO.File.Delete("element.log");
            System.IO.File.Delete("ev2d.htm");
            System.IO.File.Delete("far.log");
            System.IO.File.Delete("geom3d.htm");
            System.IO.File.Delete("near2d.log");
            System.IO.File.Delete("omm.log");


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
            if (System.IO.File.Exists("far.log"))
            {
                sr = new System.IO.StreamReader("far.log");
                sw = new System.IO.StreamWriter(targetDir + "\\far " + variable + ".log");
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
            if (System.IO.File.Exists("near2d.log"))
            {
                sr = new System.IO.StreamReader("near2d.log");
                sw = new System.IO.StreamWriter(targetDir + "\\near2d " + variable + ".log");
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

        private void evalInternal(int i, float value1, string targetDir, float v0, float v1, float v2)
        {
            string ommPath = System.IO.Path.GetTempFileName();
            System.IO.StreamReader sr = new System.IO.StreamReader(sourcePath.Text);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(ommPath);
            string line;
            string statement;
            Match mo;
            while ((line = sr.ReadLine()) != null)
            {
                line = String.Format(line, v0, v1, v2);
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


        private void eval2(float vFrom, float vTo, float vStep, float v0from, float v0step, float v1from, float v1step, float v2from, float v2step)
        {
            if (System.IO.File.Exists(sourcePath.Text))
            {
                string targetDir = System.IO.Path.GetDirectoryName(sourcePath.Text) + "\\" + System.IO.Path.GetFileNameWithoutExtension(sourcePath.Text)+" "+System.DateTime.Now.ToString("yyyymmdd-HHmmss");
                System.IO.Directory.CreateDirectory(targetDir);
                cleanLogFiles();
                float value1 = vFrom;
                if (vStep > 0.0)
                {
                    for (int i = 0; (value1 = vFrom + vStep * i) <= vTo + 0.1 * vStep; i++)
                    {
                        evalInternal(i, value1, targetDir, v0from+v0step*i, v1from+v1step*i, v2from+v2step*i);
                    }
                } else if (vStep < 0.0)
                {
                    for (int i = 0; (value1 = vFrom + vStep * i) >= vTo + 0.1 * vStep; i++)
                    {
                        evalInternal(i, value1, targetDir, v0from + v0step * i, v1from + v1step, v2from + v2step * i);
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
            float vFrom, vTo, vStep;
            float v0from, v0step;
            float v1from, v1step;
            float v2from, v2step;

            vFrom = vTo = vStep = 0.0f;

            v0from = float.Parse(boxV0from.Text);
            if (radioButton1.Checked) {
                vFrom = v0from;
                vTo = float.Parse(boxV0to.Text);
                vStep = v0step = float.Parse(boxV0step.Text);
            } else
            {
                v0step = 0.0f;
            }
            v1from = float.Parse(boxV1from.Text);
            if (radioButton2.Checked)
            {
                vFrom = v1from;
                vTo = float.Parse(boxV1to.Text);
                vStep = v1step = float.Parse(boxV1step.Text);
            }
            else
            {
                v1step = 0.0f;
            }
            v2from = float.Parse(boxV2from.Text);
            if (radioButton3.Checked)
            {
                vFrom = v2from;
                vTo = float.Parse(boxV2to.Text);
                vStep = v2step = float.Parse(boxV2step.Text);
            }
            else
            {
                v2step = 0.0f;
            }

            if (vStep != 0.0)
            {
                eval2(vFrom, vTo, vStep, v0from, v0step, v1from, v1step, v2from, v2step);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            boxV0to.Enabled = true;
            boxV0step.Enabled = true;
            boxV1to.Enabled = false;
            boxV1step.Enabled = false;
            boxV2to.Enabled = false;
            boxV2step.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            boxV1to.Enabled = true;
            boxV1step.Enabled = true;
            boxV0to.Enabled = false;
            boxV0step.Enabled = false;
            boxV2to.Enabled = false;
            boxV2step.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            boxV0to.Enabled = false;
            boxV0step.Enabled = false;
            boxV1to.Enabled = false;
            boxV1step.Enabled = false;
            boxV2to.Enabled = true;
            boxV2step.Enabled = true;
        }
    }
}
