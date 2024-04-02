using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threadin;

namespace CopyXOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Выбор входного файла";
            dlg.Filter = "Файлы текста (*.txt)|*.txt|" +
                         "Файлы Microsoft Word (*.doc)|*.doc;*.docx|" +
                         "Все файлы (*,*)|*.*";
            dlg.FilterIndex = 0;
            dlg.Multiselect = false; // запретить множественный выбор
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtInput.Text = dlg.FileName;
            }
        } // void btnInput_Click(object sender, EventArgs e);

        private void btnOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Title = "Файл для сохранения";
            dlg.Filter = "Файлы текста (*.txt)|*.txt|" +
                         "Файлы Microsoft Word (*.doc)|*.doc;*.docx|" +
                         "Все файлы (*,*)|*.*";
            dlg.FilterIndex = 0;
            dlg.CheckPathExists = true;
            dlg.OverwritePrompt = true; // предупреждение о перезаписи файла
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtOutput.Text = dlg.FileName;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter file name!");
                txtInput.Focus(); txtInput.SelectAll();
                return;
            }
            if (txtOutput.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter file name!");
                txtOutput.Focus(); txtOutput.SelectAll();
                return;
            }
            if(txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter password!");
                txtPassword.Focus();
                return;
            }
            // Запустить поток на шифрование/дешифрования
        }
    }
}
