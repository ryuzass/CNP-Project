using PuzzleCountry.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleCountry
{
    public partial class Form3 : Form
    {   
        string StatusPic="";//ประกาศตัวแปร StatusPic
        string Bai = ""; //ประกาศตัวแปร Bai
        int score = 0;//ประกาศตัวแปร score = 0
        //int i;
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start.Enabled = false;//เมื่อกด เริ่มเกม ทำให้ไม่สามารถกดได้
            random();//เริ่มทำงาน void random()
            Time.Text = "120";//กำหนดตัวเลขนับ ถอยหลัง
            timer1.Start();//เริ่มนับถอย
        }
        void random()
        {
            Random rnd1 = new Random();//ตั้งตัวแปร Random
            int i = rnd1.Next(1,21 );//กำหนดขอบเขต Random
            //MessageBox.Show(""+i);
            //MessageBox.Show("" + StatusPic);
            if (score < 0)//ถ้าscore< 0
            {
                score = 0;//ให้ปรับค่าเป็น 0
            }
            //i++;
            switch (i)//เช็คค่า i
            {
                
                case 1:
                    pictureBox1.Image = Resources.CAMBODIA;//ให้pictureBox1 แสดงรูปCAMBODIA
                    StatusPic = "CAMBODIA";//ให้ StatusPic = "CAMBODIA"
                    Bai = " B C A D O I M A ";//แสดงคำใบ้ B C A D O I M A
                    
                    break;
                case 2:
                    pictureBox1.Image = Resources.CHINA;//ให้pictureBox1 แสดงรูป CHINA
                    StatusPic = "CHINA";//ให้ StatusPic = "CHINA"
                    Bai = " C N A H I ";//แสดงคำใบ้ C N A H I
                   break;
                case 3:
                    pictureBox1.Image = Resources.INDONESIA;//ให้pictureBox1 แสดงรูป INDONESIA
                    StatusPic = "INDONESIA"; //ให้ StatusPic =INDONESIA
                    Bai = " D N O N S A I E I ";//แสดงคำใบ้ D N O N S A I E I
                    break;
                case 4:
                    pictureBox1.Image = Resources.JAPAN;//ให้pictureBox1 แสดงรูป JAPAN
                    StatusPic = "JAPAN"; //ให้ StatusPic = JAPAN
                    Bai = " P A N A J ";//แสดงคำใบ้ P A N A J
                    break;
                case 5:
                    pictureBox1.Image = Resources.LAO; //ให้pictureBox1 แสดงรูป JAPAN
                     StatusPic = "LAOS";//ให้ StatusPic = LAOS
                    Bai = " O A L S "; //แสดงคำใบ้O A L S
                   break;
                case 6:
                    pictureBox1.Image = Resources.MALAYSIA;//ให้pictureBox1 แสดงรูป MALAYSIA
                    StatusPic = "MALAYSIA";// ให้ StatusPic = MALAYSIA
                    Bai = " I L A Y S A M A "; //แสดงคำใบ้ I L A Y S A M A
                break;
                case 7:
                    pictureBox1.Image = Resources.MYANMAR;//ให้pictureBox1 แสดงรูป MYANMAR
                    StatusPic = "MYANMAR";// ให้ StatusPic = MALAYSIA
                    Bai = " M A M Y A N R ";//แสดงคำใบ้ M A M Y A N R
                     break;
                case 8:
                    pictureBox1.Image = Resources.PORTUGAL;//ให้pictureBox1 แสดงรูป PORTUGAL
                    StatusPic = "PORTUGAL";// ให้ StatusPic = PORTUGAL
                    Bai = " R O P T U L A G ";//แสดงคำใบ้ R O P T U L A G
                    break;
                case 9:
                    pictureBox1.Image = Resources.THAI;//ให้pictureBox1 แสดงรูป THAI
                    StatusPic = "THAI";// ให้ StatusPic = THAI
                    Bai = " T A H I ";//แสดงคำใบ้ R O P T U L A G
                     break;
                case 10:
                    pictureBox1.Image = Resources.VIETNAM;//ให้pictureBox1 แสดงรูป VIETNAM
                    StatusPic = "VIETNAM";// ให้ StatusPic = VIETNAM
                    Bai = " T E N A M V I ";//แสดงคำใบ้  T E N A M V I 
                    break;
                case 11:
                    pictureBox1.Image = Resources.America;//ให้pictureBox1 แสดงรูป America
                    StatusPic = "AMERICA";// ให้ StatusPic = AMERICA
                    Bai = " A E R C A M I ";//แสดงคำใบ้  A E R C A M I

                    break;
                case 12:
                    pictureBox1.Image = Resources.Belgium;//ให้pictureBox1 แสดงรูป Belgium
                    StatusPic = "BELGIUM";// ให้ StatusPic = BELGIUM
                    Bai = " M I G U L B E ";//แสดงคำใบ้  M I G U L B E 
                    break;
                case 13:
                    pictureBox1.Image = Resources.Brazil;//ให้pictureBox1 แสดงรูป Brazil
                    StatusPic = "BRAZIL";// ให้ StatusPic = Brazil
                    Bai = " L Z I R A B ";//แสดงคำใบ้  L Z I R A B 

                    break;
                case 14:
                    pictureBox1.Image = Resources.Canada;//ให้pictureBox1 แสดงรูป Canada
                    StatusPic = "CANADA";// ให้ StatusPic = Canada
                    Bai = " D A A C A N ";//แสดงคำใบ้  D A A C A N 

                    break;
                case 15:
                    pictureBox1.Image = Resources.France;//ให้pictureBox1 แสดงรูป France
                    StatusPic = "FRANCE";// ให้ StatusPic = France
                    Bai = " C E N F R A ";//แสดงคำใบ้ C E N F R A 

                    break;
                case 16:
                    pictureBox1.Image = Resources.Germany;//ให้pictureBox1 แสดงรูป Germany
                    StatusPic = "GERMANY";// ให้ StatusPic = Germany
                    Bai = " M A Y G E N R ";//แสดงคำใบ้  M A Y G E N R

                    break;
                case 17:
                    pictureBox1.Image = Resources.Iran;//ให้pictureBox1 แสดงรูป Iran
                    StatusPic = "IRAN"; //ให้ StatusPic = Iran
                    Bai = " N R I A ";//แสดงคำใบ้ N R I A 

                    break;
                case 18:
                    pictureBox1.Image = Resources.Iraq;//ให้pictureBox1 แสดงรูป Iraq
                    StatusPic = "IRAQ";// ให้ StatusPic = Iraq
                    Bai = " A Q R I ";//แสดงคำใบ้ A Q R I 

                    break;
                case 19:
                    pictureBox1.Image = Resources.Italy;//ให้pictureBox1 แสดงรูป Italy
                    StatusPic = "ITALY";// ให้ StatusPic = Italy
                    Bai = " T Y L A I ";//แสดงคำใบ้ T Y L A I 

                    break;
                case 20:
                    pictureBox1.Image = Resources.Panama;//ให้pictureBox1 แสดงรูป Panama
                    StatusPic = "PANAMA";// ให้ StatusPic = Panama
                    Bai = " N P A A A M ";//แสดงคำใบ้ N P A A A M 

                    break;
            }
            Comebai.Text = Bai;//กำหนด Comebai.Text = Bai
            point.Text = score.ToString();// กำหนด point.Text = score และแปลงเป็น String



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (StatusPic == "CAMBODIA")//ถ้าStatusPic == "CAMBODIA"
            {
                if (textBox1.Text.ToUpper() == "CAMBODIA")//ถ้าStatusPic == "CAMBODIA"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";           //ทำให้ textBox1 ว่าง
                    score += 10;                  // +score 10
                    random();                     //กลับไปที่ random();
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random();
                }
            }
            else if (StatusPic == "CHINA")//ถ้าStatusPic == "CHINA"
            {
                if (textBox1.Text.ToUpper() == "CHINA")//ถ้าStatusPic == "CHINA"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10;// +score 10
                    random();//กลับไปที่ random();
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random();
                }
            }
            else if (StatusPic == "INDONESIA")//ถ้าStatusPic == "INDONESIA"
            {
                if (textBox1.Text.ToUpper() == "INDONESIA")//ถ้าStatusPic == "INDONESIA"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10;// +score 10
                    random();//กลับไปที่ random();
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "JAPAN")//ถ้าStatusPic == "JAPAN"
            {
                if (textBox1.Text.ToUpper() == "JAPAN")//ถ้าStatusPic == "JAPAN"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10;// +score 10
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "LAOS")//ถ้าStatusPic == "LAOS"
            {
                if (textBox1.Text.ToUpper() == "LAOS")//ถ้าStatusPic == "LAOS"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10;// +score 10
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "MALAYSIA")//ถ้าStatusPic == "MALAYSIA"
            {
                if (textBox1.Text.ToUpper() == "MALAYSIA")//ถ้าStatusPic == "MALAYSIA"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10;// +score 10
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "MYANMAR")//ถ้าStatusPic == "MYANMAR"
            {
                if (textBox1.Text.ToUpper() == "MYANMAR")//ถ้าStatusPic == "MYANMAR"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10;// +score 10
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "PORTUGAL")//ถ้าStatusPic == "PORTUGAL"
            {
                if (textBox1.Text.ToUpper() == "PORTUGAL")//ถ้าStatusPic == "PORTUGAL"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10;// +score 10
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "THAI")//ถ้าStatusPic == "THAI"
            {
                if (textBox1.Text.ToUpper() == "THAI")//ถ้าStatusPic == "THAI"
                {
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !!
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score += 10; //+score 10
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    score -= 5;// score -= 5
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "VIETNAM")//ถ้าStatusPic == "VIETNAM"
            {
                if (textBox1.Text.ToUpper() == "VIETNAM")//ถ้าStatusPic == "VIETNAM"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {   score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "AMERICA")//ถ้าStatusPic == "AMERICA"
            {
                if (textBox1.Text.ToUpper() == "AMERICA")//ถ้าStatusPic == "AMERICA"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!"); //แสดงข้อความ ถูกต้องงง !      
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "BELGIUM")//ถ้าStatusPic == "BELGIUM"
            {
                if (textBox1.Text.ToUpper() == "BELGIUM")//ถ้าStatusPic == "BELGIUM"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "BRAZIL")//ถ้าStatusPic == "BRAZIL"
            {
                if (textBox1.Text.ToUpper() == "BRAZIL")//ถ้าStatusPic == "BRAZIL"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "CANADA")//ถ้าStatusPic == "CANADA"
            {
                if (textBox1.Text.ToUpper() == "CANADA")//ถ้าStatusPic == "CANADA"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "FRANCE")//ถ้าStatusPic == "FRANCE"
            {
                if (textBox1.Text.ToUpper() == "FRANCE")//ถ้าStatusPic == "FRANCE"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "GERMANY")//ถ้าStatusPic == "GERMANY"
            {
                if (textBox1.Text.ToUpper() == "GERMANY")//ถ้าStatusPic == "GERMANY"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "IRAN")//ถ้าStatusPic == "IRAN"
            {
                if (textBox1.Text.ToUpper() == "IRAN")//ถ้าStatusPic == "IRAN"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "IRAQ")//ถ้าStatusPic == "IRAQ"
            {
                if (textBox1.Text.ToUpper() == "IRAQ")//ถ้าStatusPic == "IRAQ"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "ITALY")//ถ้าStatusPic == "ITALY"
            {
                if (textBox1.Text.ToUpper() == "ITALY")//ถ้าStatusPic == "ITALY"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
            else if (StatusPic == "PANAMA")//ถ้าStatusPic == "PANAMA"
            {
                if (textBox1.Text.ToUpper() == "PANAMA")//ถ้าStatusPic == "PANAMA"
                {
                    score += 10;//+score 10
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("ถูกต้องงง !!");//แสดงข้อความ// score -= 5 ถูกต้องงง !
                    random();//กลับไปที่ random()
                }
                else//นอกจากข้อกำหนด
                {
                    score -= 5;// score -= 5
                    textBox1.Text = "";//ทำให้ textBox1 ว่าง
                    MessageBox.Show("คำตอบผิด");//แสดงข้อความ "คำตอบผิด
                    random();//กลับไปที่ random()
                }
            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            int second = Convert.ToInt32(Time.Text);//กำหนด second ทำงานกับTime.Text
            second = second - 1;//กำหนดให้นับถอยหลังทีหละ 1 
            Time.Text = Convert.ToString(second);//แสดงตัวเลข second
            if (second == 0)//เมื่อ second = 0 ให้ทำตามคำสั่ง
            {
                timer1.Stop();//หยุดเวล
                MessageBox.Show("จบเกม\nคะแนน : " + point.Text);//แสดงMessageBox โชว์ คะแนน
                //this.Dispose();
                start.Enabled = true;//ทำให้ปุ่มเริ่มเกม กดได้
                Comebai.Text = "";//ล้างคำใบ้
                pictureBox1.Image = Resources.Qz;//แสดงรูป Qz
                textBox1.Text = "";//ทำให้ textBox1 ว่าง

            }
        }

        private void Scoer_Click(object sender, EventArgs e)
        {

        }
    }
}
