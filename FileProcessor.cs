using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using System.IO;
using System.Windows.Forms;

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

        void WriteShaderParam(XmlTextWriter writer, string Param, int Value)            //Shader Integer Parameter (0x11003)
        {
            writer.WriteStartElement("Chunk");
            writer.WriteAttributeString("Type", "0x11003");
            writer.WriteComment('"' + Param + "\" (Shader Integer Parameter (0x11003))");
            WriteValue(writer, "Value", Value.ToString());
            WriteValue(writer, "Param", Param);
            writer.WriteEndElement();
        }
        void WriteShaderParam(XmlTextWriter writer, string Param, string TexName)       //Shader Texture Parameter (0x11002)
        {
            writer.WriteStartElement("Chunk");
            writer.WriteAttributeString("Type", "0x11002");
            writer.WriteComment('"' + Param + "\" (Shader Texture Parameter (0x11002))");
            WriteValue(writer, "Value", TexName);
            WriteValue(writer, "Param", Param);
            writer.WriteEndElement();
        }
        void WriteShaderParam(XmlTextWriter writer, string Param, Color Diff)            //Shader Colour Parameter (0x11005)
        {
            writer.WriteStartElement("Chunk");
            writer.WriteAttributeString("Type", "0x11005");
            writer.WriteComment('"' + Param + "\" (Shader Colour Parameter (0x11005))");
            writer.WriteStartElement("Value");
            writer.WriteAttributeString("Name", "Value");
            writer.WriteAttributeString("Red",   Diff.R.ToString());
            writer.WriteAttributeString("Green", Diff.G.ToString());
            writer.WriteAttributeString("Blue",  Diff.B.ToString());
            writer.WriteEndElement();
            WriteValue(writer, "Param", Param);
            writer.WriteEndElement();
        }
        Boolean IsGoodDim(int x)
        {
            return ((x != 0) && ((x & (x - 1)) == 0))&&(x<=2048);
        }

        public string ErrorList = "";
        public int i;
        public FileProcessor(string[] FileNames, string Shader, Color Diff, int BLMD, int FIMD, int UVMD, Boolean LIT, Boolean ATST, Boolean TSID, string EnvTex, Color EnvDiff, string OutputPath, System.Windows.Forms.ProgressBar Bar)
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
            this.i = 0;
            foreach (string File in FileNames)
            {
                Image ThisImage = Image.FromFile(File);
                string ThisFileName = Path.GetFileNameWithoutExtension(File);
                if (!(IsGoodDim(ThisImage.Width) && (IsGoodDim(ThisImage.Height))))
                {
                    ErrorList += Path.GetFileName(File) + " has invalid dimensions: " + ThisImage.Width + "x" + ThisImage.Height + "(each must be a power of 2 and cannot more than 2048)";
                    continue;
                }
                if (Path.GetExtension(File) != ".png")
                {
                    Console.WriteLine("Processing non PNG...");
                    MemoryStream m = new MemoryStream();
                    ThisImage.Save(m, System.Drawing.Imaging.ImageFormat.Png);
                    ThisImage = Image.FromStream(m);
                }
                //Write Texture chunk
                {
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
                }
                //Write Shader Chunk
                {
                    writer.WriteStartElement("Chunk");                                                  //Shader Start
                    writer.WriteAttributeString("Type", "0x11000");
                    writer.WriteComment(ThisFileName + "_m (Shader (0x11000))");

                    WriteValue(writer, "Name", Path.GetFileNameWithoutExtension(File) + "_m");
                    WriteValue(writer, "Version", "0");
                    WriteValue(writer, "PddiShaderName", Shader);
                    if (BLMD == 0) 
                        WriteValue(writer, "HasTranslucency", "0");
                    else
                        WriteValue(writer, "HasTranslucency", "1");
                    WriteValue(writer, "VertexNeeds", "33");
                    if (Shader == "spheremap")
                        WriteValue(writer, "VertexMask", "0xFFFFFFD2");
                    else
                        WriteValue(writer, "VertexMask", "0xFFFC3FD1");
                    {
                        WriteShaderParam(writer, "TEX", ThisFileName);
                        WriteShaderParam(writer, "LIT", Convert.ToInt32(LIT));
                        WriteShaderParam(writer, "2SID", Convert.ToInt32(TSID));
                        WriteShaderParam(writer, "FIMD", FIMD);
                        WriteShaderParam(writer, "BLMD", BLMD);
                        WriteShaderParam(writer, "UVMD", UVMD);
                        WriteShaderParam(writer, "ATST", Convert.ToInt32(ATST));
                        WriteShaderParam(writer, "DIFF", Diff);
                        if ((Shader == "spheremap" || Shader == "environment")&&(EnvTex != ""))
                        {
                            WriteShaderParam(writer, "REFL", EnvTex);
                            if (EnvDiff != Color.FromArgb(255, 255, 255))
                            {
                                WriteShaderParam(writer, "ENVB", EnvDiff);
                            }
                        }
                    }

                    writer.WriteEndElement();                                                           //Shader End
                }

                System.Console.WriteLine(File + " processed");
                i += 1;
                Bar.Value += 1;
            }
            writer.WriteEndElement();
            writer.Flush();
            writer.Close();
            writer.Dispose();

            if (ErrorList != "")
                MessageBox.Show("Skipped files:\n"+ErrorList, "Following errors occured while converting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
