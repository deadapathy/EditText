using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EditText
{
    public partial class EditText : Form
    {
        public EditText()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

            
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void НовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        public void ОткрытьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (ArgumentException)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName,RichTextBoxStreamType.PlainText);
                }

                this.Text = "Файл [" + openFileDialog1.FileName + "]";
            }
        }

        public void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            richTextBox1.SaveFile(saveFileDialog1.FileName);
            this.Text = "Файл [" + saveFileDialog1.FileName + "]";

            
           
        }

        public void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "Файл [" + saveFileDialog1.FileName + "]";

            }
        }

        private void ПечатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditText f = new EditText();
            f.printDocument1.Print();
        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ОтменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void ВырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void КопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void ВставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void ШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void ЦветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void ЛевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void ПравоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void СправаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void EditText_FormClosing(Object sender, FormClosingEventArgs e)
        {
            
            MessageBox.Show("Сохранить изменения?", this.Text, MessageBoxButtons.YesNo);

            if (saveFileDialog1.ShowDialog() == DialogResult.Yes && saveFileDialog1.FileName.Length > 0)
            {


                richTextBox1.SaveFile(saveFileDialog1.FileName);
                this.Text = "Файл [" + saveFileDialog1.FileName + "]";

                
            }

           
          
            
        }
    }
}


