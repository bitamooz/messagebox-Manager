using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace MessageBox_Manager___Bitamooz.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ساده‌ترین فرم MessageBox
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("یک متن جهت نمایش!");
        }

        // MessageBox با عنوان اختصاصی
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("یک متن جهت نمایش!", "عنوان");
        }

        // MessageBox با آیکون هشدار
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("یک متن جهت نمایش!", "عنوان", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // MessageBox با آیکون اطلاعات
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("یک متن جهت نمایش!", "عنوان", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // MessageBox با آیکون خطا
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("یک متن جهت نمایش!", "عنوان", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // MessageBox پیشرفته با دکمه‌های Yes/No/Cancel
        private void button7_Click(object sender, EventArgs e)
        {
            var resultmessage = MessageBox.Show("یک متن جهت نمایش!", "عنوان", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (resultmessage)
            {
                case DialogResult.Cancel:
                    MessageBox.Show("لغو شد!");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("بله انتخاب شد!");
                    break;
                case DialogResult.No:
                    MessageBox.Show("خیر انتخاب شد!");
                    break;
            }
        }

        // MessageBox با آیکون سوال
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("یک متن جهت نمایش!", "عنوان", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // MessageBox هنگام لود فرم
        private void Form1_Load(object sender, EventArgs e)
        {
            var resmsg = MessageBox.Show("آیا می‌خواهید از سایت بیت‌آموز دیدن کنید؟", "خوش آمدید!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resmsg == DialogResult.Yes)
            {
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = "https://bitamooz.com",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
        }
    }
}