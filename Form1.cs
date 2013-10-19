using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Car_Form
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ans1;
            string ans2;
            string ans3;
            string ans4;
            string ans5;
            string ans6;
            string ans7;
            string ans8;

            //เพศ
            if (radioButton2.Checked == true)
            {
                ans1 = "ชาย";
            }
            else
            {
                ans1 = "หญิง";
            }
            // อายุ
            if (radioButton3.Checked == true)
            {
                ans2 = "น้อยกว่า 20 ปี";
            }
            else if (radioButton4.Checked == true)
            {
                ans2 = "20 - 40 ปี";
            }
            else
            {
                ans2 = "มากกว่า 40 ปี";
            }
            //อายุรถ
            if (radioButton8.Checked == true)
            {
                ans3 = "ต่ำกว่า 5 ปี";
            }
            else if (radioButton7.Checked == true)
            {
                ans3 = "5 - 10 ปี";
            }
            else
            {
                ans3 = "มากกว่า 10 ปี";
            }
            //คุณตรวจสภาพรถของคุณบ่อยแค่ไหน
          
            if (radioButton9.Checked == true)
            {
                ans4 = "บ่อยมาก";
            }
            else if (radioButton10.Checked == true)
            {
                ans4 = "บ่อย";
            }
            else if (radioButton13.Checked == true)
            {
                ans4 = "พอสมควร";
            }
            else if (radioButton11.Checked == true)
            {
                ans4 = "น้อย";
            }
            else
            {
                ans4 = "ไม่เคยเลย";
            }
            // คุณตรวจสภาพรถ่อนออกเดินทางหรือไม่
          
            if (radioButton17.Checked == true)
            {
                ans5 = "ทุกครั้ง";
            }
            else if (radioButton16.Checked == true)
            {
                ans5 = "เป็นบางครั้ง";
            }
            else if (radioButton18.Checked == true)
            {
                ans5 = "นาน ๆ ครั้ง";
            }
            else
            {
                ans5 = "ไม่เคยเลย";
            }
            //วิธีการตรวจสภาพรถของคุณ
           
            if (radioButton21.Checked == true)
            {
                ans6 = "เข้าศูนย์";
            }
            else if (radioButton20.Checked == true)
            {
                ans6 = "เข้าอู่";
            }
            else if (radioButton19.Checked == true)
            {
                ans6 = "ตรวจด้วยตนเอง";
            }
            else
            {
                ans6 = "ไม่เคยเลย";
            }
            //รถของคุณซ่อมบ่อยแค่ไหน
          
            if (radioButton23.Checked == true)
            {
                ans7 = "บ่อยมาก";
            }
            else if (radioButton22.Checked == true)
            {
                ans7 = "บ่อย";
            }
            else if (radioButton24.Checked == true)
            {
                ans7 = "พอสมควร";
            }
            else if (radioButton25.Checked == true)
            {
                ans7 = "น้อย";
            }
            else
            {
                ans7 = "ไม่เคยเลย";
            }
            //คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน
            
            if (radioButton27.Checked == true)
            {
                ans8 = "มากที่สุด";
            }
            else if (radioButton28.Checked == true)
            {
                ans8 = "มาก";
            }
            else if (radioButton30.Checked == true)
            {
                ans8 = "พอสมควร";
            }
            else if (radioButton29.Checked == true)
            {
                ans8 = "น้อย";
            }
            else
            {
                ans8 = "ไม่เคยเลย";
            }
            
            Form2 frm = new Form2();
            frm.SettextBox1 = ans1;
            frm.SettextBox2 = ans2;
            frm.SettextBox3 = ans3;
            frm.SettextBox4 = ans4;
            frm.SettextBox5 = ans5;
            frm.SettextBox6 = ans6;
            frm.SettextBox7 = ans7;
            frm.SettextBox8 = ans8;
            frm.Show();
  
        }

    }
}
