using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            // 1. ปิดการใช้งานปุ่ม Next (button2) ตั้งแต่เปิดฟอร์ม
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 3. เมื่อกดปุ่ม Next ให้ไปที่ Form2
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
            if (radioButton1.Checked)
            {
                button2.Enabled = true;
            }
        }

        // เพิ่ม Event สำหรับ radioButton2 (Female) ด้วย
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton2.Checked)
            {
                button2.Enabled = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
