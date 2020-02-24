using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;

namespace ImgToP3D
{
    class FileProcessor
    {
        public FileProcessor(string[] FileNames, Color Diff, int BLMD, int FLMD, int UVMD, Boolean LIT, Boolean ATST, Boolean TSID, string OutputPath, System.Windows.Forms.ProgressBar Bar)
        {
            Bar.Maximum = FileNames.Length;
            Bar.Value = 0;
            int i = 0;
            //TODO
            foreach (string File in FileNames)
            {
                System.Console.WriteLine(File + " processed\n");
                i += 1;
                Bar.Value += 1;
            }
        }
    }
}
