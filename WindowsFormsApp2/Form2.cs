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
    public partial class Form2 : Form
    {
        // สร้างตัวแปรสำหรับสุ่มตัวเลข
        private Random random = new Random();

        public Form2()
        {
            InitializeComponent();
            // สามารถตั้งค่าความเร็วของหลอด ProgressBar ได้ที่นี่ (หรือตั้งในหน้า Design Properties ก็ได้)
            // timer1.Interval = 20; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;  // รีเซ็ตหลอดกลับไปที่ 0
            timer1.Start();          // เริ่มจับเวลาให้หลอดวิ่ง
            button1.Enabled = false; // ปิดปุ่มชั่วคราวกันการกดซ้ำ
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ถ้าหลอดยังไม่เต็ม 100 ให้เพิ่มค่าไปเรื่อยๆ
            if (progressBar1.Value < 100)
            {
                // ถ้าหลอดวิ่งช้าหรือเร็วไป สามารถเพิ่ม/ลดทีละ 2 หรือ 5 ได้ เช่น += 2;
                progressBar1.Value += 5;
            }
            else
            {
                // เมื่อหลอดเต็ม 100
                timer1.Stop();           // หยุด Timer
                button1.Enabled = true;  // เปิดปุ่มให้กลับมากดได้อีกครั้ง

                OpenRandomForm();        // เรียกฟังก์ชันสุ่มเปิดฟอร์ม
            }
        }

        // ฟังก์ชันสำหรับสุ่มเปิด Form11 - Form20
        private void OpenRandomForm()
        {
            // สุ่มเลข 11 ถึง 20 (การใช้ .Next() ตัวเลขตัวหลังต้อง +1 เสมอ คือ 21)
            int randomNumber = random.Next(11, 21);
            Form nextForm = null;

            // ตรวจสอบตัวเลขที่สุ่มได้แล้วเลือก Form ที่ตรงกัน
            switch (randomNumber)
            {
                case 11: nextForm = new Form11(); break;
                case 12: nextForm = new Form12(); break;
                case 13: nextForm = new Form13(); break;
                case 14: nextForm = new Form14(); break;
                case 15: nextForm = new Form15(); break;
                case 16: nextForm = new Form16(); break;
                case 17: nextForm = new Form17(); break;
                case 18: nextForm = new Form18(); break;
                case 19: nextForm = new Form19(); break;
                case 20: nextForm = new Form20(); break;
            }

            // ถ้ามีฟอร์มให้เปิด
            if (nextForm != null)
            {
                nextForm.Show(); // แสดงฟอร์มที่สุ่มได้
                this.Hide();
                // หากต้องการให้ Form2 (หน้าสุ่ม) ซ่อนตัวไปเมื่อฟอร์มใหม่เปิดขึ้น ให้เอา // ข้างหน้าบรรทัดด้านล่างออก
                // this.Hide(); 
            }
        }
    }
}