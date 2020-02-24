using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgToP3D
{
    public partial class Form1 : Form
    {
        Boolean SourceSet = false;
        Boolean OutputSet = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PathSourceDialog.Filter = "Image File(s) (*.jpg;*.jpeg;*.jpe;*.PNG)|*.jpg;*.jpeg;*.jpe;*.png";
            PathOutputDialog.Filter = "Output Chunk Collection (*.p3dxml)|*.p3dxml";
            BlendMode.SelectedIndex = 1;
            FilterMode.SelectedIndex = 1;
            UVMode.SelectedIndex = 0;
            ShaderType.SelectedIndex = 1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color DiffColor = colorDialog1.Color;
                DiffuseBox.BackColor = DiffColor;
                DiffHEX.Text = "#" + DiffColor.R.ToString("X2") + DiffColor.G.ToString("X2") + DiffColor.B.ToString("X2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PathSourceDialog.ShowDialog() == DialogResult.OK)
            {
                string str = "";
                for (int i = 0; i < PathSourceDialog.FileNames.Length; i++)
                {
                    if (i == PathSourceDialog.FileNames.Length - 1)
                    {
                        str += "\"" + PathSourceDialog.FileNames[i] + "\".";
                    }
                    else
                    {
                        str += "\"" + PathSourceDialog.FileNames[i] + "\", ";
                    }
                }
                PathSourceText.Text = str;
                SourceSet = true;
                if (SourceSet && OutputSet)
                    button3.Enabled = true;
            }
        }

        private void DiffHEX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (DiffHEX.Text.Length == 7)
                {
                    int HR, HG, HB;
                    Boolean F = (DiffHEX.Text.Substring(0, 1) == "#");
                    Boolean HRS = (Int32.TryParse(DiffHEX.Text.Substring(1, 2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out HR));
                    Boolean HGS = (Int32.TryParse(DiffHEX.Text.Substring(3, 2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out HG));
                    Boolean HBS = (Int32.TryParse(DiffHEX.Text.Substring(5, 2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out HB));
                    if (HRS && HGS && HBS && F)
                    {
                        DiffuseBox.BackColor = Color.FromArgb(HR, HG, HB);
                    }
                    else
                    {
                        MessageBox.Show("Error, invalid HEX value", "you got the dud!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error, invalid HEX value", "you got the dud!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PathOutputDialog.ShowDialog() == DialogResult.OK)
            {
                PathOutputText.Text = PathOutputDialog.FileName;
                OutputSet = true;
                if (SourceSet && OutputSet)
                    button3.Enabled = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //TOOL PAGE
        {
            System.Diagnostics.Process.Start("https://donutteam.com/forum/topic/3286");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //WOAS LINK
        {
            System.Diagnostics.Process.Start("https://donutteam.com/@WOAS");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //INFO
        {
            MessageBox.Show("BITSS - Batch Image To Shader Script \nVersion - 0.1\nMade by - Weasel On A Stick\n\n\nHOW TO USE:\n1.Select input images\n2.Select output .p3dxml file to create\n3.Choose settings to be applied to all shaders\n4.Click the big button\n5.Import your .p3dxml file into your .p3d file (Tools -> Import Pure3D XML...)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileProcessor FP = new FileProcessor(PathSourceDialog.FileNames, ShaderType.Text, DiffuseBox.BackColor, BlendMode.SelectedIndex, FilterMode.SelectedIndex, UVMode.SelectedIndex, LIT.Checked, ATST.Checked, TSID.Checked, PathOutputDialog.FileName, progressBar1);
            progressBar1.Value = 0;
            MessageBox.Show("Process Completed. Succesfully processed " + FP.i.ToString() + '/' + PathSourceDialog.FileNames.Length + "images!", "Complete");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] Dinput = { "d:\\GAMES\\The Simpsons Hit And Run\\tools\\dev\\AS\\11.png", "d:\\GAMES\\The Simpsons Hit And Run\\tools\\dev\\AS\\22.png", "d:\\GAMES\\The Simpsons Hit And Run\\tools\\dev\\AS\\33.png", "d:\\GAMES\\The Simpsons Hit And Run\\tools\\dev\\AS\\44.png", "d:\\GAMES\\The Simpsons Hit And Run\\tools\\dev\\AS\\Jeer_Day_Later_Blank.jpg", "d:\\GAMES\\The Simpsons Hit And Run\\tools\\dev\\AS\\Jeer_Day_Later_Blank.png" };
            string Doutput = "d:\\GAMES\\The Simpsons Hit And Run\\tools\\dev\\AS\\test.p3dxml";
            FileProcessor FP = new FileProcessor(Dinput, ShaderType.Text, DiffuseBox.BackColor, BlendMode.SelectedIndex, FilterMode.SelectedIndex, UVMode.SelectedIndex, LIT.Checked, ATST.Checked, TSID.Checked, Doutput, progressBar1);
        }

        private void DiffuseBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented", "WIP", MessageBoxButtons.OK);
        }

        private void DiffHEX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("Not yet implemented", "WIP", MessageBoxButtons.OK);
        }

        private void EnvTex_ModifiedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented", "WIP", MessageBoxButtons.OK);
        }

        private void DiffHEX2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented", "WIP", MessageBoxButtons.OK);
        }
    }
}
