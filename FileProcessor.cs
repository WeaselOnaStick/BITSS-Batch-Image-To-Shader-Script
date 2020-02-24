using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.IO;

namespace ImgToP3D
{
    class FileProcessor
    {
        void WriteValue(XmlTextWriter writer, string Name, string Value)
        {
            writer.WriteStartElement("Value");
            writer.WriteAttributeString("Name", Name);
            writer.WriteAttributeString("Value", Value);
            writer.WriteEndElement();
        }

        Boolean IsGoodDim(int x)
        {

            return ((x != 0) && ((x & (x - 1)) == 0))&&(x<=2048);
        }

        string ErrorList = "";
        public FileProcessor(string[] FileNames, Color Diff, int BLMD, int FLMD, int UVMD, Boolean LIT, Boolean ATST, Boolean TSID, string OutputPath, System.Windows.Forms.ProgressBar Bar)
        {
            XmlTextWriter writer = new XmlTextWriter(OutputPath, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = '\t';
            writer.Indentation = 1;
            writer.WriteStartElement("Pure3DFile");
            writer.WriteAttributeString("LucasPure3DEditorVersion", "4.3");
            writer.WriteComment(OutputPath);
            Bar.Maximum = FileNames.Length;
            Bar.Value = 0;
            int i = 0;
            foreach (string File in FileNames)
            {
                Image ThisImage = Image.FromFile(File);
                string ThisFileName = Path.GetFileName(File);
                if (!(IsGoodDim(ThisImage.Width) && (IsGoodDim(ThisImage.Height)))){
                    ErrorList += ThisFileName + " has invalid dimensions: " + ThisImage.Width + "x" + ThisImage.Height + "(each should be a power of 10)";
                }
                writer.WriteStartElement("Chunk");                                                  //Tex Start
                writer.WriteAttributeString("Type", "0x19000");
                writer.WriteComment(ThisFileName + " (Texture (0x19000)))");
                WriteValue(writer, "Name", ThisFileName);
                WriteValue(writer, "Version", "14000");
                WriteValue(writer, "Width", ThisImage.Width.ToString());
                WriteValue(writer, "Height", ThisImage.Height.ToString());
                //Console.WriteLine("ImageFlags " + Convert.ToString(ThisImage.Flags, 2));
                //WriteValue(writer, "AlphaDepth", "ALPHADEPTH GOES HERE");
                WriteValue(writer, "TextureType", "1");
                WriteValue(writer, "Usage", "0");
                WriteValue(writer, "Priority", "0");

                writer.WriteStartElement("Chunk");                                                  //Img Start
                writer.WriteAttributeString("Type", "0x19001");
                writer.WriteComment(ThisFileName + " (Image (0x19001)))");

                WriteValue(writer, "Name", ThisFileName);
                WriteValue(writer, "Version", "14000");
                WriteValue(writer, "Width", ThisImage.Width.ToString());
                WriteValue(writer, "Height", ThisImage.Height.ToString());
                WriteValue(writer, "Format", "1");

                writer.WriteStartElement("Chunk");                                                  //Img data Start
                writer.WriteAttributeString("Type", "0x19002");
                writer.WriteComment(ThisFileName + " (Image Data (0x19002)))");

                using (MemoryStream m = new MemoryStream())
                {
                    ThisImage.Save(m, ThisImage.RawFormat);
                    byte[] ImgBytes = m.ToArray();
                    WriteValue(writer, "ImageData", Convert.ToBase64String(ImgBytes));
                }


                writer.WriteEndElement();                                                           //Img data End

                writer.WriteEndElement();                                                           //Img End

                writer.WriteEndElement();                                                           //Tex End

                System.Console.WriteLine(File + " processed");
                i += 1;
                Bar.Value += 1;
            }
            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
            writer.Dispose();
        }
    }
}
