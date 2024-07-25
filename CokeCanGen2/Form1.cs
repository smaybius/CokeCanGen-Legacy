using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace CokeCanGen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            this.AcceptButton = button1;
            CanName.Parent = Picture;
            CanName.BackColor = Color.Transparent;
            //PrivateFontCollection pfc = new PrivateFontCollection();
            //pfc.AddFontFile("CokeFont.ttf");
            //CanName.Font = new Font(pfc.Families[0], 32, FontStyle.Regular);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            //this.KeyPreview = true;
            GenerateCanText();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GenerateCanText();
        }


        private void GenerateCanText()
        {
            CanName.Text = NameBox.Text;
            CanName.Font = new Font(CanName.Font.FontFamily, 32 - 0.5f, CanName.Font.Style);
            while (CanName.Width < System.Windows.Forms.TextRenderer.MeasureText(CanName.Text,
            new Font(CanName.Font.FontFamily, CanName.Font.Size, CanName.Font.Style)).Width)
            {
                CanName.Font = new Font(CanName.Font.FontFamily, CanName.Font.Size - 0.5f, CanName.Font.Style);
            }
        }

        private void CanName_Click(object sender, EventArgs e)
        {

        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            SaveCokeAsImage();
        }

        private void SaveCokeAsImage()
        {
            using (var bitmap = new Bitmap(Picture.Width, Picture.Height))
            {
                Picture.DrawToBitmap(bitmap, Picture.ClientRectangle);

                // Save the screenshot to the specified path that the user has chosen.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Portable Network Graphics|*.png",
                    Title = "Save your generated can",
                    FileName = "shareacoke.png"
                };
                saveFileDialog1.ShowDialog();
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.None)
            {
                Button1_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }


        private void Namebox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Modifiers == Keys.None)
            {
                e.IsInputKey = true;
            }
        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            GenerateCanText();
        }

        private void ExportButton_Click_1(object sender, EventArgs e)
        {
            using (var bitmap = new Bitmap(Picture.Width, Picture.Height))
            {
                Picture.DrawToBitmap(bitmap, Picture.ClientRectangle);

                // Save the screenshot to the specified path that the user has chosen.
                SaveFileDialog saveFileDialog1 = new SaveFileDialog
                {
                    Filter = "Portable Network Graphics|*.png",
                    Title = "Save your generated can",
                    FileName = "shareacoke.png"
                };
                saveFileDialog1.ShowDialog();
                bitmap.Save(saveFileDialog1.FileName);
            }
        }
    }
}
